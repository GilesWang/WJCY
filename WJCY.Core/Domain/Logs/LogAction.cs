using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WJCY.Core.Domain
{
    /// <summary>
    /// 标记记录日志的动作
    /// </summary>
    public class LogAction
    {
        /// <summary>
        /// 日志动作ID
        /// </summary>
        public int LogActionId { get; set; }
        /// <summary>
        /// 日志动作名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 日志动作所属的系统
        /// </summary>
        public LogSystem System { get; set; }
        /// <summary>
        /// 日志动作所属系统的ID
        /// </summary>
        public int SystemId { get; set; }
    }
}
