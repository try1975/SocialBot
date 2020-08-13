using HtmlAgilityPack;
using System;

namespace SocialBot
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = @"https://www.kellysubaru.com/used-inventory/index.htm";
            
            var web = new HtmlWeb();
            var htmlDoc = web.Load(url);

            var node = htmlDoc.QuerySelector("li.green-vehicle");
            var img = node.QuerySelector("img");
            string src = img.GetAttributeValue("src", string.Empty);
            var price = node.QuerySelector("span.value");
            var vin = node.QuerySelector("dl.vin dd");
            
            Console.WriteLine($"Img url: {src}");
            Console.WriteLine($"Price : {price.InnerText}");
            Console.WriteLine($"VIN : {vin.InnerText}");
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
