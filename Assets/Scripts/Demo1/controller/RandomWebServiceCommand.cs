using strange.extensions.command.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo1
{

    public class RandomWebServiceCommand : EventCommand
    {
        [Inject]
        public IRandomNumberModel model { get; set; }

        [Inject]
        public IRandomNumberService service { get; set; }


        public RandomWebServiceCommand()
        {
            Debug.Log("public RandomWebServiceCommand()");
        }

        public override void Execute()
        {
            Debug.Log("Execute()");
            Retain();

 

            service.dispatcher.AddListener(AllEvents.FULFILL_SERVICE_REQUEST, onComplete);
            service.Request("www.xxx.com");
        }

        private void onComplete(IEvent evt)
        {
            Debug.Log("private void onComplete(IEvent evt)");
            service.dispatcher.RemoveListener(AllEvents.FULFILL_SERVICE_REQUEST, onComplete);

            

            model.value = evt.data as string;

            dispatcher.Dispatch(AllEvents.NUMBER_CHANGE, evt.data);

            Release();
        }
    }

}
