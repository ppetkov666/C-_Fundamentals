using System;

namespace P01.Stream_Progress
{
    public class StartUp
    {
        static void Main()
        {
            var progressInfo = new StreamProgressInfo(new File("test.txt", 100, 1000));
            var progressMusic = new StreamProgressInfo(new Music("dmx", "moneyTalk", 600, 700));
            var resultInfo = progressInfo.CalculateCurrentPercent();
            var resultMusic = progressMusic.CalculateCurrentPercent();
            Console.WriteLine(resultInfo);
            Console.WriteLine(resultMusic);


        }
    }
}
