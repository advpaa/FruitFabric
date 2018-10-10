using FruitsFabric;
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
            
            int applePacksQty = (int)((double)massOfFruits / _applesForPress); // количество пачек которое получится из переданной массы фруктов

            for (int i = 1; i <= applePacksQty; i++) // цикл по наполнению пачки сока соком
            {
                AppleJuice appleJuicePack = new AppleJuice(); // переменная  appleJuicePack имеет тип AppleJuice и мы ее инициализируем
                appleJuices.Add(appleJuicePack);// добавить в коллекцию appleJuices переменную appleJuicePack
            }

            return appleJuices; // возвращаем коллекцию пачек
        }

        public List<AppleJuiceWithName> GetAppleJuice(decimal massOfFruits, string appleJuiceName) // перегруженный метод, который принимает массу фруктов и название, и возвращает коллекцию пачек
        {
            List<AppleJuiceWithName> appleJuiceswithName = new List<AppleJuiceWithName>(); // инициализация коллекции, мы говорим что коллекция с типом AppleJuice называется appleJuices

            int applePacksQty = (int)((double)massOfFruits / _applesForPress); // количество пачек которое получится из переданной массы фруктов

            for (int i = 1; i <= applePacksQty; i++) // цикл по наполнению пачки сока соком
            {
                AppleJuiceWithName appleJuicePackWithName = new AppleJuiceWithName(); // переменная  appleJuicePack имеет тип AppleJuice и мы ее инициализируем
                appleJuicePackWithName._appleJuiceName = appleJuiceName;
                appleJuiceswithName.Add(appleJuicePackWithName);// добавить в коллекцию appleJuiceswithName переменную appleJuicePack
            }

            return appleJuiceswithName; // возвращаем коллекцию пачек с именем
        }


        public List<OrangeJuice> GetOrangeJuice(decimal massOfFruits)
        {
            List<OrangeJuice> orangeJuices = new List<OrangeJuice>();
            
            int orangePacksQty = (int)((double)massOfFruits / _orangesForPress); 

            for (int i = 1; i <= orangePacksQty; i++)
            {
                OrangeJuice orangeJuicePack = new OrangeJuice();
                orangeJuices.Add(orangeJuicePack);
            }

            return orangeJuices;
        }

        public List<CherryJuice> GetCherryJuice(decimal massOfFruits)
        {
            List<CherryJuice> cherryJuices = new List<CherryJuice>();            

            int orangePacksQty = (int)((double)massOfFruits / _cherriesForPress);

            for (int i = 1; i <= orangePacksQty; i++)
            {
                CherryJuice cherryJuicePack = new CherryJuice();
                cherryJuices.Add(cherryJuicePack);
            }

            return cherryJuices;
        }
    }
}
