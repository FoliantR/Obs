namespace Observer
{
    class CarGAI : Police
    {
        public CarGAI(string _name, int _number) : base(_name, _number)
        {
            name = _name;
            number = _number;
        }
        public override string Alarm(int speed)
        {
            return $"-------------------\n" +
                $"Паструльная машина №{number} была оповещена, замечено нарушение.\n" +
                $"Была привышена скорость на {speed-60}\n" +
                $"Ответственный на смене {name}\n" +
                $"-------------------\n";
        }
    }
}
