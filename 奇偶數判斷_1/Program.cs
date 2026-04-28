namespace 奇偶數判斷_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 1. 提示使用者輸入數字
            //Console.Write("請輸入一個整數：");

            //// 2. 接收輸入並嘗試轉換為整數
            //// 使用 string 處理可能的 null 值，並用 int.Parse 轉換
            //string input = Console.ReadLine();

            //if (int.TryParse(input, out int number))
            //{
            //    // 3. 判斷奇偶數邏輯
            //    // 使用 % 運算子計算除以 2 的餘數
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine($"{number} 是 偶數 (Even)。");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{number} 是 奇數 (Odd)。");
            //    }
            //}
            //else
            //{
            //    // 防呆處理：如果使用者輸入的不是數字
            //    Console.WriteLine("輸入錯誤！請務必輸入有效的整數數字。");
            //}

            Console.Write("請輸入數字： ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                // 一行搞定判斷與輸出
                Console.WriteLine($"{n} 是 {(n % 2 == 0 ? "偶數" : "奇數")}");
            }
        }
    }
}
