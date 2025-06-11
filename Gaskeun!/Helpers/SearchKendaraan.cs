using Gaskeun_.View;

namespace GasKeun.Helpers
{
    public static class KendaraanFilter
    {
        public static void FilterKendaraan(FlowLayoutPanel flowkendaraan, string keyword)
        {
            foreach (Control control in flowkendaraan.Controls)
            {
                if (control is Card c)
                {
                    c.Visible = string.IsNullOrEmpty(keyword) || c.NamaKendaraan.ToLower().Contains(keyword);
                }
            }
        }
    }
}


