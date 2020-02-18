using System;  
public class StairCase  
{  
    public static void Main()
{
   int i,j,n;
   
   Console.Write("Input number of rows for this pattern :");
   n= Convert.ToInt32(Console.ReadLine());    
   for ( i = n; i >= 1; i--)   
            {  
                Console.WriteLine(" ");  
                for ( j = 1; j <= i; j++)  
                {  
                    Console.Write(" ");  
                }  
                for ( j = i; j <= n; j++)   
                {  
                    Console.Write("#");  
                }  
            }  
 }
} 