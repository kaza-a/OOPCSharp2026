namespace Lab_1;

internal class Calculations{
	
	public void Run(double a, double b, double c){
		Console.WriteLine($"\nПериметр = {Perimeter(a,b,c)}\nПлоща = {Square(a,b,c)}\n Тип трикутника: {Type(a,b,c)}");
	}

	double Perimeter(double a, double b, double c){
		return a+b+c;
	}

	double Square(double a, double b, double c){
		double p = (Perimeter(a,b,c))/2;
		return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
	}

	string Type(double a, double b, double c){
		if(a == b && b == c) return "Рівносторонній";
		else if(a == b || b == c || c == a) {
			if(IsRectengular(a,b,c)) return "Прямокутний рівнобедренний";
			else return "Рівнобедренний";
		}
		else if(IsRectengular(a,b,c)) return "Прямокутний";
		return "Довільний";
	}

	bool IsRectengular(double a, double b, double c){
		double[] sides = new double[3] {a,b,c};
		double max = a; // Гіпотенуза
		double k1,k2;// Катети
		for(int i = 0; i < 3; i ++){
			if(sides[i] > max) max = sides[i];
		}
		if (max == a){
			k1 = b;
			k2 = c;
		}
		else if (max == b){
			k1 = a;
			k2 = c;
		}
		else{
			k1 = a;
			k2 = b;
		}
		if(k1*k1 + k2*k2 == max*max) return true;
		else return false;
	}
}
