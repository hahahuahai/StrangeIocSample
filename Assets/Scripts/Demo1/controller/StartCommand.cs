using strange.extensions.command.impl;
using strange.extensions.context.api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo1
{

    public class StartCommand : EventCommand
    {
        [Inject(ContextKeys.CONTEXT_VIEW)]
        public GameObject contextView { get; set; }

        public override void Execute()
        {
            GameObject go = new GameObject();
            go.name = "RandomNumberView";
            go.AddComponent<RandomNumberView>();
            go.transform.parent = contextView.transform;

        }
    }

}
