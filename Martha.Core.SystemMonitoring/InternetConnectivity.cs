namespace Martha.Core.SystemMonitoring
{
    using System.Net.NetworkInformation;

    public static class InternetConnectivity
    {
        public static bool IsInternetAvailable()
        {
            try
            {
                using (var ping = new Ping())
                {
                    const string targetHost = "www.google.com";
                    const int timeout = 3000; // 3 seconds

                    PingReply reply = ping.Send(targetHost, timeout);
                    return reply.Status == IPStatus.Success;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to check internet connectivity: {ex.Message}");
                return false; // Assume internet is not available on exception
            }
        }
    }
}
