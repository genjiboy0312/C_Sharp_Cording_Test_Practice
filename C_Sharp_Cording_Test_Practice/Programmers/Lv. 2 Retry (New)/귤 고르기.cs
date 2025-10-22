using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Retry
 * 경화는 과수원에서 귤을 수확했습니다. 경화는 수확한 귤 중 'k'개를 골라 상자 하나에 담아 판매하려고 합니다. 
 * 그런데 수확한 귤의 크기가 일정하지 않아 보기에 좋지 않다고 생각한 경화는 귤을 크기별로 분류했을 때 서로 다른 종류의 수를 최소화하고 싶습니다.
 * 
 * 예를 들어, 경화가 수확한 귤 8개의 크기가 [1, 3, 2, 5, 4, 5, 2, 3] 이라고 합시다. 경화가 귤 6개를 판매하고 싶다면, 
 * 크기가 1, 4인 귤을 제외한 여섯 개의 귤을 상자에 담으면, 귤의 크기의 종류가 2, 3, 5로 총 3가지가 되며 이때가 서로 다른 종류가 최소일 때입니다.
 * 
 * 경화가 한 상자에 담으려는 귤의 개수 k와 귤의 크기를 담은 배열 tangerine이 매개변수로 주어집니다. 
 * 경화가 귤 k개를 고를 때 크기가 서로 다른 종류의 수의 최솟값을 return 하도록 solution 함수를 작성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
public class Solution
{
    public int solution(int k, int[] tangerine)
    {
        int answer = 0;
        Dictionary<int, int> _dic = new Dictionary<int, int>();

        for (int i = 0; i < tangerine.Length; i++)
        {
            if (_dic.TryAdd(tangerine[i], 1) == false)
            {
                _dic[tangerine[i]] += 1;
            }
        }

        List<int> _list = _dic.Values.ToList().OrderByDescending(o => o).ToList();

        int _resualt = k;
        while (_resualt > 0)
        {
            _resualt -= _list[answer];
            answer++;
        }

        return answer;
    }
}
internal class 귤_고르기
{
    static void Main(string[] args)
    {
        Solution _solution = new Solution();

        int[] _tangerine01 = { 1, 3, 2, 5, 4, 5, 2, 3 };
        int[] _tangerine02 = { 1, 1, 1, 1, 2, 2, 2, 3 };

        Console.WriteLine(_solution.solution(6, _tangerine01));     //  3
        Console.WriteLine(_solution.solution(4, _tangerine01));     //  2       크기 2, 2개 + 크기 3 2개 / 크기2인 2개 + 크기 5인 2개
        Console.WriteLine(_solution.solution(2, _tangerine02));     //  1       크기 1, 2개 / 크기 2 2개
    }
}
    */
}
