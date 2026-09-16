namespace Pr_1;

internal class Task2{

	public void Run(){
		int[] numbers = new int[10];
		Initialize(numbers);
		Show(numbers);
		Console.WriteLine();
		Console.WriteLine("Sum = " + SumArray(numbers));
		Console.WriteLine("Avg = " + Avg(numbers));
		Console.WriteLine("Min " + FindMin(numbers));
		Console.WriteLine("Max " + FindMax(numbers));
		Console.WriteLine($"Lenght of Array : {numbers.Length}");
	}

	void Initialize(int[] numbers){
		Random random = new Random();
		for(int i = 0; i < numbers.Length; i++){
			numbers[i] = random.Next(1, 101);
		}	
	}

	void Show(int[] numbers){
		foreach(int number in numbers){
			Console.Write(number + " ");
		}
	}

	int SumArray(int[] numbers){
		int sum = 0;
		foreach(int number in numbers){
			sum += number;
		}	
		return sum;
	}

	double Avg(int[] numbers){
		int sum = SumArray(numbers);
		double average = (double)sum / numbers.Length;
		return average;
	}

	int FindMin(int[] numbers){
		int min = numbers[0];
		foreach(int number in numbers){
			if(number < min){
				min = number;
			}
		}
		return min;
	}

	int FindMax(int[] numbers){
		return numbers.Max();
	}
}
