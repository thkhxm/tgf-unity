// /*******************************************************************
// **File Name:LogoutCommand.cs
// **Author:   tim.huang(thkhxm@gmail.com)
// **Create Time: 2023-06-10
// **Desc:
// *******************************************************************/

using HotFix.Code;
using HotFix.Utility;

namespace HotFix.MainPanel.Command
{
    public class LogoutCommand:AbstractCommand
    {
        protected override void OnExecute()
        {
            this.GetUtility<NetUtility>().Close();
        }
    }
}