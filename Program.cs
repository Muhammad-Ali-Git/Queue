using System;
using System.Net.Quic;
using System.Runtime.CompilerServices;

class Ali
{
    public static void Main()
    {
        Console.WriteLine("This program prints details of a Costumer using Queue.");
        Console.WriteLine("--------------------------------------------------------------------------------------");

        Costumer C1 = new Costumer();
        C1.ID = 101;
        C1.Name = "John Lorusso";
        C1.Salary = 5000;
        C1.Gender = "Male";

        Costumer C2 = new Costumer();
        C2.ID = 102;
        C2.Name = "Ibrahim Arabaki";
        C2.Salary = 6000;
        C2.Gender = "Male";

        Costumer C3 = new Costumer();
        C3.ID = 103;
        C3.Name = "Mary Luisse";
        C3.Salary = 7000;
        C3.Gender = "Female";

        Queue <Costumer> QC01 = new Queue<Costumer>();
        QC01.Enqueue(C1);
        QC01.Enqueue(C2);
        QC01.Enqueue(C3);

        Console.WriteLine("Using Dequeue Method (Total Count Decreases)");

        Console.WriteLine("---------------------------------------------------------------------------------------");
        Costumer QC1 = QC01.Dequeue();
        Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Gender = {3}", QC1.ID, QC1.Name, QC1.Salary, QC1.Gender);
        Console.WriteLine("Total Items in Queue = {0}", QC01.Count);

        Console.WriteLine("---------------------------------------------------------------------------------------");
        Costumer QC2 = QC01.Dequeue();
        Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Gender = {3}", QC2.ID, QC2.Name, QC2.Salary, QC2.Gender);
        Console.WriteLine("Total Items in Queue = {0}", QC01.Count);

        Console.WriteLine("---------------------------------------------------------------------------------------");
        Costumer QC3 = QC01.Dequeue();
        Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Gender = {3}", QC3.ID, QC3.Name, QC3.Salary, QC3.Gender);
        Console.WriteLine("Total Items in Queue = {0}", QC01.Count);

        Queue <Costumer> QC02 = new Queue<Costumer>();
        QC02.Enqueue(C1);
        QC02.Enqueue(C2);
        QC02.Enqueue(C3);
        
        Console.WriteLine("---------------------------------------------------------------------------------------");
        Console.WriteLine("Using Foreach Loop (Total Count Remains Same & Prints All Items in The Queue)");

        foreach (Costumer C in QC02)
        {
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Gender = {3}", C.ID, C.Name, C.Salary, C.Gender);
            Console.WriteLine("Total Items in Queue = {0}", QC02.Count);
        }

        Console.WriteLine("---------------------------------------------------------------------------------------");
        Console.WriteLine("Using Peek Method (Total Count Remains Same but Only Prints the Item at the Start of Queue)");

        Console.WriteLine("---------------------------------------------------------------------------------------");
        Costumer QC4 = QC02.Peek();
        Console.WriteLine("Peek 1");
        Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Gender = {3}", QC4.ID, QC4.Name, QC4.Salary, QC4.Gender);
        Console.WriteLine("Total Items in Queue = {0}", QC02.Count);

        Console.WriteLine("---------------------------------------------------------------------------------------");
        Costumer QC5 = QC02.Peek();
        Console.WriteLine("Peek 2");
        Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Gender = {3}", QC5.ID, QC5.Name, QC5.Salary, QC5.Gender);
        Console.WriteLine("Total Items in Queue = {0}", QC02.Count);
    }
}

public class Costumer
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public string Gender { get; set; }
}