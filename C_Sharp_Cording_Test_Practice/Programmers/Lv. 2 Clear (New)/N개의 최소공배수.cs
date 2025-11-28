using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 두 수의 최소공배수(Least Common Multiple)란 입력된 두 수의 배수 중 공통이 되는 가장 작은 숫자를 의미합니다. 예를 들어 2와 7의 최소공배수는 14가 됩니다. 
 * 정의를 확장해서, n개의 수의 최소공배수는 n 개의 수들의 배수 중 공통이 되는 가장 작은 숫자가 됩니다. 
 * n개의 숫자를 담은 배열 arr이 입력되었을 때 이 수들의 최소공배수를 반환하는 함수, solution을 완성해 주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    internal class N개의_최소공배수
    {
        public class Solution
        {
            public int solution(int[] arr)
            {
                int answer = arr[0];

                for (int i = 1; i < arr.Length; i++)
                {
                    answer = LCM(answer, arr[i]);
                }

                return answer;
            }

            //  최대 공약수
            int GCD(int x, int y)
            {
                while (y != 0)
                {
                    int _temp = y;
                    y = x % y;
                    x = _temp;
                }
                return x;
            }

            //  최소 공배수
            int LCM(int x, int y)
            {
                return x * y / GCD(x, y);
            }
        }
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _arr01 = { 2, 6, 8, 14 };
            int[] _arr02 = { 1, 2, 3 };

            Console.WriteLine(_solution.solution(_arr01));      //  168
            Console.WriteLine(_solution.solution(_arr02));      //  6
        }
    }
    */
}
