using AutoMapper;
using Avenue.Model.Avenue;
using Avenue.Model.AvenueDTO;
using Avenue.Model.Common;
using DevExpress.Xpo;
using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Avenue.Controller
{
    public class MenusController : ApiController
    {
        private static readonly ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// This is Menu API that returns all the list of menus.
        /// </summary>
        /// <returns>
        /// It returns all the Menus with required parameters such as MenuId,Key,Name,Category,API,UIUrl
        /// </returns>

        [HttpGet]
        [Route("api/menu/GetMenu")]
        public Response<List<BOS_MenusDTO>> GetMenu()
        {
            List<BOS_MenusDTO> menus = new List<BOS_MenusDTO>();
            try
            {
                log.Info("Getting menu list");

                using (var uow = new UnitOfWork())
                {
                    var menuList = uow.Query<BOS_Menus>().ToList();

                    try
                    {
                        // Fetch all menus
                        
                        foreach(var item in menuList)
                        {
                            BOS_MenusDTO menu = new BOS_MenusDTO();
                            menu.MenuId = item.MenuId;
                            menu.Key = item.Key;
                            menu.Name = item.Name;
                            menu.Category = item.Category;
                            menu.API = item.API;
                            //menu.Object.ObjectName = item.Object.ObjectName;
                            menu.UIUrl = item.UIUrl;
                            menu.Sequence = item.Sequence;
                            menu.AltText = item.AltText;
                            menus.Add(menu);
                        }

                        if (menus.Any())
                        {
                            log.Info($"Retrieved {menus.Count} menus");
                            return Response<List<BOS_MenusDTO>>.CreateResponse(Constants.Success, menus, null);
                        }
                        else
                        {
                            log.Info("No menus found in the database");
                            return Response<List<BOS_MenusDTO>>.CreateResponse(Constants.Failed, null, new ErrorHandler
                            {
                                ErrorCode = Constants.MenuListErrorCode,
                                Message = "No menus found"
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        log.Error($"Error getting menu list\nError: {ex}");
                        return Response<List<BOS_MenusDTO>>.CreateResponse(Constants.Failed, null, new ErrorHandler
                        {
                            ErrorCode = Constants.MenuListErrorCode,
                            Message = Constants.MenuListErrorMessage
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error($"Error fetching menu items\nError: {ex}");
                return Response<List<BOS_MenusDTO>>.CreateResponse(Constants.Failed, null, new ErrorHandler
                {
                    ErrorCode = Constants.MenuListErrorCode,
                    Message = Constants.MenuListErrorMessage
                });
            }
        }
    }
}
