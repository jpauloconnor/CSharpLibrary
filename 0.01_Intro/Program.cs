
using System.Speech.Synthesis;
/// <summary>
/// Solution, Namespace, Class, Main
/// </summary>
namespace _0._01_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Hey Jay. Please don't use that dumb alarm anymore.");
            
            System.Console.WriteLine("Hello World");
            System.Console.ReadLine();
        }
    }
}
