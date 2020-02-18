using System;
using System.Linq;
struct My : IComparable<My> {
public int X ;
public int Y;
public int Diff ;
public int CompareTo(My m){
    return m.Diff.CompareTo(this.Diff);
}
}
public class Test
{
    public static void Main()
    {
       
        int[] num = Console.ReadLine().Trim().Split().Select(x => int.Parse(x)).ToArray();
        int n = num[0];
        int m = num[1];
        int k = num[2];
        int[] numX = Console.ReadLine().Trim().Split().Select(x => int.Parse(x)).ToArray();
        int[] numY = Console.ReadLine().Trim().Split().Select(x => int.Parse(x)).ToArray();
       
        long total = 0 ;
        My[] arr = new My[n];
        for(int i = 0 ; i < n ; i++){
            arr[i].X = numX[i];
            arr[i].Y = numY[i];
            arr[i].Diff = Math.Abs(numX[i] - numY[i]);
        }
        Array.Sort(arr);
        for(int i = 0 ; i < n ; i++){
            if(arr[i].X > arr[i].Y){
                if(m > 0){
                    total += arr[i].X;
                    m--;
                }else{
                    total += arr[i].Y;
                    k--;
                }
            } else if(arr[i].X < arr[i].Y){
                if(k > 0){
                    total += arr[i].Y;
                    k--;
                }else{
                    total += arr[i].X;
                    m--;
                }
            } else {
                total += arr[i].X;
                if(k > m){
                    k--;
                }else{
                    m--;
                }
            }
        }
        Console.WriteLine(total);
    }
}