// /*******************************************************************
// **File Name:NetUtility.cs
// **Author:   tim.huang(thkhxm@gmail.com)
// **Create Time: 2023-06-10
// **Desc:
// *******************************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using AOT;
using Google.Protobuf;
using HotFix.Code;
using UnityEngine;
using WebSocketSharp;
using ErrorEventArgs = WebSocketSharp.ErrorEventArgs;

namespace HotFix.Utility
{
    public class NetUtility:INetUtility
    {
        //
        private WebSocket ws;
        
        
        private Dictionary<string,EasyEvent<ByteString>>  revcoerEvent = new();
        
        private void OnOpen(object sender, EventArgs e)
        {
            Log.I("WebSocket 连接已打开");
        }

        private void OnMessage(object sender, MessageEventArgs e)
        {
            // [1][1][2][4][n][n]
            // message type|compress|request method name size|data size|method name|data
            Log.D($"收到消息 {BitConverter.ToString(e.RawData)}");
            var stream = new MemoryStream(e.RawData);

            // 读取数组的第一位
            var first = (byte)stream.ReadByte();
            if (first == 2)
            {
                // 读取数组的剩余数据
                var remaining = new byte[e.RawData.Length-1];
                stream.Read(remaining);
                var res = WSResponse.Parser.ParseFrom(remaining);
                revcoerEvent[res.MessageType].Trigger(res.Data);
            }else{
                Log.W("[ws] 接收到错误的协议");
            }
        }
        
        private void OnError(object sender, ErrorEventArgs e)
        {
            Log.W("WebSocket 错误: " + e.Message);
        }
        
        private void OnClose(object sender, CloseEventArgs e)
        {
            Log.I("WebSocket 连接已关闭");
        }
        
        public EasyEvent<ByteString> Send(Api api ,byte[] data)
        {
            var req = api.NewMessage(data);
            ws.Send(req.ToByteArray());
            Log.D($"[ws] 发送请求 {api.ServiceName} - data {BitConverter.ToString(data)}");

            return revcoerEvent.GetValueOrDefault(api.RequestName, new EasyEvent<ByteString>());
        }
        
        
        public void Connect(string serverAddress)
        {

            if (ws is { IsAlive: true })
            {
                return;
            }
            
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
            if (ws is { ReadyState: WebSocketState.Open })
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