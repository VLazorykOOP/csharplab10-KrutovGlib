using Lab9_10CharpT;
using Lab9_10CharpT.SecondTask;

void main()
{
    Task1 task1 = new Task1();
    War war = new War();
    Console.WriteLine("Enter num of task: ");
    int choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1: task1.Task1FromLab2(); break;
        case 2: war.Fight(); break;
    }
}

main();