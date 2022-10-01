//AccessiblityModifiers
using AccessiblityModifiers;

//private, protected, internal, public

//bu derste private ve protected olanları öğrenicez bu sayede kalıtım yaparken diğer classa geçerken gizlee gibi yöntemleri kullanırız
//privateyaptıklarımız kalıtımla aşağıdaki classa geçmez 
//    private olanlar bir objeye tanımlayınca ulaşılmaz
//    bi ilerisi prtected kalıtım yoluyla tanımlananların aşağı geçmesini sağlarız ancak değiştirme söz konusu olamaz
//protectedin amacı kalıtım yoluyla alan, özellik veya metodların aşağı classa taşınmasını sağlar private de taşınmaz...
//obje içerisindeki ya da metod içerisindeki kullanımı privatela aynıdır...
//publicdeki amaç değişiklikde yapılabilecek şekilde kullanım olması için yaparız

Customer customer = new Customer();
LazyStudent student = new LazyStudent();
Dog dog = new Dog();
dog.id1internal = 1;
dog.Id1internal = 1;
dog.Eat();

Car car = new Car()
{
    Id1public = 1,
    id1public = 1
};
car.DriveTheCar();



namespace AccessiblityModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class Customer
    {
        int id1_private;
        private int id2_private;
        private int Id4_private { get; set; }

        void Shop()
        {
            id1_private = 1;
            id2_private = 2;
            Id4_private = 4;
            int id3local = 3;

        }
        void Pay()
        {
            Shop();
            //id3local =3;
            id1_private = 1;
            id2_private = 2;

        }
    }
    class Student
    {
        protected int id1_protected;
        protected int Id1_protected { get; set; }
        private int id2_private;

        private void Learn()
        {
            id1_protected = 1;
            id2_private = 2;
            Id1_protected = 1;
        }

        protected void Study()
        {
            Learn();
        }
    }
    class LazyStudent : Student
    {
        void Sleep()
        {
            id1_protected = 1;
            Id1_protected = 1;
            Study();
        }
    }
    internal class Animal
    {
        internal int id1internal;
        internal int Id1internal { get; set; }

        internal void Eat()
        {
            Id1internal = 1;
            id1internal = 1;
        }
    }
    class Dog : Animal
    {
        void Bark()
        {
            Id1internal = 1;
            id1internal = 1;
            Eat();
        }
    }
    public class Vehicle
    {
        public int id1public;
        public int Id1public { get; set; }
        public void Drive()
        {
            id1public = 1;
            Id1public = 1;
        }
    }
    public class Car : Vehicle
    {
        public void DriveTheCar()
        {
            Id1public = 1;
            Drive();
        }
    }
}
