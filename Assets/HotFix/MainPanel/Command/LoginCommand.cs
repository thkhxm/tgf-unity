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
            var loginReq = ServerApi.Login.NewMessage(req.ToByteArray());
            nt.Send(loginReq.ToByteArray());
            this.SendEvent<LoginResEvent>();
        }
    }

    public struct LoginResEvent
    {
        
    }
}