using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class UserProxy : ITextToSpeech
    {
        public User User { get; set; }

        public override string ToString()
        {
            return string.Format("{0}", User.Name);
        }

        public void Speak()
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SetOutputToDefaultAudioDevice();
            synthesizer.SpeakAsync(User.ToString());
        }
    }
}
