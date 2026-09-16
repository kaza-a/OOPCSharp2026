namespace Lab_1;

internal class Check{
	
	public bool CheckTriangle(double a, double b, double c){
		if (IsReal(a,b,c) && IsPositive(a,b,c)) return true;
		else return false;
	}

	public bool IsPositive(double a, double b, double c){
		if (a <= 0 || b <= 0 || c <= 0) return false;
		else return true;
	}
	
	public bool IsReal(double a, double b, double c){
		if (a + b < c || b + c < a || c + a < b) return false;
		else return true;
	}
}
