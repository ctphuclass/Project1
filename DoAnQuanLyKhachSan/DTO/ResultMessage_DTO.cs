using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ResultMessage_DTO
    {
        public string ResultCode_NV { get; set; }
        public string ResultMessage_NV { get; set; }
        public string ResultCode_DV { get; set; }
        public string ResultMessage_DV { get; set; }
        public string ResultCode_P { get; set; }
        public string ResultMessage_P { get; set; }
        public string ResultCode_KH { get; set; }
        public string ResultMessage_KH { get; set; }

        public ResultMessage_DTO()
        {
            ResultCode_NV = "-1";
            ResultMessage_NV = "defaul failed ";
            ResultCode_DV = "-1";
            ResultMessage_DV = "defaul failed ";
            ResultCode_P = "-1";
            ResultMessage_P = "defaul failed ";
            ResultCode_KH = "-1";
            ResultMessage_KH = "defaul failed ";
        }

    }
}
