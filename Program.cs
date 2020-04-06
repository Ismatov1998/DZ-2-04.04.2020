using System;

namespace Nalog
{
    class Program
    {   static void Main()
        {
          string[] position1=new string[5] {"бугалтер","юрист","Аудитор","Операционист","Кредитный эксперт"};
          int[] salary=new int[5]  {2000,3000,3400,4500,5000};///это список зарплат: Здесь я реализовал так  например чтобы
          /// найти заработную плату бугалтера надо смтореть на порядковый номер  бугалтера в этом списке и найти эту проядковый 
          /// номер в списке salary элемент находящийся под этим порядковым номером является зп бугалтера; AA
          Console.WriteLine("Введите имя:");
          string name=Console.ReadLine();

          Console.WriteLine("Введите Фамилию:");
          string surname=Console.ReadLine();

          Console.WriteLine("Выберите вашу должность так введите  цифру который стоит рядом вашего должнсто в следуюшем списке:");
          for(int i=1;i<=5;i++)
          {
            Console.WriteLine($"{i}. {position1[i-1]}");
          }
          int n=Convert.ToInt32(Console.ReadLine());

          Console.WriteLine("Введите Стаж");
          int experience=Convert.ToInt32(Console.ReadLine());
          Employee rabotnik=new Employee(name,surname); 
          rabotnik.position=position1[n-1];///
          rabotnik.salary=salary[n-1];
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
        double Zarplata,Sbornalog,KonechniyZarplata;
        
        Zarplata=salary+salary*experience/100;///учитивая стаж
        ///Заработная плата зависить от СТАЖА так если у сотрудника n лет стаж то к зп добавляется n% от зп
        Sbornalog=Zarplata*14/100;

        KonechniyZarplata=Zarplata-Sbornalog;

        Console.WriteLine($"имя:{this.name}");
        Console.WriteLine($"фамилия:{this.surname}"); 
        Console.WriteLine($"должность:{position}"); 
        Console.WriteLine($"зарплата учитивая стаж :{Zarplata}" );
        Console.WriteLine($"налог+пенсионный фонд {Sbornalog} ");
        Console.WriteLine($"зарплата к выплате {KonechniyZarplata}");
     }
      
    }
}
