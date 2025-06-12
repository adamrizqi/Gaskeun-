using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaskeun_.Models
{
    public class Pelanggan
    {
        public int IdAkun { get; set; }         // dari akun.id_akun
        public string Username { get; set; }    // dari akun.username
        public string Email { get; set; }       // dari akun.email
        public string NoHp { get; set; }        // dari akun.no_hp
        public string Password { get; set; }    // dari akun.password
        public string Status { get; set; }      // dari akun.status
        public string Foto { get; set; }        // dari akun.foto (UserModel)
    }
}