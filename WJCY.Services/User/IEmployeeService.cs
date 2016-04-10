using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WJCY.Core.Domain;

namespace WJCY.Services
{
    public interface IEmployeeService
    {
        /// <summary>
        /// 获取员工信息
        /// </summary>
        /// <param name="employeeNo">员工工号</param>
        /// <returns>员工信息</returns>
        Employee GetEmployee(int employeeNo);
        /// <summary>
        /// 获取员工信息
        /// </summary>
        /// <param name="employeeNo">员工工号</param>
        /// <param name="pwd">密码</param>
        /// <returns>员工信息</returns>
        Employee GetEmployee(int employeeNo, string pwd);
    }
}
