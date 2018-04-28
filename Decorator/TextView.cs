using System;

namespace Decorator
{
    public class TextView{

        public string Text { get; set; }

        public override string ToString(){
            return $"[Text]={Text}";
        }

    }
}