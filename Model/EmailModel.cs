using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailProject.DataLayer.Model
{
    public class EmailModel
    {
        public string To { get; set; }

        public string? CC { get; set; }

        public string? Subject { get; set; }

        public string ComposeEmail { get; set; }
    }
}
