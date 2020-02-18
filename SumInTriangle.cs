using System; 
  
class SumsInTriangle { 
      
     
    static int maxPathSum(int [,]tri,  
                          int m, int n) 
    { 
         
        for (int i = m - 1; i >= 0; i--) 
        { 
            for (int j = 0; j <= i; j++) 
            { 
               
                if (tri[i + 1,j] >  
                       tri[i + 1,j + 1]) 
                    tri[i,j] +=  
                           tri[i + 1,j]; 
                else
                    tri[i,j] +=  
                       tri[i + 1,j + 1]; 
            } 
        } 
      
        
        return tri[0,0]; 
    } 
      
    
    public static void Main () 
    { 
        int [,]tri = { {1, 0, 0}, 
                        {4, 8, 0}, 
                        {1, 5, 3} }; 
                          
        Console.WriteLine (  
             maxPathSum(tri, 2, 2)); 
    } 
} 