namespace Pr_2;

class Program{

	public static double Find_avg(int[][] arr, double[] all_avg){
		double total_avg = 0;
		for(int i = 0; i < arr.Length; i++){
			int sum = 0;
			for(int j = 0; j < arr[i].Length; j++){
				sum += arr[i][j];
			}
			all_avg[i] = sum / arr[i].Length;
			total_avg += all_avg[i];
		}
		return (double)total_avg / arr.Length;
	}

	public static int Find_min(int[][] arr, int[] all_min){
		for(int i = 0; i < arr.Length; i++){
			int min = arr[i][0];
			for(int j = 0; j < arr[i].Length; j++){
				if(arr[i][j] < min) min = arr[i][j];
			}
			all_min[i] = min;
		}
		int total_min = all_min[0];
		for(int i = 0; i < all_min.Length; i++){
			if(total_min > all_min[i]) total_min = all_min[i];
		}
		return total_min;
	}

	public static int Find_max(int[][] arr, int[] all_max){
		for(int i = 0; i < arr.Length; i++){
			int max = arr[i][0];
			for(int j = 0; j < arr[i].Length; j++){
				if(arr[i][j] > max) max = arr[i][j];
			}
			all_max[i] = max;
		}
		int total_max = all_max[0];
		for(int i = 0; i < all_max.Length; i++){
			if(total_max < all_max[i]) total_max = all_max[i];
		}
		return total_max;
	}

	public static void Show(int[] arr){
		for(int i = 0; i < arr.Length; i++){
			Console.WriteLine(i + 1 + ": " + " " + arr[i]);
		}
	}
	public static void Show(double[] arr){
		for(int i = 0; i < arr.Length; i++){
			Console.WriteLine(i + 1 + ": " + " " + arr[i]);
		}
	}

	static void Main(){
		Random random = new Random();
		int[][] groups = new int[random.Next(3,6)][];
		double[] all_avg = new double[groups.Length];
		int[] all_min = new int[groups.Length];
		int[] all_max = new int[groups.Length];
		for(int i = 0; i < groups.Length; i++){
			groups[i] = new int[random.Next(10,31)];
			for(int j = 0; j < groups[i].Length; j++){
				groups[i][j] = random.Next(1,101);
			}
		}
		double total_avg = Find_avg(groups, all_avg);
		int total_min = Find_min(groups, all_min);
		int total_max = Find_max(groups, all_max);
		Console.WriteLine("Середня оцінка по группам");
		Show(all_avg);
		Console.WriteLine("Загальна середня оцінка: " + total_avg);
		Console.WriteLine("Мінімальна оцінка по группам");
		Show(all_min);
		Console.WriteLine("Загальна мінімальна оцінка: " + total_min);
		Console.WriteLine("Максимальна оцінка по группам");
		Show(all_max);
		Console.WriteLine("Загальна максимальна оцінка: " + total_max);
//		//Одновимірний масив
//		int[] arr = new int[3];
//		//Двовимірний масив
//		int[,] arr2 = new int[2,2];
//		//Масив масивів
//		int[][] arr3 = new int[3][];
//		arr3[0] = new int[3];
//		arr3[1] = new int[2];
//		arr3[2] = new int[1];
//
//		Random random = new Random();
//		for(int i = 0; i < arr3.Length ; i++){
//			arr3[i] = new int[random.Next(1,10)];
//		}	
//		for(int i = 0; i < arr3.Length ; i++){
//			for(int j = 0; j < arr3[i].Length; j++){
//				arr3[i][j] = random.Next(1,101);
//			}
//		}
//		for(int i = 0; i < arr3.Length ; i++){
//			for(int j = 0; j < arr3[i].Length; j++){
//				Console.Write(arr3[i][j] + " ");
//			}
//			Console.WriteLine();
//		}

	}
}
