﻿using System;

namespace Develop03
{
    public struct tmp_data
    {
        private string _book;
        private int _chapter;
        private int _verse_start;
        private int _verse_end;
        private string _content;
        public tmp_data(string book, int chapter, int verse_start, int verse_end, string content)
        {
            _book = book;
            _chapter = chapter;
            _verse_start = verse_start;
            _verse_end = verse_end;
            _content = content;
        }

        public readonly string GetBook() { return _book; }
        public readonly int GetChapter() { return _chapter; }
        public readonly int GetVerse_start() { return _verse_start; }
        public readonly int GetVerse_end() { return _verse_end; }
        public readonly string GetContent() { return _content; }
    };

    class Develop03
    {
        public static void Main(string[] args)
        {
            Random rnd = new();
            int dificult_level = 3;
            List<tmp_data> myCollection = new()
            {
               new( "Proverbs", 3, 5, 6, "Trust in the Lord with all your heart and do not rely upon your understanding. Know Him in all your ways, and He will direct your paths.") ,
               new( "Psalms",1,1,1,"The praises of a man are that he did not follow the counsel of the wicked, neither did he stand in the way of sinners nor sit in the company of scorners."),
               new( "Psalms",23,1,2,"A song of David. The Lord is my shepherd; I shall not want. He causes me to lie down in green pastures; He leads me beside still waters."),
            };
            tmp_data myOption = myCollection[rnd.Next(1, myCollection.Count) - 1];
            // Console.WriteLine(myOption.book);
            Scripture myscript;
            if (myOption.GetVerse_start() == myOption.GetVerse_end())
            {
                myscript = new Scripture(myOption.GetBook(), myOption.GetChapter(), myOption.GetVerse_start(), myOption.GetContent());
            }
            else
            {
                myscript = new Scripture(myOption.GetBook(), myOption.GetChapter(), myOption.GetVerse_start(), myOption.GetVerse_end(), myOption.GetContent());
            }
            while (true)
            {
                Console.Clear();
                myscript.PrintTexts();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                string myMessage = Console.ReadLine().Trim().ToLower();
                if (myMessage == "quit") break;
                if (!myscript.IsWorking()) break;
                for (int dificult = 0; dificult < dificult_level; dificult++) myscript.HideRandomly();
            }
        }
    }
}