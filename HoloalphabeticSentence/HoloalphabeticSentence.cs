using System;
using System.Linq;

namespace HoloalphabeticSentence
{
    public class HoloalphabeticSentence
    {
        // Write the logic to determine whether the input string is a HoloalphabeticSentence or not
        public static bool IsHoloalphabeticSentence(string input, string alphabets = "abcdefghijklmnopqrstuvwxyz")
        {
            int i,j=0,count=0;
            string lowercase = input.ToLower();
            for (i= 0;i<alphabets.Length;i++)
            {
                for(j=0;j<lowercase.Length;j++)
                {
                    if(alphabets[i]==lowercase[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            if(count==26)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
