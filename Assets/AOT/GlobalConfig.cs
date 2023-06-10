// /*******************************************************************
// **File Name:GlobalConfig.cs
// **Author:   tim.huang(thkhxm@gmail.com)
// **Create Time: 2023-06-08
// **Desc:
// *******************************************************************/

using UnityEngine;
using UnityEngine.Serialization;

namespace AOT
{
    [CreateAssetMenu(fileName = "GlobalConfig", menuName = "Config/GlobalConfig", order = 0)]
    public class GlobalConfig : ScriptableObject
    {
        /// <summary>
        /// 服务器地址
        /// </summary>
        public string ServerAddress = "ws://127.0.0.1:8443/tgf";
        
        public string YooAssetPackageName = "DefaultPackage";
        
        //CDN地址
        public string DefaultHostServer = "http://192.168.1.90/hfs/";
        public string FallbackHostServer = "http://192.168.1.90/hfs/";
        public string HotDllName = "HotFix.dll";

        public string[] InitManagerNames;
        
    }
}