using System;

namespace Prototype 
{
    public class Mark : IClonable<Mark>
    {

        public DateTime MarkDate { get; set; }
        public decimal Value { get; set; }
        
        #region Constructors
        public Mark(){}

        //Une façon de faire
        public Mark(Mark source){
            this.Value = source.Value;
            this.MarkDate = new DateTime(source.MarkDate.Ticks);
        }
        #endregion

        //Une autre façon de faire
        public Mark Clone(){
            return new Mark{
                Value = this.Value,
                MarkDate = new DateTime(this.MarkDate.Ticks)
            };
        }
    }
}