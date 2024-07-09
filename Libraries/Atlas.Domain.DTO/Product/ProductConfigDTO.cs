using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.Product
{
    public class ProductConfigDTO
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDisplayName { get; set;}
        public bool IsDiscontinued { get; set; }
        public DateTime? DiscontinuedDate { get; set; }
        public long ConfigKeyId { get; set; }
        public string ConfigKeyName { get; set; }
        public string Value { get; set; }
        public bool IsActive { get; set; }
        public string ValueType { get; set; }
        public char? ValueDelimiter { get; set; }
        public bool OverideAllowed { get; set; }
        public string Format { get; set; }
        public string ComparisonOperator { get; set; }
        public string OperationType { get; set; }
        public bool AllowInherit { get; set; }
        public string ErrorMessage { get; set; }
        public string Description { get; set; }
        public int WorkFlowCode { get; set; }
        public bool IsSFXProduct { get; set; }
        public bool IsFlashLoan { get; set; }
    }
}
