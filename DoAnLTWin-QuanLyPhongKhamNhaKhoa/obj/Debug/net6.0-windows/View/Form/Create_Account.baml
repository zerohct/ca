   M S B A M L   `   `   `  ����[  WDoAnLTWin-QuanLyPhongKhamNhaKhoa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullu?clr-namespace:DoAnLTWin_QuanLyPhongKhamNhaKhoa.View.userControl1DoAnLTWin_QuanLyPhongKhamNhaKhoa.View.userControl  5   	   :    4DoAnLTWin_QuanLyPhongKhamNhaKhoa.Form.Create_Account   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   Huc?clr-namespace:DoAnLTWin_QuanLyPhongKhamNhaKhoa.View.userControl  5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
     � Title$  Create_Account��5	   	   $	��450��6    $	��750��6-   
������  � WindowStyle$
 None=�5
   "      MaterialDesignBody#���   5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont#���  5       � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency$
 True��6.   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��350 �6   �� 5      $��* �6   .+�5   
   �� ���#99FFFF �� Padding$ 30q�6&    �� CornerRadius$ 	30,0,0,30��63   ._�5      �� $��Center=�6   .+�5      �� $��/image/Logo/logo.png��6   $	��180��66   $	��180��6B   $��0,0,0,40q�6O   �� 5      $*��$Create an account 
for your employee��6   	 �� TextAlignment$	 Center=�6M   $��SemiBold"�5      $��28(�62   
���   �6@   �� 5        AngleRightButton#��[ 6   $��10q�6E   .��5       "  FontAwesome.WPF.ImageAwesome  
   Icon$
 
AngleRight=�6&   $��25��68   $��25��6C      
Foreground �#99ffff$��3,0,0,0q�5!   &   5"      5#      5%      �� 5(   
   -   5        $��1��5(      $ 20q�6!   ���#ffffff$ 	0,30,30,0��6C   ._�5*      � .+�5+      � .+�5,      �� -   5        $��/image/icon/close.png��5,      $��0,4,5,0q�6;   $��25��6L     IconApp#��[ 6W   6x   5-      �� 5.      -   5        $��/image/icon/minus.png��5.      $��0,7,40,0q�67   $��25��6I   #��[ 6T   6v   � 50      $��Center=�6   $��Center=�62    51      �� 52      $	��150 �6+   �� 53      $��* �6+    � RowDefinitions 56      �� 57      $
��Auto �6(   �� 58      $
��Auto �6(   �� 59      $
��Auto �6(   �� 5:      $
��Auto �6(   �� 5;      $
��Auto �6(   .+�5=      �� $��1��6    $��Tên nhân viên��6-     text#��[ 6B   �� 5>      $��2��6    $��Tên đăng nhập��6-   #��[ 6B   �� 5?      $��3��6    $��Mật khẩu��6-   #��[ 6=   � 5@      $��25��6   $	��153��6'   $	��Top=�63   $
��Left=�6K   $��1��6g   $��1��6w   .+�5A      �� -   5         ��Name$ 
cbnhanvien��5A   #   $��0q�68   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Chọn nhân viên��5B   %    " MaterialDesignOutlinedComboBox#��[ 5C   %   $��25��5D   %   $	��150��61   5E      � 5F      $��2��6   $��1��6(   $��30��68   $	��150��6D   $	��Top=�6P   $
��Left=�6i   $��0 20 0 0q�6�   .+�5G      �� -   5         ��Name$ txtUser��5G   #   $��0q�65   $ Nhập tên đăng nhập��5H   %    % !MaterialDesignFloatingHintTextBox#��[ 5I   %   5J      � 5K      $��3��6   $��1��6(   $��30��68   $	��150��6D   $	��Top=�6P   $
��Left=�6i   $��0 20 0 0q�6�   .+�5L      �� -   5        $ txtPass��5L   #   $��0q�65   $ Nhập tên đăng nhập��5M      #��[ 5N      5O      � 5Q      $��1��6   $��5��6+   $��0,40,0,0q�68    5R      �� 5S      $��* �6/   �� 5T      $��* �6/   .+�5V      �� -   5         ��Name$ 	btnCancer��5V   h   $��Cancer��6!   $��0,0,10,0q�62     
ButtonMain#��[ 6D   6{   �� 5W      -   5        $ btnSave��5W   {   $
��Save��6!   $��10,0,0,0q�60   $��1��6B     buttonMainGreen#��[ 6R   6�   5X      5Z      5[      5\      5]      5^      