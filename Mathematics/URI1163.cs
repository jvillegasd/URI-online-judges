using System;

class URI1163{
    
    static void Main(String[] args){
        double h, angle, V, p1, p2, pi = 3.14159, gravity = 9.80665;
        int n;
        String input;
        String[] inputArray = new String[2];
        while (Double.TryParse(Console.ReadLine(), out h))
        {
            input = Console.ReadLine();
            inputArray = input.Split(' ');
            p1 = Convert.ToDouble(inputArray[0]);
            p2 = Convert.ToDouble(inputArray[1]);
            n = Convert.ToInt32(Console.ReadLine());
            while (n-- > 0)
            {
                input = Console.ReadLine();
                inputArray = input.Split(' ');
                angle = Convert.ToDouble(inputArray[0]);
                V = Convert.ToDouble(inputArray[1]);
                angle = (angle*pi)/180;
                double time = (V*Math.Sin(angle)+Math.Sqrt(Math.Pow(V*Math.Sin(angle), 2)+2*gravity*h))/gravity; 
                double xDistance = Math.Round(V*Math.Cos(angle)*time, 5);
                String X = xDistance.ToString("0.00000");
                if (xDistance >= p1 && xDistance <= p2)
                {
                    Console.WriteLine(X + " -> DUCK");
                }else{
                    Console.WriteLine(X + " -> NUCK");
                }
            }
        }
    }
}