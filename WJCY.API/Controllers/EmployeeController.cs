using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WJCY.Services;
using WJCY.Core.Domain;
using WJCY.Data;

namespace WJCY.API.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class EmployeeController : BaseApiController
    {
        #region fields
        private IEmployeeService _employeeService = null;
        #endregion

        #region ctor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="employeeService"></param>
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        #endregion
        /// <summary>
        /// 获取员工信息
        /// </summary>
        /// <param name="employeeNo">员工工号</param>
        /// <returns>员工信息</returns>
        [HttpGet]
        public Employee GetEmployee(int employeeNo)
        {
            var em = _employeeService.GetEmployee(employeeNo);
            return em;
        }
    }
}
