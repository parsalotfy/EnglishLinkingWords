using System.Collections.Generic;
using HtmlAgilityPack;

namespace EnglishLinkingWords
{
    [HasXPath]
    public class CambridgeDictionarySearchResult
    {
        [XPath("//div[@class='cdo-dblclick-area']/h1[@class='hw']", ReturnType.InnerHtml)]
        // //*[@id="entryContent"]/div[2]/h1
        public string Title { get; set; }


        [XPath("//div[@class='cdo-dblclick-area']/div[@class='page']/div[@data-id='cacd']")]
        public Section American { get; set; }

/*
        [XPath("//div[@class='cdo-dblclick-area']/div[@class='page']/div[@data-id='cald4']")]
        public Section English { get; set; }
        /*

                        [XPath("//*div[@class='cdo-dblclick-area']/div[@class='page']/div[@data-id='cbed']")]
                        public BusinessSection Business { get; set; }


                        [XPath("//*div[@class='cdo-dblclick-area']/div[@class='page']/div[@data-id='examples']")]
                        public ExamplesSection Examples { get; set; }


                        [XPath("//*div[@class='cdo-dblclick-area']/div[@class='page']/div[@data-id='combinations']")]
                        public CollocationsSection Collocations { get; set; }
                */
    }

    [HasXPath]
    public class Section
    {
        [XPath("//span[@class='posgram ico-bg']", ReturnType.InnerText)]
        public string TypeOfPhrase { get; set; }


        //div[@class='def-block pad-indent'] for when we want to get all the definitions
        [XPath("//div[@class='sense-block']//div[@class='def-block pad-indent']")] //for when we just want to get main definition
        public IEnumerable<Meaning> Meanings { get; set; }

    }

    [HasXPath]
    public class Meaning
    {
        [XPath("//span[@class='def-info']",ReturnType.InnerHtml)]
        public string Lable { get; set; }



        //b[@class='def']
        [XPath("//p[@class='def-head semi-flush']/b[@class='def']", ReturnType.InnerText)]
        public string Definition { get; set; }


        //span[@class='eg']

        //span[@class='def-body']//div[@class='examp emphasized']
        [XPath("//span[@class='def-body']//div[@class='examp emphasized']", ReturnType.InnerText)]
        public IEnumerable<string> Examples { get; set; }
    }




    public class EnglishSection
    {

    }

    public class BusinessSection
    {

    }

    public class ExamplesSection
    {

    }

    public class CollocationsSection
    {

    }

}