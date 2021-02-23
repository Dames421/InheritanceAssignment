using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Duck aDuck = new Duck("Steve", true, true, true, true, true, true, true);
            Eagle anEagle = new Eagle("Kevin", true, true, true, true, true, true, true);
            Hawk aHawk = new Hawk("Mike", true, true, true, true, true, true, true);
            HummingBird aHummingBird = new HummingBird("John", true, true, true, true, true, true, true);
            Ostrich anOstrich = new Ostrich("Aiden", true, true, true, true, true, true, true);
            Penguin aPenguin = new Penguin("Paul", true, true, true, true, true, true, true);
            Seagull aSeagull = new Seagull("Sam", true, true, true, true, true, true, true);

            List<Bird> aListOfBirds = new List<Bird>();
            
            aListOfBirds.Add(aDuck);
            aListOfBirds.Add(anEagle);
            aListOfBirds.Add(aHawk);
            aListOfBirds.Add(aHummingBird);
            aListOfBirds.Add(anOstrich);
            aListOfBirds.Add(aPenguin);
            aListOfBirds.Add(aSeagull); 


            foreach (var bird in aListOfBirds)
            {
                Console.WriteLine(bird.ToString());
            }

            Console.ReadLine();

        }
    }
}
