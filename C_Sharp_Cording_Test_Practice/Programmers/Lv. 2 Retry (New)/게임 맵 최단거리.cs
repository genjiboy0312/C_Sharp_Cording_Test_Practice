using System;
using System.Collections.Generic;

/* ROR 게임은 두 팀으로 나누어서 진행하며, 상대 팀 진영을 먼저 파괴하면 이기는 게임입니다. 따라서, 각 팀은 상대 팀 진영에 최대한 빨리 도착하는 것이 유리합니다.
 * 
 * 지금부터 당신은 한 팀의 팀원이 되어 게임을 진행하려고 합니다. 
 * 다음은 5 x 5 크기의 맵에, 당신의 캐릭터가 (행: 1, 열: 1) 위치에 있고, 상대 팀 진영은 (행: 5, 열: 5) 위치에 있는 경우의 예시입니다
 * 
 * 위 그림에서 검은색 부분은 벽으로 막혀있어 갈 수 없는 길이며, 흰색 부분은 갈 수 있는 길입니다. 
 * 캐릭터가 움직일 때는 동, 서, 남, 북 방향으로 한 칸씩 이동하며, 게임 맵을 벗어난 길은 갈 수 없습니다.
 * 아래 예시는 캐릭터가 상대 팀 진영으로 가는 두 가지 방법을 나타내고 있습니다.
 * 
 * 첫 번째 방법은 11개의 칸을 지나서 상대 팀 진영에 도착했습니다.
 * 두 번째 방법은 15개의 칸을 지나서 상대팀 진영에 도착했습니다.
 * 
 * 위 예시에서는 첫 번째 방법보다 더 빠르게 상대팀 진영에 도착하는 방법은 없으므로, 
 * 이 방법이 상대 팀 진영으로 가는 가장 빠른 방법입니다.
 * 
 * 만약, 상대 팀이 자신의 팀 진영 주위에 벽을 세워두었다면 상대 팀 진영에 도착하지 못할 수도 있습니다. 
 * 예를 들어, 다음과 같은 경우에 당신의 캐릭터는 상대 팀 진영에 도착할 수 없습니다.
 * 
 * 게임 맵의 상태 maps가 매개변수로 주어질 때, 캐릭터가 상대 팀 진영에 도착하기 위해서 지나가야 하는 칸의 개수의 최솟값을 return 하도록 solution 함수를 완성해주세요. 
 * 단, 상대 팀 진영에 도착할 수 없을 때는 -1을 return 해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    class Solution
    {
        public int solution(int[,] maps)
        {
            // 맵 크기
            int _rowCount = maps.GetLength(0);
            int _colCount = maps.GetLength(1);

            // 방문 여부
            bool[,] _visited = new bool[_rowCount, _colCount];

            // 최단 거리 저장
            int[,] _distance = new int[_rowCount, _colCount];

            // BFS용 큐 (좌표)
            Queue<(int row, int col)> _queue = new Queue<(int, int)>();

            // 이동 방향 (상, 하, 좌, 우)
            int[] _dirRow = { -1, 1, 0, 0 };
            int[] _dirCol = { 0, 0, -1, 1 };

            // 시작점
            _queue.Enqueue((0, 0));
            _visited[0, 0] = true;
            _distance[0, 0] = 1;

            while (_queue.Count > 0)
            {
                var _cur = _queue.Dequeue();        //  1. 현재 위치를 꺼낸다

                // 도착 지점이면 바로 반환
                if (_cur.row == _rowCount - 1 && _cur.col == _colCount - 1)
                    return _distance[_cur.row, _cur.col];

                // 2. 4방향 탐색
                for (int i = 0; i < 4; i++)
                {
                    int _nextRow = _cur.row + _dirRow[i];
                    int _nextCol = _cur.col + _dirCol[i];

                    // 맵 밖
                    if (_nextRow < 0 || _nextRow >= _rowCount || _nextCol < 0 || _nextCol >= _colCount)
                        continue;

                    // 벽
                    if (maps[_nextRow, _nextCol] == 0)
                        continue;

                    // 이미 방문
                    if (_visited[_nextRow, _nextCol])
                        continue;

                    _visited[_nextRow, _nextCol] = true;
                    _distance[_nextRow, _nextCol] = _distance[_cur.row, _cur.col] + 1;        //  3. 거리 = 이전거리 + 1
                    _queue.Enqueue((_nextRow, _nextCol));                                   //  4. 갈 수 있으면 큐에 넣는다
                }
            }
            // 도착 불가
            return -1;
        }

        internal class 게임_맵_최단거리
        {
            static void Main(string[] args)
            {
                Solution _solution = new Solution();

                int[,] _maps01 = { { 1, 0, 1, 1, 1 }, { 1, 0, 1, 0, 1 }, { 1, 0, 1, 1, 1 }, { 1, 1, 1, 0, 1 }, { 0, 0, 0, 0, 1 } };
                int[,] _maps02 = { { 1, 0, 1, 1, 1 }, { 1, 0, 1, 0, 1 }, { 1, 0, 1, 1, 1 }, { 1, 1, 1, 0, 0 }, { 0, 0, 0, 0, 1 } };

                Console.WriteLine(_solution.solution(_maps01));     //  11
                Console.WriteLine(_solution.solution(_maps02));     //  -1
            }
        }
    }
    */
}