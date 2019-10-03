using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.mediation.impl;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo1
{

    public class RandomNumberMediator : EventMediator
    {
        [Inject]
        public RandomNumberView view { get; set; }

        public override void OnRegister()
        {
            base.OnRegister();

            view.dispatcher.AddListener(RandomNumberView.CLICK_EVENT, onViewClicked);

            dispatcher.AddListener(AllEvents.NUMBER_CHANGE, OnNumberChange);

            view.init();
        }

        public override void OnRemove()
        {
            view.dispatcher.RemoveListener(RandomNumberView.CLICK_EVENT, onViewClicked);

            dispatcher.RemoveListener(AllEvents.NUMBER_CHANGE, OnNumberChange);
        }

        private void onViewClicked()
        {
            Debug.Log("onViewClicked()");
            dispatcher.Dispatch(AllEvents.REQUEST_WEB_SERVICE);
        }

        private void OnNumberChange(IEvent evt)
        {
            Debug.Log("OnNumberChange()");
            string number = Convert.ToString(evt.data);
            view.updateNumber(number);
        }

    }

}
