using strange.extensions.dispatcher.eventdispatcher.api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo1
{

    public interface IRandomNumberService 
    {
        void Request(string url);
        IEventDispatcher dispatcher { get; set; }
    }

}
