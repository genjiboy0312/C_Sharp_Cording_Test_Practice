using System;
using System.Collections.Generic;

/* n개의 음이 아닌 정수들이 있습니다. 이 정수들을 순서를 바꾸지 않고 적절히 더하거나 빼서 타겟 넘버를 만들려고 합니다. 
 * 예를 들어 [1, 1, 1, 1, 1]로 숫자 3을 만들려면 다음 다섯 방법을 쓸 수 있습니다.
 * 
 * -1+1+1+1+1 = 3
 * +1-1+1+1+1 = 3
 * +1+1-1+1+1 = 3
 * +1+1+1-1+1 = 3
 * +1+1+1+1-1 = 3
 * 
 * 사용할 수 있는 숫자가 담긴 배열 numbers, 
 * 타겟 넘버 target이 매개변수로 주어질 때 숫자를 적절히 더하고 빼서 타겟 넘버를 만드는 방법의 수를 
 * return 하도록 solution 함수를 작성해주세요.
*/
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[] numbers, int target)
        {
            int answer = 0;

            int _length = numbers.Length;       //  크기
            Queue<int> _queue = new Queue<int>();       //  큐를 만든다

            //  큐에 0을 넣는다
            _queue.Enqueue(0);

            //  numbers 배열의 각 숫자에 대해 반복한다
            for (int i = 0; i < _length; i++)
            {
                //  현재 큐의 크기를 저장한다
                int _size = _queue.Count;

                //  +, - 일때의 값을 더한다
                for (int j = 0; j < _size; j++)
                {
                    int current = _queue.Dequeue();

                    _queue.Enqueue(current + numbers[i]);
                    _queue.Enqueue(current - numbers[i]);
                }
            }
            //  갯수
            while (_queue.Count > 0)
            {
                if (_queue.Dequeue() == target)
                    answer++;
            }

            return answer;
        }
    }
    internal class 타겟_넘버
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _numbers01 = { 1, 1, 1, 1, 1 };
            int[] _numbers02 = { 4, 1, 2, 1 };

            Console.WriteLine(_solution.solution(_numbers01, 3));       //  5
            Console.WriteLine(_solution.solution(_numbers02, 4));       //  2
        }
    }
    */
}
