using MySysBD.BL.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace MySysBD.BL.Controller
{
    public class MyDataController
    {
        List<MyData> myDatas = new List<MyData>();
        MyData currentData = new MyData();
        
        /// <summary>
        /// Устанавливаем заголовок(ключевое слово или словосочетание).
        /// </summary>
        /// <param name="lowerData"></param>
        public void AddLowData(string lowData)
        {
            if (string.IsNullOrWhiteSpace(lowData))
            {
                throw new ArgumentNullException("Строка не может быть ровна null", nameof(lowData));
            }
            else
            {
                currentData.LowData = lowData;
            }
        }

        /// <summary>
        /// Устанавливаем описание нашего заголовка.
        /// </summary>
        /// <param name="bigData"></param>
        public void AddBigData(string bigData)
        {
            if (string.IsNullOrWhiteSpace(bigData))
            {
                throw new ArgumentNullException("Строка не может быть ровна null", nameof(bigData));
            }
            else
            {
                currentData.BigData = bigData;
            }
        }

        /// <summary>
        /// Добавляем в нашу коллекцию новый объек моих данных
        /// </summary>
        public void AddAllinCollection()
        {
            if (currentData == null)
            {
                throw new ArgumentNullException("Данные не могут быть равны null", nameof(currentData));
            }
            else
            {
                myDatas.Add(currentData);
            }
        }

        /// <summary>
        /// Смотрим оглавление по ключевым словам или словамсочетания. lowdata
        /// </summary>
        public void ShowLowData()
        {
            foreach (var item in myDatas)
            {
                Console.WriteLine((myDatas.IndexOf(item)+1)+ ". " + item.LowData);
            }
        }


        public MyDataController()
        {
            myDatas = Load();

        }
        /// <summary>
        /// Сохраняем нашу коллекцию данных из MyData.
        /// </summary>
        public void Save()
        {
            var formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("MyData.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, myDatas);
            }
        }

        /// <summary>
        /// Выгрузка нашего списка данных из файла.
        /// </summary>
        /// <returns></returns>
        private List<MyData> Load()
        {
            var formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("MyData.dat", FileMode.OpenOrCreate))
            {
                if (fs.Length>0 && formatter.Deserialize(fs) is List<MyData> mydata)
                {
                    return mydata;
                }
                else
                {
                    return new List<MyData>();
                }
            }
        }

    }
}
