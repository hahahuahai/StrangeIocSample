using strange.extensions.command.impl;
using strange.extensions.context.api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo2
{

    public class StartCommand : Command
    {
        [Inject(ContextKeys.CONTEXT_VIEW)]
        public GameObject contextView { get; set; }

        public override void Execute()
        {

            GameObject go = new GameObject();
            go.name = "GuessNumberView";
            go.AddComponent<GuessNumberView>();
            go.transform.parent = contextView.transform;

        }
    }

}
