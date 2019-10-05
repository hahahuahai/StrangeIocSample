using strange.extensions.context.impl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo2
{
    public class Demo2Root : ContextView
    {
        private void Awake()
        {
            context = new Demo2Context(this);
        }
    }

}
