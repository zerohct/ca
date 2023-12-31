﻿using DoAnLTWin_QuanLyPhongKhamNhaKhoa.Form;
using DoAnLTWin_QuanLyPhongKhamNhaKhoa.Model1;
using DoAnLTWin_QuanLyPhongKhamNhaKhoa.ModelView;
using System;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace DoAnLTWin_QuanLyPhongKhamNhaKhoa.View.userControl
{
    /// <summary>
    /// Interaction logic for uc_ThemNCC.xaml
    /// </summary>
   
    public partial class uc_ThemNCC : UserControl
    {
        private DaphongkhamnhakhoaContext context;
        public uc_ThemNCC()
        {
            InitializeComponent();
            context = new DaphongkhamnhakhoaContext();
        }
        public void LoadNhaCungCap()
        {
            var ncc = context.Nhacungcaps.ToList();
            dataaGridNCC.ItemsSource = ncc;

        }
        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            NhaCungCap ncc  = new NhaCungCap();
            ncc.Closed += (s, args) =>
            {
                LoadNhaCungCap();
            };
            ncc.Show();
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            var row = dataaGridNCC.SelectedItem as Nhacungcap;
            if (row == null) return;
            NhaCungCap ncc = new NhaCungCap(row);
            ncc.Closed += (s, args) =>
            {
                LoadNhaCungCap();
            };
            ncc.Show();
        }
        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButton.OK);
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            var selectedNCC = dataaGridNCC.SelectedItem as Nhacungcap;
            if (selectedNCC != null)
            {
                try
                {
                    var NCCToDelete = context.Nhacungcaps.FirstOrDefault(ncc =>ncc.MaNcc == selectedNCC.MaNcc);

                    if (NCCToDelete != null)
                    {
                        context.Nhacungcaps.Remove(NCCToDelete);
                        context.SaveChanges();
                        LoadNhaCungCap();
                    }
                    else
                    {
                        ShowErrorMessage("Không thể tìm thấy nhà cung cấp để xóa.");
                    }
                }
                catch (Exception ex)
                {
                    ShowErrorMessage("Không thể xóa nhà cung cấp: " + ex.Message);
                }
            }
            else
            {
                ShowErrorMessage("Chọn một nhà cung cấp để xóa.");
            }
        }
    }
}
