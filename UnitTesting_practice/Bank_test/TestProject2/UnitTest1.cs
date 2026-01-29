using EmployeeServices;

namespace TestProject2
{
    [TestFixture]
    public class Employeeetest
    {
        private Mock<IEmployeeService> _employeeServiceMock;

        private Employee _employee;

        [SetUp]
        public void Setup()
        {
            _employeeServiceMock = new Mock<IEmployeeService>();
            _employee = new Employee(new Employee2());
        }
        [Test]
        public void EmployeeeTest()
        {
            // Arrange
            //_employeeServiceMock.Setup(es => es.getname()).Returns("John Doe");
            //_employeeServiceMock.Setup(es => es.getid()).Returns(123);
            //// Act
            //var name = _employee.DisplayEmployeeName();
            //var id = _employee.DisplayEmployeeID();
            Employee _employee=new Employee(new Employee2());
            // Assert
            Assert.AreEqual("version 2 Employee Name", _employee.DisplayEmployeeName());
            Assert.AreEqual(2, _employee.DisplayEmployeeID());
        }



        }
}