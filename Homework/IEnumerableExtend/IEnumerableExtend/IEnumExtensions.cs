using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtend
{
    public static class IEnumExtensions
    {
        //SUM
        public static T Sum<T>(this IEnumerable<T> collection)
        {
            if (collection.Count() == 0)
            {
                throw new NullReferenceException("The given array is empty!");
            }
            else
            {
                dynamic sum = 0;

                foreach (var element in collection)
                {
                    sum += element;
                }

                return sum;
            }
        }
        //product
        public static T Product<T>(this IEnumerable<T> collection)
        {
            if (collection.Count() == 0)
            {
                throw new NullReferenceException("The given array is empty!");
            }
            else
            {
                dynamic product = 1;

                foreach (var element in collection)
                {
                    product *= element;
                }

                return product;
            }
        }
        //average
        public static T Average<T>(this IEnumerable<T> collection)
        {
            if (collection.Count() == 0)
            {
                throw new NullReferenceException("The given array is empty!");
            }
            else
            {
                dynamic sum = 0;

                foreach (var element in collection)
                {
                    sum += element;
                }
                return sum / collection.Count();
            }
        }
        //min
        public static T Min<T>(this IEnumerable<T> collection)
        {
            if (collection.Count() == 0)
            {
                throw new NullReferenceException("The given array is empty!");
            }
            else
            {
                dynamic min = collection.First();
                foreach (var item in collection)
                {
                    if (min > item)
                    {
                        min = item;
                    }  
                }
                return min;
            }
        }
        //Max
        public static T Max<T>(this IEnumerable<T> collection)
        {
            if (collection.Count() == 0)
            {
                throw new NullReferenceException("The given array is empty!");
            }
            else
            {
                dynamic max = collection.First();
                foreach (var item in collection)
                {
                    if (max < item)
                    {
                        max = item;
                    }
                }
                return max;
            }
        }
    }
}
