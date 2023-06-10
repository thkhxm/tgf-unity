// /*******************************************************************
// **File Name:CodeArchitecture.cs
// **Author:   tim.huang(thkhxm@gmail.com)
// **Create Time: 2023-06-08
// **Desc: 全局architecture
// *******************************************************************/

using AOT;
using HotFix.Code;
using HotFix.MainPanel.Model;
using HotFix.Utility;
using UnityEngine;

namespace HotFix
{   
    public class CodeArchitecture : Architecture<CodeArchitecture>
    {

        #region initArchitechture
        private static CodeArchitecture mArchitecture;
        public static IArchitecture Interface
        {
            get
            {
                if (mArchitecture == null)
                {
                    MakeSureArchitecture();
                }
                return mArchitecture;
            }
        }

        private static void MakeSureArchitecture()
        {
            if (mArchitecture != null) return;
            mArchitecture = new CodeArchitecture();
            mArchitecture.Init();
                
            mArchitecture.ClearUp();
        }
        #endregion
       
        
        protected override void Init()
        {
            RegisterModel(new ServerModel());
            
            RegisterUtility(new IOCContainer());
            RegisterUtility(new NetUtility());
            
        }
        
    }

}