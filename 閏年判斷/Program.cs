namespace 閏年判斷
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("請輸入中華民國年份數字: ");

            //string input = Console.ReadLine();

            //// 1. 將輸入字串轉換為整數
            //if (int.TryParse(input, out int rocYear))
            //{
            //    // 2. 轉換為西元年 (民國年 + 1911)
            //    int adYear = rocYear + 1911;

            //    // 3. 閏年判斷邏輯
            //    // 公式: (能被4整除 且 不能被100整除) 或 (能被400整除)
            //    bool isLeapYear = (adYear % 4 == 0 && adYear % 100 != 0) || (adYear % 400 == 0);

            //    // 4. 輸出結果
            //    if (isLeapYear)
            //    {
            //        Console.WriteLine($"民國 {rocYear} 年 (西元 {adYear} 年) 是【閏年】。");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"民國 {rocYear} 年 (西元 {adYear} 年) 是【平年】。");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("錯誤：請輸入有效的數字年份。");
            //}


            

            // 1. 提示使用者輸入
            Console.Write("請輸入中華民國年份數字: ");

            // 2. 讀取輸入並嘗試轉換為整數
            // 使用 var 是 C# 的隱含型別宣告，out var year 則是簡化的區域變數宣告
            if (int.TryParse(Console.ReadLine(), out var rocYear))
            {
                // 3. 將民國年份轉換為西元年 (西元 = 民國 + 1911)
                int adYear = rocYear + 1911;

                // 4. 使用 DateTime 結構的靜態方法 DaysInMonth
                // 該方法會根據年份與月份，自動回傳該月的天數 (已內建閏年邏輯)
                int daysOfFebruary = DateTime.DaysInMonth(adYear, 2);

                // 5. 判斷 2 月是否為 29 天
                bool isLeap = (daysOfFebruary == 29);

                // 6. 使用 C# 8.0+ 的 Switch 表達式 (Switch Expression) 進行結果格式化
                string message = isLeap switch
                {
                    true => $"【閏年】(西元 {adYear} 年的 2 月有 29 天)",
                    false => $"【平年】(西元 {adYear} 年的 2 月僅 28 天)"
                };

                // 7. 輸出最終結果
                Console.WriteLine($"\n>> 查詢結果：民國 {rocYear} 年是 {message}");
            }
            else
            {
                // 若使用者輸入非數字字元，顯示錯誤提示
                Console.WriteLine("❌ 錯誤：請輸入正確的數字格式。");
            }

            // 程式結束提示
            Console.WriteLine("\n按任意鍵結束程式...");
            Console.ReadKey();
        }
    }
}
