using EncodeDecodeRecordSource;
using NUnit.Framework;

namespace EncodeDecodeRecordsTests
{
    [TestFixture]
    public class EncodeDecodeRecordSourceTest
    {
        [Test]
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

        [Test]
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

        [Test]
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

        [Test]
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
