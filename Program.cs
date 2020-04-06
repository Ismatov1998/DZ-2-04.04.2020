using System;

namespace Nalog
{
    class Program
    {   static void Main()
        {
          string[] position1=new string[2] {"бугалтер","юрист"};
          int[] position2=new int[2]  {2000,3000};

          Console.WriteLine("Введите имя:");
          string name=Console.ReadLine();

          Console.WriteLine("Введите Фамилию:");
          string surname=Console.ReadLine();

          Console.WriteLine("Выберите цифру который стоит рядом вашего должнсто в следуюшем списке");
          for(int i=1;i<=2;i++)
          {
            Console.WriteLine($"{i}. {position1[i-1]}");
          }
          int n=Convert.ToInt32(Console.ReadLine());

          Console.WriteLine("Введите Зарплату");
          double salary=Convert.ToDouble(Console.ReadLine());

          Console.WriteLine("Введите Стаж");
          int experience=Convert.ToInt32(Console.ReadLine());

          Employee rabotnik=new Employee(name,surname); 
          rabotnik.position=position1[n];
          rabotnik.salary=salary;
          rabotnik.experience=experience;
          rabotnik.getinfo();
        }

    }
    class Employee
    {     
     public string name {set;get;}
     public string surname {set;get;}
     public string position;
     public double salary;
     public int experience;

     public Employee(string name, string surname)
     {
       this.name=name;
       this.surname=surname;
     }
     public void getinfo()
     {
        Console.WriteLine($"имя:{this.name} фамилия:{this.surname} должность:{position} зарплата:{salary} стаж:{experience}");
     }
      
    }
}
