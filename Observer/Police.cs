namespace Observer
{
    class Police
    {
        protected string name;
        protected int number;

        public virtual string Alarm(int speed)
        {
            return $"-------------------\n" +
                $"{number}-Самара, замечено нарушение.\n" +
                $"Была привышена скорость на {speed-60}\n" +
                $"Ответственный на смене {name}\n" +
                $"-------------------\n";
        }

        public Police(string _name, int _number)
        {
            name = _name;
            number = _number;
        }

    }
}
