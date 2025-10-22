//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

///* 피보나치 수는 F(0) = 0, F(1) = 1일 때, 1 이상의 n에 대하여 F(n) = F(n-1) + F(n-2) 가 적용되는 수 입니다.
// * 
// * 예를들어
// * 
// * F(2) = F(0) + F(1) = 0 + 1 = 1
// * F(3) = F(1) + F(2) = 1 + 1 = 2
// * F(4) = F(2) + F(3) = 1 + 2 = 3
// * F(5) = F(3) + F(4) = 2 + 3 = 5
// * 와 같이 이어집니다.
// * 
// * 2 이상의 n이 입력되었을 때, n번째 피보나치 수를 1234567으로 나눈 나머지를 리턴하는 함수, solution을 완성해 주세요.
// */
//namespace C_Sharp_Cording_Test_Practice
//{
//    public class Solution
//    {
//        public int solution(int n)
//        {
//            int _temp;
//            int _before = 0;
//            int answer = 1;        // F(1) = 1
//            int MOD = 1234567;

//            if (n <= 1)
//                return n;

//            for (int i = 2; i <= n; i++)
//            {
//                _temp = (answer + _before) % MOD;
//                _before = answer;
//                answer = _temp;
//            }

//            return answer;
//        }
//    }
//    internal class 피보나치_수
//    {
//        static void Main(string[] args)
//        {
//            Solution _solution = new Solution();

//            Console.WriteLine(_solution.solution(3));           //  2
//            Console.WriteLine(_solution.solution(5));           //  5
//        }
//    }
//}
