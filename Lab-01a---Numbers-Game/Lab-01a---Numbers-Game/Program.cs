using System;

namespace Lab_01a___Numbers_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartSequence();
        }
        static void StartSequence()
        {                      
            Console.WriteLine("Enter a number greater than zero");
            int x = Convert.ToInt32(Console.ReadLine());



            try
            {
                //decler ane array
                int []arr=new int[x];
                //fill  array in elements
                int[] Narr= Populate(arr);
                //var to save sum the element of araay
                int sum = GetSum(Narr);
                //var to save Multiply for sum and rendom array elements 
                int Y = GetProduct(Narr,sum);
                //var to save divide  
                decimal div = GetQuotient(Y);   
                // to show the length array 
                Console.WriteLine($"Your array is size {Narr.Length}");
                // to show the element of array 
                Console.Write($"The numbers in array arr ");
                GetArr(Narr);
                Console.WriteLine("");
                // to show the sumation of elements 
                Console.WriteLine($"The sum of array is  {sum}");
                // to show The equation 
                Console.WriteLine($" {sum} * {Y/sum}={Y}" );
                // to show The equation
                Console.WriteLine($" {Y} * {Y / div}={div}");
                Console.Write($"Program is complete ");

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }


        }
        static int[] Populate(int[]newarr)
          {
            //Fill in the matrix
            //declaer array 
            int[]intarr=new int[newarr.Length];
            try
            {
                //to fill the array with user inpute
                for (int i = 0; i < intarr.Length; i++)
                {
                    Console.WriteLine("PLese enter number :  " + (i + 1) + "  of  " + newarr.Length);
                    intarr[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //to catch any erorr
            catch(FormatException ex) { Console.WriteLine(ex.Message); }
            return intarr;
        }
        static int GetSum(int []arr)
        {//to sumation array elements
            int sum = 0;
            //to sum the elements
            for (int i = 0; i < arr.Length; i++)
            {

                sum += arr[i];
            }
            ////requirement
            if (sum <20)
            {
                Console.WriteLine($"Value of {sum} is too low");
                return sum;
            }
            else
            {
                return sum;
            }
                    

        }
        static int GetProduct(int []arr,int sum)
        {
            //this function to Multiply the array element with rendom array elements
            int product = 0;
            try { 
            Console.WriteLine($"select a random number between 1 and{arr.Length}");
                //to take anumber rendom from element array
            int Euser= Convert.ToInt32(Console.ReadLine());
                //to save Multiply array
                product = arr[Euser-1] * sum;
            }

            catch (FormatException ex) { Console.WriteLine(ex.Message); }
            return product;
        }
        static decimal GetQuotient(int product)
        {
            //this function to divied the array

            decimal quotient = 0;
            try
            {
                Console.WriteLine($"please enter a number to divide your product {product} by");
                int Euser = Convert.ToInt32(Console.ReadLine());
                 quotient = product / Euser;
               
            }
            catch  (Exception ex)
            {
                Console.WriteLine($"something erorr {ex}");
            }
            
            
                return quotient;
            
        }
        static void GetArr(int[] arr)
        {
            //to print the array 
            for (int i = 0; i < arr.Length; i++)
            {

               Console.Write("," + arr[i]);
            }
         

        }
    }
}
