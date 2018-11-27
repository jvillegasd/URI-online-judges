using System;

class URI1170{

    static void Main(String[] args){
        int n, days;
        float x;
        n = Convert.ToInt32(Console.ReadLine());
        while (n-- > 0)
        {
            x = Convert.ToSingle(Console.ReadLine());
            days = 0;
            while(x > 1)
            {
                x = x / 2;
                days++;
            }
            Console.WriteLine(days + " dias");
        }
    }
}