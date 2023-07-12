// /*******************************************************************
// **File Name:Api.cs
// **Author:   tim.huang(thkhxm@gmail.com)
// **Create Time: 2023-06-12
// **Desc:
// *******************************************************************/

using System;
using Google.Protobuf;

namespace AOT
{
    public struct Api
    {
        public string Module { get; }
        public string ServiceName { get; }
        
        public string RequestName => Module + "." + ServiceName;

        public Api(string module,string serviceName)
        {
            Module = module ?? throw new ArgumentNullException(nameof(module));
            ServiceName = serviceName ?? throw new ArgumentNullException(nameof(serviceName));
        }

        public WSMessage NewMessage()
        {
            var ms = new WSMessage
                { Data = null, Module = Module, ServiceName = ServiceName };
            return ms;
        }
        
        public WSMessage NewMessage(byte[] data)
        {
            var ms = new WSMessage
                { Data = ByteString.CopyFrom(data), Module = Module, ServiceName = ServiceName };
            return ms;
        }
    }
}