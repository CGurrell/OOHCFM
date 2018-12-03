using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOHCFMWebsite.Data.Interfaces
{
    public interface ICFMDataRetriever
    {
        void ExtractJsonFilesFromZip(string fileStream);
    }
}
