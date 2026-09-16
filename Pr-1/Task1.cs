namespace Pr_1;



public class Task1{

	public void Run(int a){
		PrintEven(IsEven(a));
	}

	bool IsEven(int a){
		return a % 2 == 0;
	}

	void PrintEven(bool isEven){
		if (isEven) Console.WriteLine("even");
		else Console.WriteLine("odd");
	}
}
