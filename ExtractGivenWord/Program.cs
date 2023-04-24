using System.Collections;
using System.Text;

namespace extractGivenWord
{
    internal class ExtractGivenWord
    {
        public String extract(String text) {
            StringBuilder res = new StringBuilder();
            String[] senteces = text.Split('.');
            List<String> inSentence = new List<String>();
            foreach (var sentence in senteces)
            {
                String[] sen = sentence.Split(" ");
                if (sen.Contains("in"))
                {  
                    inSentence.Add(sentence);
                }
            }
            if (inSentence.Count > 0)
            {
                foreach(var sentence in inSentence)
                {   String temp= sentence;
                    if (sentence.ElementAt(0) == ' ') {temp =sentence.Remove(0, 1); 
                    }
                    res.Append(temp+"\n");
                }
                return res.ToString();
            }
            else return "";
        }
        static void Main(string[] args)
        {
            String text = "We are living in a yellow submarine. " +
                "We don't have anything else. " +
                "Inside the submarine is very tight." +
                " So we are drinking all the day." +
                " We will move out of it in 5 days.";
            ExtractGivenWord e = new ExtractGivenWord();
            Console.WriteLine(e.extract(text));
        }
        
    }
}