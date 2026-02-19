using System;

/* 초 단위로 기록된 주식가격이 담긴 배열 prices가 매개변수로 주어질 때, 
 * 가격이 떨어지지 않은 기간은 몇 초인지를 return 하도록 solution 함수를 완성하세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] prices)
        {
            int[] answer = new int[prices.Length];
            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    answer[i]++;

                    if (prices[j] < prices[i])
                        break;
                }
            }
            return answer;
        }
    }
    internal class 주식가격
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _prices = { 1, 2, 3, 2, 3 };

            //  4, 3, 1, 1, 0
            foreach (var i in _solution.solution(_prices))
            {
                Console.Write(i + " ");
            }
        }
    }
    */
}