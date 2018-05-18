using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace _0._01_Intro
{
    public class HelloWorld
    {
        public string PrintAnythingToConsole(string str)
        {
            Console.WriteLine(str);
            return str;
        }

        public void SayHelloWorld()
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Hey Jay. Please don't use that dumb alarm anymore.");

            Console.WriteLine("Hello World");
            Console.ReadLine();
        }

        public string HavingFun(string anything)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak(anything);
            return anything;
        }

    }
}
