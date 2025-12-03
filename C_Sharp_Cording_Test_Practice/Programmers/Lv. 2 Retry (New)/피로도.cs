using System;

/* Retry : DFS
 * XX게임에는 피로도 시스템(0 이상의 정수로 표현합니다)이 있으며, 일정 피로도를 사용해서 던전을 탐험할 수 있습니다. 
 * 이때, 각 던전마다 탐험을 시작하기 위해 필요한 "최소 필요 피로도"와 던전 탐험을 마쳤을 때 소모되는 "소모 피로도"가 있습니다. 
 * 
 * "최소 필요 피로도"는 해당 던전을 탐험하기 위해 가지고 있어야 하는 최소한의 피로도를 나타내며, "소모 피로도"는 던전을 탐험한 후 소모되는 피로도를 나타냅니다. 
 * 예를 들어 "최소 필요 피로도"가 80, "소모 피로도"가 20인 던전을 탐험하기 위해서는 유저의 현재 남은 피로도는 80 이상 이어야 하며, 던전을 탐험한 후에는 피로도 20이 소모됩니다.
 * 
 * 이 게임에는 하루에 한 번씩 탐험할 수 있는 던전이 여러개 있는데, 한 유저가 오늘 이 던전들을 최대한 많이 탐험하려 합니다. 
 * 유저의 현재 피로도 k와 각 던전별 "최소 필요 피로도", "소모 피로도"가 담긴 2차원 배열 dungeons 가 매개변수로 주어질 때, 유저가 탐험할수 있는 최대 던전 수를 return 하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        // 방문 여부를 체크할 배열
        public bool[] _visited;
        // 최대 던전 수를 저장할 변수
        public int _maxCount = 0;

        public int solution(int k, int[,] dungeons)
        {
            // 던전의 개수
            int _countDungeon = dungeons.GetLength(0);

            // 방문 배열 초기화
            _visited = new bool[_countDungeon];
            _maxCount = 0;

            // DFS 탐색 시작 (현재 피로도, 던전 정보, 현재 탐험한 던전 수)
            DFS(k, dungeons, 0);

            return _maxCount;
        }

        private void DFS(int currentK, int[,] dungeons, int count)
        {
            // 현재까지 탐험한 던전 수가 기존 최대값보다 크다면 갱신
            if (count > _maxCount)
                _maxCount = count;

            // 모든 던전을 순회하며 탐험 시도
            for (int i = 0; i < dungeons.GetLength(0); i++)
            {
                // 아직 방문하지 않았고, 현재 피로도가 최소 필요 피로도보다 크거나 같다면
                // dungeons[i, 0] : 최소 필요 피로도. dungeons[i, 1] : 소모 피로도
                if (!_visited[i] && currentK >= dungeons[i, 0])
                {
                    // 방문 처리
                    _visited[i] = true;

                    // 재귀 호출: 피로도를 소모하고, count를 1 증가시켜 다음 단계로 이동
                    DFS(currentK - dungeons[i, 1], dungeons, count + 1);

                    // 백트래킹: 다른 순서의 탐색을 위해 방문 처리 취소
                    _visited[i] = false;
                }
            }
        }
    }
    internal class 피로도
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[,] _dungeons = { { 80, 20 }, { 50, 40 }, { 30, 10 } };

            Console.WriteLine(_solution.solution(80, _dungeons));       //  3
        }
    }
    */
}
