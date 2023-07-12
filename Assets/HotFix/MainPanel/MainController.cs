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
using UnityEngine.UI;

namespace HotFix.MainPanel
{
    public class MainController : MonoBehaviour,IController
    {
        [SerializeField]
        private Button _loginBtn;
        [SerializeField]
        private Button _logoutBtn;

        
        
        private void Start()
        {
            //找到globalConfig
            var globalConfig = GameObject.FindWithTag("load").GetComponent<LoadDll>().Config;
            //初始配置服务器地址
            this.GetModel<ServerModel>().ServerAddress = globalConfig.ServerAddress;
            //登录点击command
            _loginBtn.onClick.AddListener(this.SendCommand<LoginCommand>);
            //登出点击事件
            _loginBtn.onClick.AddListener(this.SendCommand<LogoutCommand>);
        }

        private void OnDestroy()
        {
            this.SendCommand<LogoutCommand>();
        }

        public IArchitecture GetArchitecture()
        {
            return CodeArchitecture.Interface;
            
        }
    }
}