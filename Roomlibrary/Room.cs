using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roomlibrary
{
    public class Room
    {
        double roomLeight; //длина комнаты
        double roomWidth; //ширина комнаты

        public double RoomLeght
        {
            get { return roomLeight; }
            set { roomLeight = value; }
        }
    public double RoomWidth
        {
            get { return roomWidth; }
            set { roomWidth = value; }
        }
        /// <summary>
        /// Метод вычисляет значение перимера
        /// </summary>
        /// <returns>Возвращает значение периметра</returns>
        public double RoomPerimetr()
        {
            return 2 * (roomLeight + roomWidth);
        }
        /// <summary>
        /// Метод вычисляет площадь комнаты
        /// </summary>
        /// <returns>Возвращает значение площади</returns>
        public double RoomArea()
        {
            return roomLeight * roomWidth;
        }
        /// <summary>
        /// Метод вычисляет число квадратных метров
        /// на одного человека
        /// </summary>
        /// <param name="np">Число человек</param>
        /// <returns>Возвращает число квадратных метров</returns>
        public double PersonArea(int np)
        {
            return RoomArea() / np;
        }

    }
}
