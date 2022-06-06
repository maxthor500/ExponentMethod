namespace ExponentMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetPower(3, 0));
            Console.WriteLine(GetPower(7, 1));
            Console.WriteLine(GetPower(6, 5));
            Console.ReadLine();
        }

        static int GetPower(int baseNum, int powNum)
        {
            int result = 1;

            for(int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }

            return result;
        }
    }
}