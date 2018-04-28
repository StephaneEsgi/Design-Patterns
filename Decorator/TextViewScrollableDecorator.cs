using System;

namespace Decorator
{
    public class TextViewScrollableDecorator : TextViewDecorator
    {
        public TextViewScrollableDecorator(TextView textView) : base(textView) { }

        public override string ToString()
        {
            return base.ToString() + " Je suis scrollable !";
        }
    }
}
