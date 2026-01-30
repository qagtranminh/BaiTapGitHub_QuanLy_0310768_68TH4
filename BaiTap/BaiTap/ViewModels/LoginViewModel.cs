using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap.ViewModels
{
    internal class LoginViewModel
    {
       public string Username { get; set; }
        public string Password { get; set; }
        public  bool IsLoggedIn { get; set; }
    }
}
