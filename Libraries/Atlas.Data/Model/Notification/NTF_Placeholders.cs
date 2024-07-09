using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Notification
{
    public class NTF_Placeholders : XPLiteObject
    {
        [Key(AutoGenerate = true)]
        public int NTF_PlaceholdersId { get; set; }
        [Persistent]
        public string Name { get; set; }
        [Persistent]
        public string Descriptions { get; set; }

        #region Constructors
        public NTF_Placeholders() : base() { }
        public NTF_Placeholders(Session session) : base(session) { }
        #endregion
    }
}
