using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._99_HighestScoringWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = FindHighestWord("a cat b");
            Console.WriteLine(word);
            Console.ReadLine();
        }


        //find highest word
            //Take in a string of words...
            //break up the string into words...
            //calculate each words score...
            //find highest word in collection....
        
        public static string FindHighestWord(string s)
        {
            string biggestWord = "";
            int currentWordScore = 0;

            var words = BreakUpWords(s);
            foreach(var word in words)
            {
                int wordScore = FindWordScore(word);
                if(wordScore > currentWordScore)
                {
                    biggestWord = word;
                    currentWordScore = wordScore;
                    Console.WriteLine(word);
                }
            }
            return biggestWord;
        }
        public static int FindWordScore(string word)
        {
            int wordScore = 0;
           
            var letterArray = ConvertWord(word);
            foreach(char letter in letterArray)
            {
                var valueOfLetter = GiveLetterAValue(letter);
                wordScore = valueOfLetter + wordScore;
            }
            return wordScore;
        }

        public static IEnumerable<string> BreakUpWords(string s)
        {
            string[] wordsInString = s.Split();
            return wordsInString;
        }

        public static IEnumerable<char> ConvertWord(string s)
        {
            char[] charArray = s.ToCharArray();
            return charArray;
        }

        public static int GiveLetterAValue(char letter)
        {
            int score = 0;
            switch (letter)
            {
                case 'a':
                    score = 1;
                    break;
                case 'b':
                    score = 2;
                    break;
                case 'c':
                    score = 3;
                    break;
                case 'd':
                    score = 4;
                    break;
                case 'e':
                    score = 5;
                    break;
                case 'f':
                    score = 6;
                    break;
                case 'g':
                    score = 7;
                    break;
                case 'h':
                    score = 8;
                    break;
                case 'i':
                    score = 9;
                    break;
                case 'j':
                    score = 10;
                    break;
                case 'k':
                    score = 11;
                    break;
                case 'l':
                    score = 12;
                    break;
                case 'm':
                    score = 13;
                    break;
                case 'n':
                    score = 14;
                    break;
                case 'o':
                    score = 15;
                    break;
                case 'p':
                    score = 16;
                    break;
                case 'q':
                    score = 17;
                    break;
                case 'r':
                    score = 18;
                    break;
                case 's':
                    score = 19;
                    break;
                case 't':
                    score = 20;
                    break;
                case 'u':
                    score = 21;
                    break;
                case 'v':
                    score = 22;
                    break;
                case 'w':
                    score = 23;
                    break;
                case 'x':
                    score = 24;
                    break;
                case 'y':
                    score = 25;
                    break;
                case 'z':
                    score = 26;
                    break;
            }
            return score;
        }

    }
}
/*
 
TODO:
Separate a string into words...
Return the highest scoring word....
Handle two words with same score....
Return the word that's earliest...
make everything lc....

     */
