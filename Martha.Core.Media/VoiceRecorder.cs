namespace Martha.Core.Media
{
    using NAudio.Wave;

    public class VoiceRecorder : IDisposable
    {
        #region Fields
        private WaveInEvent? _waveIn;
        private WaveFileWriter? _waveWriter;
        #endregion

        #region Recording
        public void StartRecording(string outputFilePath)
        {
            _waveIn = new WaveInEvent();
            _waveIn.DataAvailable += WaveIn_DataAvailable;
            _waveIn.WaveFormat = new WaveFormat(44100, 1); // Sample rate: 44.1 kHz, Mono
            _waveWriter = new WaveFileWriter(outputFilePath, _waveIn.WaveFormat);

            _waveIn.StartRecording();
        }

        public void StopRecording()
        {
            _waveIn.StopRecording();
            _waveIn.Dispose();
            _waveWriter.Close();
        }
        #endregion

        #region Helper
        private void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            _waveWriter.Write(e.Buffer, 0, e.BytesRecorded);
        }
        public void Dispose()
        {
            _waveIn?.Dispose();
            _waveWriter?.Dispose();
        }
        #endregion
    }
}
