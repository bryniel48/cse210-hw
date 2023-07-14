using System;
using System.Collections.Generic;
namespace Foundations1{
    class Program
    {
        static void Main(string[] args)
        {
            // initialization of the videos
            List<string> markCommentInfo = new List<string>(){
                "Bryan", "I love this video!", "05/20/2023",
                "Hamilton", "This video is mid.", "05/24/2023",
                "Jason", "I wish I could be in this video!", "05/25/2023"
                };
            List<string> bradCommentInfo = new List<string>(){
                "George", "I hated this video!", "06/08/2023",
                "Lynda", "This is very informational!", "06/09/2023",
                "Snellen", "It was a decent video", "06/10/2023"
                };
            List<string> kyleCommentInfo = new List<string>(){
                "Jessica", "Too much language!", "07/05/2023",
                "Chloe", "I did not like this video at all", "07/06/2023",
                "Alex", "This video sucks", "07/07/2023"
                };
            Video mark = new Video();
            mark.storeTitle("I built a giant nerf gun");
            mark.storeAuthor("Mark Rober");
            mark.storeLength(360);
            Video brad = new Video();
            brad.storeTitle("What Penguins like to do");
            brad.storeAuthor("Brad Stevenson");
            brad.storeLength(500);
            Video kyle = new Video();
            kyle.storeAuthor("Kyle Anderson");
            kyle.storeTitle("Why we should be able to speak potty words");
            kyle.storeLength(400);
            for(int i = 0; i < 9; i+=3){
                Comments firstComment = new Comments();
                firstComment.storeName(markCommentInfo[i]);
                firstComment.storeText(markCommentInfo[i+1]);
                firstComment.storeDate(markCommentInfo[i+2]);
                mark.storeComments(firstComment);
            }
            for (int i = 0; i < 9; i+=3){
                Comments firstComment = new Comments();
                firstComment.storeName(bradCommentInfo[i]);
                firstComment.storeText(bradCommentInfo[i+1]);
                firstComment.storeDate(bradCommentInfo[i+2]);
                brad.storeComments(firstComment);
            }
            for (int i = 0; i < 9; i+=3){
                Comments firstComment = new Comments();
                firstComment.storeName(kyleCommentInfo[i]);
                firstComment.storeText(kyleCommentInfo[i+1]);
                firstComment.storeDate(kyleCommentInfo[i+2]);
                kyle.storeComments(firstComment);
            }
            Console.WriteLine(mark.getTitle());
            Console.WriteLine(mark.getAuthor());
            Console.WriteLine(mark.getLength());
            mark.printComments();
            Console.WriteLine();
            Console.WriteLine(brad.getTitle());
            Console.WriteLine(brad.getAuthor());
            Console.WriteLine(brad.getLength());
            brad.printComments();
            Console.WriteLine();
            Console.WriteLine(kyle.getTitle());
            Console.WriteLine(kyle.getAuthor());
            Console.WriteLine(kyle.getLength());
            kyle.printComments();
           
        }
    }
}