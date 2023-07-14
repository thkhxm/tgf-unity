// /*******************************************************************
// **File Name:Log.cs
// **Author:   tim.huang(thkhxm@gmail.com)
// **Create Time: 2023-07-14
// **Desc:
// *******************************************************************/

using UnityEngine;

namespace HotFix.Code
{
    public class Log
    {

        public static void I(string msg)
        {
            Debug.Log($"[info] {msg}");
        }
        
        public static void D(string msg)
        {
            Debug.Log($"[debug] {msg}");
        }
        public static void W(string msg)
        {
            Debug.LogWarning($"[warn] {msg}");
        }
        public static void E(string msg)
        {
            Debug.LogError($"[err] {msg}");
        }
    }
}