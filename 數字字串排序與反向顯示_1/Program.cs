namespace 數字字串排序與反向顯示_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 提示輸入
            Console.WriteLine("請輸入一串以逗號分隔的數字：");
            string input = Console.ReadLine();

            // 2. 依照逗號切割字串
            string[] stringArray = input.Split(',');

            // 3. 建立一個同樣長度的整數陣列
            int[] numbers = new int[stringArray.Length];

            // 4. 手動轉換：利用迴圈將字串轉為整數
            for (int i = 0; i < stringArray.Length; i++)
            {
                // 去除多餘空白並轉型
                numbers[i] = int.Parse(stringArray[i].Trim());
            }

            // 5. 由小到大排序 (正向排序)
            Array.Sort(numbers);
            Console.WriteLine("\n由小到大排序：");
            // 使用 string.Join 自動處理逗號隔開的格式(替代以下foreach方法)
            Console.WriteLine(string.Join(", ", numbers));

            //foreach (int n in numbers)
            //{
            //    Console.Write(n + " ");
            //}

            // 6. 由大到小排序 (將排序好的陣列反轉)
            Array.Reverse(numbers);
            Console.WriteLine("\n\n由大到小排序：");
            // 使用 string.Join 自動處理逗號隔開的格式(替代以下foreach方法)
            Console.WriteLine(string.Join(", ", numbers));

            //foreach (int n in numbers)
            //{
            //    Console.Write(n + " ");
            //}
        }
    }
}
