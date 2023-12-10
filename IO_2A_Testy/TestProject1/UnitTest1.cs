using IO_2A_Testy;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {

        public Calculator Calculator { get; set; } = new Calculator();
        [TestMethod]
        public void TestMethod1()
        {
            int x = 1;
            int y = 2;

            int expected = 3;

            int actual = Calculator.Sum(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow(0,0,0)]
        [DataRow(1, 2, 3)]
        [DataRow(2, 2, 4)]
        [DataRow(4, 2, 6)]
        public void AddTest(int x, int y, int expected) {
            int actual = Calculator.Sum(x, y);
            Assert.AreEqual(expected, actual);
        }
        /*public static IEnumerable<object[]> Data
        {
            get
            {
                return new[]
                {
                    new object[] {0,0,0},
                    new object[] {1,1,2},
                    new object[] {2,2,4},
                    new object[] {3,3,6},
                };
            }
        }
        */
        const string path = @"C:\Users\ath.ACI-L412-11A\Documents\repos\IO_2A_Testy\IO_2A_Testy\plik.txt";

        public static IEnumerable<object[]> Data
        {
            get
            {
                return DLzPliku.Pobieracz(path);
            }
        }

        [TestMethod]
        [DynamicData(nameof(Data))]

        public void AddDynamicDataTest(int x, int y, int expected)
        {
            int actual = Calculator.Sum(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}