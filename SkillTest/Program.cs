namespace SkillTest
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Opgave 2");
            
            Dog d1 = new Dog(1, "Jimmy", "Chihuahua", 2017);
            Dog d2 = new Dog(2, "Tim", "Golden retriever", 2018);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Opgave 3");
            Member m1 = new Member(3, "Bob Larsen", "Adresse 1", new DateTime(1995, 6, 14), "+4550202925", "Bob@gmail.com");
            Member m2 = new Member(4, "James Larsen", "Adresse 2", new DateTime(1985, 7, 15), "+4550202930", "James@gmail.com");
            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine();

            Console.WriteLine("Opgave 4");
            
            m1.RegisterDog(d1);
            m2.RegisterDog(d2);
            
            Console.WriteLine("Printing dogs");
            
            m1.PrintDogs();
            m2.PrintDogs();

           

            Console.WriteLine("Deleting dogs:");

            m1.RemoveDog(d1);


            Console.WriteLine();
            Console.WriteLine("Opgave 6");

            Member m3 = new Member(3, "Bob Larsen", "Adresse 1", new DateTime(1980, 6, 14), "+4550202925", "Bob@gmail.com");
            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);




            Console.WriteLine();
            Console.WriteLine("Opgave 6");

            Console.WriteLine($"Member 1 Fee Base Fee 500 DKK: {m1.MemberFee(500)} DKK");
            Console.WriteLine($"Member 2 Fee Base Fee 1000 DKK: {m2.MemberFee(1000)} DKK");

            Console.WriteLine();
            Console.WriteLine("Opgave 7");

            Member m5 = new Member(3, "Bob Larsen", "Adresse 1", new DateTime(2020, 6, 14), "+4550202925", "Bob@gmail.com");
            Member m6 = new Member(4, "James Larsen", "Adresse 2", new DateTime(1985, 7, 15), "", "James@gmail.com");
            
            try 
            {
                m5.Validate();
            } 
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                m6.Validate();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

            Console.WriteLine();
            Console.WriteLine("Opgave 8");

            static void Validate(Member member)
            {

                try
                {
                    new Member(3, "Bob Larsen", "Adresse 1", new DateTime(2020, 6, 14), "+4550202925", "");
                }
                catch (ArgumentException e)
                {
                    //Console.WriteLine(e.Message);
                    throw;
                }

                try
                {
                    new Member(4, "James Larsen", "Adresse 2", new DateTime(1985, 7, 15), "", "James@gmail.com");
                }
                catch (ArgumentException e)
                {
                    //Console.WriteLine(e.Message);
                    throw;
                }
            }

          
        }
    }
}
