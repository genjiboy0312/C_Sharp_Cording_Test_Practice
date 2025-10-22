//using System.CodeDom.Compiler;
//using System.Collections.Generic;
//using System.Collections;
//using System.ComponentModel;
//using System.Diagnostics.CodeAnalysis;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.Serialization;
//using System.Text.RegularExpressions;
//using System.Text;
//using System;

///* 노드와 선으로 구성 되어있는 그래프가 있다.
// * 두 노드를 연결하는 선은 하나만 존재할 수 있으며, 각 선의 길이는 1
// * 해당 그래프 내부에는 순환이 가능한 연결이 하나 구성되어 있다. 어떤 노드는 그 순환으로부터 떨어져 있다.
// * 
// * 각 노드가 순환 구조로 구성 되어 있는 내부 그래프로부터 얼마나 떨어져 있는지 그 거리를 구하고,
// * 그 거리를 정수 배열로 반환해야 한다. 다만 노드가 순환 구조에 속해 있다면 그 거리는 0이다.
// * 
// * 각 노드가 순환 구조에서 얼마나 떨어져 있는지 구해라 
// * (단, 순환 구조에 속해 있다면 거리는 0 으로 계산)
// * 
// * Example 
// * s_ndoes = 6
// * s_edges = 6
// * s_from = { 0, 1, 0, 2, 0, 1}
// * s_to = {1, 2, 2, 4, 3, 5}
// * 
// */

//namespace C_Sharp_Cording_Test_Practice
//{
//    class Result
//    {
//        public static List<int> nodeDistance(int sNodes, List<int> sFrom, List<int> sTo)
//        {
//            // 1. 그래프를 인접 리스트로 변환
//            List<int>[] _graph = new List<int>[sNodes];
//            for (int i = 0; i < sNodes; i++)
//                _graph[i] = new List<int>();


//            //  연결
//            for (int i = 0; i < sFrom.Count; i++)
//            {
//                int u = sFrom[i];
//                int v = sTo[i];
//                _graph[u].Add(v);
//                _graph[v].Add(u);
//            }

//            // 2. 사이클 찾기 (DFS)
//            bool[] _visited = new bool[sNodes];
//            int[] _parent = new int[sNodes];
//            Array.Fill(_parent, -1);
//            bool[] _isCycle = new bool[sNodes];

//            void DFS(int node, int par)
//            {
//                _visited[node] = true;
//                foreach (var next in _graph[node])
//                {
//                    if (next == par) continue;
//                    if (!_visited[next])
//                    {
//                        _parent[next] = node;
//                        DFS(next, node);
//                    }
//                    else
//                    {
//                        // 사이클 발견
//                        int cur = node;
//                        _isCycle[cur] = true;
//                        while (cur != next)
//                        {
//                            cur = _parent[cur];
//                            _isCycle[cur] = true;
//                        }
//                    }
//                }
//            }

//            DFS(0, -1);

//            // 3. BFS로 순환으로부터 거리 계산
//            int[] _dist = Enumerable.Repeat(-1, sNodes).ToArray();
//            Queue<int> _queue = new Queue<int>();
//            for (int i = 0; i < sNodes; i++)
//            {
//                if (_isCycle[i])
//                {
//                    _dist[i] = 0;
//                    _queue.Enqueue(i);
//                }
//            }

//            while (_queue.Count > 0)
//            {
//                int node = _queue.Dequeue();
//                foreach (var next in _graph[node])
//                {
//                    if (_dist[next] == -1)
//                    {
//                        _dist[next] = _dist[node] + 1;
//                        _queue.Enqueue(next);
//                    }
//                }
//            }

//            return _dist.ToList();
//        }

//    }
//    class 문제_2
//    {
//        //public static void Main(string[] args)
//        //{
//        //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        //    string[] sNodesEdges = Console.ReadLine().TrimEnd().Split(' ');

//        //    int sNodes = Convert.ToInt32(sNodesEdges[0]);
//        //    int sEdges = Convert.ToInt32(sNodesEdges[1]);

//        //    List<int> sFrom = new List<int>();
//        //    List<int> sTo = new List<int>();

//        //    for (int i = 0; i < sEdges; i++)
//        //    {
//        //        string[] sFromTo = Console.ReadLine().TrimEnd().Split(' ');

//        //        sFrom.Add(Convert.ToInt32(sFromTo[0]));
//        //        sTo.Add(Convert.ToInt32(sFromTo[1]));
//        //    }

//        //    List<int> result = Result.nodeDistance(sNodes, sFrom, sTo);

//        //    textWriter.WriteLine(String.Join("\n", result));

//        //    textWriter.Flush();
//        //    textWriter.Close();
//        //}
//        public static void Main(string[] args)
//        {
//            // 예제 입력값 바로 지정
//            int sNodes = 6;
//            List<int> sFrom = new List<int> { 0, 1, 0, 2, 0, 1 };
//            List<int> sTo = new List<int> { 1, 2, 2, 4, 3, 5 };

//            // 노드 거리 계산
//            List<int> result = Result.nodeDistance(sNodes, sFrom, sTo);

//            // 결과 출력
//            Console.WriteLine("각 노드의 순환까지 거리:");
//            for (int i = 0; i < result.Count; i++)
//            {
//                Console.WriteLine($"노드 {i}: {result[i]}");
//            }
//        }

//    }
//}
