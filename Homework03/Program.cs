namespace Homework03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入整數(用,分隔)");

            // ── 原始寫法：Where 分別篩選 ────────────────────────────────
            var numbers = Console.ReadLine().Split(",").Select(int.Parse).ToList();

            var odd  = numbers.Where(x => x % 2 != 0).OrderBy(x => x);
            var even = numbers.Where(x => x % 2 == 0).OrderBy(x => x);

            Console.WriteLine($"奇數：{string.Join(",",  odd)}");
            Console.WriteLine($"偶數： {String.Join(",", even)}");

            Console.WriteLine("──────────────────────");
            

            Console.WriteLine("請輸入整數(用,分隔)");
            // ── GroupBy 寫法：一次分兩組 ────────────────────────────────
            // 同時完成分類
            var numbers3 = Console.ReadLine().Split(",").Select(int.Parse).ToList();
            var groups = numbers3.GroupBy(x => x % 2 == 0);
            foreach (var group in groups)
            {
                string label = group.Key ? "偶數" : "奇數";
                Console.WriteLine($"{label}：{string.Join(",", group.OrderBy(x => x))}");
            }

            Console.WriteLine("──────────────────────");

            Console.WriteLine("請輸入整數(用,分隔)");
            // ── ToLookup 寫法：建立分類字典 ──────────────────────────────
            // ToLookup(x => x % 2) → 依餘數分類，key 為 0（偶數）或 1（奇數）
            var numbers4 = Console.ReadLine().Split(",").Select(int.Parse).ToList();
            var lookup = numbers4.ToLookup(x => x % 2);
            Console.WriteLine($"奇數：{string.Join(",", lookup[1].OrderBy(x => x))}");
            Console.WriteLine($"偶數：{string.Join(",", lookup[0].OrderBy(x => x))}");

            Console.WriteLine("──────────────────────");

            Console.WriteLine("請輸入整數(用,分隔)");
            // ── 先排序再篩選：排序只做一次 ──────────────────────────────
            // 先對全部數字排序
            var numbers5 = Console.ReadLine().Split(",").Select(int.Parse).OrderBy(x => x).ToList();
            Console.WriteLine($"奇數：{string.Join(",", numbers5.Where(x => x % 2 != 0))}");
            Console.WriteLine($"偶數：{string.Join(",", numbers5.Where(x => x % 2 == 0))}");
            Console.ReadLine();
        }
    }
}
