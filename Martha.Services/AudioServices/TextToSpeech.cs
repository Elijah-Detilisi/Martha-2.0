#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace Martha.Services.AudioServices
{
    using System.Speech.Synthesis;

    public class TextToSpeech
    {
        #region Fields
        private readonly SpeechSynthesizer _speechSynthesizer;
        #endregion

        #region Construction
        public TextToSpeech()
        {
            _speechSynthesizer = new SpeechSynthesizer();
        }
        #endregion

        #region Pronouncation Methods
        public void Speak(string text)
        {
            _speechSynthesizer.SpeakAsync(text);
        }
        #endregion

        #region Cancellation Methods
        public void Dispose()
        {
            _speechSynthesizer.Pause();
            _speechSynthesizer.Dispose();
        }
        public void StopSpeech()
        {
            _speechSynthesizer.SpeakAsyncCancelAll();
        }
        #endregion

        #region SpeechSynthesizer Properties
        public int SpeechVolume
        {
            get { return _speechSynthesizer.Volume; }
            set { _speechSynthesizer.Volume = value; }
        }
        public int SpeechRate
        {
            get { return _speechSynthesizer.Rate; }
            set { _speechSynthesizer.Rate = value; }
        }
        #endregion
    }

}
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.