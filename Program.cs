﻿Page FirstPage = new Page("Min første side i min awesome bog");

Page second = new Page("Min anden side i min awesome bog");

Page third = new Page("Min tredje side side i min awesome bog");

Chapter Kapitel1 = new Chapter("Variabler");

Kapitel1.Pages.Add(FirstPage);
Kapitel1.Pages.Add(second);
Kapitel1.Pages.Add(third);


Kapitel1.Read();

Console.ReadLine();