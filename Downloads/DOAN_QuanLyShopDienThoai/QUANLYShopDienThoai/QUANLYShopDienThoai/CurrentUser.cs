using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYShopDienThoai
{
    
    
        public static class CurrentUser
        {
            public static int MaNV { get; set; }
            public static string TenNV { get; set; }
            public static string Role { get; set; } // "Admin" hoặc "NhanVien"
            public static bool IsLoggedIn { get; set; } = false;
        }
}

