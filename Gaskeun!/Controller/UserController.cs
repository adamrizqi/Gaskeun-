using Gaskeun_.Model;
using Gaskeun_.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaskeun_.Controller
{
    public class UserController
    {
        private UserModel model = new UserModel();

        public DataRow LoadUser(int id)
        {
            return model.GetUser(id);
        }
        public void UpdateUserImage(int userId, string imageUrl)
        {
            model.UpdateUserImage(userId, imageUrl);
        }

        public DataTable GetHistoryTransaksi(int userId)
        {
            return model.GetHistoryTransaksi(userId);
        }

        public string GetUserPhoto(int userId)
        {
            var row = model.GetUser(userId);
            return row != null && row["foto"] != DBNull.Value ? row["foto"].ToString() : null;
        }

    }
}
