using DoAnLTWin_QuanLyPhongKhamNhaKhoa.Form;
using DoAnLTWin_QuanLyPhongKhamNhaKhoa.Model1;
using DoAnLTWin_QuanLyPhongKhamNhaKhoa.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DoAnLTWin_QuanLyPhongKhamNhaKhoa.View.userControl
{
    /// <summary>
    /// Interaction logic for uc_qlphieuluong.xaml
    /// </summary>
    public partial class uc_hoadon : UserControl
    {
        private DaphongkhamnhakhoaContext context;
        public uc_hoadon()
        {
            InitializeComponent();
            context = new DaphongkhamnhakhoaContext();
            LoadHoaDon();
        }
        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            
        }
        public void LoadHoaDon()
        {
            var query = from dv in context.Dichvus
                        select new Dichvu
                        {
                           MaDv = dv.MaDv,
                           TenDv = dv.TenDv,    
                           Dvt = dv.Dvt,    
                           Sl = dv.Sl,
                        };
            DataGridHoaDon.ItemsSource = query.ToList();
        }

        private void txtSDT_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
