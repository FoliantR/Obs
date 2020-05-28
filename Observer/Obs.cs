using System;
using System.Collections.Generic;

namespace Observer
{
    class Obs<T> where T: Police
    {
        public List<T> polices = new List<T>();
        public void Work()
        {
            int buffSpeed;
            Random rndSpeed = new Random();

            //Эмуляция трассы и 5 машин
            for (int i = 0; i < 5; i++)
            {
                buffSpeed = rndSpeed.Next(40,120); 
                if (buffSpeed > 79)
                {
                    foreach (var item in polices)
                    {
                        Console.WriteLine(item.Alarm(buffSpeed));
                    }
                }
            }
        }
    }
}
