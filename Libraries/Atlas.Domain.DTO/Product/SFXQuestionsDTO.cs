using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Domain.DTO.Product
{
    public class SFXQuestionsDTO
    {
        public long SFXQuestionId { get; set; }
        public string QuestionText { get; set; }
        public string Type { get; set; }
        public string Answer { get; set; }
        public long ApplicationId { get; set; }
        public string NationalId { get; set; }
    }
}
