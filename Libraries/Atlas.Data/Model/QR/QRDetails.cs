using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.QR
{
    public class QRDetails:XPLiteObject
    {
        [Key(AutoGenerate = true)]
        public Int64 QRId { get; set; }
        [Persistent]
        public Int64 ApplicationId { get; set; }
        [Persistent]
        public Int64 ClientId { get; set; }
        [Persistent]
        public DateTime CreatedDate { get; set; }
        [Persistent]
        public Int64 CreatedBy { get; set; }
        [Persistent]
        public DateTime UpdatedDate { get; set; }
        [Persistent]
        public String Request { get; set; }
        [Persistent]
        public String Response { get; set; }
        [Persistent]
        public String FileName { get; set; }
        [Persistent]
        public String QRType { get; set; }
        [Persistent]
        public String DocumentName { get; set; }
        #region Constructor
        public QRDetails() : base() { }
        public QRDetails(Session session) : base(session) { }
        #endregion
    }
}
