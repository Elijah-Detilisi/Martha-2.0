
namespace Martha.Core.Media
{
    using NAudio.Wave;
    public class MP3Player
    {
        #region Fields
        private WaveOutEvent _outputDevice;
        #endregion

        #region Construction
        public MP3Player()
        {
            _outputDevice = new WaveOutEvent();
        }
        #endregion

        #region Media controllers
        public void Play(string mp3File)
        {
            using (var audioFile = new AudioFileReader(mp3File))
            {
                this.Stop();
                _outputDevice.Init(audioFile);
                _outputDevice.Play();
            }
        }
        public void Stop()
        {
            if (_outputDevice.PlaybackState == PlaybackState.Playing)
            {
                _outputDevice.Stop();
            }
        }
        public void Pause()
        {
            if (_outputDevice.PlaybackState == PlaybackState.Playing)
            {
                _outputDevice.Pause();
            }
        }
        #endregion
    }
}
