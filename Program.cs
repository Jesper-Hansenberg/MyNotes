Page myfirstpage = new Page("En klasse er noget man instantierere med NEW og så er det et object.");
Page page2 = new Page("asdasdasd");

List<Page> KapitelPages = new List<Page>(){
    myfirstpage,
    page2
};


List<Chapter> chapters = new List<Chapter>();
Chapter kapitel1 = new Chapter("haps", KapitelPages);
chapters.Add(kapitel1);

Book mybook = new Book("asdasd", chapters);


mybook.Start();