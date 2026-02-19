using System;
using System.Collections.Generic;
/* 정수로 이루어진 배열 numbers가 있습니다. 
 * 배열 의 각 원소들에 대해 자신보다 뒤에 있는 숫자 중에서 자신보다 크면서 가장 가까이 있는 수를 뒷 큰수라고 합니다.
 * 
 * 정수 배열 numbers가 매개변수로 주어질 때, 모든 원소에 대한 뒷 큰수들을 차례로 담은 배열을 return 하도록 solution 함수를 완성해주세요. 
 * 단, 뒷 큰수가 존재하지 않는 원소는 -1을 담습니다.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] numbers)
        {
            int n = numbers.Length;
            int[] answer = new int[n];

            for (int i = 0; i < n; i++)
                answer[i] = -1;

            Stack<int> stack = new Stack<int>(); // 인덱스 저장

            for (int i = 0; i < n; i++)
            {
                while (stack.Count > 0 && numbers[stack.Peek()] < numbers[i])
                {
                    int index = stack.Pop();
                    answer[index] = numbers[i];
                }

                stack.Push(i);
            }

            return answer;
        }
    }
    internal class 뒤에_있는_큰_수_찾기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _number01 = { 2, 3, 3, 5 };
            int[] _number02 = { 9, 1, 5, 3, 6, 2 };

            //  3, 5, 5, -1
            foreach (int n in _solution.solution(_number01))
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            //  -1, 5, 6, 6, -1, -1
            foreach (int n in _solution.solution(_number02))
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
    }
    */
}
