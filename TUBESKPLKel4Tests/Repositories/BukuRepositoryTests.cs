using Microsoft.VisualStudio.TestTools.UnitTesting;
using TUBESKPLKel4.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUBESKPLKel4.Model;
using System.Reflection;

namespace TUBESKPLKel4.Repository.Tests
{
    [TestClass()]
    public class BukuRepositoryTests
    {
        public BukuRepository _bukuRepository;
        [TestInitialize]
        public void Init()
        {
            _bukuRepository = new BukuRepository();

        }
        [TestMethod()]
        public void getAllBukuTest()
        {
            List<Buku> listBuku = _bukuRepository.getAllBuku();

            Assert.IsNotNull(listBuku);

        }

        [TestMethod()]
        public void getBukuByKodeTest()
        {
            Buku buku = _bukuRepository.getBukuByKode(4);


            Assert.IsNotNull(buku);



        }
    }
}