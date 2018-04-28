using System;

namespace Decorator
{
    public class TextViewBorderDecorator : TextViewDecorator
    {
        public TextViewBorderDecorator(TextView textView) : base(textView) { }

        public override string ToString()
        {
            return base.ToString() + " Je possède une bordure !";
        }
    }
}
