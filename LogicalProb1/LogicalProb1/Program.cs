using System;

class GFG
{


    static void findSeries(int num,
                int first, int sec)
    {

      
        while (counter < num - 2)
        {
            sum = first + sec;
            Console.Write(sum + " ");
            first = sec;
            counter++;
        }
    }

  
    public static void Main()
    {
        int n = 5, first = 2, sec = 4;

        findSeries(n, first, sec);
    }
}

// By FARUQESAY

