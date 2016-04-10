using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WJCY.Core;
using WJCY.Core.Domain;

namespace WJCY.Services
{
    public class EmployeeService : IEmployeeService
    {
        #region Fields
        private IRepository<Employee> employeeRepository;
        #endregion

        #region ctor
        public EmployeeService(IRepository<Employee> employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        #endregion

        /// <summary>
        /// <seealso cref="IEmployeeService.GetEmployee(int)"/>
        /// </summary>
        /// <param name="employeeNo"></param>
        /// <returns></returns>
        public Employee GetEmployee(int employeeNo)
        {
            if (employeeNo == 0)
            {
                return null;
            }
            return employeeRepository.Table.Where(q => q.EmployeeNo == employeeNo).FirstOrDefault();
        }
        /// <summary>
        /// <seealso cref="IEmployeeService.GetEmployee(int, string)"/>
        /// </summary>
        /// <param name="employeeNo"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public Employee GetEmployee(int employeeNo, string pwd)
        {
            if (employeeNo == 0 || string.IsNullOrWhiteSpace(pwd))
            {
                return null;
            }
            return employeeRepository.Table.Where(q => q.EmployeeNo == employeeNo && q.Pwd == pwd).FirstOrDefault();
        }
    }
}
