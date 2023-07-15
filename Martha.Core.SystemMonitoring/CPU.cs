#pragma warning disable CA1416 // Validate platform compatibility
namespace Martha.Core.SystemMonitoring
{
    using System.Diagnostics;
    public static class CPU
    {
        public static float GetCurrentUsage()
        {
            using (var cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total"))
            {
                float cpuUsage = cpuCounter.NextValue();
                Thread.Sleep(1000);
                cpuUsage = cpuCounter.NextValue();
                return cpuUsage;
            }
        }

    }
}
#pragma warning restore CA1416 // Validate platform compatibility
