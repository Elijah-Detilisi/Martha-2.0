namespace Martha.Core.SystemMonitoring
{
    using System.IO;

    public class HardDrive
    {
        #region Fields
        private readonly DriveInfo _driveInfo;
        #endregion

        #region Construction
        public HardDrive(string driveLetter)
        {
             _driveInfo = new DriveInfo(driveLetter);
        }
        #endregion

        #region Hard-drive attributes
        public long GetTotalSize()
        {
            long result;

            if (_driveInfo.IsReady)
            {
                result = _driveInfo.TotalSize;
            }
            else
            {
                throw new Exception($"Drive {_driveInfo.Name} is not ready.");
            }

            return result; 
        }
        public long GetTotalFreeSpace()
        {
            long result;

            if (_driveInfo.IsReady)
            {
                result = _driveInfo.TotalFreeSpace;
            }
            else
            {
                throw new Exception($"Drive {_driveInfo.Name} is not ready.");
            }

            return result;
        }
        public long GetUsedSpace()
        {
            return GetTotalSize() - GetTotalFreeSpace();
        }

        public string GetDriveFormat()
        {
            string result;

            if (_driveInfo.IsReady)
            {
                result = _driveInfo.DriveFormat;
            }
            else
            {
                throw new Exception($"Drive {_driveInfo.Name} is not ready.");
            }

            return result;
        }
        #endregion

    }
}
