using System;

class URI1093{ //URI 1093, Consider Gambler's Ruin

    static void Main(String[] args){
        int EV1, EV2, AT, D;
        String stats;
        String[] statsArray = new String[4];
        while (true)
        {
            stats = Console.ReadLine();
            statsArray = stats.Split(' ');
            EV1 = Convert.ToInt32(statsArray[0]);
            EV2 = Convert.ToInt32(statsArray[1]);
            AT = Convert.ToInt32(statsArray[2]);
            D = Convert.ToInt32(statsArray[3]);
            if (EV1 == 0 && EV2 == 0 && AT == 0 && D ==0) 
            {
              break;
            }
            Console.WriteLine(getGamble(EV1, EV2, AT, D));
        }
    }

    private static String getGamble(int EV1, int EV2, int AT, int D){
        double probability = 0;
        int temp = EV1, cont = 0;
        while(temp > 0)  //Get how much the player can hold until the player lost
        {
          temp = temp - D;
          cont++;
        }
        EV1 = cont;
        cont = 0;
        temp = EV2;
        while(temp > 0)
        {
          temp = temp - D;
          cont++;
        }
        EV2 = cont;
        if(AT == 3) //Fair coin flipping
        {
            probability = (double) EV1/(EV1 + EV2);
        }else{ //Unfair coin flipping
            double p = (double)AT / 6;
            double q = 1 - p;
            double baseP = q / p;
            probability = (1 - Math.Pow(baseP, EV1)) / (1 - Math.Pow(baseP, EV1 + EV2));
        }
        probability = Math.Round(probability, 3) * 100;
        return probability.ToString("0.0");
    }
}