using System;
using System.Collections.Generic;

/* Retry
 * 철호는 수열을 가지고 놀기 좋아합니다. 어느 날 철호는 어떤 자연수로 이루어진 
 * 원형 수열의 연속하는 부분 수열의 합으로 만들 수 있는 수가 모두 몇 가지인지 알아보고 싶어졌습니다. 
 * 원형 수열이란 일반적인 수열에서 처음과 끝이 연결된 형태의 수열을 말합니다. 
 * 
 * 예를 들어 수열 [7, 9, 1, 1, 4] 로 원형 수열을 만들면 다음과 같습니다.
 * 
 * 원형 수열은 처음과 끝이 연결되어 끊기는 부분이 없기 때문에 연속하는 부분 수열도 일반적인 수열보다 많아집니다.
 * 원형 수열의 모든 원소 elements가 순서대로 주어질 때, 원형 수열의 연속 부분 수열 합으로 만들 수 있는 수의 개수를 
 * return 하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[] elements)
        {
            int n = elements.Length;
            HashSet<int> sums = new HashSet<int>();         //  HashSet -> 중복 제거

            // 길이 1부터 n까지
            for (int length = 1; length <= n; length++)
            {
                // 시작 위치
                for (int start = 0; start < n; start++)
                {
                    int sum = 0;
                    for (int i = 0; i < length; i++)
                    {
                        sum += elements[(start + i) % n]; // 원형 처리
                    }
                    sums.Add(sum);
                }
            }

            return sums.Count;
        }
    }
    internal class 연속_부분_수열_합의_개수
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] elements = { 7, 9, 1, 1, 4 };
            Console.WriteLine(_solution.solution(elements));        //  18
        }
    }
    */
}
