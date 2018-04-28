using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            TextView basic = new TextView{ Text = "Je suis une textView avec un texte ^^ !" };

            TextView scrollable = new TextViewScrollableDecorator(basic);
            TextView basicWithBorder = new TextViewBorderDecorator(basic);
            TextView scrollableWithBorder = new TextViewBorderDecorator(scrollable);
            TextView reversedScrollableWithBorder = new TextViewReverseDecorator(scrollableWithBorder);
            TextView reversedBasic = new TextViewReverseDecorator(basic);

            System.Console.WriteLine(basic);
            System.Console.WriteLine();
            System.Console.WriteLine(scrollable);
            System.Console.WriteLine();
            System.Console.WriteLine(basicWithBorder);
            System.Console.WriteLine();
            System.Console.WriteLine(scrollableWithBorder);
            System.Console.WriteLine();
            System.Console.WriteLine(reversedScrollableWithBorder);
            System.Console.WriteLine();
            System.Console.WriteLine(reversedBasic);
        }
    }
}
