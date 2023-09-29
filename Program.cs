Page myFirstPage = new Page("En klasse er noget man instantierere med NEW og så er det et object.");
Page mySecondPage = new Page("Klassen kan instantieres med forskellige parametre, som så kan bruges i klassen.");

List<Page> KapitelPages = new List<Page>();
KapitelPages.Add(myFirstPage);
KapitelPages.Add(mySecondPage);


List<Chapter> chapters = new List<Chapter>();
Chapter kapitel1 = new Chapter("OOP", KapitelPages);
chapters.Add(kapitel1);

Book mybook = new Book("Programming Notes", chapters);

mybook.Start();