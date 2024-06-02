using DesignPatterns.AbstractFactory;

IBookProvider bookStore = new BookStore();
IBookProvider library = new Library();


Console.WriteLine("---------- BOOK STORE -------------------");
bookStore.GetNovel().PrintBook();
Console.WriteLine("-------------------------------------------");
bookStore.GetHistory().PrintBook();
Console.WriteLine("-------------------------------------------");


Console.WriteLine("---------- LIBRARY -------------------");
library.GetNovel().PrintBook();
Console.WriteLine("-------------------------------------------");
library.GetHistory().PrintBook();
Console.WriteLine("-------------------------------------------");