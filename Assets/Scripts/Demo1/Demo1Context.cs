using strange.extensions.context.api;
using strange.extensions.context.impl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo1
{
    public class Demo1Context : MVCSContext
    {
        public Demo1Context(MonoBehaviour view) : base(view)
        {

        }

        protected override void mapBindings()
        {
            injectionBinder.Bind<IRandomNumberModel>().To<RandomNumberModel>().ToSingleton();
            injectionBinder.Bind<IRandomNumberService>().To<RandomNumberService>().ToSingleton();

            mediationBinder.Bind<RandomNumberView>().To<RandomNumberMediator>();

            commandBinder.Bind(AllEvents.REQUEST_WEB_SERVICE).To<RandomWebServiceCommand>();

            commandBinder.Bind(ContextEvent.START).To<StartCommand>().Once();

        }

    }

}
