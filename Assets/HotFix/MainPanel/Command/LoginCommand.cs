// /*******************************************************************
// **File Name:LoginCommon.cs
// **Author:   tim.huang(thkhxm@gmail.com)
// **Create Time: 2023-06-10
// **Desc:
// *******************************************************************/

using System;
using AOT;
using HotFix.Code;
using HotFix.MainPanel.Model;
using HotFix.Utility;

namespace HotFix.MainPanel.Command
{
    public class LoginCommand : AbstractCommand
    {
        protected override void OnExecute()
        {
            var serverAddress = this.GetModel<ServerModel>().ServerAddress;
            this.GetUtility<NetUtility>().Connect(serverAddress);
        }
    }
}