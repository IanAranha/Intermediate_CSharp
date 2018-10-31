using System;
namespace MethodsDemo
{
    public class Calculator
    {

        //Instead of having to redefine a new array each time, by using a "params" key word
        //we dont have to. Arrays are fixed length and need to be defined. But with params, we dont have to declare the array
        //or the number of items.
        public int Add(params int[] numbers)
        {
            var sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum;
        }
        public Calculator()
        {

        }
    }
}
