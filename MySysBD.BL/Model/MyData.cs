using System;


namespace MySysBD.BL.Model
{
    [Serializable]
    public class MyData
    {
        public string LowData { get; set; }
        public string BigData { get; set; }

        public MyData(string lowdata)
        {
            if (string.IsNullOrWhiteSpace(lowdata))
            {
                throw new ArgumentNullException("Данные не могут быть Null", nameof(lowdata));
            }
            else
            {
                LowData = lowdata;
                BigData = "Данные отсутствуют";
            }
        }
        public MyData(string lowdata, string bigdata)
        {
            if (string.IsNullOrWhiteSpace(lowdata) && string.IsNullOrWhiteSpace(bigdata))
            {
                throw new ArgumentNullException("Данные не могут быть Null", nameof(lowdata));
            }
            else
            {
                LowData = lowdata;
                BigData = bigdata;
            }
        }

        public MyData()
        {
        }
        public override string ToString()
        {
            return LowData + " " + BigData;
        }
    }
}
