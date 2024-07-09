using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.NuCard
{
    public sealed class NUC_NuPay_File_Processing:XPLiteObject
    {
        #region Constructors

        public NUC_NuPay_File_Processing() : base() { }
        public NUC_NuPay_File_Processing(Session session) : base(session) { }

        #endregion
        [Key]
        public Int64 Id { get; set; }
        public String Name { get; set; }
        public String Path { get; set; }
        public DateTime? ProcessingDate { get; set; }
        public Int64 ProcessedBy { get; set; }
        public bool IsProcessed{ get; set; }
        public int TotalRecords { get; set; }
        public int ValidRecords { get; set; }
        public int InvalidRecords { get; set; }
        public string FileArchives { get; set; }
    }
}
