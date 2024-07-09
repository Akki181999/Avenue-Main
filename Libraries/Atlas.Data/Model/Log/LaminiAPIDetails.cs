using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.Model.Log
{
    //LamininApi
    public class LaminiAPIDetails : XPLiteObject
    {
        private int _laminiAPIDetailId;
        [Key(AutoGenerate = true)]
        public int LaminiAPIDetailId
        {
            get
            {
                return _laminiAPIDetailId;
            }
            set
            {
                SetPropertyValue("IntegrationLogId", ref _laminiAPIDetailId, value);
            }
        }

        private int? _applicationId;
        [Persistent]
        public int? ApplicationId
        {
            get
            {
                return _applicationId;
            }
            set
            {
                SetPropertyValue("IntegrationLogId", ref _applicationId, value);
            }
        }

        private string _idNumber;
        [Persistent]
        public string IDNumber
        {
            get => _idNumber;
            set => SetPropertyValue(nameof(IDNumber), ref _idNumber, value);
        }

        private string _apiType;
        public string APIType
        {
            get
            {
                return _apiType;
            }
            set
            {
                SetPropertyValue(nameof(APIType), ref _apiType, value);
            }
        }

        private int _clientId;
        [Persistent]
        public int ClientId
        {
            get
            {
                return _clientId;
            }

            set
            {
                SetPropertyValue(nameof(ClientId), ref _clientId, value);
            }
        }

        public LaminiAPIDetails() : base() { }
        public LaminiAPIDetails(Session session) : base(session) { }
    }
}
