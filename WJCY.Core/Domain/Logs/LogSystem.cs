using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WJCY.Core.Domain
{
    /// <summary>
    /// 标记记录日志的系统
    /// </summary>
    public class LogSystem
    {
        /// <summary>
        /// Log system identifier
        /// </summary>
        public int LogSystemId { get; set; }
        /// <summary>
        /// Log system name
        /// </summary>
        public string LogSystemName { get; set; }
        /// <summary>
        /// 日志系统下的所有日志动作
        /// </summary>
        public List<LogAction> Actions { get; set; }
    }
}
