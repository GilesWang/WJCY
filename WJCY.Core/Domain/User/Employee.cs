using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WJCY.Core.Domain
{
    public class Employee : BaseEntity
    {
        /// <summary>
        /// 员工工号
        /// </summary>
        public int EmployeeNo { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Pwd { get; set; }
        /// <summary>
        /// 员工信息
        /// </summary>
        public Person EmployeeInfo { get; set; }

    }
}
