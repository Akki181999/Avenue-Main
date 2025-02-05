﻿using System;
using System.Runtime.Serialization;
using Atlas.Common.Extensions;

namespace Atlas.Domain.DTO
{
    [Serializable]
    [DataContract]
    public class BankDTO
    {
        [DataMember]
        public Int64 BankId { get; set; }
        [DataMember]
        public Enumerators.General.BankName Type
        {
            get
            {
                return Description.FromStringToEnum<Enumerators.General.BankName>();
            }
            set
            {
                value = Description.FromStringToEnum<Enumerators.General.BankName>();
            }
        }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string UniversalCode { get; set; }
        [DataMember]
        public string SwiftCode { get; set; }

        //Added for SQL Code field
        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public bool IsAEDOEnable { get; set; }
        [DataMember]
        public string FinancialInstitutionId { get; set; }
        [DataMember]
        public Int64 RealPayBankId { get; set; }
    }
}
