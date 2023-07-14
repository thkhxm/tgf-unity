// /*******************************************************************
// **File Name:LoginCommon.cs
// **Author:   tim.huang(thkhxm@gmail.com)
// **Create Time: 2023-06-10
// **Desc:
// *******************************************************************/


using Google.Protobuf;
using HotFix.Code;
using HotFix.MainPanel.Model;
using HotFix.Utility;
using UnityEngine;

namespace HotFix.MainPanel.Command
{
    public class LoginCommand : AbstractCommand
    {
        protected override void OnExecute()
        {
            var serverAddress = this.GetModel<ServerModel>().ServerAddress;
            var nt = this.GetUtility<NetUtility>();
            nt.Connect(serverAddress);
            var req = new LoginReq { Account = "tim", Password = "123" };
            nt.Send(ServerApi.Login, req.ToByteArray()).Register(res =>
            {
                Debug.Log($"[login] 用户 {req} 登录成功");
                var e = new MainController.LoginEvent {Success = true};
                this.SendEvent(e);
            },true);
        }
    }
    
}