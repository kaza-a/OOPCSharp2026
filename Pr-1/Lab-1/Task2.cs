namespace Lab_1;

internal class Calculations{
	
	public void Run(double a, double b, double c){
		Console.WriteLine($"\nПериметр = {Perimeter(a,b,c)}\nПлоща = {Square(a,b,c)}\nТип трикутника: {Type(a,b,c)}");
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
		double hyp = GetHyp(a,b,c);
		double[] legs = GetLegs(a,b,c);
		if(legs[0]*legs[0] + legs[1]*legs[1] == hyp*hyp) return true;
		else return false;
	}

	double GetHyp(double a, double b, double c){
		double[] sides = new double[3] {a,b,c};
		double max = a;
		for(int i = 0; i < 3; i ++){
			if(sides[i] > max) max = sides[i];
		}
		return max;
	}
	
	double[] GetLegs(double a, double b, double c){
		double[] legs = new double[2];

		double max = GetHyp(a,b,c);
		if (max == a){
			legs[0] = b;
			legs[1] = c;
		}
		else if (max == b){
			legs[0] = a;
			legs[1] = c;
		}
		else{
			legs[0] = a;
			legs[1] = b;
		}
		return legs;
	}
}
