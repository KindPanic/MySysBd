using MySysBD.BL.Controller;
using MySysBD.BL.Model;
using System;


namespace MySysBD.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDataController = new MyDataController();
            var myMenu = new Menu();
            bool menu = true; //Переменная для выхода из цикла меню.
            int value = 0; //Переменная должна хранить выброное меню.
            Console.WriteLine("Это своя БД для системотехника\n");
            do
            {
                value = myMenu.MainMenu();

                switch (value)
                {
                    case 1:
                        Console.WriteLine("ЧАВО");
                        myDataController.ShowLowData();
                        break;
                    case 2:
                        Console.WriteLine("Добавляем данные в базу");
                        var lowData = Console.ReadLine();
                        myDataController.AddLowData(lowData);
                        var bigData = Console.ReadLine();
                        myDataController.AddBigData(bigData);
                        myDataController.AddAllinCollection();
                        myDataController.Save();

                        break;
                    case 3:
                        Console.WriteLine("Список магазинов");
                        break;
                    case 4:
                        myDataController.Save();
                        menu = false;
                        break;
                    default:
                        break;
                }

            }
            while (menu);
        }
    }
}
