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

            }

            List<IFeedable> feedables = new List<IFeedable> { new Dog("Baki", 2, "German Sheperd"), new Cat("Garfield", 2, true), new Bird("Harry", 1, true) };

            foreach (var f in feedables)
            {
                f.Feed();
            }

            List<ITrainable> trainable = new List<ITrainable> { new Dog("Baki", 2, "German Sheperd"), new Bird("Harry", 1, true) };

            foreach (var t in trainable)
            {
                t.Train();
            }
        }
    }
}
