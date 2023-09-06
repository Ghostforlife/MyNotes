Page FirstPage = new Page(MyNotes.VariablesPageOne);

Page Second = new Page("Anden side");

Page Third = new Page("Tredje side");

Chapter Kapitel1 = new Chapter("Variabler");

Kapitel1.Pages.Add(FirstPage);
Kapitel1.Pages.Add(Second);
Kapitel1.Pages.Add (Third);


Book mybook = new Book("Programmerings Notater");
mybook.Chapters.Add(Kapitel1);
mybook.Start();

Console.ReadLine();
