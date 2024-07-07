using System.Collections.Generic;

namespace ModSync
{
    public class ModFile(uint crc, bool nosync = false)
    {
        public readonly uint crc = crc;
        public readonly bool nosync = nosync;
    }

    public class Persist
    {
        public Dictionary<string, ModFile> previousSync = [];
        public string downloadDir = string.Empty;
        public List<string> filesToDelete = [];
    }
}