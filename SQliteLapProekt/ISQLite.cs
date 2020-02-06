using System;
using System.Collections.Generic;
using System.Text;

namespace SQliteLapProekt
{
    public interface ISQLite
    {
        string GetDatabasePath(string filename);
    }
}
