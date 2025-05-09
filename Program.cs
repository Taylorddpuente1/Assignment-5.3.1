// Give an integer array flowerbed.
//0= empty, 1= not empty
//integer n
//return true if i n new flowers can be plantedin the flower bed without violating no adjacent flowers rule
//, otherwise false

using System;
class Program
{
    static bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        int count = 0;
        for (int i = 0; i < flowerbed.Length; i++)
        {
            if (flowerbed[i] == 0)
            {
                bool leftEmpty = (i == 0 || flowerbed[i - 1] == 0);
                bool rightEmpty = (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0);

                if (leftEmpty && rightEmpty)
                {
                    flowerbed[i] = 1;
                    count++;
                    if (count >= n) return true;
                }
            }
        }
        return count >= n;
    }
    static void Main()
    {
        //Example 1
        int[] flowerbed = { 1, 0, 0, 0, 1 };
        int n = 1;

        bool result = CanPlaceFlowers(flowerbed, n);
        Console.WriteLine(result);
    }   
}