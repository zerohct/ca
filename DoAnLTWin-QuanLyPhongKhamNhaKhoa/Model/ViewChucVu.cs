﻿using System;
using System.Collections.Generic;

namespace DoAnLTWin_QuanLyPhongKhamNhaKhoa.Model1;

public partial class ViewChucVu
{
    public int MaCv { get; set; }

    public string Tencv { get; set; } = null!;

    public string MoTa { get; set; } = null!;

    public decimal TienLuong { get; set; }
}
