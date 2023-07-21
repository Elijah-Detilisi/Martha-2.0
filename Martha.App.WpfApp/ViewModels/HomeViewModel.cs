using Martha.Core.Information;
using Martha.Core.Speech;
using Martha.Core.SystemMonitoring;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Martha.App.WpfApp.ViewModels
{
    public class HomeViewModel
    {
        #region Fields
        private readonly HardDrive _hardDrive;
        private readonly TextToSpeech _textToSpeech;

        #endregion

        #region Properties
        public string Username { get; private set; }
        public string Greeting { get; private set; }
        public string SystemStatus { get; private set; }
        #endregion

        #region Construction
        public HomeViewModel()
        {
            _textToSpeech = new TextToSpeech();
            _hardDrive = new HardDrive(driveLetter: "C");
        }
        #endregion

        #region Init methods
        
        private void AnnounceStartUpMessage()
        {
            //Arrange
            string startUpMessage = String.Format("{0}. {1}.",
                Greeting, SystemStatus
            );

            //Speak
            _textToSpeech.Speak(startUpMessage);
        }
        #endregion

        #region Load Methods
        private void LoadGreeting()
        {
            Greeting = String.Format("Good {0} {1}, today is {2} and the time is {3}",
                Time.TimeOfDayText(), Username, Time.CurrentDate().ToLongDateString(), Time.CurrentTime()
            );
        }
        private void LoadSystemStatus()
        {
            //var ramUsage = String.Format("RAM usage is at {0}%.", RAM.GetCurrentUsage());
            var soundLevel = String.Format("Sound levels are at {0}%", SoundLevel.GetMasterVolumeLevel());
            var internetStatus =String.Format("Computer {0} currently connected to internet", 
                InternetConnectivity.IsInternetAvailable() ? "is" : "is not");
            var cpuUsage = String.Format("Current CPU usage is at {0}%", CPU.GetCurrentUsage());
            var harddrive = String.Format("Harddirve used space is at {0} gigabytes, meaning that only {1} gigabytes remains of your total {2} gigabytes",
                _hardDrive.GetUsedSpace(), _hardDrive.GetTotalFreeSpace(), _hardDrive.GetTotalSize());
            
            SystemStatus = String.Format("Your {0}. {1}. The {2}, and the {3}", 
                internetStatus, soundLevel, cpuUsage, harddrive);
        }

        public void LoadViewModel()
        {
            LoadGreeting();
            LoadSystemStatus();
        }
        #endregion

    }
}
