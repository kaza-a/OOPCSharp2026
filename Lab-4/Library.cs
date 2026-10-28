namespace Lab_4;

internal class Library{
	private List<Books> _books = new List<Books>();
	private List<Users> _users = new List<Users>();

	public void AddBook(Books book){
		_books.Add(book);
	}

	public void AddUser(Users user){
		_users.Add(user);
	}

	private Books? FindBook(int id){
		return _books.Find(b => b.Id == id);
	}

	private Users? FindUser(int id){
		return _users.Find(u => u.Id == id);
	}

	public void BorrowBook(int userId, int bookId){
		Users? user = FindUser(userId);
		if(user == null){
			Console.WriteLine("Користувача не знайдено");
			return;
		}

		Books? book = FindBook(bookId);
		if(book == null){
			Console.WriteLine("Книгу не знайдено");
			return;
		}

		user.BorrowBook(book);
	}

	public void ReturnBook(int userId, int bookId){
		Users? user = FindUser(userId);
		if(user == null){
			Console.WriteLine("Користувача не знайдено");
			return;
		}

		Books? book = FindBook(bookId);
		if(book == null){
			Console.WriteLine("Книгу не знайдено");
			return;
		}

		user.ReturnBook(book);
	}

	public void ShowBooks(){
		Console.WriteLine("Усі книги: ");
		foreach(Books book in _books){
			book.Show_info();
		}
	}

	public void ShowAvailable(){
		Console.WriteLine("Доступні книги: ");
		foreach(Books book in _books){
			if(book.IsAvailable){
				book.Show_info();
			}
		}
	}

	public void ShowBorrowed(){
		Console.WriteLine("Книги, які зараз орендуються: ");
		foreach(Books book in _books){
			if(!book.IsAvailable){
				book.Show_info();
			}
		}
	}

	public void ShowUsers(){
		Console.WriteLine("Усі користувачі: ");
		foreach(Users user in _users){
			user.Show_info();
		}
	}

	public bool ShowUserBooks(int userId){
		Users? user = FindUser(userId);
		if(user == null){
			Console.WriteLine("Користувача не знайдено");
			return false;
		}

		if(user.BorrowedBooks.Count == 0){
			Console.WriteLine("Користувач не орендує книг");
			return false;
		}

		foreach(Books book in user.BorrowedBooks){
			book.Show_info();
		}
		return true;
	}
}
