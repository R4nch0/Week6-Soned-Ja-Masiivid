using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu "h", "o" ja "l" tähte on lauses "Hello World!"           
            string lause = "Hello World!".ToLower();   
            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for (int i = 0; i < lause.Length; i++)
            {
                if (lause[i] == 'h')
                {
                    hCounter++;
                }
                if (lause[i] == 'o')
                {
                    oCounter++;
                }
                if (lause[i] == 'l')
                {
                    lCounter++;
                }
            }

             Console.WriteLine($"Sinu lauses on {hCounter} 'h' tähte");
             Console.WriteLine($"Sinu lauses on {lCounter} 'l' tähte");
             Console.WriteLine($"Sinu lauses on {oCounter} 'o' täht");
           
        }
    }
}
