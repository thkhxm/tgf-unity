// /*******************************************************************
// **File Name:NetworkController.cs
// **Author:   tim.huang(thkhxm@gmail.com)
// **Create Time: 2023-07-12
// **Desc:
// *******************************************************************/

using UnityEngine;

namespace HotFix.Code
{
    public class NetworkController : MonoBehaviour,IController
    {
        
        
        
        public IArchitecture GetArchitecture()
        {
            return CodeArchitecture.Interface;
        }
    }
}