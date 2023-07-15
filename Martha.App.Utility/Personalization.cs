using Martha.Core.Information;
using Martha.Core.SystemMonitoring;

namespace Martha.App.Utility
{
    public class Personalization
    {
        #region Fields
        private readonly HardDrive _hardDrive;

        #endregion

        #region Properties
        public string Username { get; private set; }
        public string Greeting { get; private set; }
        public string SystemStatus { get; private set; }
        #endregion

        #region Construction
        public Personalization()
        {
            _hardDrive = new HardDrive(driveLetter:"C");
        }
        #endregion

        #region Load Methods
        public void LoadGreeting()
        {
            Greeting = String.Format("Good {0} {1}, today is {2} and the time is {3}.",
                Time.TimeOfDayText(), Username, Time.CurrentDate(), Time.CurrentTime()
            );
        }
        public void LoadSystemStatus()
        {
            var internetStatus = InternetConnectivity.IsInternetAvailable()? "is" : "is not";

            SystemStatus = String.Format("Your computer {0} currently connected to internet, " + "sound levels are at {1}, " +
                "the CPU usage is at {2}, " + "RAM usage is at {3}, " + "and {4} gigabytes of harddrive has been used.",
                internetStatus, SoundLevel.GetMasterVolumeLevel(), CPU.GetCurrentUsage(), RAM.GetTotalRAM(), _hardDrive.GetUsedSpace()
            );
        }
        #endregion

    }
}
