using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_demo.Test
{
    [TestClass]
    public class ArrayUtilsTest
    {
        [TestMethod]
        public void FindMax_ValidArray_ReturnsMax()
        {
            int[] array = { 3, 7, 1, 9, 4 };
            int expectedMax = 9;

            int actualMax = ArrayUtils.FindMax(array);

            Assert.AreEqual(expectedMax, actualMax);
        }

        [TestMethod]
        public void FindMin_ValidArray_ReturnsMin()
        {
            int[] array = { 3, 7, 1, 9, 4 };
            int expectedMin = 1;

            int actualMin = ArrayUtils.FindMin(array);

            Assert.AreEqual(expectedMin, actualMin);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FindMax_EmptyArray_ThrowsException()
        {
            int[] array = { };
            ArrayUtils.FindMax(array);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FindMin_EmptyArray_ThrowsException()
        {
            int[] array = { };
            ArrayUtils.FindMin(array);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FindMax_NullArray_ThrowsException()
        {
            int[] array = null;
            ArrayUtils.FindMax(array);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FindMin_NullArray_ThrowsException()
        {
            int[] array = null;
            ArrayUtils.FindMin(array);
        }
    }
}
