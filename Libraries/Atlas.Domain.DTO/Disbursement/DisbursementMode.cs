using Atlas.Domain.DTO.Branch;
using System;
using System.Collections.Generic;

namespace Atlas.Domain.DTO.Disbursement
{
    public class DisbursementMode
    {
        public DisbursementModeDTO LastDisbursementMode { get; set; }
        public List<DisbursementModeDTO> AllowedDisbursementModes { get; set; }
    }
    public class DisbursementRequest
    {
        public int DisbursementModeId { get; set; }
        public int MaxRetryCount { get; set; }
        public int AttemptCount { get; set; }
        public int ApplicationId { get; set; }
        public string ClientIpAddress { get; set; }

    }

    public class RolloverData
    {
        public long RollOverAccountId { get; set; }
        public DateTime RolloverAcceptanceDate { get; set; }
    }

    public class DisbursementStatusModel
    {
        public int ApplicationId { get; set; }
        public int DisbursementModeId { get; set; }

        //public bool DisbursementStatus { get; set; }
        public bool IsIssueInNucardStatus { get; set; }
        public bool IsAmountAlreadyLoadedInNucardStatement { get; set; }

        public string DisbursementStatusMessage { get; set; }
    }
    public class InitiateDisbursementModel
    {
        public int ApplicationId { get; set; }
        public int AccountId { get; set; }
        public int DisbursementModeId { get; set; }
        public string NuCardNumber { get; set; }
        public string DisbursementStatus { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
