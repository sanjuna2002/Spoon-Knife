namespace Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PrimeNumberCount = 0;   
            int PrimeNumberSum = 0;
            int number = 2;

            while(PrimeNumberCount < 10) { 
                int Moduluscount= 0;
                for(int i = 1; i < number; i++)
                {
                    if(number %i  == 0)
                    {
                        Moduluscount++;
                    }
                }

            if(Moduluscount == 2) {
                    PrimeNumberSum=PrimeNumberSum+number;
                    PrimeNumberCount++;
                }
            
            
            }
            Console.WriteLine($"prime number sum {PrimeNumberSum}");

 


        }
    }
}
