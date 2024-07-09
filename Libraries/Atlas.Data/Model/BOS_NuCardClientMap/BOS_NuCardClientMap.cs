using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.BOS_NuCardClientMap
{
    public sealed class BOS_NuCardClientMap: XPLiteObject
    {
       
        private Int64 _NuCardClientMapId;
        [Key(AutoGenerate = false)]
        public Int64 NuCardClientMapId
        {
            get { return _NuCardClientMapId; }
            set { SetPropertyValue("NuCardClientMapId", ref _NuCardClientMapId, value); ; }
        }

        private Int64 _NuCardId;

        public Int64 NuCardId
        {
            get { return _NuCardId; }
            set { SetPropertyValue("NuCardId", ref _NuCardId, value); }
        }
        private Int64 _AccountId;

        public Int64 AccountId
        {
            get { return _AccountId; }
            set { SetPropertyValue("AccountId", ref _AccountId, value); }
        }
        private Int64 _ApplicationId;

        public Int64 ApplicationId
        {
            get { return _ApplicationId; }
            set { SetPropertyValue("ApplicationId", ref _ApplicationId, value); }
        }
        private Int64 _ClientId;

        public Int64 ClientId
        {
            get { return _ClientId; }
            set { SetPropertyValue("ClientId", ref _ClientId, value); }
        }

        [Persistent("AllocationDate")]
        public DateTime AllocationDate { get; set; }

        [Persistent("NationalID")]
        public string NationalId { get; set; }

        [Persistent("AccountCardFirstName")]
        public string AccountCardFirstName { get; set; }

        [Persistent("AccountCardSurname")]
        public string AccountCardSurname { get; set; }

        [Persistent("AccountCardCellphone")]
        public string AccountCardCellphone { get; set; }

        [Persistent("AllocatedBy")]
        public Int64 AllocatedBy { get; set; }

        #region Constructors

        public BOS_NuCardClientMap() : base() { }
        public BOS_NuCardClientMap(Session session) : base(session) { }

        #endregion

    }
}
