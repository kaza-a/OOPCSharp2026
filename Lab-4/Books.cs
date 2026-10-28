namespace Lab_4;

internal class Books{

	static int counter_id = 1;

	private string _author, _title;
	private Users _user; 
	private int _year, _id;
	private bool _isAvailable;
	
	public string Author => _author; 
	public string Title => _title; 
	public int Year => _year;
	public int Id => _id;
	public bool IsAvailable => _isAvailable;

	public Books(string author, string name, int year){
		_author = author;
		_title = name;
		_year = year;
		_isAvailable = true;
		_id = counter_id;
		counter_id++;
	}
	
	public void Show_info(){
		string status = _isAvailable ? "В наявності" : $"В оренді у {_user.Name}({_user.Id})";
		Console.WriteLine($"{Id}.\"{Title}\", за авторством {Author}, {Year} року видання, {status}");
	}

	public void Borrow(Users user){
		if(!_isAvailable){
				Console.WriteLine("Книга вже видана");
				return;
		}
		_user = user;
		_isAvailable = false;
	}

	public void Return(){
		_user = null;
		_isAvailable = true;
	}
}
