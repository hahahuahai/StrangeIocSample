using strange.extensions.command.api;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using strange.extensions.context.impl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo2
{

    public class Demo2Context : MVCSContext
    {
        public Demo2Context(MonoBehaviour view) : base(view)
        {

        }

        protected override void addCoreComponents()
        {
            base.addCoreComponents();
            injectionBinder.Unbind<ICommandBinder>();
            injectionBinder.Bind<ICommandBinder>().To<SignalCommandBinder>().ToSingleton();
        }

        public override IContext Start()
        {
            base.Start();
            StartSignal startSignal = injectionBinder.GetInstance<StartSignal>();
            startSignal.Dispatch();
            return this;
        }

        protected override void mapBindings()
        {
            base.mapBindings();

            injectionBinder.Bind<IGuessNumberModel>().To<GuessNumberModel>().ToSingleton();
            injectionBinder.Bind<IGuessNumberService>().To<GuessNumberService>().ToSingleton();

            mediationBinder.Bind<GuessNumberView>().To<GuessNumberMediator>();

            commandBinder.Bind<StartSignal>().To<StartCommand>().Once();
            commandBinder.Bind<CallWebServiceSignal>().To<CallWebServiceCommand>();


        }

    }

}

