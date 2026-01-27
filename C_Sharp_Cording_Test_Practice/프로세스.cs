using System;
using System.Collections.Generic;
using System.Linq;

/* Retry
 * 운영체제의 역할 중 하나는 컴퓨터 시스템의 자원을 효율적으로 관리하는 것입니다. 
 * 이 문제에서는 운영체제가 다음 규칙에 따라 프로세스를 관리할 경우 특정 프로세스가 몇 번째로 실행되는지 알아내면 됩니다.
 * 
 * 1. 실행 대기 큐(Queue)에서 대기중인 프로세스 하나를 꺼냅니다.
 * 2. 큐에 대기중인 프로세스 중 우선순위가 더 높은 프로세스가 있다면 방금 꺼낸 프로세스를 다시 큐에 넣습니다.
 * 3. 만약 그런 프로세스가 없다면 방금 꺼낸 프로세스를 실행합니다.
 *      3.1 한 번 실행한 프로세스는 다시 큐에 넣지 않고 그대로 종료됩니다.
 * 
 * 예를 들어 프로세스 4개 [A, B, C, D]가 순서대로 실행 대기 큐에 들어있고, 우선순위가 [2, 1, 3, 2]라면 [C, D, A, B] 순으로 실행하게 됩니다.
 * 
 * 현재 실행 대기 큐(Queue)에 있는 프로세스의 중요도가 순서대로 담긴 배열 priorities와, 몇 번째로 실행되는지 알고싶은 프로세스의 위치를 알려주는 location이 매개변수로 주어질 때, 
 * 해당 프로세스가 몇 번째로 실행되는지 return 하도록 solution 함수를 작성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(int[] priorities, int location)
        {
            int answer = 0;

            // (우선순위, 원래 위치) 큐 생성 → 튜플
            Queue<(int _priority, int _index)> _queue = new Queue<(int, int)>();
            //  전체 삽입
            for (int i = 0; i < priorities.Length; i++)
            {
                _queue.Enqueue((priorities[i], i));
            }

            //  비어있는지 확인
            while (_queue.Count > 0)
            {
                //  하나 꺼낸다
                var _cur = _queue.Dequeue();
                //  뒤에 더 큰 priority 있는지 검사. Any : 확인
                bool _hasHigher = _queue.Any(x => x._priority > _cur._priority);

                //  있으면 다시 넣고, 없으면 실행 카운트 + location 검사
                if (_hasHigher)
                    _queue.Enqueue(_cur);       //  뒤로 보냄
                else
                {
                    answer++;
                    if (_cur._index == location)
                        return answer;
                }
            }
            return answer;
        }
    }
    internal class 프로세스
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _prior01 = { 2, 1, 3, 2 };
            int[] _prior02 = { 1, 1, 9, 1, 1, 1 };

            Console.WriteLine(_solution.solution(_prior01, 2));     //  1
            Console.WriteLine(_solution.solution(_prior02, 0));     //  5
        }
    }
    */
}