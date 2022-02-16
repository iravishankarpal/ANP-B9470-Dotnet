using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfTst
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITst" in both code and config file together.
    [ServiceContract]
    public interface ITst
    {
        [OperationContract]
        int CalculateSI(int p, int r, int t);
        [OperationContract]
        DataTable GetRecordList();
      
    }
}
