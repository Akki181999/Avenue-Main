using Atlas.Common.ExceptionBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Atlas.Common.ResponseBase
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
       

        public static Response<T> CreateResponse(string _responseStatus, T _data, ErrorHandler _responseError, Pagination _pageSetting=null, Condition _Condition=null)
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
    }

    public class Sort
    {
        public string Key { get; set; }
        public string OrderBy { get; set; }
    }
}