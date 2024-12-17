namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 74;
            int teklik = num % 10;
            int onluq = (num - teklik) / 10;
            int result = teklik * 10 + onluq;
            { Console.WriteLine(result); }
        }
    }
}
