using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailProject.DataLayer.Model
{
    public class EmailListModel
    {
        public string To { get; set; }
        public List<EmailListDetail> Details { get; set; }
    }

    public class EmailListDetail
    {
        public string? Subject { get; set; }
        public string? CC { get; set; }
        public string? ComposeEmail { get; set; }
        public DateTime? SendDate { get; set; }
        public string IsSend { get; set; }
    }
}
