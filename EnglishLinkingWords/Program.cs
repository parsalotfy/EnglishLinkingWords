using System;
using System.IO;
using HtmlAgilityPack;

namespace EnglishLinkingWords
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlWeb stackoverflowSite = new HtmlWeb();

            HtmlDocument htmlDocument;
            // HtmlDocument htmlDocument = stackoverflowSite.Load("https://dictionary.cambridge.org/us/dictionary/english/illustration");
            //HtmlDocument htmlDocument = stackoverflowSite.Load("https://dictionary.cambridge.org/us/dictionary/english/stereotype");
            //HtmlDocument htmlDocument = stackoverflowSite.Load("https://dictionary.cambridge.org/us/dictionary/english/mention");
            //HtmlDocument htmlDocument = stackoverflowSite.Load("https://dictionary.cambridge.org/us/dictionary/english/furthermore");
            //HtmlDocument htmlDocument = stackoverflowSite.Load("https://dictionary.cambridge.org/us/dictionary/english/concept");
            //htmlDocument = stackoverflowSite.Load("https://dictionary.cambridge.org/us/dictionary/english/hello");
            //HtmlDocument htmlDocument = stackoverflowSite.Load("https://dictionary.cambridge.org/us/dictionary/english/structure");
            string[] linkingWords = File.ReadAllLines(@"C:\Users\Parsa\Desktop\EnglishLinkingWords\EnglishLinkingWords\LinkingWords.txt");

            foreach (string linkingWord in linkingWords)
            {
                htmlDocument = stackoverflowSite.Load("https://dictionary.cambridge.org/us/dictionary/english/" + linkingWord);
                htmlDocument.Save(@"C:\Users\Parsa\Desktop\EnglishLinkingWords\EnglishLinkingWords\ResultPagesSaved\"+linkingWord+".html");
            }







            //CambridgeDictionarySearchResult stackOverflowPage = htmlDocument.DocumentNode.GetEncapsulatedData<CambridgeDictionarySearchResult>();



        }
    }
}
