using System;

class Program
{
    static void Main(string[] args)
    {
        investor();

    }
    static void investor()
    {
       int inputN;
        int[] N = new int[inputN = int.Parse(Console.ReadLine())];
        int K = int.Parse(Console.ReadLine());

        for(int i=0; i < inputN; i++)
        {
            N[i] = int.Parse(Console.ReadLine());
        }

        int count,max = 0;

        for(int i = K; i < inputN-K; i++)
        {
            int Side = 0;
            for(int j = 1; j < K+1; j++)
            {
            Side = Side + N[i-j] + N[i+j];
            }
            count = Side + N[i];
            if(count>max)
            {
                max = count;
            }
        }       
        Console.WriteLine(max);
    }     
}






