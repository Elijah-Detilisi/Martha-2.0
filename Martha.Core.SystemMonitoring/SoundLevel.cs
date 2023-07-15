namespace Martha.Core.SystemMonitoring
{
    using NAudio.CoreAudioApi;
    public static class SoundLevel
    {
        public static float GetMasterVolumeLevel()
        {
            using (var enumerator = new MMDeviceEnumerator())
            {
                var defaultDevice = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
                var audioEndpointVolume = defaultDevice.AudioEndpointVolume;
                var masterVolumeLevel = audioEndpointVolume.MasterVolumeLevelScalar;
                return masterVolumeLevel * 100;
            }
        }

        public static void SetMasterVolumeLevel(float level)
        {
            using (var enumerator = new MMDeviceEnumerator())
            {
                var defaultDevice = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
                var audioEndpointVolume = defaultDevice.AudioEndpointVolume;
                audioEndpointVolume.MasterVolumeLevelScalar = level;
            }
        }

    }
}
