using System;
using NUnit.Framework;
using Person;
using System.Web;
using System.Web.Mvc;
using PService;

namespace PersonControllerTest
{
    [TestFixture]
    public class NUnitTest1
    {
        [Test]
        public void GetViewTest_AddNew()
        {
            var controller = new Person.Controllers.PersonsController();
            var result = controller.AddPerson();
            Assert.IsInstanceOf<ViewResult>(result);
        }

        [Test]
        public void GetViewTest_Index()
        {
            var controller = new Person.Controllers.PersonsController();
            var result = controller.Index();
            Assert.IsInstanceOf<ViewResult>(result);
            Assert.IsInstanceOf<System.Collections.Generic.List<PersonViewModel>>(((ViewResult)result).Model);
        }

        [Test]
        public void GetViewTest_Edit()
        {
            var controller = new Person.Controllers.PersonsController();
            var result = controller.Edit(1);///
            Assert.IsInstanceOf<ViewResult>(result);
            Assert.IsInstanceOf<PersonViewModel>(((ViewResult)result).Model);
        }

        [Test]
        public void GetViewTest_Delete()
        {
            var controller = new Person.Controllers.PersonsController();
            var result = controller.Delete(1);///
            Assert.IsInstanceOf<ViewResult>(result);
            Assert.IsInstanceOf<PersonViewModel>(((ViewResult)result).Model);
        }

        ///http://habrahabr.ru/post/176137/
    }
}