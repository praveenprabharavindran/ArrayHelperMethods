using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ArrayHelpers
{
    public class Serialize1DArray
    {
        public string Serialize(int[] array)
        {
            var result = string.Join(", ", array);
            return result;
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, "1, 2, 3")]
        public void TestSerialize1D(int[] array, string expected)
        {
            var sut = new Serialize1DArray();
            var actual = sut.Serialize(array);
            Assert.Equal(expected, actual);
        }

    }
}
