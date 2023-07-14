// /*******************************************************************
// **File Name:MainController.cs
// **Author:   tim.huang(thkhxm@gmail.com)
// **Create Time: 2023-06-10
// **Desc:
// *******************************************************************/

using System;
using AOT;
using HotFix.Code;
using HotFix.MainPanel.Command;
using HotFix.MainPanel.Model;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace HotFix.MainPanel
{
    public class MainController : ViewController
    {
        [SerializeField]
        private Button _loginBtn;
        [SerializeField]
        private Button _logoutBtn;

        
        protected override void InitStart()
        {
            //找到globalConfig
            var globalConfig = GameObject.FindWithTag("load").GetComponent<LoadDll>().Config;
            //初始配置服务器地址
            this.GetModel<ServerModel>().ServerAddress = globalConfig.ServerAddress;
            //登录点击command
            _loginBtn.onClick.AddListener(this.SendCommand<LoginCommand>);
            //登出点击事件
            _logoutBtn.onClick.AddListener(this.SendCommand<LogoutCommand>);
        }

        private void OnDestroy()
        {
            this.SendCommand<LogoutCommand>();
        }
        
        protected override void InitEvent()
        {
            this.RegisterEvent<LoginEvent>(e =>
            {
                if (e.Success)
                {
                    SceneManager.LoadScene("Scenes/Game");
                }
                else
                {
                    Debug.Log("[login] 登录失败");
                }
            }).UnRegisterWhenGameObjectDestroyed(this);
        }
        
        public struct LoginEvent
        {
            public bool Success{ get; set; }
        }
        
    }
}