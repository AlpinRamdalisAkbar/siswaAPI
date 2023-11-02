using Microsoft.EntityFrameworkCore;
using siswaAPI.Models;

namespace siswaAPI.Data
{
    public class DbContextSiswa : DbContext
    {
        public DbContextSiswa(DbContextOptions<DbContextSiswa> options) : base(options)
        {
        }

        public DbSet<Siswa> SISWA { get; set; }
    }
}
