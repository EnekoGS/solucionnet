using Asociaciones;
using Asociaciones.ManyToMany;
using Asociaciones.ManyToOne;
using Asociaciones.OneToOne;

Console.WriteLine("================ OneToOne ===============");

Address address1 = new Address { Id = 1, Street = "Calle 1", City = "Madrid" };
Address address2 = new Address { Id = 1, Street = "Calle 1", City = "Madrid" };

Customer customer = new Customer { Id = 1, Name = "Customer 1", Age = 30, Address = address };

Console.WriteLine(address1);
Console.WriteLine(customer);

Console.WriteLine("================ OneToMany y ManyToOne ================");

Author author1 = new Author { Id = 1, Name = "Author 1" };

Book book1 = new Book { Id = 1, Title = "Book 1", Author = author1 };
//book1.Author = author1;
Book book2 = new Book { Id = 2, Title = "Book 2", Author = author1 };
//book2.Author = author1;
Book book3 = new Book { Id = 3, Title = "Book 3", Author = author1 };
//book3.Author = author1;

Console.WriteLine(book1);
Console.WriteLine(book2);
Console.WriteLine(book3);

// author1.Books = new List<book> { book1, book2, book3 };

/*
author1.Books.Add(book1);
author1.Books.Add(book2);
author1.Books.Add(book3);
*/

author1.Books.AddRange(new List<Book> { book1, book2, book3 });
Console.WriteLine(author1);

Console.WriteLine("================= ManyToMany ================");

// Crear películas
Film film1 = new Film { Id = 1, Title = "Film 1", Duration = 120 };
Film film2 = new Film { Id = 1, Title = "Film 1", Duration = 180 };

// Crear categorías

Category category1 = new Category { Id = 1, Name = "Comedia", Color = "Amarillo"};
Category category2 = new Category { Id = 2, Name = "Terror", Color = "Negro" };
Category category3 = new Category { Id = 3, Name = "Acción", Color = "Verde" };

// Asociar
film1.Categories.Add(category1);
film1.Categories.Add(category3);

film2.
