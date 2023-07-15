using System;
using System.Collections.Generic;

namespace Foundation3{

    class Program
    {
        static void Main(string[] args)
        {
            // intitilize the three events
            Lectures lecture = new Lectures();
            lecture.storeTitle("Is football the best sport?");
            lecture.storeDescription("Come discuss and learn why football is better than any other sport");
            lecture.storeDateAndTime("07/10/2023", "17:00");
            lecture.storeAddress("123 S 456 W");
            lecture.storeSpeaker("Anna Jones");
            lecture.storeCapacity(100);

            Receptions reception = new Receptions();
            reception.storeTitle("Ashley and Jason's Wedding");
            reception.storeDescription("Come join us in celebration of this newley wed couple!");
            reception.storeDateAndTime("07/14/2023", "16:00");
            reception.storeAddress("456 S 789 E");
            reception.storeRSVP("Janice Bellford    hello@gmail.com");
            reception.storeRSVP("Jennifer Bruce     whywehere@gmail.com");
            reception.storeRSVP("Bryant Martavius   martBry@hotmail.com");

            Outdoor outdoor = new Outdoor();
            outdoor.storeTitle("YSA Dance Party");
            outdoor.storeDescription("Come party with fellow YSA aged adults to mix and mingle");
            outdoor.storeDateAndTime("07/15/2023", "16:00");
            outdoor.storeAddress("789 W 123 N");
            outdoor.storeWeatherReport("Heavy Rain");

            Console.WriteLine((lecture.getFullDetails()) + "\n");
            Console.WriteLine((reception.getFullDetails()) + "\n");
            Console.WriteLine((outdoor.getFullDetails()) + "\n");

            Console.WriteLine((lecture.getShortDescription()) + "\n");
            Console.WriteLine((reception.getShortDescription()) + "\n");
            Console.WriteLine((outdoor.getShortDescription()) + "\n");

        }
    }
}