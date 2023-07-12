using Martha.Core.Information;

namespace Martha.App.Utility
{
    public class Personalization
    {
        public string Greeting { get; private set; }
        public string Username { get; private set; }

        private void LoadGreeting()
        {
            Greeting = String.Format("Good {0} {1}, today is {2} and the time is {3}.",
                Time.TimeOfDayText(), Username, Time.CurrentDate(), Time.CurrentTime()
            );
        }
    }
}
