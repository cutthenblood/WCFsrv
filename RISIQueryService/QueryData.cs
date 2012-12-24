using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RISIQueryService
{
    [DataContract]
   public class QueryData
    {
            [DataMember]
            public string Name { get; set; }
            [DataMember]
            public string MNN { get; set; }
            [DataMember]
            public string Producer { get; set; }
            [DataMember]
            public string FarmGroup { get; set; }
            [DataMember]
            public string Lform { get; set; }
            [DataMember]
            public string Id_goods { get; set; }
            [DataMember]
            public Dictionary<string, string> values { get; set; }

       
    }
}
