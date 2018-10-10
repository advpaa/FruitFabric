using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitsFabric
{
    class JuiceFactory
    {
        private double _applesForPress; //поле - это признак класса, например, у класса дерево - это цвет листа
        private double _orangesForPress;//
        private double _cherriesForPress;//

        public JuiceFactory(double applesForPress, double orangesForPress, double cherriesForPress) //конструктор, который принимает как параметр фрукты для выжимки
        {
            _applesForPress = applesForPress; // используется для инициализации полей (поле=переменная)
            _orangesForPress = orangesForPress;//это коэф, сколько надо для 1 пачки
            _cherriesForPress = cherriesForPress;
        }

        public List<AppleJuice> GetAppleJuice(decimal massOfFruits) // метод, который принимает массу фруктов и возвращает коллекцию пачек
        {
            List<AppleJuice> appleJuices = new List<AppleJuice>(); // инициализация коллекции, мы говорим что коллекция с типом AppleJuice называется appleJuices
            AppleJuice appleJuicePack = new AppleJuice(); // переменная  appleJuicePack имеет тип AppleJuice и мы ее инициализируем

            decimal applePacksQty = (decimal)massOfFruits / (decimal)_applesForPress; // количество пачек которое получится из переданной массы фруктов

            for (int i = 1; i <= (int)applePacksQty; i++) // цикл по наполнению пачки сока соком
            {
                appleJuices.Add(appleJuicePack);// добавить в коллекцию appleJuices переменную appleJuicePack
            }

            return appleJuices; // возвращаем коллекцию пачек
        }

        public List<OrangeJuice> GetOrangeJuice(decimal massOfFruits)
        {
            List<OrangeJuice> orangeJuices = new List<OrangeJuice>();
            OrangeJuice orangeJuicePack = new OrangeJuice();

            decimal orangePacksQty = (decimal)massOfFruits / (decimal)_orangesForPress; 

            for (int i = 1; i <= (int)orangePacksQty; i++)
            {
                orangeJuices.Add(orangeJuicePack);
            }

            return orangeJuices;
        }

        public List<CherryJuice> GetCherryJuice(decimal massOfFruits)
        {
            List<CherryJuice> cherryJuices = new List<CherryJuice>();
            CherryJuice cherryJuicePack = new CherryJuice();

            decimal orangePacksQty = (decimal)massOfFruits / (decimal)_cherriesForPress;

            for (int i = 1; i <= (int)orangePacksQty; i++)
            {
                cherryJuices.Add(cherryJuicePack);
            }

            return cherryJuices;
        }
    }
}
