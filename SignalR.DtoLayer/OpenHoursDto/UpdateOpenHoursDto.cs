using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.OpenHoursDto
{
    public class UpdateOpenHoursDto
    {
        public int OpenHoursId { get; set; }
        public string Day { get; set; }
        public string Hours { get; set; }
    }
}
