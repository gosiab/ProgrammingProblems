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
            string[][] MultiArray = records.Split('=').Select(t => t.Split('#')).ToArray();
            int dim1 = MultiArray.Length;
            int dim2 = MultiArray.Select(a => a.Length).Max();

            string[,] arr = new string[dim1, dim2];
            for (int i = 0; i < dim1; i++)
                for (int j = 0; j < MultiArray[i].Length; j++)
                    arr[i, j] = MultiArray[i][j];
            return arr;

        }

    }
}
