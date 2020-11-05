using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMecanica.DTOs
{
    public class LoginResultDTO
    {
        public bool Succeeded { get; set; }

        public string Token { get; set; }
    }
}
