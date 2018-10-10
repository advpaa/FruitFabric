using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Создать фабрику(класс-фабрику) по производству сока из разных видов фруктов(3-и вида: яболко, япельсин и вишня). 
//Т.е.создать экземпляр List<*какой-то сок*>, вызывая различные методы которого(например, List<AppleJuice> GetAppleJuice(decimal massOfFruits), 
//будет производить n упаковок яблочного сока в зависимости от массы переданых яблок)
//Для Упаковок Использовать классы(AppleJuice, OrangeJuice, CherryJuice)
//Необходимые массы для производства 1 упаковки:            
//яблок: 1,5 кг,
//апельсин: 1.3 кг,
//вишен: 2,4 кг

// part.2 a - Сделать так, чтобы если ты будешь передавать в метод помимо массы  еще и название сока (создать перегруженный метод с параметрами int и string), ты будешь получать упаковки сока с массой
//и названием (т.е. создать класс-наследник от applejuice, cherryjuice, applejuice).
// b - функционал по наполнению сока в коробку (там где рандом), вынести в статический класс со статическим методом
// c -в наследуемом классе от juice (e.g. applejuice)  создать два конструктора один должен ссылаться на конструктор базового класса, а второй на первый конструктор 

namespace FruitsFabric
{
    class Program
    {
        static void Main(string[] args)
        {
            //string massoffruits = AppleFruit.GetAppleJuice();
            JuiceFactory juiceFactory = new JuiceFactory(1.5, 1.3, 2.4); // создаем экземпляр фабрики
            int applePacksNumber = juiceFactory.GetAppleJuice(50).Count(); //передаем массу фруктов и подсчитываем количество пачек в коллекции
            int orangePacksNumber = juiceFactory.GetOrangeJuice((decimal)70.4).Count(); // приведение типов
            int cherryPacksNumber = juiceFactory.GetCherryJuice((decimal)93.6).Count();

            Console.WriteLine($"applePacksNumber and Name : {applePacksNumber}; orangePacksNumber : {orangePacksNumber}; cherryPacksNumber : {cherryPacksNumber}");
            Console.ReadLine();
        }
    }
}
//ToDo: После generic-ов сделать класс, в котором будут храниться все соки, и по индексу получать конкретный вид (индексаторы) 
