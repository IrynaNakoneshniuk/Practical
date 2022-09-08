using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using System.Runtime.Serialization;
using static System.Console;

namespace PenaltiesAccounting
{
    [Serializable]
    internal class Chek: ISerializable
    {
        public long? IdentifyCode { get; set; }
        public DateTime DateTime { get; set; }
        public string ? NumberBaseDocument { get; set; }
        public double? Sum { get; set; }
        public string? Status { get; set; }
        public string? BankDetails { get; set; }
        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
         {
            info.AddValue("Date: ", DateTime);
            info.AddValue("Number of base document: ", NumberBaseDocument);
            info.AddValue("Sum: ", Sum);
            info.AddValue("Status:", Status);
            info.AddValue("Bank Details", BankDetails);
            info.AddValue("IdentifyCode", IdentifyCode);
        }
       

    }
}
