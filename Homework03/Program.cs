namespace Homework03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入整數(用,分隔)");
            var numbers = Console.ReadLine().Split(',').Select(x => int.Parse(x));
            var odd = numbers.Where(x => x % 2 != 0).OrderBy(x => x);
            var even = numbers.Where(x => x % 2 == 0).OrderBy(x => x);
            Console.WriteLine("奇數：" + String.Join(",", odd));
            Console.WriteLine("偶數：" + String.Join(",", even));
        }
    }
}
