using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Avenue.Model.Common
{
    public class Response<T>
    {
        public string Status
        { get; set; }
        public T Data
        { get; set; }
        public ErrorHandler Error { get; set; }
        public Pagination Pagination { get; set; }
        public Condition Condition { get; set; }

        public static Response<T> CreateResponse(string _responseStatus, T _data, ErrorHandler _responseError, Pagination _pageSetting = null, Condition _Condition = null)
        {
            Response<T> response = new Response<T>();
            response.Status = _responseStatus;
            response.Data = _data;
            response.Error = _responseError;
            response.Pagination = _pageSetting;
            response.Condition = _Condition;
            return response;
        }
    }

    public class Pagination
    {
        public int TotalNoOfData { get; set; }
        public int PageNo { get; set; }
        public int PageSize { get; set; }

        public Pagination()
        {
            TotalNoOfData = 0; PageNo = 0; PageSize = 20;
        }
    }

    public class Condition
    {
        public Pagination pagination { get; set; }
        public Sort sort { get; set; }
        public Dictionary<string, dynamic> search { get; set; }
        public RecordCount recordCount { get; set; }
        public CardCount cardCount { get; set; }
        public string SearchType { get; set; }
        public Boolean AllData { get; set; }
        public Boolean ShowPositiveOnly { get; set; } = false;
        public int InstallmentNo { get; set; }
        public Boolean NuCardBlockAccess { get; set; }
        public string TermsRange { get; set; }
        public Boolean IsLoanDisable { get; set; }
        public Boolean IsEmiDisable { get; set; }
    }

    public class Sort
    {
        public string Key { get; set; }
        public string OrderBy { get; set; }
    }

    public class RecordCount
    {
        public int TotalCount { get; set; }
        public int OverdueCount { get; set; }
        public int PHOCount { get; set; }

    }

    public class CardCount
    {
        public int TotalCards { get; set; }

    }

    public static class Constants
    {
        public const string Failed = "Failed";
        public const string FailedCode = "FAILED";
        public const string Success = "Success";
        public const string SuccessCode = "SUCCESS";
        public const string MenuListErrorCode = "Avenue - MENU_ERROR";
        public const string MenuListErrorMessage = "Avenue - Error in getting menu list";
        public const string RegisterErrorCode = "Avenue - Register_ERROR";
        public const string RegisterErrorMessage = "Avenue - Error while Register User";
        public const string LoginErrorCode = "Avenue - Login_ERROR";
        public const string LoginErrorMessage = "Avenue - Error while Login User";
        public const string ChangePasswordErrorCode = "Avenue - ChangePassword_ERROR";
        public const string ChangePasswordErrorMessage = "Avenue - Error while Changing Password";
        public const string UserListErrorCode = "Avenue - User not found";
        public const string UserListErrorMessage = "Avenue - Error in getting user list";
        public const string UserErrorCode = "Avenue - RegistrationError";
        public const string UserErrorMessage = "Avenue - Error in user registration";
    }

    public class ErrorHandler
    {
        public string ErrorCode { get; set; }
        public string Message { get; set; }
    }

}