using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsWord = false;

            if (string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }

            if (ignoreCase == true)
            {
                word = word.ToLower();

                var lc = words.Select(x => x.ToLower()).ToList();

                containsWord = lc.Contains(word);
            }

            if (ignoreCase == false)
            {
                containsWord = words.Contains(word);
            }

            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(num));

            for (var i = 3; i <= boundary; i += 2)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            //int index = -1;
            //bool uindex;

            //for (int i = 0; i < str.Length; i++)
            //{
            //    uindex = true;

            //    for (int j = 0; j < str.Length; j++)
            //    {
            //        if (str[i] == str[j] && i != j)
            //        {
            //            uindex = false;
            //        }
            //    }

            //    if (uindex == true)
            //    {
            //        index = i;
            //    }
            //}
            //return index;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str.IndexOf(str[i]) == str.LastIndexOf(str[i]))
                {
                    return i;
                }

            }
            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }

                    currentCount++;
                }

                if (currentCount > count)
                {
                    count = currentCount;
                }
            }

            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var nthElement = new List<double>();

            if (elements == null)
            {
                return new double[] { };
            }

            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] % n == 0)
                {
                    nthElement.Add(elements[i]);
                }

                if (n < 0 || n > elements.Count)
                {
                    nthElement.Clear();
                }
            }

            return nthElement.ToArray();

        }
    }
}
