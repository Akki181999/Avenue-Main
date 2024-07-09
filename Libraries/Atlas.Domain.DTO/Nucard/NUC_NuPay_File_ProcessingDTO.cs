using Atlas.Domain.DTO.BOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.Nucard
{
    public class NUC_NuPay_File_ProcessingDTO
    {
        public Int64 Id { get; set; }
        public String Name { get; set; }
        public String Path { get; set; }
        public DateTime? ProcessingDate { get; set; }
        public Int64 ProcessedBy { get; set; }
        public bool IsProcessed { get; set; }
        public int TotalRecords { get; set; }
        public int ValidRecords { get; set; }
        public int InvalidRecords { get; set; }
        public string FileArchives { get; set; }
        public List<BOS_ActionDTO> Actions { get; set; }
    }
}
