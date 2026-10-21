namespace CSharpDay30_OOP_Recap_AnimalShelterManagementSystem_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal> { new Dog("Baki", 2, "German Sheperd"), new Cat("Garfield", 2, true), new Bird("Harry", 1, true) };

            foreach (var a in animals)
            {
                a.ShowInfo();
                a.MakeSound();

                if (a is IFeedable feedable)
                {
                    feedable.Feed();
                }
                if (a is ITrainable trainable)
                {
                    trainable.Train();
                }
                else
                {
                    Console.WriteLine("Not Trainable\n");
                }

            }

        }
    }
}
