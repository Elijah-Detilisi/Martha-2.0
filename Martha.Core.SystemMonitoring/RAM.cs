#pragma warning disable CA1416 // Validate platform compatibility
namespace Martha.Core.SystemMonitoring
{
    using System.Diagnostics;
    public static class RAM
    {
        public static float GetTotalRAM()
        {
            using (var computerInfo = new PerformanceCounter("Memory", "Total Visible Memory Size"))
            {
                return computerInfo.NextValue() / (1024 * 1024); // Convert to megabytes
            }
        }

        public static float GetCurrentUsage()
        {
            using (var ramCounter = new PerformanceCounter("Memory", "Available MBytes"))
            {
                var availableRAM = ramCounter.NextValue();
                var usedRAM = GetTotalRAM() - availableRAM;
                return usedRAM;
            }
        }
    }
}
#pragma warning restore CA1416 // Validate platform compatibility