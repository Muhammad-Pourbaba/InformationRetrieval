

using System.Collections.Generic;

namespace contr
{
    public class Tokenize
    {
        static char[] spaceChar = { ' ', '_', '-', '/', '\\' };
        private static List<string> toList(string[] splitArr)
        {
            List<string> output = new List<string>();
            for (int i = 0; i < splitArr.Length; i++)
            {
                if(splitArr[i]!=null)
                output.Add(splitArr[i]);

            }
            return output;
        }
        #region tokenizer

        /// <summery>
        /// Tokenize a string
        /// </summery>
        /// <para>takes the raw string </para>

        public static List<string> tokenList(string q)
        {
            //Splits query base on space chars and push tokens into List
            return toList(q.Split(spaceChar));
        }
        #endregion
    }
}