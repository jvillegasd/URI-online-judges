using System;

class URI1213{ //URI 1213,  Consider Modular Arithmetics

    static void Main(String[] args){
        int number, cont, n;
        while(int.TryParse(Console.ReadLine(), out n))
        {
            number = cont = 1;
            while (number % n != 0)
            {
                number = (number * 10 + 1) % n;
                cont++;
            }
            Console.WriteLine(cont);
        }
    }
}