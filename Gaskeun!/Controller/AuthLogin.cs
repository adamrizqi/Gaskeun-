using Gaskeun_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Gaskeun_.Helpers;

namespace Gaskeun_.Controller
{
    public class AuthLogin
    {
        AdminContext adminContext = new AdminContext();
        PelangganContext pelangganContext = new PelangganContext();

        public bool LoginAdmin(string username, string password)
        {
            return adminContext.CekAdmin(username, password);
        }

        public bool LoginPelanggan(string username, string password)
        {
            int idPelanggan = pelangganContext.CekPelanggan(username, password);

            if (idPelanggan > 0) 
            {
                Session.CurrentUserId = idPelanggan;
                return true;
            }
            else
            {
                return false; 
            }
        }
    }
}
