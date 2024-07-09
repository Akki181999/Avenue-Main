using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.Account
{
   public class ACC_SchedulesDTO
    {

        public Int32? Installment_SrNo
        {
            get;set;
        }

       

        public Int32? Noofdays
        {
            get; set;
        }

       
        public Decimal? DeferredAmount
        {
            get; set;

        }

      

        public Decimal? Interest
        {
            get; set;
        }

       

        public Decimal? Servicefee
        {
            get; set;
        }

        

        public Decimal? Premium
        {
            get; set;
        }

       

        public Decimal? Installment
        {
            get; set;
        }

      

        public Decimal? Totalinstallment
        {
            get; set;
        }

       

        public Decimal? Remaningbalance
        {
            get; set;
        }

       

        public DateTime? Duedate
        {
            get; set;
        }

        

        public Decimal? VAP
        {
            get; set;
        }


        public Decimal? Paid_Installment
        {
            get; set;
        }

       
        public Int64 ACC_ScheduleId
        {
            get; set;
        }
       

        public Decimal? VAP_Funeral
        {
            get; set;
        }
       

        public Decimal? VAP_Tax
        {
            get; set;
        }
        

        public Decimal? VAP_Other
        {
            get; set;
        }
        public String DebitOrderStatus { get; set; } = "CREATED";
    }
}
