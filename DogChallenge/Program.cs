using System;

namespace DogChallenge
{
    public class Dog
    {
        public enum Gender
        {
            Male,
            Female
        }
       public String name;
       public String owner;
       public int age;
       public Gender gender;

        /*Switch Case for Gender*/
        public static string GetGender(Gender gender)
        {
            if (gender == Gender.Male)
            {
                return "His";
            }
            else
            {
                return "Her";
            }
        }
        //Dog Method
        public Dog(String petName, String ownerName, int dogAge, Gender dogGender)
        {
            name = petName;
            owner = ownerName;
            age = dogAge;
            gender = dogGender;
        }

//Bark Method
public void Bark(int num)
        {
            for (int i =0; i < num; i++)
            {
                Console.WriteLine("Woof!");
            }
        }

        //Get Tag method
        public string GetTag()
        {
            string yearorYears;
            if (age == 1)
            {
                yearorYears = " year ";
            }
            else
            {
                yearorYears = " years ";
            }
            string hisorher = GetGender(gender).ToString();
            string heorshe;
            if (hisorher == "His")
            {
                heorshe = "he";
            }
            else
            {
                heorshe = "she";
            }
            return "If lost, call " + owner + " " + hisorher + " name is " + name + " and " + heorshe + " is " + age +  yearorYears + "old.";
        }

        /*Main class*/
        static void Main(string[] args)
        {
            Dog puppy = new Dog("Orion", "Shawn", 1, Gender.Male);
            puppy.Bark(3);
            Console.WriteLine(puppy.GetTag());

            Dog myDog = new Dog("Lileu", "Dale", 4, Gender.Female);
            myDog.Bark(1);
            Console.WriteLine(myDog.GetTag());
        }
    }
}
