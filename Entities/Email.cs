using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailProject.DataLayer.Entities
{
    public class Email : BaseEntity
    {
        public string From { get; set; }

        public string To { get; set; }

        public string? CC { get; set; }

        public string? Subject { get; set; }

        public string ComposeEmail { get; set; }

        public bool IsSend { get; set; }
        public DateTime? SendDate { get; set; }
    }
}
