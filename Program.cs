Book mybook = new Book("My Book", new List<Chapter>()
{
    new Chapter("Chapter 1", new List<Page>()
    {
        new Page(MyNotes.VariablesPageOne),
        new Page(MyNotes.VariablesPageTwo),
    }),
    new Chapter("asdasd", new List<Page>()
    {
        new Page(MyNotes.VariablesPageOne),
        new Page(MyNotes.VariablesPageTwo),
    })
});

mybook.Start();