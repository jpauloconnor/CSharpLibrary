using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Objects_AssemblyReferences_Speech
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer speak = new SpeechSynthesizer();
            speak.Speak("How are you?");
        }
    }
}
