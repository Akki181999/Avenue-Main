using Atlas.Domain.DTO.BOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.Nucard
{
   public class NuCardReplacementDTO
    {
       public int CardReplaceId { get; set; }
       public long ClientId { get; set; }
       public string NationalId { get; set; }
       public string OldVoucherNumber { get; set; }
       public string NewVoucherNumber { get; set; }
       public int DebitOrderModeId { get; set; }
       public decimal CardFees  { get; set; }
       public string CellNumber { get; set; }
       public string TerminalId { get; set; }
       public int StatusId { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
       public long Createdby { get; set; }
       public DateTime ChangeStatusdate { get; set; }
       public long Changeby { get; set; }
        public long BranchId { get; set; }
        public long ReasonId { get; set; }
        public List<BOS_ActionDTO> Actions { get; set; }
    }
}
