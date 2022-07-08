using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Регулярки
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string s = @"агггф И снова солнца закат я вижу перед собой
                            И не орет наш комбат и не зовет идти в бой
                            Я вырезаю ножом на деревянном бруске
                            Имя твое
                            Мы с пацанами сидим на рыхлой, черной земле
                            И вспоминаем друзей, павших на этой войне
                            И думаем об одном что у кого то  из нас
                            Будет пуля в виске


                            Припев:
                                        Война, бесконечная стрельба над головой
                            И лежит в сырой земле товарищ мой
                            Талисман сжимаю крепко я в руке
                            Тихо плача при луне


                            Пишу тебе я, пойми, что нет моей здесь вины
                            Что нет назад мне, пути я сам хотел бы уйти
                            И я прошу об одном, о самом дорогом
                            Любовь мою сохрани
                            Нам предстоит завтра бой серьёзный и роковой
                            И будет вновь наша кровь проливаться рекой
                            А если переживу то ожидает меня
                            Дорога домой


                            Припев:
                            Война, бесконечная стрельба над головой
                            И лежит в сырой земле товарищ мой
                            Талисман сжимаю крепко я в руке
                            Тихо плача при луне";
            Console.WriteLine("Хотите ввести команду?\n1 - ввести\n 0 - нет");
            //string userAsk = Console.ReadLine();
            string ask = "в";
            Console.WriteLine("Начинается на:");
            ask = (@"\b") + Console.ReadLine() + (@"\w*");
            Console.WriteLine("Заканчивается на:");                                            //string r = (@"\bв\w*");//(@"\w*а\b | \w*е\w*");
            string ask2;
            ask2 = (@"\w*") + Console.ReadLine() + (@"\b");                                          // {
            Console.WriteLine("Содержит :");                                            //string r = (@"\bв\w*");//(@"\w*а\b | \w*е\w*");
            string ask3;
            ask3 = ("|") + (@"\w*") + Console.ReadLine() + (@"\w*");

            Regex regex = new Regex(ask + ask2 + ask3, RegexOptions.IgnoreCase);


            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
        }
    }
}
