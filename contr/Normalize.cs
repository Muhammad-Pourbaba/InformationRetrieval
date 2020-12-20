

using System.Collections.Generic;

namespace contr
{
    public class Normalize
    {

        static string[] stopWord = { "`", ",", "'", "\"", ":", "\t",".","?","~","!",
                            "@","#","$","(",")","*","&","^","%","<","p>","b>",">",";","{","}","[","]"};
        static string[] regWord = { "a", "the", "in", "at", "as", "an", "i", "on", "of", "my", "about", "this", "am", "me", "us", "these", "is", "you", "", "\u00a0", "its", "it's", "not", "isn't" };

        public static List<string> normalList(List<string> tokens)
        {
            //Deletes all stop words of token list
            stopWordTerminator(tokens);
            //Changes all the tokens to lowercase
            lowerThem(tokens);
            //Deletes all the regular words from sentence-sized Query.It actually rmoves the regular words from tokens in lists bigger than #2 tokens
            regularWordTerminator(tokens);

            return tokens;
        }
        public static void stopWordTerminator(List<string> tokens)
        {
            for (int i = 0; i < tokens.Count; i++)
            {
                for (int j = 0; j < stopWord.Length; j++)
                {
                    if (tokens[i].Contains(stopWord[j]))
                    {
                        tokens[i] = tokens[i].Replace(stopWord[j], "");
                    }
                }

            }

        }
        public static void lowerThem(List<string> tokens)
        {
            for (int i = 0; i < tokens.Count; i++)
            {
                tokens[i] = tokens[i].ToLower();
            }
        }
        private static bool containReg(string s)
        {
            for (int i = 0; i < regWord.Length; i++)
            {
                if (s.Equals(regWord[i]))
                    return true;
            }
            return false;
        }
        public static void regularWordTerminator(List<string> tokens)
        {

            if (tokens.Count > 2)
            {
                foreach (var word in regWord)
                {
                    tokens.RemoveAll(containReg);
                }


                // for (int i = 0; i < temp.Count; i++)
                // {
                //     for (int j = 0; j < regWord.Length; j++)
                //     {
                //         if (temp[i].Equals(regWord[j]))
                //         {
                //             tokens.RemoveAt(i);


                //         }
                //     }

                // }

            }

        }

    }
}