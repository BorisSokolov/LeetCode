using System.Collections.Generic;

namespace Kill_Process
{
    public class Solution
    {
        public IList<int> KillProcess(IList<int> pid, IList<int> ppid, int kill)
        {
            var dict = new Dictionary<int, List<int>>();

            for (int i = 0; i < ppid.Count; i++)
            {
                if (ppid[i] > 0)
                {
                    List<int> list;
                    if (!dict.TryGetValue(ppid[i], out list))
                        list = new List<int>();

                    list.Add(pid[i]);
                    dict[ppid[i]] = list;
                }
            }
            Queue<int> queue = new Queue<int>();
            var answer = new List<int>();
            queue.Enqueue(kill);

            while (queue.Count > 0)
            {
                int i = queue.Dequeue();
                answer.Add(i);
                if (dict.ContainsKey(i))
                {
                    foreach (int id in dict[i])
                        queue.Enqueue(id);
                }
            }
            return answer;
        }
    }
}
