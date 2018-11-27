using System;

class URI1197{

    static void Main(String[] args){
        int v, t;
        String input;
        String[] intputArray = new String[2];
        while (true)
        {
            try
            {
                input = Console.ReadLine();
                intputArray = input.Split(' ');
                v = Convert.ToInt32(intputArray[0]);
                t = Convert.ToInt32(intputArray[1]);
                Console.WriteLine(2 * v * t);
            }
            catch (Exception e){break;}
        }
    }
}