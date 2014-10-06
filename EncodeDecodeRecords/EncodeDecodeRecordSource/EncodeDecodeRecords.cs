using System.Linq;

namespace EncodeDecodeRecordSource
{
    public class EncodeDecodeRecords
    {
        public string DecodeRecords(string[,] records)
        {
            string decodeString = "";

            int recWidth = records.GetLength(0);
            int recHeigh = records.GetLength(1);

            for (int i = 0; i < recWidth; i++)
            {
                for (int j = 0; j < recHeigh; j++)
                {
                    decodeString = decodeString + records[i, j];
                    if (j < recHeigh - 1)
                    {
                        decodeString = decodeString + "=";
                    }
                }
                if (i < recWidth - 1)
                {
                    decodeString = decodeString + "#";
                }
            }



            return decodeString;
        }

        public string[,] EncodeRecords(string records)
        {
            var multiArray = records.Split('=').Select(t => t.Split('#')).ToArray();
            var dim1 = multiArray.Length;
            var dim2 = multiArray.Select(a => a.Length).Max();

            var arr = new string[dim1, dim2];
            for (var i = 0; i < dim1; i++)
                for (var j = 0; j < multiArray[i].Length; j++)
                    arr[i, j] = multiArray[i][j];
            return arr;

        }

    }
}
