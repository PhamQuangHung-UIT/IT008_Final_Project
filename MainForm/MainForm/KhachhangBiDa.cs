namespace MainForm
{
    public class KhachhangBiDa
    {
        public KhachhangBiDa() { }

        public static Khachhang? GetKhachhang(int idkh)
        {
            string commandText = $"SELECT * FROM KHACHHANG WHERE IDKH = {idkh}";
            var data = FMain.GetSqlData(commandText);
            if (data.Rows.Count > 0) 
            {
                string? hoten = data.Rows[0]["HOTEN"].ToString();
                string? dchi = data.Rows[0]["DCHI"].ToString();
                string? sodt = data.Rows[0]["SODT"].ToString();
                Khachhang khachhang = new(idkh, hoten, dchi, sodt);
                return khachhang;
            }
            return null;
        }
    }
}
