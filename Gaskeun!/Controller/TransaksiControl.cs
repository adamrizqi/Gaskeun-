using Gaskeun_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaskeun_.Controller
{
    public class TransaksiControl
    {
        TransaksiContext transaksiContext;
        public TransaksiControl()
        {
            transaksiContext = new TransaksiContext();
        }
        public List<Transaksi> ReadTransaksi()
        {
            return transaksiContext.Read();
        }
        public bool UpdateTransaksi(Transaksi transaksi)
        {
            return transaksiContext.Update(transaksi);
        }
        public bool AddTransaksi(Transaksi transaksi)
        {
            return transaksiContext.Insert(transaksi);
        }
    }
}
