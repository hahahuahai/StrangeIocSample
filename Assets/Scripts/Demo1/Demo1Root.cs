using strange.extensions.context.impl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo1
{
    public class Demo1Root : ContextView
    {
        private void Awake()
        {
            context = new Demo1Context(this);
        }
    }

}
