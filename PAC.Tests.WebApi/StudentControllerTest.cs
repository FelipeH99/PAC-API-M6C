using PAC.BusinessLogic;

namespace PAC.Tests.WebApi;
using System.Collections.ObjectModel;

using System.Data;
using Moq;
using PAC.IBusinessLogic;
using PAC.Domain;
using PAC.WebAPI;
using Microsoft.AspNetCore.Mvc;

[TestClass]
public class StudentControllerTest
{
    [TestClass]
    public class UsuarioControllerTest
    {
        [TestInitialize]
        public void InitTest()
        {
        }
    }
    [TestMethod]
    public void TestGetAllStudents()
    {
        var studentServiceMock = new Mock<IStudentLogic>(MockBehavior.Strict);
        Student std =new Student();

        studentServiceMock.Setup(x => x.InsertStudents(std));
        var controller = new StudentController(studentServiceMock.Object);

        var result = StudentController.GetStudents() as OkObjectResult;

        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
    }

}
