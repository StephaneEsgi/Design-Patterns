using System;
using static System.Console;

namespace TemplateMethod
{
    public abstract class Activity
    {
        public void Begin()
        {
            OnCreate();
            OnStart();
            OnResume();
        }

        public void End()
        {
            OnPause();
            OnStop();
            OnDestroy();
        }

        public virtual void OnCreate()
        {
            WriteLine("[Activity] OnCreate()");
            WriteLine($"[Activity] Instatiation du layout '{GetLayoutRes()}'");
        }

        public virtual void OnStart()
        {
            WriteLine("[Activity] OnStart()");
        }

        public virtual void OnResume()
        {
            WriteLine("[Activity] OnResume()");
        }

        public virtual void OnPause()
        {
            WriteLine("[Activity] OnPause()");
        }

        public virtual void OnStop()
        {
            WriteLine("[Activity] OnStop()");
        }

        public virtual void OnDestroy()
        {
            WriteLine("[Activity] OnDestroy()");
        }

        // on délègue l'implémentation aux classes concrètes qui fourniront cette ressource
        public abstract string GetLayoutRes();

    }
}