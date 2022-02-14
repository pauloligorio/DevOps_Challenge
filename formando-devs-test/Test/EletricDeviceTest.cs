using formando_devs_api.Domain;
using NUnit.Framework;
 
namespace EmployeeService.Test
{
    [TestFixture]
    public class EmployeeTests
    {
        [TestCase(20, 220, ExpectedResult = 4400)]
        [TestCase(20, 110, ExpectedResult = 2200)]
        public double When_VoltageAndCurrentExpectsPowerResult(double Current, double Voltage)
        {
            EletricDevice Device = new EletricDevice(Current, Voltage);
            var Power = Device.GetPower();
            return Power;
        }

        [TestCase(20, 220, ExpectedResult = 15) // era 11
        [TestCase(20, 110, ExpectedResult = 5.5)]
        public double When_VoltageAndCurrentExpectsResistenceResult(double Current, double Voltage)
        {
            EletricDevice Device = new EletricDevice(Current, Voltage);
            var Resistence = Device.GetResistence();
            return Resistence;
        }
    }
}