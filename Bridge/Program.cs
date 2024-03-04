using Bridge.Books;
using Bridge.Content;

// Creating content for languages
IBookContent englishContent = new EnglishContent();
IBookContent frenchContent = new FrenchContent();
IBookContent spanishContent = new SpanishContent();



// Creating different books with different content
Book frenchMathBook = new MathBook(frenchContent);
Book spanishHistoryBook = new HistoryBook(spanishContent);
Book englishScienceBook = new ScienceBook(englishContent);

// Producing books with different content

englishScienceBook.Produce();
frenchMathBook.Produce();
spanishHistoryBook.Produce();

Console.WriteLine();


Console.ReadLine();