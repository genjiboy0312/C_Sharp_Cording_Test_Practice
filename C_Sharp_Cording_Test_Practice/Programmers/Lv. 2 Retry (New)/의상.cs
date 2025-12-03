using System;
using System.Collections.Generic;
using System.Linq;

/* Retry
 * 코니는 매일 다른 옷을 조합하여 입는것을 좋아합니다.
 * 
 * 예를 들어 코니가 가진 옷이 아래와 같고, 오늘 코니가 동그란 안경, 긴 코트, 파란색 티셔츠를 입었다면 다음날은 청바지를 추가로 입거나 동그란 안경 대신 검정 선글라스를 착용하거나 해야합니다.
 * 
 * 종류	이름
 * 얼굴	동그란 안경, 검정 선글라스
 * 상의	파란색 티셔츠
 * 하의	청바지
 * 겉옷	긴 코트
 * 
 * 코니는 각 종류별로 최대 1가지 의상만 착용할 수 있습니다. 예를 들어 위 예시의 경우 동그란 안경과 검정 선글라스를 동시에 착용할 수는 없습니다.
 * 착용한 의상의 일부가 겹치더라도, 다른 의상이 겹치지 않거나, 혹은 의상을 추가로 더 착용한 경우에는 서로 다른 방법으로 옷을 착용한 것으로 계산합니다.
 * 코니는 하루에 최소 한 개의 의상은 입습니다.
 * 코니가 가진 의상들이 담긴 2차원 배열 clothes가 주어질 때 서로 다른 옷의 조합의 수를 return 하도록 solution 함수를 작성해주세요.
 */
namespace C_Sharp_Cording_Test_Practice
{
    /*
    public class Solution
    {
        public int solution(string[,] clothes)
        {
            int len = clothes.GetLength(0);

            // clothes → [이름, 종류]
            // 종류별로 그룹핑 후 개수 세기
            var groups = Enumerable.Range(0, len)
                                   .GroupBy(i => clothes[i, 1])      // 종류 기준 그룹
                                   .Select(g => g.Count())           // 각 종류별 개수
                                   .ToList();

            // (개수 + 1)을 모두 곱하고 최종적으로 -1
            //  acc : 이전 결과 (누적된 곱), c : 현재 요소 (딕셔너리의 value)
            int answer = groups.Aggregate(1, (acc, c) => acc * (c + 1)) - 1;

            return answer;
        }
    }
    internal class 의상
    {
        static void Main(string[] args)
        {
            Solution _solution = new Solution();

            string[,] _clothes01 = { { "yellow_hat", "headgear" }, { "blue_sunglasses", "eyewear" }, { "green_turban", "headgear" } };
            string[,] _clothes02 = { { "crow_mask", "face" }, { "blue_sunglasses", "face" }, { "smoky_makeup", "face" } };

            Console.WriteLine(_solution.solution(_clothes01));      //  5
            Console.WriteLine(_solution.solution(_clothes02));      //  3
        }
    }
    */
}