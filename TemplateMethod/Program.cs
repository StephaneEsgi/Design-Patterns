using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var mainActivity = new MainActivity();
            mainActivity.Begin();
            mainActivity.End();
        }
    }
}
