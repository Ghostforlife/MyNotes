Page FirstPage = new Page(MyNotes.VariablesPageOne);
Page SecondPage = new Page(MyNotes.VariablesPageTwo);


Chapter Kapitel1 = new Chapter("Variabler");
Chapter Kapitel2 = new Chapter("Tekst");


Kapitel1.Pages.Add(FirstPage);
Kapitel2.Pages.Add(SecondPage);


Book mybook = new Book("Programmerings Notater");
mybook.Chapters.Add(Kapitel1);
mybook.Chapters.Add(Kapitel2);
mybook.Start();

Console.ReadLine();
