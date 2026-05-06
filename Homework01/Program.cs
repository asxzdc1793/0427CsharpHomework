namespace Homework01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 提示使用者輸入以逗號分隔的數值
            Console.WriteLine("輸入整數數值(用,分隔):");

            // 讀取使用者輸入，並以逗號為分隔符號切割成字串陣列
            // 例如："12,18,13,23,32" → ["12", "18", "13", "23", "32"]
            var input = Console.ReadLine().Split(",");

            // 使用 LINQ 的 Reverse() 反轉陣列順序，再用 Join 合併回逗號分隔的字串，直接輸出
            // 例如：["12", "18", "13", "23", "32"] → "32,23,13,18,12"
            Console.WriteLine(string.Join(',', input.Reverse()));
            Console.ReadLine();
            
        }
    }
}
