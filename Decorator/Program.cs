using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            TextView basic = new TextView{ Text = "Je suis une textView avec un texte ^^ !" };

            TextView scrollable = new TextViewScrollableDecorator(basic);

            System.Console.WriteLine(basic);
            System.Console.WriteLine(scrollable);
        }
    }
}
