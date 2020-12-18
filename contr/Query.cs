using System;
using System.Collections.Generic;

namespace contr
{
    /// <summery>
    /// Takes the query from user and makes all the tokenization
    /// </summery>
    public class Query
    {
         List<string> tokens;
        char[] spaceChar={' ','\u00a0','_','-','/','\\'};
        string[] stopWord = { "`", ",", "'", "\"", ":", "\t",".","?","~","!",
                            "@","#","$","(",")","*","&","^","%","<",">",";","{","}","[","]"};
        string[] regWord={"a","the","in","at","as","an","i","on","of","my","about","this","am","me","us","these"};

        public List<string> Tokens{
            get {return tokens;}
        }
        public Query(string q)
        {
            tokenize(q);

        }
        public List<string> getTokens(){
            return tokens;
        }
        #region tokenizer

        /// <summery>
        /// Tokenize a string
        /// </summery>
        /// <para>takes the raw string </para>

        private void tokenize(string q)
        {
            //Splits query base on space chars and push tokens into List
            tokens = toList(q.Split(spaceChar));
            //Deletes all stop words of token list
            stopWordTerminator();         
            //Changes all the tokens to lowercase
            lowerThem();
            //Deletes all the regular words from sentence-sized Query.It actually rmoves the regular words from tokens in lists bigger than #2 tokens
            regularWordTerminator();
            

          
        }
        #endregion
        #region more
        private List<string> toList(string[] splitArr)
        {
            List<string> output = new List<string>();
            for (int i = 0; i < splitArr.Length; i++)
            {
                output.Add(splitArr[i]);

            }
            return output;
        }
        private void stopWordTerminator()
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
        private void lowerThem(){
            for (int i = 0; i < tokens.Count; i++)
            {
                tokens[i]=tokens[i].ToLower();
            }
        }
        private void regularWordTerminator(){
            if (tokens.Count > 2)
            {
                for (int i = 0; i < tokens.Count; i++)
                {
                    for (int j = 0; j < regWord.Length ; j++)
                    {
                        if (tokens[i].Equals(regWord[j]))
                        {
                            tokens.RemoveAt(i);
                            i--;

                        }
                    }

                }
                
            }
        }
        #endregion
    }


}