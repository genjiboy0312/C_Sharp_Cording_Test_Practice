//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

///* 0과 1로 이루어진 어떤 문자열 x에 대한 이진 변환을 다음과 같이 정의합니다.
// * 
// * x의 모든 0을 제거합니다.
// * x의 길이를 c라고 하면, x를 "c를 2진법으로 표현한 문자열"로 바꿉니다.
// * 예를 들어, x = "0111010"이라면, x에 이진 변환을 가하면 x = "0111010" -> "1111" -> "100" 이 됩니다.
// * 
// * 0과 1로 이루어진 문자열 s가 매개변수로 주어집니다. s가 "1"이 될 때까지 계속해서 s에 이진 변환을 가했을 때, 
// * 이진 변환의 횟수와 변환 과정에서 제거된 모든 0의 개수를 각각 배열에 담아 return 하도록 solution 함수를 완성해주세요.
// */
//namespace C_Sharp_Cording_Test_Practice
//{
//    internal class 이진_변환_반복하기
//    {
//        public class Solution
//        {
//            public int[] solution(string s)
//            {
//                int _change = 0;       // 변환 횟수
//                int _removeZero = 0;   // 제거된 0의 총 개수

//                while (s != "1")
//                {
//                    // 1. 0 제거
//                    int beforeLen = s.Length;
//                    s = s.Replace("0", "");
//                    int afterLen = s.Length;

//                    // 제거된 0 개수 누적
//                    _removeZero += (beforeLen - afterLen);

//                    // 2. 남은 길이를 2진수로 변환
//                    s = Convert.ToString(afterLen, 2);

//                    // 변환 횟수 증가
//                    _change++;
//                }

//                return new int[] { _change, _removeZero };
//            }
//        }
//        static void Main(string[] args)
//        {
//            Solution _solution = new Solution();

//            string _s01 = "110010101001";
//            string _s02 = "01110";
//            string _s03 = "1111111";

//            Console.WriteLine(_solution.solution(_s01));        //  3, 8
//            Console.WriteLine(_solution.solution(_s02));        //  3, 3
//            Console.WriteLine(_solution.solution(_s03));        //  4, 1
//        }
//    }
//}