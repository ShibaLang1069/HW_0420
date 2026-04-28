namespace 奇偶數判斷_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 提示並讀取使用者輸入
            Console.WriteLine("請輸入一串數字，並以逗號分隔：");
            string input = Console.ReadLine();

            // 2. 拆分字串為陣列
            string[] items = input.Split(',');

            // 3. 準備兩個「動態清單 (List)」來存放分類後的數字
            List<int> odds = new List<int>();  // 存放奇數
            List<int> evens = new List<int>(); // 存放偶數

            // 4. 逐一巡覽並分類
            foreach (string item in items)
            {
                // 將文字轉換為整數 (Trim 是為了去掉空格)
                if (int.TryParse(item.Trim(), out int number))
                {
                    // 判斷奇偶數 (除以 2 的餘數是否為 0)
                    if (number % 2 == 0)
                    {
                        evens.Add(number);
                    }
                    else
                    {
                        odds.Add(number);
                    }
                }
            }

            // 5. 排序 (由小到大)
            odds.Sort();
            evens.Sort();

            // 6. 顯示結果
            Console.WriteLine("\n--- 分類結果 ---");
            Console.WriteLine("奇數數列：" + string.Join(", ", odds));
            Console.WriteLine("偶數數列：" + string.Join(", ", evens));
        }
    }
}
