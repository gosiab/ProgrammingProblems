using Microsoft.VisualStudio.TestTools.UnitTesting;
using EncodeDecodeRecordSource;

namespace EncodeDecodeRecordsTests
{
    [TestClass]
    public class EncodeDecodeRecordSourceTest
    {
        [TestMethod]
        public void DecodeSource_ShouldReturnRightString()
        {
            // Arange
            string[,] data = { { "id", "123" }, { "name", "bob" }, { "salary", "30000" } };
            var decode = new EncodeDecodeRecords();
            var expected = decode.DecodeRecords(data);

            // Act
            var result = "id=123#name=bob#salary=30000";

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EncodeSource_ShouldReturnRightArray()
        {
            // Arange
            string data = "id=123#name=bob#salary=30000";
            var encode = new EncodeDecodeRecords();
            var expected = encode.EncodeRecords(data);

            // Act
            string[,] result = { { "id", "123" }, { "name", "bob" }, { "salary", "30000" } };

            // Assert
            Assert.AreEqual(result.ToString(), expected.ToString());
        }

        [TestMethod]
        public void DecodeSource1_ShouldReturnRightString()
        {
            // Arange
            string[,] data = { { "id", "123" }, { "name", "bob" }, { "salary", "30000" }, { "date", "25.08.2014" } };
            var decode = new EncodeDecodeRecords();
            var expected = decode.DecodeRecords(data);

            // Act
            const string result = "id=123#name=bob#salary=30000#date=25.08.2014";

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EncodeSource1_ShouldReturnRightArray()
        {
            // Arange
            const string data = "id=123#name=bob#salary=30000#date=25.08.2014";
            var encode = new EncodeDecodeRecords();
            var expected = encode.EncodeRecords(data);

            // Act
            string[,] result = { { "id", "123" }, { "name", "bob" }, { "salary", "30000" }, { "date", "25.08.2014" } };

            // Assert
            Assert.AreEqual(result.ToString(), expected.ToString());
        }
    }
}
