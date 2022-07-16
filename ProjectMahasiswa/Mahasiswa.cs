using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    public class Mahasiswa
    {
        public string NIM { get; set; }
        public string Nama { get; set; }
        public string Kelamin { get; set; }
        public string IPK { get; set; }

        public static implicit operator Mahasiswa(List<Mahasiswa> v)
        {
            throw new NotImplementedException();
        }
        // PERINTAH: lengkapi property class mahasiswa, sesuai petunjuk soal
    }
}
