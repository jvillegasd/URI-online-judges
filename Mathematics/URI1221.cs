using System;

class URI1221{ //URI 1221

    static void Main(String[] args){
        int n;
        n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            long number = Convert.ToInt64(Console.ReadLine());
            if (number == 0 || number == 1)
            {
                Console.WriteLine("Not Prime");
                continue;
            }
            if(number == 2)
            {
                Console.WriteLine("Prime");
                continue;
            }
            int cont = 1;
            for(int j = 2; j < Math.Sqrt(number); j++)
            {
                if(number % j == 0)
                {
                    cont = 0;
                    break;
                }
            }
            if(cont != 1)
            {
                Console.WriteLine("Not Prime");
            }else{
                Console.WriteLine("Prime");
            }
        }
    }
}