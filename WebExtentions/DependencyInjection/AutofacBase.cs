using Autofac;
using System;

namespace WebExtentions.DependencyInjection
{
    public abstract class AutofacBase : Module
    {
        //�˴���д��������쳣
        protected override System.Reflection.Assembly ThisAssembly => this.GetType().Assembly;

        protected override void Load(ContainerBuilder builder)
        {

        }
    }
}