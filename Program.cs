Page FirstPage = new Page(MyNotes.VariablesPageOne);

Page Second = new Page("Anden side");

Page Third = new Page("Tredje side");

Chapter Kapitel1 = new Chapter("Kapitel: 1 - Variabler");

Kapitel1.Pages.Add(FirstPage);
Kapitel1.Pages.Add(Second);
Kapitel1.Pages.Add (Third);

Kapitel1.Read();

Book mybook = new Book("Notes");
mybook.Chapters.Add(Kapitel1);
mybook.Start();

Console.ReadLine();
