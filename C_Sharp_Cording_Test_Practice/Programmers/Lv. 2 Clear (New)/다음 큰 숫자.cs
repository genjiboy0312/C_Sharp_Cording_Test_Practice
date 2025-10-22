//using System;
//using System.Linq;

///* 자연수 n이 주어졌을 때, n의 다음 큰 숫자는 다음과 같이 정의 합니다.
// * 
// * 조건 1. n의 다음 큰 숫자는 n보다 큰 자연수 입니다.
// * 조건 2. n의 다음 큰 숫자와 n은 2진수로 변환했을 때 1의 갯수가 같습니다.
// * 조건 3. n의 다음 큰 숫자는 조건 1, 2를 만족하는 수 중 가장 작은 수 입니다.
// * 예를 들어서 78(1001110)의 다음 큰 숫자는 83(1010011)입니다.
// * 
// * 자연수 n이 매개변수로 주어질 때, n의 다음 큰 숫자를 return 하는 solution 함수를 완성해주세요.
// */
//namespace C_Sharp_Cording_Test_Practice
//{
//    class Solution
//    {
//        public int solution(int n)
//        {
//            // n의 2진수 표현에서 1의 개수 계산
//            int nCount = Convert.ToString(n, 2).Count(c => c == '1');

//            // n보다 큰 수부터 차례로 탐색
//            int next = n + 1;
//            while (true)
//            {
//                int nextCount = Convert.ToString(next, 2).Count(c => c == '1');
//                if (nextCount == nCount)
//                    return next; // 조건 만족하면 바로 반환
//                next++;
//            }
//        }
//        internal class 다음_큰_숫자
//        {
//            static void Main(string[] args)
//            {
//                Solution _solution = new Solution();

//                Console.WriteLine(_solution.solution(78));        //  83
//                Console.WriteLine(_solution.solution(15));        //  23
//            }
//        }
//    }
//}
