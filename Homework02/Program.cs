namespace Homework02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一個整數:");

            // 將輸入的字串轉換為整數
            int n = int.Parse(Console.ReadLine());

            // ── 原始寫法：for 迴圈 + Enumerable.Repeat ──────────────────
            // i 從 0 跑到 n-1，每圈產生一行結果
            // n - i     → 該行要重複的數字（5, 4, 3, 2, 1）
            // i + 1     → 重複的次數（1, 2, 3, 4, 5）
            // Repeat    → LINQ 方法，產生重複元素的序列
            // Join("")  → 把序列合併成字串（不加分隔符號）
            for (int i = 0; i < n; i++)
            {
                string result = String.Join("", Enumerable.Repeat(n - i, i + 1));
                Console.WriteLine(result);
            }

            Console.WriteLine("──────────────────────");

            // ── Range 寫法：  ───
            // Enumerable.Range(0, n) → 產生 0, 1, 2, ..., n-1 的序列，取代 for 迴圈
            // .Select(i => ...)      → 對序列中每個 i 套用轉換，產生每一行的字串
            // 邏輯與原始寫法完全相同，只是改用宣告式（LINQ）的思維描述
            var lines = Enumerable.Range(0, n)
                .Select(i => string.Join("", Enumerable.Repeat(n - i, i + 1)));

            // 逐行輸出結果
            foreach (var line in lines)
                Console.WriteLine(line);
        }
    }
}
