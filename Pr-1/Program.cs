namespace Pr_1;

class Program{
  static void Main(){
		Task1 task1 = new Task1();
		task1.Run(4);
		
		Console.WriteLine("\n====================\n");

		Task2 task2 = new Task2();
		task2.Run();

		Console.WriteLine("\n====================\n");

		Task3 task3 = new Task3();
		task3.Run();

		Console.WriteLine("\n====================\n");

		Task4 task4 = new Task4();
		task4.Run();
	}
}
