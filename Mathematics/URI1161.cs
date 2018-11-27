using System;

class URI1161{ //URI1161

    static void Main(String[] args){
        int m, n;
        String input;
        String[] inputArray = new String[2];
        while ((input = Console.ReadLine()) != null)
        {
            inputArray = input.Split(' ');
            try{
                  m = Convert.ToInt32(inputArray[0]);
                  n = Convert.ToInt32(inputArray[1]);
                  Console.WriteLine(getFactorial(m) + getFactorial(n));
                }catch(Exception e){
                  break;
                }
        }
    }

    private static long getFactorial(int number){
        long factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial = factorial * i;
        }
        return factorial;
    }
}