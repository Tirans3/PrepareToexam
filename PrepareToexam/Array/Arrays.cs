﻿using System;
namespace Arrays
{
    public class Arrays
    {
        /*
          Все массивы в C# построены на основе класса Array из пространства имен System.
          
          Этот класс определяет ряд свойств и методов, которые мы можем использовать при работе с массивами.

          Основные свойства и методы:

          Свойство Length возвращает длину массива

          Свойство Rank возвращает размерность массива

          Статический метод BinarySearch() выполняет бинарный поиск в отсортированном массиве

          Статический метод Clear() очищает массив, устанавливая для всех его элементов значение по умолчанию

          Статический метод Copy() копирует часть одного массива в другой массив

          Статический метод Exists() проверяет, содержит ли массив определенный элемент

          Статический метод Find() находит элемент, который удовлеворяет определенному условию

          Статический метод FindAll() находит все элементы, которые удовлеворяет определенному условию

          Статический метод IndexOf() возвращает индекс элемента

          Статический метод Resize() изменяет размер одномерного массива

          Статический метод Reverse() располагает элементы массива в обратном порядке

          Статический метод Sort() сортирует элементы одномерного массива
         */
        void Display()
        {
            int[] numbers = { -4, -3, -2, -1, 0, 1, 2, };

            int[] numbers2 = new int[5];

            // расположим в обратном порядке
            Array.Reverse(numbers);

            // уменьшим массив до 4 элементов
            Array.Resize(ref numbers, 4);            // 4    3   2   1

            Array.Copy(numbers, 2, numbers2, 0, 5);  // -2	-1	 0    1 	2

            Array.FindAll<int>(numbers, x => x > 0); //  0   1   2
        }
    }
}
