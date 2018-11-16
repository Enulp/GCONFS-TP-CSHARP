using System;

namespace Partie2
{
    public class Student
    {
        // Attributs (A vous de compléter)
        public string name;
        // ...

        // Constructeur (A vous de compléter)
        public Student(string name, int life, int damage, bool isMagician, int physicalArmor, int magicalArmor)
        {
            this.name = name;
            // ...
        }
        
        // Static functions

        public static void DisplayNbStudent()
        {
            Console.WriteLine("There are {0} student(s).", nbStudent);
        }
        
        // Methodes

        public void TakeDamage(int damage, bool isMagical)
        {
            // TODO
        }
        
        public void Attack(Student s)
        {
            // TODO
        }

        public virtual void Status()
        {
            // TODO
        }
        
        // Getters & Setters
        
        public string Name
        {
            // TODO
        }

        public int Life
        {
            // TODO
        }

        public int Damage
        {
            // TODO
        }
    }
}