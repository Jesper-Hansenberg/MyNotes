Page FirstPage = new Page(MyNotes.VariablesPageOne);


Page second = new Page("Min anden side i min awesome bog");

Page third = new Page("Min tredje side side i min awesome bog");
Page foruth  = new Page("Min tredje side side i min awesome bog");

Chapter Kapitel1 = new Chapter("Variabler");

Kapitel1.Pages.Add(FirstPage);
Kapitel1.Pages.Add(second);
Kapitel1.Pages.Add(third);


Book mybook = new Book("Haps");
mybook.Chapters.Add(Kapitel1);
mybook.Start();

Console.ReadLine();