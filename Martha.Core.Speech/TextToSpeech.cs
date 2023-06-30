#pragma warning disable CA1416 // Validate platform compatibility
namespace Martha.Core.Speech
{
    using System.Speech.Synthesis;

    public class TextToSpeech : IDisposable
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

        #region SpeechSynthesizer Speak
        public void Speak(string text)
        {
            try
            {
                _speechSynthesizer.SpeakAsync(text);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Speech synthesis failed: {ex.Message}");
            }
        }
        #endregion

        #region SpeechSynthesizer Cancellation
        public void StopSpeech()
        {
            _speechSynthesizer.SpeakAsyncCancelAll();
        }
        public void Dispose()
        {
            _speechSynthesizer.Dispose();
        }
        #endregion

        #region SpeechSynthesizer Properties
        public int Volume
        {
            get { return _speechSynthesizer.Volume; }
            set { _speechSynthesizer.Volume = value; }
        }

        public int Rate
        {
            get { return _speechSynthesizer.Rate; }
            set { _speechSynthesizer.Rate = value; }
        }
        #endregion
    }
}
#pragma warning restore CA1416 // Validate platform compatibility
