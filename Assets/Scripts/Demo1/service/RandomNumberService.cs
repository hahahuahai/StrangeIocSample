using System.Collections;
using System.Collections.Generic;
using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.api;
using UnityEngine;

namespace Demo1
{

    public class RandomNumberService : IRandomNumberService
    {

        [Inject(ContextKeys.CONTEXT_VIEW)]
        public GameObject contextView { get; set; }

        [Inject]
        public IEventDispatcher dispatcher { get; set; }

        private string url;

        public RandomNumberService() { }

        public void Request(string url)
        {
            Debug.Log("   public void Request(string url)");
            this.url = url;

            MonoBehaviour root = contextView.GetComponent<Demo1Root>();
            root.StartCoroutine(generateRandomNumber());
        }

        private IEnumerator generateRandomNumber()
        {
            Debug.Log("private IEnumerator generateRandomNumber()");
            yield return new WaitForSeconds(1f);

            int randomnumber = Random.Range(1, 100);
            dispatcher.Dispatch(AllEvents.FULFILL_SERVICE_REQUEST, randomnumber);
            
        }
    }

}
