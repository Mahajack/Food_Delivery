
using System; 

public class Diagonal 
{ 
	// Function to calculate difference 
	public static int difference(int[,] arr, 
								int n) 
	{ 	
		int d1 = 0, d2 = 0; 
	
		for (int i = 0; i < n; i++) 
		{ 
			for (int j = 0; j < n; j++) 
			{ 
				// finding sum of primary diagonal 
				if (i == j) 
					d1 += arr[i, j];
                     
	
				// finding sum of secondary diagonal 
				if (i == n - j - 1) 
					d2 += arr[i, j]; 
                   
			} 
		}       
        Console.WriteLine("Primary Diagonal is : " +d1);
        Console.WriteLine("Secondary Diagonal is : " +d2);
		// Absolute difference of the 
		// sums across the diagonals 
		return Math.Abs(d1 - d2); 
	} 
		
		public static void Main() 
	{ 
		int n = 3; 
		
		int[,] arr ={{11, 2, 4}, 
					{4 , 5, 6}, 
					{10, 8,-12}}; 
	
		Console.WriteLine("The Diagonal Difference is: " + difference(arr, n)); 
		
	}  
} 


