// /*******************************************************************
// **File Name:NetUtility.cs
// **Author:   tim.huang(thkhxm@gmail.com)
// **Create Time: 2023-06-10
// **Desc:
// *******************************************************************/

using System;
using HotFix.Code;
using UnityEngine;
using WebSocketSharp;

namespace HotFix.Utility
{
    public class NetUtility:INetUtility
    {
        //
        private WebSocket ws;
        
        
        public EasyEvent<byte[]> revcoerEvent;
        
        private void OnOpen(object sender, EventArgs e)
        {
            Debug.Log("WebSocket 连接已打开");
        }
        
        
        
        private void OnMessage(object sender, MessageEventArgs e)
        {
            // [1][1][2][4][n][n]
            // message type|compress|request method name size|data size|method name|data
            Debug.Log("收到消息: " + e.RawData);
        }
        
        private void OnError(object sender, ErrorEventArgs e)
        {
            Debug.LogError("WebSocket 错误: " + e.Message);
        }
        
        private void OnClose(object sender, CloseEventArgs e)
        {
            Debug.Log("WebSocket 连接已关闭");
        }
        
        public void Send(byte[] data)
        {
            ws.Send(data);
        }
        
        
        public void Connect(string serverAddress)
        {
            // 连接 WebSocket 服务器
            ws = new WebSocket(serverAddress);
        
            // 注册事件处理程序
            ws.OnOpen += OnOpen;
            ws.OnMessage += OnMessage;
            ws.OnError += OnError;
            ws.OnClose += OnClose;
            ws.Connect();
        }
        
        public void Close()
        {
            // 断开 WebSocket 连接
            if (ws != null && ws.ReadyState == WebSocketState.Open)
            {
                ws.Close();
            }
        }
    }
    
    public interface INetUtility : IUtility
    {
        void Connect(string serverAddress);
        void Close();
    }
}