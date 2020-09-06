using System;
using System.Collections.Generic;
using System.Text;

namespace GenericList
{
    class GenericList<T>
    {
        // Fields
        private int length = 0;
        private T[] array;
        private int lastIndex = 0;
        private bool updateArray = false;

        
        // Properties
        public int Length
        {
            get
            {
                return array.Length;
            }
        }

        public string EmptyIndexes
        {
            get
            {
                string indexes = "";
                for (int i = 0; i < length; i++)
                {
                    if (array[i] == null)
                    {
                        indexes += i.ToString();
                        if (i != length - 1)
                        {
                            indexes += " ";
                        }
                    }
                }
                return indexes;
            }
        }
        
        
        // Constructor
        public GenericList(int length)
        {
            this.length = length;
            array = new T[length];
        }


        //Methods
        public void AddElement(T element)
        {
            while (lastIndex >= length)
            {
                length += 1;
                updateArray = true;
            }
            if (updateArray)
            {
                T[] newArray = new T[length];
                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
                newArray = null;
                updateArray = false;
            }
            array[lastIndex] = element;
            lastIndex++;
        }

        public void DeleteElement(int index)
        {
            if (index >= length)
            {
                throw new IndexOutOfRangeException("Not in range");
            }
            array[index] = default(T);
        }

        public T GetElement(int index)
        {
            if (index >= length)
            {
                throw new IndexOutOfRangeException("Out Of Range!");
            }
            return array[index];
        }

        // TODO Edit element by index;

        // Workds on any positions
        public void AddElementOn(int index, T element)
        {
            while (index >= length)
            {
                length += 1;
                updateArray = true;
            }
            if (updateArray)
            {
                T[] newArray = new T[length];
                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
                newArray = null;
                updateArray = false;
            }
            array[index] = element;
        }
    
        public void Clear()
        {
            for (int i = 0; i < length; i++)
            {
                array[i] = default(T);
            }
        }

        public string MyToString()
        {
            string text = "";
            foreach(T element in array)
            {
                if(element == null)
                {
                    text += "";
                    continue;
                }
                text += element.ToString() + " ";
            }
            return text;
        }

    }
}
