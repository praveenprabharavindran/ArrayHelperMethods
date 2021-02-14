using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HelperMethods.Bitwise
{
    /// <summary>
    /// Refer: https://docs.microsoft.com/en-us/dotnet/api/system.convert.tostring?view=net-5.0
    /// </summary>
    public class ToBase
    {
        public string ToBase2(int value)
        {
            return Convert.ToString(value, toBase: 2);
        }

        public string ToBase8(int value)
        {
            return Convert.ToString(value, toBase: 8);
        }

        public string ToBase16(int value)
        {
            return Convert.ToString(value, toBase: 16);
        }



        [Theory]
        [InlineData(9, "1001")]
        [InlineData(2, "10")]
        public void ToBase2_ShouldConvertToBinary(int input, string expected)
        {
            var actual = ToBase2(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(25, "19")]
        [InlineData(109, "6D")]
        public void ToBase16_ShouldConvertToHex(int input, string expected)
        {
            var actual = ToBase16(input).ToUpper();
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(25, "31")]
        [InlineData(109, "155")]
        public void ToBase8_ShouldConvertToBase8(int input, string expected)
        {
            var actual = ToBase8(input).ToUpper();
            Assert.Equal(expected, actual);
        }
    }
}
