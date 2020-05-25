using System;
using System.Collections.Generic;

namespace Common
{
    public class UslugaLogowania
    {
        public static void PiszDoPliku(List<ILogowanie> zmienioneElementy)
        {
            foreach (var element in zmienioneElementy)
            {

                Console.WriteLine(element.Log());
            }
        }
    }
}
