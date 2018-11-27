using System;

class URI1198{

    static void Main(String[] args){
        String input;
        String[] inputArray = new String[2];
        long HA, EA;
        while (true)
        {
            try
            {
                input = Console.ReadLine();
                inputArray = input.Split(' ');
                HA = Convert.ToInt64(inputArray[0]);
                EA = Convert.ToInt64(inputArray[1]);
                Console.WriteLine(Math.Abs(HA - EA));
            }
            catch (Exception e){break;}
        }
    }
}