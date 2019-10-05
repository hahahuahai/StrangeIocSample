using strange.extensions.mediation.impl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Demo2
{

    public class GuessNumberMediator : Mediator
    {
        [Inject]
        public GuessNumberView view { get; set; }

        [Inject]
        public CallWebServiceSignal callWebServiceSignal { get; set; }

        public override void OnRegister()
        {
            callWebServiceSignal.AddListener(InitCards);
            view.init();
            callWebServiceSignal.Dispatch("INITCARDS");//发信号，初始化三张牌的数字
        }

        public override void OnRemove()
        {
            callWebServiceSignal.RemoveListener(InitCards);
        }

        private void InitCards(string message)
        {
            Debug.Log(message);
            //生成三个随机数的功能最好发信号给CallSeriviceCommand，让CallSeriviceCommand来处理。这里为了图方便。
            int Card1Number = Random.Range(1, 100);
            int Card2Number = Random.Range(1, 100);
            int Card3Number = Random.Range(1, 100);

            view.initCardsNumber(Card1Number, Card2Number, Card3Number);
        }
    }
}
