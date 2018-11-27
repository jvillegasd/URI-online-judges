using System;

class URI1028{ //URI 1028

    static void Main(String[] args){
        int n = 3001, F1 = 1001, F2 = 1001, cont = 0;
        String inw = "";
        String[] numbers = new String[2];
        n = Convert.ToInt32(Console.ReadLine());
        while(cont < n)
        {
            inw = Console.ReadLine();
            numbers = inw.Split(' ');
            F1 = Convert.ToInt32(numbers[0]);
            F2 = Convert.ToInt32(numbers[1]);
            Console.WriteLine(getMaxLength(F1, F2));
            cont++;
        } 
    }

    private static int getMaxLength(int F1, int F2){
        if (F2 == 0)
        {
            return F1;
        }
        return getMaxLength(F2, F1 % F2);
    }
}