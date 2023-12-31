﻿using DoAnLTWin_QuanLyPhongKhamNhaKhoa.Form;
using DoAnLTWin_QuanLyPhongKhamNhaKhoa.Model1;
using DoAnLTWin_QuanLyPhongKhamNhaKhoa.ModelView;
using DoAnLTWin_QuanLyPhongKhamNhaKhoa.View.Form;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace DoAnLTWin_QuanLyPhongKhamNhaKhoa.View.userControl
{
    /// <summary>
    /// Interaction logic for uc_dichvu.xaml
    /// </summary>
    public partial class uc_dichvu : UserControl
    {
        private DaphongkhamnhakhoaContext context;
        public uc_dichvu()
        {
            InitializeComponent();
            context = new DaphongkhamnhakhoaContext();
            LoadDichVu();
        }

        public void LoadDichVu()
        {
            var dv = context.Dichvus.ToList();
            DataGridDV.ItemsSource = dv;
        }
        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            ThemDichVu dv = new ThemDichVu();
            dv.Closed += (s, args) =>
            {
                LoadDichVu();
            };
            dv.Show();
        }
        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButton.OK);
        }


        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            var selectedDichVu = DataGridDV.SelectedItem as Dichvu;
            if (selectedDichVu != null)
            {
                try
                {
                    var DichVuDelete = context.Dichvus.FirstOrDefault(dv => dv.MaDv == selectedDichVu.MaDv);

                    if (DichVuDelete != null)
                    {
                        context.Dichvus.Remove(DichVuDelete);
                        context.SaveChanges();
                        LoadDichVu();
                    }
                    else
                    {
                        ShowErrorMessage("Không thể tìm thấy dịch vụ để xóa.");
                    }
                }
                catch (Exception ex)
                {
                    ShowErrorMessage("Không thể xóa dịch vụ: " + ex.Message);
                }
            }
            else
            {
                ShowErrorMessage("Chọn một dịch vụ để xóa.");
            }
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            var row = DataGridDV.SelectedItem as Dichvu;
            if (row == null) return;
            ThemDichVu dv = new ThemDichVu(row);
            dv.Closed += (s, args) =>
            {
                LoadDichVu();
            };
            dv.Show();
        }
    }
}

