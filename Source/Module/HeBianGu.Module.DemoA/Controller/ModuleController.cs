using HeBianGu.Base.WpfBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace HeBianGu.Module.DemoA
{
    [Controller("Module")]
    internal class ModuleController : Controller
    {
        [Action(DisplayName ="方法一")]
        public async Task<IActionResult> Module()
        {
            return await ViewAsync();
        }
    }
}
