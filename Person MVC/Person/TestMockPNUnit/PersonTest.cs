using System;
//using NUnit.Framework;
using PService;
using PPersistence;
using PDomain;
using Moq;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestMockPNUnit
{
    [TestFixture]
    public class PersonTest
    {
        //[Test]
        //public void CreatePersonTest()
        //{
        //    var mock = new Mock<IRepository<PDomain.Person>>();
        //   // mock.
        //}

        //[Test]
        //public void GetPersonByID()
        //{
        //    const int pId = 200;
        //    var mock = new Mock<IRepository<PDomain.Person>>();
        //    mock.Setup(x => x.GetByID(pId)).Returns(new PDomain.Person());
        //    var repository = mock.Object;
        //    var service = new PersonServices(repository);
        //    var result = service.GetById(pId);

        //    Assert.IsNotNull(result);
        //}
    }
}