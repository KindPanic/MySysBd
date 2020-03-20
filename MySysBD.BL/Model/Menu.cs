using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySysBD.BL.Model
{
   public class Menu
    {
        public int MainMenu()
        {
                Console.WriteLine("Выберите действие\n");
                Console.WriteLine("1.ЧАВО");
                Console.WriteLine("2.Добавить данные");
                Console.WriteLine("3.Посмотреть список магазинов");
                Console.WriteLine("4.Сохранить и выйти");
            if (int.TryParse(Console.ReadLine(), out int result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Нужно выбрать меню по цифре");
                    return 0;
                }
        }

    }
}
