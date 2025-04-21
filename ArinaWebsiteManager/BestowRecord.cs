using Aritiafel.Organizations.RaeriharUniversity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArinaWebsiteManager
{
    public class BestowRecord
    {
        public long ID { get; set; } = 0;
        public string PersonID { get; set; } = "";
        public string BestowerID { get; set; } = "";
        public int MoralRank { get; set; } = 0;
        public string BestowDateTime { get; set; } = ArDateTime.Now.ToStandardString();
        public string Reason { get; set; } = "初評定";        
        public string Memo { get; set; } = "";

        public BestowRecord()
            : this("", "d5209122-71ca-46e2-956b-ab0b76d9476b")
        { }

        public BestowRecord(string personID)
            : this(personID, "d5209122-71ca-46e2-956b-ab0b76d9476b")
        { }

        public BestowRecord(string personID, string bestowerID)
        {
            PersonID = personID;
            BestowerID = bestowerID;
        }
    }
}
