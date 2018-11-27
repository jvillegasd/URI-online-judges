using System;

class URI1199{

    static void Main(String[] args){
        String input;
        String output;
        while (true)
        {
            try{
              input = Console.ReadLine();
              if(input.IndexOf('x') != -1)
              {
                Console.WriteLine(Convert.ToString(Convert.ToInt64(input, 16), 10));
              }else if(input.IndexOf('x') == -1 && !input.Equals("-1")){
                output = Convert.ToString(Convert.ToInt64(input, 10) ,16);
                Console.WriteLine("0x" + output.ToUpper());
              }else{
                break;
              }
            }catch(Exception e){break;}
        }
    }
}   