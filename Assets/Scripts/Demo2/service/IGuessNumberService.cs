using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo2
{

    public interface IGuessNumberService
    {
        void Request(string url);

        FulfillWebServiceRequestSignal fulfillSignal { get; set; }
    }

}
