namespace Martha.Core.SystemMonitoring
{
    using System.Diagnostics;

    public static class AppManagement
    {
        public static void OpenApplication(string applicationPath)
        {
            Process.Start(applicationPath);
        }

        public static void CloseApplication(string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName);
            foreach (Process process in processes)
            {
                process.CloseMainWindow();
                process.WaitForExit();
            }
        }

    }
}
