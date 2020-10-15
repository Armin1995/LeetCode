using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode911
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] persons = new int[] { 0, 1, 2, 2, 1 };
            int[] times = new int[] { 20, 28, 29, 54, 56 };
            int[] ts = new int[] { 28, 53, 57, 29, 29, 28, 30, 20, 56, 55 };
            TopVotedCandidate obj = new TopVotedCandidate(persons, times);
            string str = "";
            foreach (var t in ts)
            {
                int param_1 = obj.Q(t);
                str += param_1 + ",";
            }
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }

    public class TopVotedCandidate
    {
        private Dictionary<int, Dictionary<int, int>> personTimeVoteCountDict = new Dictionary<int, Dictionary<int, int>>();
        private Dictionary<int, int> timeLeaderDict = new Dictionary<int, int>();

        public TopVotedCandidate(int[] persons, int[] times)
        {
            var leadPerson = persons[0];
            for (int i = 0; i < times.Length; i++)
            {
                var person = persons[i];
                var time = times[i];
                if (personTimeVoteCountDict.ContainsKey(person))
                {
                    var voteCount = personTimeVoteCountDict[person].Last().Value;
                    personTimeVoteCountDict[person].Add(time, ++voteCount);
                }
                else
                {
                    personTimeVoteCountDict.Add(person, new Dictionary<int, int>() { { time, 1 } });
                }
                var tempDict = personTimeVoteCountDict.GroupBy(o => o.Value.Count).ToDictionary(o => o.Key, v => v.ToList()).OrderByDescending(o => o.Key).First().Value;
                if (tempDict.Any(o => o.Key == person))
                {
                    timeLeaderDict.Add(time, person);
                    leadPerson = person;
                }
                else
                {
                    timeLeaderDict.Add(time, leadPerson);
                }
            }
        }

        public int Q(int t)
        {
            return timeLeaderDict.LastOrDefault(o => o.Key <= t).Value;
        }
    }
}
