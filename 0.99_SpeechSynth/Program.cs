using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace _0._99_SpeechSynth
{
    class Program
    {
        static void Main(string[] args)
        {

            //Original Code from: http://www.wpf-tutorial.com/audio-video/speech-synthesis-making-wpf-talk/


            PromptBuilder promptBuilder = new PromptBuilder();
            promptBuilder.AppendText("Hello world");

            PromptStyle promptStyle = new PromptStyle();
            promptStyle.Volume = PromptVolume.Soft;
            promptStyle.Rate = PromptRate.Slow;
            promptBuilder.StartStyle(promptStyle);
            promptBuilder.AppendText("and hello to the universe too.");
            promptBuilder.EndStyle();

            promptBuilder.AppendText("On this day, ");
            promptBuilder.AppendTextWithHint(DateTime.Now.ToShortDateString(), SayAs.Date);

            promptBuilder.AppendText(", we're gathered here to learn");
            promptBuilder.AppendText("all", PromptEmphasis.Strong);
            promptBuilder.AppendText("about");
            promptBuilder.AppendTextWithHint("C Sharp", SayAs.SpellOut);

            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.Speak(promptBuilder);

            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the audio output.
            synth.SetOutputToWaveFile(@"C:\temp\test.wav");

            // Select the US English voice.
            synth.SelectVoice("Microsoft Server Speech Text to Speech Voice (en-US, Helen)");

            // Build a prompt.
            PromptBuilder builder = new PromptBuilder();
            builder.AppendText("That is a big pizza!");

            // Speak the prompt.
            synth.Speak(builder);



        }
    }
}


