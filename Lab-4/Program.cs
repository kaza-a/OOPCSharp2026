namespace Lab_4;

class Program{

	static int UserInput(int max, int min = 1){
		int value;
		while(!int.TryParse(Console.ReadLine(), out value) || value < min || value > max){
			Console.Write("Некоректне значення, спробуйте ще раз: ");
		}
		return value;
	}

	static void Borrow(Library library){
		Console.WriteLine("Хто орендує книгу(id)?");
		library.ShowUsers();
		int userId = UserInput(int.MaxValue);

		Console.WriteLine("Яку книгу орендує(id)?");
		library.ShowAvailable();
		int bookId = UserInput(int.MaxValue);

		library.BorrowBook(userId, bookId);
	}

	static void Return(Library library){
		Console.WriteLine("Хто повертає книгу(id)?");
		library.ShowUsers();
		int userId = UserInput(int.MaxValue);

		Console.WriteLine("Яку книгу повертає(id)?");
		if(!library.ShowUserBooks(userId)){
			return;
		}
		int bookId = UserInput(int.MaxValue);

		library.ReturnBook(userId, bookId);
	}

	static void Main(){
		Library library = new Library();

		library.AddBook(new Books("Дж. Орвелл", "1984", 1949));
		library.AddBook(new Books("М. Булгаков", "Майстер і Маргарита", 1967));
		library.AddBook(new Books("Т. Шевченко", "Кобзар", 1840));
		library.AddBook(new Books("Л. Українка", "Лісова пісня", 1911));
		library.AddBook(new Books("Р. Мартін", "Чистий код", 2008));

		library.AddUser(new Users("Bill"));
		library.AddUser(new Users("Adolf"));
		library.AddUser(new Users("Anna"));

		bool isOpen = true;

		while(isOpen){
			Console.Clear();
			Console.Write("Бібліотечний застосунок\n1.Переглянути всі книги \n2.Переглянути доступні книги \n3.Переглянути орендовані книги \n4.Переглянути користувачів бібліотеки \n5.Оренда книги \n6.Повернення книги \n7.Вихід\n");
			switch(UserInput(7)){
				case 1: library.ShowBooks(); break;
				case 2: library.ShowAvailable(); break;
				case 3: library.ShowBorrowed(); break;
				case 4: library.ShowUsers(); break;
				case 5: Borrow(library); break;
				case 6: Return(library); break;
				case 7: isOpen = false; break;
			}

			if(isOpen){
				Console.WriteLine("\nНатисніть будь-яку клавішу, щоб продовжити...");
				Console.ReadKey();
			}
		}
	}
}
