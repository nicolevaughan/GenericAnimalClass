namespace GenericAnimalClass
{
    public class Animal <T>
    {
        //define a field of type T
        public T data;

        //define a constructor of the Animal class
        public Animal(T data)
        {
            this.data = data;
            Console.WriteLine("Data passed: " + this.data);
        }
        //need getAnimal method to retrieve data
        public T getAnimal()
        {
            return data;
        }
    }
    class Program
    {
        static void Main()
        {
            Animal<string> animalName = new Animal<string>("Galapagos Tortoise");

            Animal<string> animalHabitat = new Animal<string>("Galapagos Islands");

            Animal<bool> endangered = new Animal<bool>(true);

            Animal<bool> extinct = new Animal<bool>(false);

            Animal<int> averageLifeSpan = new Animal<int>(100);


        }
    }
}