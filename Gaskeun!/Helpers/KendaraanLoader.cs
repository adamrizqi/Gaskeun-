using System.Collections.Generic;
using System.Windows.Forms;
using Gaskeun_.Models;
using Gaskeun_.Controller;
using Gaskeun_.View;

namespace GasKeun.Helpers
{
    public class KendaraanLoader
    {
        public static void LoadKendaraan(Control container, List<Kendaraan> listKendaraan)
        {
            foreach (var kendaraan in listKendaraan)
            {
                Card card = new Card();
                card.SetKendaraan(kendaraan);
                container.Controls.Add(card);
            }
        }
    }
}
