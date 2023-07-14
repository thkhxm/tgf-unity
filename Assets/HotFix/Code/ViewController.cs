// /*******************************************************************
// **File Name:ViewController.cs
// **Author:   tim.huang(thkhxm@gmail.com)
// **Create Time: 2023-07-14
// **Desc:
// *******************************************************************/

using System;
using UnityEngine;

namespace HotFix.Code
{
    public abstract class ViewController:MonoBehaviour,IController
    {
        private void Start()
        {
            InitEvent();
            InitStart();
        }

        public IArchitecture GetArchitecture()
        {
            return CodeArchitecture.Interface;
        }

        protected abstract void InitEvent();

        protected abstract void InitStart();
    }
}