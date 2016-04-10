using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WJCY.Admin.Models.Common
{
    public class MenuViewModel
    {
        public string MenuText { get; set; }
        public string MenuAction { get; set; }
        public string MenuController { get; set; }

        public List<MenuViewModel> ChildMenuList { get; set; }

        public MenuViewModel ParentMenu { get; set; }
    }
}
