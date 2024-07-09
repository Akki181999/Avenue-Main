using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Product
{
   public class PRD_Documents : XPLiteObject
    {
        [Key(AutoGenerate = true)]
        public Int64 DocumentId { get; set; }
        [Persistent]
        public string DocumentName { get; set; }
        [Persistent]
        public string DocumentType { get; set; }
        [Persistent]
        public string UploadPath { get; set; }
        [Persistent]
        public string DisplayDocumentName { get; set; }
        [Persistent]
        public Int64 SizeInBytes { get; set; }

        [Persistent]
        public DateTime CreatedDate { get; set; }

        [Persistent]
        public DateTime? LastUpdatedDate { get; set; }

        [Persistent]
        public Int64 CreatedBy { get; set; }

        [Persistent]
        public Int64 LastUpdatedBy { get; set; }

        [Persistent]
        public bool IsActive { get; set; }

        #region Constructors
        public PRD_Documents() : base() { }
        public PRD_Documents(Session session) : base(session) { }
        #endregion
    }
}
