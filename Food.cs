using System;
using System.Linq;
public class FoodDelivery
{
    public static void Main()
    {
        Console.WriteLine("Enter the no of orders : ");
        string[] array_index = Console.ReadLine().Split(' ');
        int total_no_of_orders = Convert.ToInt32(array_index[0]);
        int deliveryman1totalorder = Convert.ToInt32(array_index[1]);
        int deliveryman2totalorder = Convert.ToInt32(array_index[2]);
        int[] deliveryman1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int[] deliveryman2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        
        Array.Sort(deliveryman1);
        Array.Reverse(deliveryman1);
        Array.Sort(deliveryman2);
        Array.Reverse(deliveryman2);

        int deliveryman1tip = 0, deliveryman2tip = 0, maximum_tip = 0;

        while (total_no_of_orders > 0)
        {

            if (deliveryman1tip < deliveryman1totalorder &&  
                deliveryman2tip < deliveryman2totalorder && 
                deliveryman1[deliveryman1tip] >= deliveryman2[deliveryman2tip])
            {
                maximum_tip += deliveryman1[deliveryman1tip];
                deliveryman1tip++;
            }

            else if (deliveryman1tip < deliveryman1totalorder && 
                     deliveryman2tip < deliveryman2totalorder && 
                     deliveryman1[deliveryman1tip] < deliveryman2[deliveryman2tip])
            {
                maximum_tip += deliveryman2[deliveryman2tip];
                deliveryman2tip++;
            }

            else if (deliveryman1tip < deliveryman1totalorder)
            {
                maximum_tip += deliveryman1[deliveryman1tip];
                deliveryman1tip++;
            }

            else if (deliveryman2tip < deliveryman2totalorder)
            {
                maximum_tip += deliveryman2[deliveryman2tip];
                deliveryman2tip++;
            }

            total_no_of_orders--;
        }

        Console.WriteLine("Maximum tip is : " +maximum_tip);

    }
}