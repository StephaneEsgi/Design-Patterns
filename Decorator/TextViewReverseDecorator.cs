using System;
using System.Linq;

namespace Decorator
{
    public class TextViewReverseDecorator : TextViewDecorator
    {
        public TextViewReverseDecorator(TextView textView) : base(textView) { }

        public override string ToString()
        {
            return new string(base.ToString().ToCharArray().Reverse().ToArray());
        }
    }
}
