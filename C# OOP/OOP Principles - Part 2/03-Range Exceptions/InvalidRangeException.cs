
namespace _03_Range_Exceptions
{
    using System;
    class InvalidRangeException<T> : ApplicationException
    {
     
        private T lowerRange;
        private T upperRange;

        public T LowerRange
        {
            get { return lowerRange; }
            set { lowerRange = value; }
        }
        public T UpperRange
        {
            get { return upperRange; }
            set { upperRange = value; }
        }

        public InvalidRangeException(T lowerRange, T upperRange)
        {
            //   this.message = message;
            this.LowerRange = lowerRange;
            this.UpperRange = upperRange;
        }

        public override string Message
        {
            get
            {
                return string.Format("Value must be in the range [{0} ... {1}]", this.LowerRange, this.UpperRange);
            }
        }


    }
}
