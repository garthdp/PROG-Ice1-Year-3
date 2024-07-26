using Ice1;
namespace IceTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestStudentNumber()
        {
            Student student = new Student("ST10058364", "Garth", "du Preez", "3", "1999/10/12", "BCAD", "0827717811", "garthdp@gmail.com");
            Assert.AreEqual(student[0], "ST10058364");
        }
        [TestMethod]
        public void TestFullName()
        {
            Student student = new Student("ST10058364", "Garth", "du Preez", "3", "1999/10/12", "BCAD", "0827717811", "garthdp@gmail.com");
            Assert.AreEqual("Garth du Preez", student[1] + " " +  student[2]);
        }
        [TestMethod]
        public void TestCourse()
        {
            Student student = new Student("ST10058364", "Garth", "du Preez", "3", "1999/10/12", "BCAD", "0827717811", "garthdp@gmail.com");
            Assert.AreEqual("BCAD3", student[5] + "" + student[3]);
        }
        [TestMethod]
        public void TestContactDetails()
        {
            Student student = new Student("ST10058364", "Garth", "du Preez", "3", "1999/10/12", "BCAD", "0827717811", "garthdp@gmail.com");
            Assert.AreEqual("0827717811, garthdp@gmail.com", student[6] + ", " +  student[7]);
        }
        [TestMethod]
        public void TestDateOfBirth()
        {
            Student student = new Student("ST10058364", "Garth", "du Preez", "3", "1999/10/12", "BCAD", "0827717811", "garthdp@gmail.com");
            Assert.AreEqual("1999/10/12", student[4]);
        }
    }
}