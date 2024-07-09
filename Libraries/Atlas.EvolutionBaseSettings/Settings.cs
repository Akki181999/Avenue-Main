using Atlas.Common.Utils;
using Atlas.Domain.Model.Common;
using log4net;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.EvolutionBaseSettings
{
    public class Settings
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static string pgsqlConnectionString = ConfigurationManager.ConnectionStrings["Atlas"].ConnectionString.Replace("XpoProvider=Postgres;", "");
        public static string GetServerIPAddress()
        {
            try
            {
                string hostName = Dns.GetHostName();
                IPHostEntry host;
                string localIP = "";
                host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress ip in host.AddressList)
                {
                    if (ip.AddressFamily.ToString() == "InterNetwork")
                    {
                        localIP = ip.ToString();
                    }
                }
                return localIP;
                //return "172.31.75.60";
            }
            catch (Exception ex)
            {
                log.Info($"[GetServerIPAddress] error :{ex}");
                return null;
            }
        }

        public static List<BaseSettings> GetAllEvolutionBaseSettings(string projectName, string ipAddress)
        {
            try
            {
                log.Info($"[GetEvolutionBaseSettings] function started for projectName {projectName},ipAddress {ipAddress}");
                var ProjectDetails = GetProjectDetails();
                ProjectDetails prj = new ProjectDetails();
                if (ProjectDetails != null)
                {
                    prj = ProjectDetails.FirstOrDefault(x => x.ProjectName == projectName);
                    if (prj == null)
                    {
                        return null;
                    }
                }
                string cacheKey = $"{prj.CacheKeyName}";
                ObjectCache cache = MemoryCache.Default;
                if (cache.Contains(cacheKey))
                {
                    log.Info($"[GetAllEvolutionBaseSettings]: contains Cache key {cacheKey}");
                    return (List<BaseSettings>)cache.Get(cacheKey);
                }
                else
                {
                    List<BaseSettings> lstBaseSettings = new List<BaseSettings>();
                    using (NpgsqlConnection connection = new NpgsqlConnection(pgsqlConnectionString))
                    {
                        using (NpgsqlCommand cmd = new NpgsqlCommand())
                        {
                            cmd.CommandTimeout = 300;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "getevolutionbasesettings";
                            cmd.Connection = connection;
                            cmd.Parameters.Add("@projectname", NpgsqlDbType.Text).Value = projectName;
                            cmd.Parameters.Add("@ipaddress", NpgsqlDbType.Text).Value = ipAddress;
                            try
                            {
                                connection.Open();
                                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        BaseSettings settings = new BaseSettings();
                                        settings.SettingName = reader["SettingName"].ToString();
                                        settings.SettingValue = reader["SettingValue"].ToString();
                                        settings.IsActive = DBNull.Value == null ? false : Convert.ToBoolean(reader["IsActive"]);
                                        settings.ProjectName = reader["ProjectName"].ToString();
                                        lstBaseSettings.Add(settings);
                                    }
                                    double caheTime = Convert.ToDouble(5);// need to bind here
                                    CacheItemPolicy cacheItemPolicy = new CacheItemPolicy
                                    {
                                        AbsoluteExpiration = DateTime.Now.AddHours(caheTime)
                                    };
                                    cache.Add(cacheKey, lstBaseSettings, cacheItemPolicy);
                                    return lstBaseSettings;
                                }
                            }
                            catch (Exception ex)
                            {
                                connection.Close();
                                log.Error($"[GetEvolutionBaseSettings] Error {ex}");
                                return null;
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                log.Error($"Error in connection [GetEvolutionBaseSettings] function for projectName {projectName},ipAddress {ipAddress},error {ex}");
                throw ex;
            }
        }

        public static string GetProjectName()
        {
            try
            {
                string projectName = System.IO.Path.GetFileName(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString();
                projectName = projectName.Replace(".dll", "");
                return projectName;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public static string AppSettings(string keyName)
        {
            try
            {
                log.Info($"[AppSettings] keyName :{keyName}");
                List<BaseSettings> allSetting = new List<BaseSettings>();
                string ipAddress = Settings.GetServerIPAddress();
                //string projectName = GetProjectName();
                log.Info($"[AppSettings] ipAddress :{ipAddress}");
                // log.Info($"[AppSettings] projectName :{projectName}");
                if (ipAddress != null)
                {
                    allSetting = Settings.GetAllEvolutionBaseSettings(BackOfficeEnum.ProjectName.BackOfficeServer.ToString(), ipAddress);
                }
                if (allSetting.Count > 0)
                {
                    var settingValue = allSetting.FirstOrDefault(x => x.SettingName == keyName);
                    if (settingValue != null)
                    {
                        log.Info($"[AppSettings] SettingValue :{settingValue.SettingValue}");
                        return settingValue.SettingValue;
                    }
                }
                log.Info("[AppSettings] No key found");
                return null;
            }
            catch (Exception ex)
            {
                log.Info($"[AppSettings] Error while getting the key value for key name {keyName} error:{ex}");
                return null;
            }
        }

        //[HttpGet]
        //[Route("Products/ResetBaseSettingsCache")]

        public static List<BaseSettings> ResetBaseSettingCache(string ProjectName)
        {
            try
            {
                //Get the Project and Cache details
                var ProjectDetails = GetProjectDetails();
                ProjectDetails prj = new ProjectDetails();
                if (ProjectDetails != null)
                {
                    prj = ProjectDetails.FirstOrDefault(x => x.ProjectName == ProjectName);
                    if(prj == null)
                    {
                        return null;
                    }
                }
                List<BaseSettings> settings = new  List<BaseSettings> ();
                string ipAddress = Settings.GetServerIPAddress();
                List<string> cacheKeys = MemoryCache.Default.Select(kvp => kvp.Key).ToList();
                foreach (string cacheKey in cacheKeys)
                {
                    if (cacheKey == prj.CacheKeyName)
                    {
                        MemoryCache.Default.Remove(cacheKey);
                    }
                }
                log.Info("[ResetBaseSettingCache] Get Base Config Details");
                settings = GetAllEvolutionBaseSettings(ProjectName, ipAddress);
                return settings;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static List<ProjectDetails> GetProjectDetails()
        {
            try
            {
                List<ProjectDetails> lst = new List<ProjectDetails>();
                string cacheKey = $"CMPY_ProjectCache";
                ObjectCache cache = MemoryCache.Default;
                if (cache.Contains(cacheKey))
                {
                    log.Info($"[GetAllEvolutionBaseSettings]: contains Cache key {cacheKey}");
                    return (List<ProjectDetails>)cache.Get(cacheKey);
                }
                else
                {
                    using (NpgsqlConnection connection = new NpgsqlConnection(pgsqlConnectionString))
                    {
                        using (NpgsqlCommand cmd = new NpgsqlCommand())
                        {
                            cmd.CommandTimeout = 300;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "getprojectdetails";
                            cmd.Connection = connection;
                            try
                            {
                                connection.Open();
                                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        ProjectDetails prj = new ProjectDetails();
                                        prj.CacheKeyName = reader["CacheKeyName"].ToString();
                                        prj.ProjectName = reader["ProjectName"].ToString();
                                        lst.Add(prj);
                                    }
                                    double caheTime = Convert.ToDouble(5);// need to bind here
                                    CacheItemPolicy cacheItemPolicy = new CacheItemPolicy
                                    {
                                        AbsoluteExpiration = DateTime.Now.AddHours(caheTime)
                                    };
                                    cache.Add(cacheKey, lst, cacheItemPolicy);
                                    return lst;
                                }
                            }
                            catch (Exception ex)
                            {
                                connection.Close();
                                log.Error($"[GetProjectDetails] Error {ex}");
                                return null;
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                log.Error($"[GetProjectDetails] error {ex}");
                throw ex;
            }
        }

    }
}
