using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.SocialMediaDto
{
    public class ResultSocialMediaDto
    {
        public int SocialMediaId { get; set; }
        public string Platform { get; set; }
        public string Logo { get; set; }
        public string LinkUrl { get; set; }
    }
}
