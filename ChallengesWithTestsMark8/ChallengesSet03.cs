using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {

            return vals.Contains(false);


            //another way to do it
            // for(val i = 0; i < vals.Length; i++)
            //{

            // if(vals[i] == false)
            //{
              //  return true;
           // }

            //}

           // return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {


            if (numbers == null)
            {
                return false;
            }

            var sum = numbers.Sum();

            if (sum % 2 != 0)
            {
                return true;
            }

            else
            {
                return false;
            }




            
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            //return password.Contains(password.ToLower().ToUpper()) ? true : false;

            var isLower = false;
            var isUpper = false;
            var isNumber = false;

            for(var i = 0; i < password.Length; i++)
            {
                if(char.IsLower(password[i]))
                {
                    isLower = true;
                }

                if(char.IsUpper(password[i]))
                {
                    isUpper = true;
                }

                if(char.IsNumber(password[i]))
                {
                    isNumber = true;
                }
            }

            if(isLower == true && isUpper == true && isNumber == true)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();


        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();


            //another way to do it w/o linq
            //return val[val.Length - 1];

        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
       
            //return (number == null) ? 0 : dividend / divisor;


            if (divisor == 0)

            {
                return 0;
            }

            
            return dividend / divisor;

        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First();


            //another way w/o linq
            //return nums [nums.Length - 1] - nums[0];

            //another way
            //return nums[^1] - nums[0];


        }

        public int[] GetOddsBelow100()
        {

            var list = new List<int>();

            for(var i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    list.Add(i);
                }
            }

            return list.ToArray();
            

        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (var i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }


        }
    }
}

