using System;

namespace Decorator
{
    public abstract class TextViewDecorator : TextView
    {
        protected TextView textView;

        protected TextViewDecorator(TextView textView)
        {
            this.textView = textView;
        }

        public override string ToString()
        {
            return textView.ToString();
        }
    }
}