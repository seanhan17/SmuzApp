using SmuzApp.Web.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmuzApp.Web.Common.Models
{
    public class ResponseModel
    {
        public ResponseModel(ResultCode resultCode = ResultCode.FAILURE)
        {
            ResultCode = resultCode;
            ErrorMessage = new List<string>();
        }

        public ResultCode ResultCode { get; set; }
        public string ResultMessage { get; set; }
        public object Value { get; set; }
        public string RedirectUrl { get; set; }
        public List<string> ErrorMessage { get; set; }
    }
}
