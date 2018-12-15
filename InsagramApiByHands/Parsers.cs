using System;
using System.Collections.Generic;
using System.IO;

namespace InsagramApiByHands
{
    public static class Parsers
    {
        public static void WriteListOfStringToFile(List<string> followersList, string filepath)
        {
            StreamWriter sw = new StreamWriter(filepath);
            foreach (var follower in followersList)
            {
                sw.WriteLine(follower);
            }
            sw.Close();
        }
        public static List<string> ReadListOfStringFromFile(string filepath)
        {
            StreamReader streamReader = new StreamReader(filepath);
            List<string> stringBase = new List<string>();
            stringBase.AddRange(streamReader.ReadToEnd().Split('\n'));
            streamReader.Close();
            return stringBase;
        }
        public static int ParseFollowersCount(string followersString)
        {
            string intString = string.Empty;
            for (int i = 0; i < followersString.Length; i++)
            {
                if (followersString[i] >= '0' && followersString[i] <= '9')
                {
                    intString += followersString[i];
                }
            }
            return !string.IsNullOrEmpty(intString) ? Int32.Parse(intString) : 0;
        }
        
    }
}
