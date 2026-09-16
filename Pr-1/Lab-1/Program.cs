namespace Lab_1;

class Program{
	
  static void Main(){
		double a = 4;
		double b = 11;
		double c = 8;

		Check task1 = new Check();
		Calculations task2 = new Calculations();
		
		if(task1.CheckTriangle(a,b,c)){
			task2.Run(a,b,c);
		}
		else{
			Console.WriteLine("Трикутник не може існувати: ");
			if (!task1.IsPositive(a,b,c))
				Console.WriteLine("Не всі сторони трикутника додатні");
			if (!task1.IsReal(a,b,c))
				Console.WriteLine("Трикутник із такими сторонами не може існувати");
		}	
  }
}
