using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace contr
{
    public class Dict
    {
        public static Dictionary<string, Dictionary<string, int>> tokenizedHtml = new Dictionary<string, Dictionary<string, int>>();
        public Dict()
        {
            collCrl("C:\\Users\\Muhammad\\Documents\\projects\\InformationRetrieval\\Coll");

        }
        public void collCrl(string fldr)
        {


            foreach (var file in Directory.GetFiles(fldr))
            {
                if (file.EndsWith(".html"))
                {

                    parseHtml(file);

                }
            }

        }
        public void parseHtml(string file)
        {
            List<string> temp = new List<string>();

            StreamReader HReader = new StreamReader(file);

            foreach (var parag in HReader.ReadToEnd().Split('<'))
            {
                if (parag.StartsWith("p") || parag.StartsWith("b"))
                {

                    temp = Normalize.normalList(Tokenize.tokenList(parag));
                    foreach (var term in temp)
                    {
                        if (tokenizedHtml.ContainsKey(term))
                        {
                            if (tokenizedHtml[term].ContainsKey(file))
                            {
                                tokenizedHtml[term][file] = tokenizedHtml[term][file] + 1;
                            }
                            else
                            {
                                tokenizedHtml[term].Add(file, 1);
                            }
                        }
                        else
                        {
                            tokenizedHtml.Add(term, new Dictionary<string, int>() { { file, 1 } });
                        }
                    }
                }
            }

        }

    }
}