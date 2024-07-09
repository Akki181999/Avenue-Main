using Avenue.Model.Avenue;
using Avenue.Model.AvenueDTO;
using Avenue.Model.Common;
using Avenue.Repository;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Avenue.Controller
{
        public class LoginController : ApiController
        {
            private readonly UserRepository userRepository;
        private static readonly ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public LoginController()
            {
                userRepository = new UserRepository();
            }

            [HttpPost]
            [Route("api/Login/Register")]
            public Response<UserProfileDto> Register(RegisterModel model)
            {
                try
                {
                    UserProfileDto userProfile = new UserProfileDto();
                    var user = userRepository.CreateUser(model.UserId, model.Email, model.Password);
                    if (user == null)
                    {
                        return Response<UserProfileDto>.CreateResponse(Constants.Failed, null, null);
                    }
                    else
                    {
                        userProfile.UserId = user.UserId;
                        userProfile.Email = user.Email;
                        return Response<UserProfileDto>.CreateResponse(Constants.Success, userProfile, null);
                    }                   
                }
                catch (Exception ex)
                {
                return Response<UserProfileDto>.CreateResponse(Constants.Failed, null, new ErrorHandler
                {
                    ErrorCode = Constants.RegisterErrorCode,
                    Message = Constants.RegisterErrorMessage
                });
            }
            }

            [HttpPost]
            [Route("api/Login/login")]
            public Response<UserProfileDto> UserLogin(LoginModel model)
            {
                try
                {
                UserProfileDto userProfile = new UserProfileDto();
                    var user = userRepository.GetUserProfileByUsername(model.UserId);
                    if (user != null && user.Password == model.Password)
                    {
                    userProfile.UserId = user.UserId;
                    userProfile.Email = user.Email;
                    return Response<UserProfileDto>.CreateResponse(Constants.Success, userProfile, null);
                    }
                    else
                    {
                    return Response<UserProfileDto>.CreateResponse(Constants.Failed, null, null);
                }
                }
                catch (Exception ex)
                {
                log.Error($"Error fetching menu items\nError: {ex}");
                return Response<UserProfileDto>.CreateResponse(Constants.Failed, null, new ErrorHandler
                {
                    ErrorCode = Constants.LoginErrorCode,
                    Message = Constants.LoginErrorMessage
                });
            }
            }

            [HttpPost]
            [Route("api/Login/changepassword")]
            public Response<UserProfileDto> ChangePassword(ChangePasswordModel model)
            {
                try
                {
                UserProfileDto userProfile = new UserProfileDto();
                var user = userRepository.GetUserProfileByUsername(model.UserId);
                    if (user != null && user.Password == model.OldPassword)
                    {
                        user.Password = model.NewPassword;
                        var user2 = userRepository.SaveUser(user);
                    userProfile.UserId = user2.UserId;
                    userProfile.Email = user2.Email;
                    return Response<UserProfileDto>.CreateResponse(Constants.Success, userProfile, null);
                }
                    else
                    {
                    return Response<UserProfileDto>.CreateResponse(Constants.Failed, null, null);
                }
                }
                catch (Exception ex)
                {
                return Response<UserProfileDto>.CreateResponse(Constants.Failed, null, new ErrorHandler
                {
                    ErrorCode = Constants.ChangePasswordErrorCode,
                    Message = Constants.ChangePasswordErrorMessage
                });
            }
            }
        }
}
