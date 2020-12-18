using System;
using HtmlAgilityPack;
using System.IO;

namespace contr
{
    public class Crawler
    {

       static HtmlWeb web =new HtmlWeb();
        HtmlDocument doc =web.Load("https://google.com/");
    }
}
