   M S B A M L   `   `   `  ����[  WDoAnLTWin-QuanLyPhongKhamNhaKhoa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullu?clr-namespace:DoAnLTWin_QuanLyPhongKhamNhaKhoa.View.userControl1DoAnLTWin_QuanLyPhongKhamNhaKhoa.View.userControl  5      @    :DoAnLTWin_QuanLyPhongKhamNhaKhoa.View.userControl.uc_Thuoc   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Qlocal?clr-namespace:DoAnLTWin_QuanLyPhongKhamNhaKhoa.View.userControl     5      
�������.��5	      (� .��5
   
   �   � RowDefinitions  5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $��* �6    �� 5      $��50 �6    �� 5      $��30 �6    .+�5      � $��0��6   .+�5      �� $��Thông tin thuốc ��6      textfont#��[  64   5      � 5      $��1��6    � ColumnDefinitions 5      �� 5      $��70 �6'   �� 5      $	��170 �6'   �� 5      $	��170 �6'   �� 5      $	��170 �6'   �� 5      $	��170 �6'   .+�5      � $��1��6   .+�5      �� -   5         ��Name$ btnThem��5   V   $��Thêm Thuốc��6     	AppButton#��[ 62   6g   5      � 5       $��2��6   .+�5!      �� -   5        $ btnSua��5!   T   $��Sửa Thuốc��6   #��[ 61   6d   5"      � 5#      $��3��6   .+�5$      �� -   5        $ btnXoa��5$   T   $��Xóa Thuốc��6   #��[ 61   6d   5%      � 5&      $��4��6   .+�5'      �� $��In Thông Tin Thuốc��6   #��[ 6:   5(      5)      � 5*      $��2��6   .+�5+      &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridThuoc��5+      $��Center=�62   $��Center=�6O   $	��808��5,      $	��300��6   $
��Auto=�6(   $
��Auto=�6Z      AutoGenerateColumns$ False��6�      
IsReadOnly$
 True��6�   $��2 0 2 2q�6�   
���   �   GridLinesVisibility$	 All=�6�      Columns 5.      0  *System.Windows.Controls.DataGridTextColumn  5/      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 23 6-     50      	   Header$	 Mã Thuốc��6-   $ 80 6?   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6J   �� *	MaThuoc+  51      $	 Tên thuốc��6-   $	 150 6@   
 6L   �� *
TenThuoc+  52      $	 Mô tả��6-   $	 170 6<   
 6H   �� *Mota+  53      $
	 Giá��6-   $ 80 6:   
 6E   �� *Gia+  54      $	 Mã dạng thuốc��6-   $	 100 6D   
 6P   �� *TenDt+  55      $	 Nhà cung cấp��6-   $	 100 6C   
 6O   �� *TenNcc+  56      $	 Hạn sử dụng��6-   $	 100 6B   
 6N   �� *Hsd+ �� StringFormat$ 
dd/MM/yyyy��5:      5<      � 5=      $��3��6   $��Right=�6    .+�5>      E   ?DoAnLTWin_QuanLyPhongKhamNhaKhoa.View.userControl.navigationBar  5?      5@      5A      5B      