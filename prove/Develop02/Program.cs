using System.Collections.Generic;

using System;

namespace Develop02
{
    class Program
    {
        static void Main(string[] args)
        {
            Prompt newPrompts = new Prompt();
            DateTime currentDateTime = DateTime.Now;

            Entry myEntry = new Entry();
            String ranPrompt = newPrompts.getRandomPrompt();
            Console.WriteLine(ranPrompt);
            String answer = Console.ReadLine();
            myEntry.StorePrompt(ranPrompt);
            myEntry.StoreResponse(answer);
            myEntry.StoreDate(currentDateTime.ToString());

            Entry yourEntry = new Entry();
            String yourRanPrompt = newPrompts.getRandomPrompt();
            Console.WriteLine(ranPrompt);
            String yourAnswer = Console.ReadLine();
            myEntry.StorePrompt(yourRanPrompt);
            myEntry.StoreResponse(yourAnswer);
            yourEntry.StoreDate(currentDateTime.ToString());

            Journal journal = new Journal();
            journal.StoreEntry(myEntry);
            journal.StoreEntry(yourEntry);

            List<Entry> entries = journal.GetEntries();
            foreach (Entry entry in entries)
            {
                string message = $"{entry.GetDate()}\n{entry.GetPrompt()}\n{entry.GetResponse()}\n";
                Console.WriteLine(message);
            }
        }
    }
}