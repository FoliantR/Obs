namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Obs<PostGAI> posts = new Obs<PostGAI>();
            posts.polices.Add(new PostGAI("Мавран", 559));
            posts.polices.Add(new PostGAI("Кириешка", 575));
            posts.polices.Add(new PostGAI("Митрофан", 334));
            posts.Work();

            Obs<CarGAI> cars = new Obs<CarGAI>();
            cars.polices.Add(new CarGAI("Какашка", 544666));
            cars.polices.Add(new CarGAI("Малина", 5478888));
            cars.Work();
        }
    }
}
