using Microsoft.VisualStudio.TestTools.UnitTesting;
using TUBESKPLKel4.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUBESKPLKel4.Model;

namespace TUBESKPLKel4.Repository.Tests
{
    [TestClass()]
    public class PeminjamanRepositoryTests
    {
        public PeminjamanRepository _peminjamanRepository;
        [TestInitialize]
        public void init()
        {
            _peminjamanRepository = new PeminjamanRepository();
        }
        [TestMethod()]
        public void getAllRiwayatTest()
        {
            List<Peminjaman> x = _peminjamanRepository.getAllRiwayat();
            Assert.IsNotNull(x);
        }

        [TestMethod()]
        public void getPeminjamanByKodeTest()
        {
            Peminjaman x = _peminjamanRepository.getPeminjamanByKode(35);
            Assert.IsNotNull(x);
        }
    }
}