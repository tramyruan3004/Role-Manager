using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentTreeViewV2.Classes
{
    [Serializable]
    internal static class General
    {
        public static string GenerateUUID()
        {
            Guid uuid = Guid.NewGuid();
            string uuidString = uuid.ToString();

            return uuidString;
        } // end of GenerateUUID method


    }//end of General class
}//end of namespace
