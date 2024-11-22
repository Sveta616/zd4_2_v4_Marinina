using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtLib
{
    //Статический класс
    public static class Calculate
    {
        //Статическая фун-ция для определения потраченного времени
        public static int Calcl(List<int> list)
        {

            // Проверка на наличие только целых неотрицательных чисел
            foreach (var item in list)
            {
                if (item < 0)
                {
                    throw new Exception("Все значения должны быть неотрицательными");
                }

            }

            // Добавление нулей, если количество элементов не кратно 3
            while (list.Count % 3 != 0)
            {
                list.Add(0);
            }

            int time = 0;

            for (int i = 0; i < list.Count; i += 3)
            {

                int first = list[i];

                int second = list[i + 1];

                int third = list[i + 2];

                if (second > third)
                {
                    first += second;
                }
                else
                {
                    first += third;
                }
                time += first;
            }
            return time;
        }
    }
  }
