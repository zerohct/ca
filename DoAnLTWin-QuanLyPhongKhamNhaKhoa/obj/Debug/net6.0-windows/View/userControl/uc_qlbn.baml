   M S B A M L   `   `   `  ����[  WDoAnLTWin-QuanLyPhongKhamNhaKhoa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullu?clr-namespace:DoAnLTWin_QuanLyPhongKhamNhaKhoa.View.userControl1DoAnLTWin_QuanLyPhongKhamNhaKhoa.View.userControl  5      ?    9DoAnLTWin_QuanLyPhongKhamNhaKhoa.View.userControl.uc_qlbn   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Nuc?clr-namespace:DoAnLTWin_QuanLyPhongKhamNhaKhoa.View.userControl     5      
�������.��5	      (� .��5
   
   �   � RowDefinitions  5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $��* �6    �� 5      $��50 �6    �� 5      $��30 �6    .+�5      � $��0��6   .+�5      �� $��Thông tin Bệnh nhân��6      textfont#��[  67   5      � 5      $��1��6    � ColumnDefinitions 5      �� 5      $	��100 �6'   �� 5      $	��170 �6'   �� 5      $	��170 �6'   �� 5      $	��170 �6'   �� 5      $	��170 �6'   .+�5      � $��1��6   .+�5      �� -   5         ��Name$ btnThem��5   Y   $��Thêm Bệnh nhân��6     	AppButton#��[ 66   $
��Left=�6�   $��
10,30,0,10q�6�   $	��150��6�   5      � 5       $��2��6   .+�5!      �� -   5        $ btnSua��5!   X   $��Sửa Bệnh nhân��6   #��[ 65   $��30��6}   $��
10,30,10,0q�6�   $	��Top=�6�   5"      � 5#      $��3��6   .+�5$      �� -   5        $ btnXoa��5$   X   $��Xóa Bệnh nhân��6   #��[ 65   $	��NaN��6h   $��10,30,10,10q�6u   6�   5%      � 5&      $��4��6   .+�5'      �� $��In Thông Tin��6   #��[ 64   5(      5)      � 5*      $��2��6    5+      �� 5,      $
��161* �6'   �� 5-      $
��229* �6'   .+�5/      &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridBenhNhan��5/      $
��Left=�65   $��15,0,0,0q�6P   $��Center=�6b      SelectionMode$ Extended=�6}   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6�      SelectionUnit$ FullRow=�50      $	��750��65   $	��300��6A   $
��Auto=�6N   $
��Auto=�6�      AutoGenerateColumns$ False��6�      
IsReadOnly$
 True��6�   $��2 0 2 2q�6�   
���   �	   GridLinesVisibility$		 All=�6  $��2��6&  
   Columns
 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã Bệnh Nhân��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6C   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6O   �� *MaBn+  54      $ Tên Bệnh Nhân��6-   $	 120 6D    6P   �� *TenBn+  55      $ 
Ngày Sinh��6-   $	 100 6@    6L   �� *
NgaySinh+ �� StringFormat$ 
dd/MM/yyyy��  56      $ Giới Tính��6-   $ 70 6@    6K   �� *
GioiTinh+  57      $ Địa Chỉ��6-   $	 100 6>    6J   �� *DiaChi+  58      $ Email��6-   $	 165 6<    6H   �� *Email+  59      $
 SĐT��6-   $	 115 6:    6F   �� *Sdt+5=      5?      � 5@      $��3��6   $��Right=�6    .+�5A      E   ?DoAnLTWin_QuanLyPhongKhamNhaKhoa.View.userControl.navigationBar  5B      5C      5D      5E      