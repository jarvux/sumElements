using System;
using System.Collections.Generic;

namespace SumElements
{
    public static class Elements
    {
        public static Tuple<int, int> SumElements(IReadOnlyList<int> arr, int k)
        {
            var visited = new Dictionary<int, int>();
            for (var index = 0; index < arr.Count; index++)
            {
                var element = arr[index];
                if (visited.ContainsKey(k - element))
                {
                    var ele = visited[k - element];
                    return new Tuple<int, int>(ele, index);
                }

                visited[element] = index;
            }

            return new Tuple<int, int>(0,0);
        }
    }
}