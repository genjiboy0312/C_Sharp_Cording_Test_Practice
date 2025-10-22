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

///* 한 배열에 팀원들의 번호들이 섞여있다. 이 배열을 이용하여 짝수 팀과 홀수 팀을 만들고자 한다.
// * 
// * 이 배열의 앞에는 짝수 팀원들이, 뒤에는 홀수 팀원들이 위치할 수 있도록 배열을 정렬해야 한다.
// * 
// * Example
// * arr = {8, 1, 4, 7}
// * 
// * 다음 4개의 배열은 팀 구분을 올바르게 구성한 배열이다.
// * a = {8, 4, 1, 7}
// * b = {4, 8, 1, 7}
// * c = {8, 4, 7, 1}
// * d = {4, 8, 7, 1}
// * 
// * 위 배열들 중에서 4와 1을 바꾼 a 배열이 1번의 이동으로 최소한의 이동을 만족한다
// * 
// * Function Description
// * 아래 편집기에서 Function Moves()를 완료한다
// * 
// * Moves()에는 다음과 같은 매개 변수가 있다.
// * int arr[n] : 양의 정수 배열
// * 
// * Returns
// * int : 모든 짝수 요소가 홀수 요소보다 이전 인덱스에 있는 정수 배열을 정렬하는 데 필요한
// * 최소 이동 횟수
// * 
// * Note : 짝수 또는 홀수 내의 순서는 중요하지 않다.
// */

//namespace C_Sharp_Cording_Test_Practice
//{
//    class Result
//    {

//        /*
//         * Complete the 'Moves' function below.
//         *
//         * The function is expected to return an INTEGER.
//         * The function accepts INTEGER_ARRAY arr as parameter.
//         */
//        public static int Moves(List<int> arr)
//        {
//            int _moveCount = 0;   // 총 이동 횟수
//            int _evenPos = 0;     // 다음 짝수가 와야 할 인덱스 위치

//            for (int i = 0; i < arr.Count; i++)
//            {
//                if (arr[i] % 2 == 0)
//                {
//                    if (i != _evenPos)
//                    {
//                        _moveCount++;
//                    }
//                    _evenPos++;
//                }
//            }
//            return _moveCount;
//        }

//    }
//    class 문제_1
//    {
//        //public static void Main(string[] args)
//        //{
//        //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        //    int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

//        //    List<int> arr = new List<int>();

//        //    for (int i = 0; i < arrCount; i++)
//        //    {
//        //        int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
//        //        arr.Add(arrItem);
//        //    }

//        //    int result = Result.Moves(arr);

//        //    textWriter.WriteLine(result);

//        //    textWriter.Flush();
//        //    textWriter.Close();
//        //}
//        public static void Main(string[] args)
//        {
//            List<List<int>> _testCases = new List<List<int>>
//    {
//        new List<int> { 8, 1, 4, 7 },      // 기대값: 1
//        new List<int> { 2, 4, 6, 8 },      // 기대값: 0
//        new List<int> { 1, 3, 5, 7 },      // 기대값: 0
//        new List<int> { 4, 3, 2, 1, 6, 5 } // 기대값: 2
//    };

//            foreach (var _arr in _testCases)
//            {
//                int _result = Result.Moves(_arr);
//                Console.WriteLine($"입력: [{string.Join(", ", _arr)}] → 이동 횟수: {_result}");
//            }
//        }

//    }
//}