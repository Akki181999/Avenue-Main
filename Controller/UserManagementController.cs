using Avenue.Model.Avenue;
using Avenue.Model.AvenueDTO;
using Avenue.Model.Common;
using Avenue.Repository;
using DevExpress.Xpo;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Avenue.Controller
{
    public class UserManagementController : ApiController
    {
        private static readonly ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private readonly UserRepository userRepository;
        public UserManagementController()
        {
            userRepository = new UserRepository();
        }


        [HttpGet]
        [Route("api/User/GetUsers")]
        public Response<List<UserDetailsDto>> GetUsers()
        {
            List<UserDetailsDto> users = new List<UserDetailsDto>();
            try
            {
                log.Info("Getting user list");

                using (var uow = new UnitOfWork())
                {
                    var userList = uow.Query<userdetails>().ToList();

                    try
                    {
                        // Fetch all menus

                        foreach (var item in userList)
                        {
                            UserDetailsDto user = new UserDetailsDto
                            {
                                UserId = item.userid,
                                NationalId = item.nationalid,
                                Email = item.email,
                                FirstName = item.firstname,
                                LastName = item.lastname,
                                GenderId = item.genderid,
                                ContactNumber = item.contactnumber,
                                DateOfBirth = item.dateofbirth,
                                Designation = item.designation,
                                DepartmentId = item.departmentid,
                                RoleId = item.roleid,
                                IsActive = item.isactive
                            };

                            users.Add(user);
                        }

                        if (users.Any())
                        {
                            log.Info($"Retrieved {users.Count} users");
                            return Response<List<UserDetailsDto>>.CreateResponse(Constants.Success, users, null);
                        }
                        else
                        {
                            log.Info("No users found in the database");
                            return Response<List<UserDetailsDto>>.CreateResponse(Constants.Failed, null, new ErrorHandler
                            {
                                ErrorCode = Constants.UserListErrorCode,
                                Message = "No User found"
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        log.Error($"Error getting user list\nError: {ex}");
                        return Response<List<UserDetailsDto>>.CreateResponse(Constants.Failed, null, new ErrorHandler
                        {
                            ErrorCode = Constants.UserListErrorCode,
                            Message = Constants.UserListErrorMessage
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error($"Error fetching menu items\nError: {ex}");
                return Response<List<UserDetailsDto>>.CreateResponse(Constants.Failed, null, new ErrorHandler
                {
                    ErrorCode = Constants.MenuListErrorCode,
                    Message = Constants.MenuListErrorMessage
                });
            }
        }

        [HttpPost]
        [Route("api/User/SaveUser")]
        public Response<UserDetailsDto> SaveUser(UserDetailsDto userDetailsDto)
        {
            
                try
                {
                var existingUser = userRepository.GetByNationalId(userDetailsDto.NationalId);

                    if (existingUser != null)
                    {
                        // Update existing user
                        existingUser.userid = userDetailsDto.UserId;
                        existingUser.email = userDetailsDto.Email;
                        existingUser.firstname = userDetailsDto.FirstName;
                        existingUser.lastname = userDetailsDto.LastName;
                        existingUser.genderid = userDetailsDto.GenderId;
                        existingUser.contactnumber = userDetailsDto.ContactNumber;
                        existingUser.dateofbirth = userDetailsDto.DateOfBirth;
                        existingUser.designation = userDetailsDto.Designation;
                        existingUser.departmentid = userDetailsDto.DepartmentId;
                        existingUser.roleid = userDetailsDto.RoleId;
                        existingUser.isactive = userDetailsDto.IsActive;
                        var user = userRepository.UpdateUserDetails(existingUser);
                        if (user == null)
                        {
                            return Response<UserDetailsDto>.CreateResponse(Constants.Failed, null, null);
                        }
                        else
                        {
                        UserDetailsDto userDetailsDto1 = new UserDetailsDto
                        {
                            UserId = user.userid,
                            NationalId = user.nationalid,
                            Email = user.email,
                            FirstName = user.firstname,
                            LastName = user.lastname,
                            GenderId = user.genderid,
                            ContactNumber = user.contactnumber,
                            DateOfBirth = user.dateofbirth,
                            Designation = user.designation,
                            DepartmentId = user.departmentid,
                            RoleId = user.roleid,
                            IsActive = user.isactive
                        };
                            return Response<UserDetailsDto>.CreateResponse(Constants.Success, userDetailsDto1, null);
                        }
                    }
                    else
                    {
                        // Create new user
                       
                        var user = userRepository.SaveUserDetails(userDetailsDto);
                        if (user == null)
                        {
                            return Response<UserDetailsDto>.CreateResponse(Constants.Failed, null, null);
                        }
                        else
                        {

                            return Response<UserDetailsDto>.CreateResponse(Constants.Success, user, null);
                        }
                    }  
                }
                catch (Exception ex)
                {
                    log.Error($"Error fetching menu items\nError: {ex}");
                    return Response<UserDetailsDto>.CreateResponse(Constants.Failed, null, new ErrorHandler
                    {
                        ErrorCode = Constants.UserErrorCode,
                        Message = Constants.UserErrorMessage
                    });
                }
            
            
        }
    }
}
