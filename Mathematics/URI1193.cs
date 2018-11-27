using System;

class URI1193{

    static void Main(String[] args){
        int n, cont = 0;
        String input, type, number;
        String[] inputArray = new String[2];
        String[,] output = new String[2, 2];
        n = Convert.ToInt32(Console.ReadLine());
        while (cont < n)
        {
            input = Console.ReadLine();
            inputArray = input.Split(' ');
            number = inputArray[0];
            type = inputArray[1];
            output = getConvertion(number, type);
            Console.WriteLine("Case {0}:", cont + 1);
            for (int i = 0; i < 2; i++)
            {
                if(i == 1)
                {
                  Console.WriteLine(output[i, 0] + " " + output[i, 1] + "\n");
                }else{
                  Console.WriteLine(output[i, 0] + " " + output[i, 1]);
                }
            }
            cont++;
        }
    }

    private static String[,] getConvertion(String numberO, String type){
        String[,] convertion = new String[2, 2];
        if (type.Equals("dec"))
        {
            String binary = Convert.ToString(Convert.ToInt32(numberO, 10), 2);
            String hex = Convert.ToString(Convert.ToInt32(numberO, 10), 16);
            convertion[0, 0] = hex;
            convertion[0, 1] = "hex";
            convertion[1, 0] = binary;
            convertion[1, 1] = "bin";
        }
        if (type.Equals("bin"))
        {
            String dec = Convert.ToString(Convert.ToInt32(numberO, 2), 10);
            String hex = Convert.ToString(Convert.ToInt32(numberO, 2), 16);
            convertion[0, 0] = dec;
            convertion[0, 1] = "dec";
            convertion[1, 0] = hex;
            convertion[1, 1] = "hex";
        }
        if (type.Equals("hex"))
        {
            String dec = Convert.ToString(Convert.ToInt32(numberO, 16), 10);
            String binary = Convert.ToString(Convert.ToInt32(numberO, 16), 2);
            convertion[0, 0] = dec;
            convertion[0, 1] = "dec";
            convertion[1, 0] = binary;
            convertion[1, 1] = "bin";
        }
        return convertion;
    }
}