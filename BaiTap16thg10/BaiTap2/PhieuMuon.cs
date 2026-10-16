using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace BaiTap2
{
    public class PhieuMuon : INotifyPropertyChanged
    {
        private string maPhieu = "";
        private string maSinhVien = "";
        private string hoTenSinhVien = "";
        private string thietBi = "";
        private int soLuong = 1;
        private DateTime ngayMuon = DateTime.Today;
        private DateTime hanTra = DateTime.Today.AddDays(7);
        private DateTime? ngayTraThucTe;

        public string MaPhieu
        {
            get => maPhieu;
            set => SetField(ref maPhieu, value);
        }
        public string MaSinhVien
        {
            get => maSinhVien;
            set => SetField(ref maSinhVien, value);
        }
        public string HoTenSinhVien
        {
            get => hoTenSinhVien;
            set => SetField(ref hoTenSinhVien, value);
        }
        public string ThietBi
        {
            get => thietBi;
            set => SetField(ref thietBi, value);
        }
        public int SoLuong
        {
            get => soLuong;
            set => SetField(ref soLuong, value);
        }
        public DateTime NgayMuon
        {
            get => ngayMuon;
            set
            {
                if (SetField(ref ngayMuon, value))
                    OnPropertyChanged(nameof(TinhTrang));
            }
        }
        public DateTime HanTra
        {
            get => hanTra;
            set
            {
                if (SetField(ref hanTra, value))
                    OnPropertyChanged(nameof(TinhTrang));
            }
        }
        public DateTime? NgayTraThucTe
        {
            get => ngayTraThucTe;
            set
            {
                if (SetField(ref ngayTraThucTe, value))
                    OnPropertyChanged(nameof(TinhTrang));
            }
        }
        public string TinhTrang
        {
            get
            {
                if (NgayTraThucTe.HasValue)
                    return "Đã trả";

                if (HanTra.Date < DateTime.Today)
                    return "Quá hạn";

                return "Đang mượn";
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        private bool SetField<T>(
            ref T field,
            T value,
            [CallerMemberName] string? propertyName = null)
        {
            if (Equals(field, value))
                return false;

            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        private void OnPropertyChanged(string? propertyName)
        {
            PropertyChanged?.Invoke(
                this,
                new PropertyChangedEventArgs(propertyName));
        }
    }
}
