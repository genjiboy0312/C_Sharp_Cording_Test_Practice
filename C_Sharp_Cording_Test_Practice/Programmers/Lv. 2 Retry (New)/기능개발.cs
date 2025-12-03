using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Retry
 * 프로그래머스 팀에서는 기능 개선 작업을 수행 중입니다. 각 기능은 진도가 100%일 때 서비스에 반영할 수 있습니다.
 * 
 * 또, 각 기능의 개발속도는 모두 다르기 때문에 뒤에 있는 기능이 앞에 있는 기능보다 먼저 개발될 수 있고, 이때 뒤에 있는 기능은 앞에 있는 기능이 배포될 때 함께 배포됩니다.
 * 
 * 먼저 배포되어야 하는 순서대로 작업의 진도가 적힌 정수 배열 progresses와 각 작업의 개발 속도가 적힌 정수 배열 speeds가 주어질 때 각 배포마다 몇 개의 기능이 배포되는지를 return 하도록 solution 함수를 완성하세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int[] progresses, int[] speeds)
        {
            // 각 작업이 완료되기까지 며칠 걸리는지 저장할 큐
            Queue<int> daysQueue = new Queue<int>();

            for (int i = 0; i < progresses.Length; i++)
            {
                // 남은 퍼센트 계산
                double remain = 100 - progresses[i];
                // 남은 일수 계산 (올림 처리: 2.3일 -> 3일 필요)
                int day = (int)Math.Ceiling(remain / speeds[i]);

                daysQueue.Enqueue(day);
            }

            List<int> answerList = new List<int>();

            // 큐가 빌 때까지 반복
            while (daysQueue.Count > 0)
            {
                // 가장 앞에 있는 기능이 걸리는 일수 꺼내기 (기준점)
                int currentMaxDay = daysQueue.Dequeue();
                int count = 1;

                // 다음 기능들이 현재 기준 기능보다 빨리 끝나거나 동시에 끝난다면 함께 배포
                while (daysQueue.Count > 0 && daysQueue.Peek() <= currentMaxDay)
                {
                    daysQueue.Dequeue(); // 큐에서 제거
                    count++;             // 배포 개수 증가
                }

                // 이번 묶음의 배포 개수 저장
                answerList.Add(count);
            }

            return answerList.ToArray();
        }
    }
    internal class 기능개발
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] _progresses01 = { 93, 30, 55 };
            int[] _progresses02 = { 95, 90, 99, 99, 80, 99 };

            int[] _speeds01 = { 1, 30, 5 };
            int[] _speeds02 = { 1, 1, 1, 1, 1 };

            Console.WriteLine(_solution.solution(_progresses01, _speeds01));     //  2, 1
            Console.WriteLine(_solution.solution(_progresses02, _speeds02));     //  1, 3, 2
        }
    }
    */
}
