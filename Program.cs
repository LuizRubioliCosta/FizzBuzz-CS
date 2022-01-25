using System;

namespace FizzBuzz
{
   public class Program
    {
        public static int i=0;
        
         static void Main(string[] args){
             Console.WriteLine("Digite o valor de N");
             int numero=int.Parse(Console.ReadLine());
             FizzBuzz(numero);

         }
       public static  void FizzBuzz (int n)
    {
        
        for(i=1; i<n+1; i++){
        if (i % 3 ==0  && i % 5 == 0){
            Console.WriteLine("FizzBuzz");
          
        }
        else if (i%3==0){
            Console.WriteLine("Fizz");
            
        }
         else if   (i%5==0){
             Console.WriteLine("Buzz");
            
        }
        else{
            Console.WriteLine(i);
        }
        }

    }
}}
