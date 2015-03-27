
using System;
using System.Collections;
using System.Text;
namespace GenericClass
{
    public class GenericList<T> where T : IComparable<T>          
            
    {

        private T[] elements;
        private int nextIndex;

        // Constructor
        public GenericList(int capacity)
        {
            elements = new T[capacity];
        }

        // Properties
        public int NextIndex
        {
            get
            {
                return this.nextIndex;
            }
        }

#region Methods
        // Add element
        public void AddElement(T element)
        {
            if (this.nextIndex == this.elements.Length)
            {
                this.AutoGrow();
            }
            elements[nextIndex] = element;
            nextIndex++;
        }
        // Access element by index           << HOW/WHY DOES THIS WORK!? []
        public T this[int index]
        {
            get
            {
                if (index > this.nextIndex - 1)        // why can't I access lastIndex with elements. < it's the same, isn't it?
                {
                    throw new IndexOutOfRangeException();
                }
                return this.elements[index];
            }
        }
       
        // Remove element by Index
        public void RemoveElementByIndex(int index)
        {
            for (int i = index; i < this.nextIndex && i < this.elements.Length - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
            this.nextIndex--;
            this.elements[nextIndex] = default(T);
           
        }
        // Insert at Position !
        public void InsertAtPosition(int index, T element)
        {

            if (this.nextIndex == this.elements.Length)
            {
                this.AutoGrow();       
            }
            for (int i = this.nextIndex; i >= index && i > 0; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }
            this.elements[index] = element;
            this.nextIndex++;
            
        }
        // Clear Array
        public void Clear()
        {
            this.elements = new T[this.elements.Length];
        }

        public int FindElementByIndex(T element)
        {
            int index = 0;

            for (int i = 0; i < elements.Length; i++)
            {
                if ( elements[i].Equals(element) )
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        // Autogrow
        public void AutoGrow()
        {
            T[] tempArr = new T[this.elements.Length * 2];
            for (int i = 0; i < elements.Length; i++)
            {
                tempArr[i] = elements[i];
            }
            elements = tempArr;         // Interesting!
        }
        // Min
        public T Min()
        {
            T min = elements[0];
            for (int i = 0; i < elements.Length; i++)
            {
                if (min.CompareTo(elements[i]) > 0)     
                {
                    min = elements[i];
                }
            }
            return min;
        }
        // Max
        public T Max()
        {
            T max = elements[0];
            for (int i = 0; i < elements.Length; i++)
            {
                if (max.CompareTo(elements[i]) < 0)     
                {
                    max = elements[i];
                }
            }
            return max;
        }

        public override string ToString()
        {
            StringBuilder array = new StringBuilder();
            for (int i = 0; i < this.nextIndex; i++)
            {
                array.Append(elements[i]);
                if ( i < this.nextIndex - 1)
                {
                     array.Append(", ");
                }
            }
            return array.ToString();
        }
#endregion 

    }
}
