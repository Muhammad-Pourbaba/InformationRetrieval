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

        public List<string> Tokens
        {
            get { return tokens; }
        }
        public Query(string q)
        {
           tokens=Normalize.normalList(Tokenize.tokenList(q));
        }
    }


}