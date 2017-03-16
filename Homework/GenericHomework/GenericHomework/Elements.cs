
namespace GenericHomework
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Elements<T>
    {
        #region Fields
        private static T[] empty;
        private T[] data;

        private int indexPosition = 0;
        #endregion


        #region Constructors
        public Elements(int lenght)
        {
            this.data = new T[lenght];
            empty = new T[lenght];
        }
        #endregion


        #region Methods


        public void AddElement(T element)
        {
            //if (this.lastIndexPosition < this.data.Length)
            //{
                this.data[indexPosition] = element;
                this.indexPosition++;
            //}
            //else
            //{
            //    throw new ArgumentException("You are out of range of the array!");
            //}
            
        }
        public void RemoveElement(int index)
        {
            for (int i = index; i < this.indexPosition && i < this.data.Length -1 ; i++)
            {
                this.data[i] = this.data[i + 1];
            }
            this.indexPosition--;
            this.data[indexPosition] = default(T);
        }
        public void ClearAll()
        {
            for (int i = 0; i < data.Length; i++)
            {
                this.data[i] = empty[i];
            }
        }
        public void InsertByIndex(int index, T element)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.indexPosition; i++)
            {
                sb.Append(this.data[i]);
                if (i < this.indexPosition - 1)
                {
                    sb.Append(", ");
                }
            }

            return sb.ToString();
        }
        public T this[int index] //indexer
        {
            get
            {
            if (index > this.indexPosition - 1)
	        {
		    throw new IndexOutOfRangeException();
	        }
             return this.data[index]; 
            }
            private set { this.data[index] = value; }
            
        }
        private void AutoGrow()
        {
            var newData = new T[this.data.Length * 2];
            for (int i = 0; i < this.data.Length; i++)
            {
                newData[i] = this.data[i];
            }
            this.data = newData;
        }
        #endregion   
    }
}
