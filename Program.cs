Page p = new Page("hejsa");

Chapter chap1 = new Chapter("vars");

chap1.Pages.Add(p);

Book book = new Book("Jespers bog");

book.Chapters.Add(chap1);


book.Start();