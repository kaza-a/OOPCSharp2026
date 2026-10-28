using System.Collections;

namespace Lab_4;

internal class Users{
	private static int couter_id = 1;
	private string _name;
	private	int _id;
	private List<Books> borrowedBooks = new List<Books>();
	
	public IReadOnlyList<Books> BorrowedBooks => borrowedBooks;
	public string Name => _name;
	public int Id => _id;

	public Users(string name){
		_name = name;
		_id = couter_id;
		couter_id++;
	}

	public void Show_info(){
		if(borrowedBooks.Count > 0){
			Console.WriteLine($"{Id}.Користувач {Name} орендує такі книги: ") ;
			foreach(Books book in borrowedBooks){
				Console.Write("\t");
				book.Show_info();
			}
		}
		else
			Console.WriteLine($"{Id}.{Name} не орендує книг");

	}

	public void BorrowBook(Books book){

		if(!book.IsAvailable){
			Console.WriteLine("Книги немає в наявності");
			return;
		}

		if(borrowedBooks.Contains(book)){
			Console.WriteLine("Користувач вже орендував цю книгу");
			return;
		}
		
		book.Borrow(this);
		borrowedBooks.Add(book);

	}

	public void ReturnBook(Books book){
		if(borrowedBooks.Contains(book)){
			book.Return();
			borrowedBooks.Remove(book);
		}
		else{
			Console.WriteLine("Користувач не орендує цю книгу");
		}
	}
}
