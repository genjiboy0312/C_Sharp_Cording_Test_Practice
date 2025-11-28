using System;

/* 정수 n, left, right가 주어집니다. 다음 과정을 거쳐서 1차원 배열을 만들고자 합니다.
 * 
 * n행 n열 크기의 비어있는 2차원 배열을 만듭니다.
 * i = 1, 2, 3, ..., n에 대해서, 다음 과정을 반복합니다.
 * 1행 1열부터 i행 i열까지의 영역 내의 모든 빈 칸을 숫자 i로 채웁니다.
 * 1행, 2행, ..., n행을 잘라내어 모두 이어붙인 새로운 1차원 배열을 만듭니다.
 * 새로운 1차원 배열을 arr이라 할 때, arr[left], arr[left+1], ..., arr[right]만 남기고 나머지는 지웁니다.
 * 정수 n, left, right가 매개변수로 주어집니다. 주어진 과정대로 만들어진 1차원 배열을 return 하도록 solution 함수를 완성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int n, long left, long right)
        {
            int length = (int)(right - left + 1);
            int[] answer = new int[length];

            for (long i = left; i<= right; i++)
            {
                long row = i / n;
                long col = i % n;
                answer[i - left] = (int)(Math.Max(row, col) + 1);
            }

            return answer;
        }
    }
    internal class n_2_배열_자르기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            Console.WriteLine(_solution.solution(3, 2, 5));     //  3, 2, 2, 3
            Console.WriteLine(_solution.solution(4, 7, 14));     //  4, 3, 3, 3, 4, 4, 4, 4
        }
    }
    */
}