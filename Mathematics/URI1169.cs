using System;

class URI1169{

    static void Main(String[] args){
        int n, x;
        ulong weight;
        n = Convert.ToInt32(Console.ReadLine());
        while (n-- > 0)
        {
            x  = Convert.ToInt32(Console.ReadLine());
            weight = 0;
            for (int i = 0; i < x; i++)
            {
                weight = weight + Convert.ToUInt64(Math.Pow(2, i));
            }
            Console.WriteLine(weight / 12000 + " kg");
        }
    }
}