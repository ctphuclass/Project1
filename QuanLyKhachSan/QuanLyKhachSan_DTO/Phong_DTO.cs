using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan_DTO
{
    public class Phong_DTO
    {
        private string maphong;
        private string tinhtrang;
        public Phong_DTO() { }
        public Phong_DTO(DataRow row)
        {
            this.Maphong = row["MaPhong"].ToString();
            this.Tinhtrang = row["TinhTrang"].ToString();
        }


        public string Maphong
        {
            get
            {
                return maphong;
            }

            set
            {
                maphong = value;
            }
        }

        public string Tinhtrang
        {
            get
            {
                return tinhtrang;
            }

            set
            {
                tinhtrang = value;
            }
        }
    }
}
