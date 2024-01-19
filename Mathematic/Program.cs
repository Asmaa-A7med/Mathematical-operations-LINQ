namespace Mathematic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] numbers= { 1, 2, 3, 4, 5 };
                     //to count numbers in array 
            var count = numbers.Count();
            Console.WriteLine("count of elemnt in array : "+count);
                    
                    //return sum of element in array
            var sum=numbers.Sum();
            Console.WriteLine("sum of elements = "+sum);

                    //return maximum number in array
            var max=numbers.Max();
            Console.WriteLine("Max number is : " + max);

                    //return minimum number in array 
            var min=numbers.Min();
            Console.WriteLine("Minimum number is : " + min);

                    //to return average of numbers in array
            var avg=numbers.Average();
            Console.WriteLine("The average of numbers = " + avg);
        
        }
    }
}