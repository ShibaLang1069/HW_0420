namespace 迴圈倒置_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 取得使用者輸入
            Console.Write("請輸入一個整數數字: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                // 2. 外部迴圈：控制總共有幾行 (從 1 跑到 n)
                for (int i = 1; i <= n; i++)
                {
                    // 3. 計算當前這行要顯示的數字
                    // 例如 n=5, i=1 時，數字是 5; i=2 時，數字是 4
                    int currentNumber = n - i + 1;

                    // 4. 內部迴圈：控制數字要重複幾次 (重複 i 次)
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(currentNumber);
                    }

                    // 5. 換行
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("請輸入有效的整數！");
            }
        }
    }
}
