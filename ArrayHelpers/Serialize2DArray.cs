using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ArrayHelpers
{
    public class Serialize2DArray
    {
        public string Serialize(int[,] array, string rowDelim = "\n", string colDelim = ", ")
        {
            if (array == null
                || array.Rank != 2
                || array.GetLength(0) < 1
                || array.GetLength(1) < 1)
                return string.Empty;
            var builder = new StringBuilder();
            for (int row = 0; row < array.GetLength(0); row++)
            {
                var currentRow = Enumerable.Range(0, array.GetLength(1)).Select(col => array[row, col]).ToArray();
                builder.Append(string.Join(colDelim, currentRow));
                builder.Append(rowDelim);
            }
            --builder.Length;
            return builder.ToString();

        }

        [Theory]
        [InlineData(0, "1, 2, 3\n4, 5, 6")]
        public void TestSerialize1D(int dataIndex, string expected)
        {
            List<int[,]> testData = new List<int[,]> { new int[,] { { 1, 2, 3 }, { 4, 5, 6 } } };
            var sut = new Serialize2DArray();
            var actual = sut.Serialize(testData[dataIndex]);
            Assert.Equal(expected, actual);
        }
    }
}
