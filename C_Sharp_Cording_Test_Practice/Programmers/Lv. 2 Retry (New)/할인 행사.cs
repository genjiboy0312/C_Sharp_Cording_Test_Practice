using System;
using System.Collections.Generic;

/* Retry
 * XYZ 마트는 일정한 금액을 지불하면 10일 동안 회원 자격을 부여합니다. XYZ 마트에서는 회원을 대상으로 매일 한 가지 제품을 할인하는 행사를 합니다. 
 * 할인하는 제품은 하루에 하나씩만 구매할 수 있습니다. 
 * 알뜰한 정현이는 자신이 원하는 제품과 수량이 할인하는 날짜와 10일 연속으로 일치할 경우에 맞춰서 회원가입을 하려 합니다.
 * 
 * 예를 들어, 정현이가 원하는 제품이 바나나 3개, 사과 2개, 쌀 2개, 돼지고기 2개, 냄비 1개이며, 
 * XYZ 마트에서 14일간 회원을 대상으로 할인하는 제품이 날짜 순서대로 
 * 치킨, 사과, 사과, 바나나, 쌀, 사과, 돼지고기, 바나나, 돼지고기, 쌀, 냄비, 바나나, 사과, 바나나인 경우에 대해 알아봅시다. 
 * 첫째 날부터 열흘 간에는 냄비가 할인하지 않기 때문에 첫째 날에는 회원가입을 하지 않습니다. 
 * 둘째 날부터 열흘 간에는 바나나를 원하는 만큼 할인구매할 수 없기 때문에 둘째 날에도 회원가입을 하지 않습니다. 
 * 셋째 날, 넷째 날, 다섯째 날부터 각각 열흘은 원하는 제품과 수량이 일치하기 때문에 셋 중 하루에 회원가입을 하려 합니다.
 * 
 * 정현이가 원하는 제품을 나타내는 문자열 배열 want와 정현이가 원하는 제품의 수량을 나타내는 정수 배열 number, 
 * XYZ 마트에서 할인하는 제품을 나타내는 문자열 배열 discount가 주어졌을 때, 회원등록시 정현이가 원하는 제품을 모두 할인 받을 수 있는 회원등록 날짜의 총 일수를 return 하는 solution 함수를 완성하시오. 
 * 가능한 날이 없으면 0을 return 합니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(string[] want, int[] number, string[] discount)
        {
            int answer = 0;
            int n = discount.Length;

            // 슬라이딩 윈도우 시작점
            for (int i = 0; i <= n - 10; i++)
            {
                Dictionary<string, int> window = new Dictionary<string, int>();

                // 10일 구간의 할인 상품 개수 계산
                for (int j = i; j < i + 10; j++)
                {
                    if (window.ContainsKey(discount[j]))
                        window[discount[j]]++;
                    else
                        window[discount[j]] = 1;
                }

                bool match = true;
                // 원하는 상품과 수량 확인
                for (int k = 0; k < want.Length; k++)
                {
                    string w = want[k];
                    int cnt = number[k];
                    if (!window.ContainsKey(w) || window[w] < cnt)
                    {
                        match = false;
                        break;
                    }
                }

                if (match) answer++;
            }

            return answer;
        }
    }

    internal class 할인_행사
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string[] _want01 = { "banana", "apple", "rice", "pork", "pot" };
            string[] _want02 = { "apple" };

            int[] _number01 = { 3, 2, 2, 2, 1 };
            int[] _number02 = { 10 };

            string[] _discount01 = { "chicken", "apple", "apple", "banana", "rice", "apple", "pork", "banana", "pork", "rice", "pot", "banana", "apple", "banana" };
            string[] _discount02 = { "banana", "banana", "banana", "banana", "banana", "banana", "banana", "banana", "banana", "banana" };

            Console.WriteLine(_solution.solution(_want01, _number01, _discount01));     //  3
            Console.WriteLine(_solution.solution(_want02, _number02, _discount02));     //  0
        }
    }
    */
}