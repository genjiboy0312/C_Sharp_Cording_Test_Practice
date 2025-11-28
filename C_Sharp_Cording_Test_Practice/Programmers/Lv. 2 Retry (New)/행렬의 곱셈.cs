using System;

/* Retry
 * 2차원 행렬 arr1과 arr2를 입력받아, arr1에 arr2를 곱한 결과를 반환하는 함수, solution을 완성해주세요.
 * 
 * 제한 조건
 * 행렬 arr1, arr2의 행과 열의 길이는 2 이상 100 이하입니다.
 * 행렬 arr1, arr2의 원소는 -10 이상 20 이하인 자연수입니다.
 * 곱할 수 있는 배열만 주어집니다.
 */
namespace C_Sharp_Cording_Test_Practice
{ 
    /*
    public class Solution
    {
        public int[,] solution(int[,] arr1, int[,] arr2)
        {
            int _row1 = arr1.GetLength(0);    // arr1 행
            int _col1 = arr1.GetLength(1);    // arr1 열
            int _row2 = arr2.GetLength(0);    // arr2 행
            int _col2 = arr2.GetLength(1);    // arr2 열

            // arr1의 열과 arr2의 행이 같아야 함
            int[,] answer = new int[_row1, _col2];

            for (int i = 0; i < _row1; i++)
            {
                //  여기서 _col1 이 아닌 _col2가 들어가는 이유
                //  arr1 크기 : _row1 x _col1, arr2 크기 : _col1 x _col2. 결과 크기 _ro1 x _col2
                for (int j = 0; j < _col2; j++)
                {
                    int _sum = 0;

                    for (int k = 0; k < _col1; k++)
                    {
                        _sum += arr1[i, k] * arr2[k, j];
                    }

                    answer[i, j] = _sum;
                }
            }
            return answer;
        }
    }
    internal class 행렬의_곱셈
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[,] _arr11 = { { 1, 4 }, { 3, 2 }, { 4, 1 } };
            int[,] _arr12 = { { 2, 3, 2 }, { 4, 2, 4 }, { 3, 1, 4 } };

            int[,] _arr21 = { { 3, 3 }, { 3, 3 } };
            int[,] _arr22 = { { 22, 22, 11 }, { 36, 28, 18 }, { 29, 20, 14 } };

            PrintMatrix(_solution.solution(_arr11, _arr21));      //  [[15, 15], [15, 15], [15, 15]]
            PrintMatrix(_solution.solution(_arr12, _arr22));      //  [[22, 22, 11], [36, 28, 18], [29, 20, 14]]
        }
        static void PrintMatrix(int[,] arr)
        {
            int r = arr.GetLength(0);
            int c = arr.GetLength(1);

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
    */
}