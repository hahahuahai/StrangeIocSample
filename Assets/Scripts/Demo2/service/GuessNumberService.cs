using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Demo2
{

    public class GuessNumberService : IGuessNumberService
    {
        public FulfillWebServiceRequestSignal fulfillSignal { get; set; }

        public void Request(string url)
        {
            throw new System.NotImplementedException();
        }
    }

}