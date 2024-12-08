using PaletteGenerator.Core.Utility;

namespace PaletteGeneratorTest.Core.Utility
{
    [TestClass]
    public class RangeManagerCycleTest
    {
        [TestMethod]
        public void CycleMinPositiveTest()
        {
            int min = 20;
            int max = 30;
            int value = 18;
            int expected = 28;

            Assert.AreEqual(expected, PaletteGenerator.Core.Utility.Range.Cycle(min, max, value));
        }

        [TestMethod]
        public void CycleMinNegativeTest()
        {
            int min = -20;
            int max = 30;
            int value = -21;
            int expected = 29;

            Assert.AreEqual(expected, PaletteGenerator.Core.Utility.Range.Cycle(min, max, value));
        }

        [TestMethod]
        public void CycleMaxPositiveTest()
        {
            int min = 10;
            int max = 40;
            int value = 50;
            int expected = 20;

            Assert.AreEqual(expected, PaletteGenerator.Core.Utility.Range.Cycle(min, max, value));
        }

        [TestMethod]
        public void CycleMaxNegativeTest()
        {
            int min = -100;
            int max = -10;
            int value = -8;
            int expected = -98;

            Assert.AreEqual(expected, PaletteGenerator.Core.Utility.Range.Cycle(min, max, value));
        }

        [TestMethod]
        public void CycleHueMinTest()
        {
            int min = 0;
            int max = 360;
            int value = -10;
            int expected = 350;

            Assert.AreEqual(expected, PaletteGenerator.Core.Utility.Range.Cycle(min, max, value));
        }

        [TestMethod]
        public void CycleMaxTest()
        {
            int min = 0;
            int max = 360;
            int value = 370;
            int expected = 10;

            Assert.AreEqual(expected, PaletteGenerator.Core.Utility.Range.Cycle(min, max, value));
        }
    }
}