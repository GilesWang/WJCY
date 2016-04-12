using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WJCY.API.MessagePattern
{
    public class ApiResult
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public string ErrorCode { get; set; }
    }

    public class ApiResult<T> : ApiResult
    {
        public T Result { get; set; }
    }
}
