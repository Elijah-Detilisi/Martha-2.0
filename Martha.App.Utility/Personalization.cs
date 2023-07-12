namespace Martha.App.Utility
{
    public class Personalization
    {
        public string Greeting { get; private set; } = string.Empty;

        private void LoadGreeting()
        {
            Greeting = string.Empty;
        }
    }
}
