using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan_DTO
{
    public class ResultMessageBO
    {
        public int ResultCode { get; set; }
        public string ResultMessage { get; set; }
        public ResultMessageBO()
        {
            ResultCode = -1;
            ResultMessage = "DEFAULT ERROR";
        }
    }
}
