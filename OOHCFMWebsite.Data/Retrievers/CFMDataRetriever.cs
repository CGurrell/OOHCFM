using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Compression;
using System.IO;
using System.Linq;
using OOHCFMWebsite.Data.Interfaces;

namespace OOHCFMWebsite.Data
{
    public class CFMDataRetriever : ICFMDataRetriever
    {
        public void ExtractJsonFilesFromZip(string fileLocation)
        {
            fileLocation = @"C:\Users\Chris Gurrell\Downloads\Zip";
            DirectoryInfo directoryInfo = new DirectoryInfo(Path.GetFullPath(fileLocation));
            FileInfo fileToDecompress = directoryInfo.GetFiles("*.zip").OrderByDescending(x => x.CreationTime).First();
            ZipFile.ExtractToDirectory(fileToDecompress.FullName, fileLocation + @"\Unzipped-" + DateTime.Now.ToString("yyyy-MM-dd hh-mm-ss"));
        }
    }
}
