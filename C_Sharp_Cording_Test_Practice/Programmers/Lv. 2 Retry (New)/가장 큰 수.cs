using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Retry    
 * 0 또는 양의 정수가 주어졌을 때, 정수를 이어 붙여 만들 수 있는 가장 큰 수를 알아내 주세요.
 * 
 * 예를 들어, 주어진 정수가 [6, 10, 2]라면 [6102, 6210, 1062, 1026, 2610, 2106]를 만들 수 있고, 이중 가장 큰 수는 6210입니다.
 * 
 * 0 또는 양의 정수가 담긴 배열 numbers가 매개변수로 주어질 때, 순서를 재배치하여 만들 수 있는 가장 큰 수를 문자열로 바꾸어 return 하도록 solution 함수를 작성해주세요.
 * 
 * 제한 사항
 * numbers의 길이는 1 이상 100,000 이하입니다.
 * numbers의 원소는 0 이상 1,000 이하입니다.
 * 정답이 너무 클 수 있으니 문자열로 바꾸어 return 합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public string solution(int[] numbers)
        {
            //  int → string 배열 변환
            string[] _arr = numbers.Select(x => x.ToString()).ToArray();

            //  정렬. (b + a) : 내림차순 정렬
            Array.Sort(_arr, (a, b) => (b + a).CompareTo(a + b));

            //  이어 붙이기
            StringBuilder _sb = new StringBuilder();
            foreach (var s in _arr)
            {
                _sb.Append(s);
            }

            //  0이면
            if (_sb[0] == '0')
                return "0";

            return _sb.ToString();
        }
    }
    internal class 가장_큰_수
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _numbers01 = { 6, 10, 2 };
            int[] _numbers02 = { 3, 30, 34, 5, 9 };

            Console.WriteLine(_solution.solution(_numbers01));   //  6210
            Console.WriteLine(_solution.solution(_numbers02));   //  9534330
        }
    }
    */
}