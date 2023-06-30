#pragma warning disable CA1416 // Validate platform compatibility
namespace Martha.Core.SystemMonitoring
{
    using System.Diagnostics;
    public class CPU
    {
        public float GetCurrentUsage()
        {
            using (var cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total"))
            {
                float cpuUsage = cpuCounter.NextValue();
                return cpuUsage;
            }
        }
    }
}
#pragma warning restore CA1416 // Validate platform compatibility
