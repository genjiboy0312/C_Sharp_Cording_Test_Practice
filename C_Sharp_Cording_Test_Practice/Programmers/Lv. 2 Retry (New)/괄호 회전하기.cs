using System;
using System.Collections.Generic;
using System.Text;

/* Retry
 * 다음 규칙을 지키는 문자열을 올바른 괄호 문자열이라고 정의합니다.
 * 
 * (), [], {} 는 모두 올바른 괄호 문자열입니다.
 * 만약 A가 올바른 괄호 문자열이라면, (A), [A], {A} 도 올바른 괄호 문자열입니다. 
 * 예를 들어, [] 가 올바른 괄호 문자열이므로, ([]) 도 올바른 괄호 문자열입니다.
 * 만약 A, B가 올바른 괄호 문자열이라면, AB 도 올바른 괄호 문자열입니다. 
 * 예를 들어, {} 와 ([]) 가 올바른 괄호 문자열이므로, {}([]) 도 올바른 괄호 문자열입니다.
 * 
 * 대괄호, 중괄호, 그리고 소괄호로 이루어진 문자열 s가 매개변수로 주어집니다. 
 * 이 s를 왼쪽으로 x (0 ≤ x < (s의 길이)) 칸만큼 회전시켰을 때 s가 올바른 괄호 문자열이 되게 하는 x의 개수를 return 하도록 solution 함수를 완성해주세요.
*/
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(string s)
        {
            int answer = 0;
            int n = s.Length;
            StringBuilder _sb = new StringBuilder(s);

            for (int i = 0; i < n; i++)
            {
                if (IsValid(_sb.ToString()))
                    answer++;

                // 왼쪽으로 1칸 회전
                char first = _sb[0];
                _sb.Remove(0, 1);
                _sb.Append(first);
            }
            return answer;
        }

        private bool IsValid(string str)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in str)
            {
                if (c == '(' || c == '[' || c == '{')
                    stack.Push(c);
                else
                {
                    if (stack.Count == 0) 
                        return false;

                    char top = stack.Pop();

                    if ((c == ')' && top != '(') ||
                        (c == ']' && top != '[') ||
                        (c == '}' && top != '{'))
                        return false;
                }
            }

            return stack.Count == 0;
        }
    }
    internal class 괄호_회전하기
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string _s01 = "[](){}";
            string _s02 = "}]()[{";
            string _s03 = "[)(]";
            string _s04 = "}}}";

            Console.WriteLine(_solution.solution(_s01));    //  3  
            Console.WriteLine(_solution.solution(_s02));    //  2
            Console.WriteLine(_solution.solution(_s03));    //  0
            Console.WriteLine(_solution.solution(_s04));    //  0
        }
    }
    */
}