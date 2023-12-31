﻿using System;
using System.Collections.Generic;

namespace DoAnLTWin_QuanLyPhongKhamNhaKhoa.Model1;

public partial class Chucvu
{
    public int MaCv { get; set; }

    public string TenCv { get; set; } = null!;

    public string Mota { get; set; } = null!;

    public virtual ICollection<Luong> Luongs { get; set; } = new List<Luong>();

    public virtual ICollection<Nhanvien> Nhanviens { get; set; } = new List<Nhanvien>();
}
