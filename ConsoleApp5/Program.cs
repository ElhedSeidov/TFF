namespace ConsoleApp5
{


    public interface IPerson
    {
        public void Speak()
        { }


    }

    public class RussianPerson
    {
        public void Speak()
        { Console.WriteLine("Privet"); }

    }
    public class FrenchPerson
    {
        public void Speak()
        {
            Console.WriteLine("Bonjour");

        }
        public class SpanishPerson
        {
            public void Speak()
            { Console.WriteLine("Hola"); }

        }









        public class Program
        {
            static void Main(string[] args)
            {
                SpanishPerson spanishPerson = new SpanishPerson();
                spanishPerson.Speak();
                FrenchPerson frenchPerson = new FrenchPerson();
                frenchPerson.Speak();
                RussianPerson russiaPerson = new RussianPerson();
                russiaPerson.Speak();

            }
        }

    }
}