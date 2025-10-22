using System;

/* Retry
 * Leo는 카펫을 사러 갔다가 아래 그림과 같이 중앙에는 노란색으로 칠해져 있고 테두리 1줄은 갈색으로 칠해져 있는 격자 모양 카펫을 봤습니다.
 * Leo는 집으로 돌아와서 아까 본 카펫의 노란색과 갈색으로 색칠된 격자의 개수는 기억했지만, 전체 카펫의 크기는 기억하지 못했습니다.
 * 
 * Leo가 본 카펫에서 갈색 격자의 수 brown, 노란색 격자의 수 yellow가 매개변수로 주어질 때 
 * 카펫의 가로, 세로 크기를 순서대로 배열에 담아 return 하도록 solution 함수를 작성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int[] solution(int brown, int yellow)
        {
            int total = brown + yellow;

            //  노란색이 생기려면 최소 3줄 이상
            //   total / 3 : height을 너무 크게 탐색할 필요가 없음
            //  (6,4) (4,6) 같은 의미
            for (int height = 3; height <= total / 3; height++)
            {
                if (total % height != 0) 
                    continue;

                int width = total / height;

                // 내부(노란색) 영역이 일치하는지 확인
                if ((width - 2) * (height - 2) == yellow)
                {
                    return new int[] { width, height };
                }
            }
            return new int[] { 0, 0 }; // 혹시 모를 예외
        }
    }
    internal class 카펫
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            int[] result1 = _solution.solution(10, 2);
            Console.WriteLine($"[{result1[0]}, {result1[1]}]");  // [4, 3]

            int[] result2 = _solution.solution(8, 1);
            Console.WriteLine($"[{result2[0]}, {result2[1]}]");   // [3, 3]

            int[] result3 = _solution.solution(24, 24);
            Console.WriteLine($"[{result3[0]}, {result3[1]}]");  // [8, 6]
        }
    }
    */
}