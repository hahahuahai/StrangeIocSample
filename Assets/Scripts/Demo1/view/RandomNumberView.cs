using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.mediation.impl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Demo1
{

    public class RandomNumberView : View
    {
        internal const string CLICK_EVENT = "CLICK_EVENT";

        [Inject]
        public IEventDispatcher dispatcher { get; set; }

        [Inject(ContextKeys.CONTEXT_VIEW)]
        public GameObject contextView { get; set; }
        private GameObject RandomNumberCanvas;

        internal void init()
        {
            RandomNumberCanvas = Instantiate(Resources.Load("RandomNumberCanvas")) as GameObject;
            GameObject GenerateBtn =  RandomNumberCanvas.transform.Find("GenerateBtn").gameObject;
            GenerateBtn.GetComponent<Button>().onClick.AddListener(GenerateBtnClick);
            RandomNumberCanvas.transform.parent = transform;
        }

        private void GenerateBtnClick()
        {
            Debug.Log("GenerateBtn Clicked!");
            dispatcher.Dispatch(CLICK_EVENT);
        }

        internal void updateNumber(string number)
        {
            Debug.Log("internal void updateNumber(string number)");
            Debug.Log("number:" + number);
            GameObject RandomNumberCanvas = transform.Find("RandomNumberCanvas(Clone)").gameObject;
            Debug.Log("RandomNumberCanvas:"+RandomNumberCanvas.transform.Find("RandomNumberTxt").gameObject.GetComponent<Text>().text);
            //GameObject RandomNumberTxt = RandomNumberCanvas.transform.Find("RandomNumberTxt").gameObject;
            RandomNumberCanvas.transform.Find("RandomNumberTxt").gameObject.GetComponent<Text>().text = number;
        }
    }

}
