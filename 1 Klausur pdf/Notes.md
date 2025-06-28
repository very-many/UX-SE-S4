## Aufgabe 1 : 5 Punkte

> Schreiben Sie eine Reihe von Python-Anweisungen, um eine Variable var zu deklarieren und ihr den Wert 'hallo' zuzuweisen. Das Programm soll dann überprüfen, ob die Variable var eine Ganzzahl oder eine Zeichenkette ist. Wenn es sich um eine Ganzzahl handelt, soll das Programm 'Ganzzahl' auf der Konsole ausgeben. Wenn es sich um eine Zeichenkette handelt, soll das Programm 'Zeichenkette' ausgeben.

```csharp
var variable = "Das hier ist ein String";
if (variable.GetType() == typeof(string))
{
	label2.Text = "Zeichenkette";
}
else if (variable.GetType() == typeof(int))
{
	label2.Text = "Ganzzahl";
}
else
{
	label2.Text = variable.GetType().ToString();
}
```

## Aufgabe 2: 9 Punkte

> Schreiben Sie ein Programm, um eine Liste von Tupeln L basierend auf dem zweiten Element des Tupels in aufsteigender Reihenfolge zu sortieren.
> Die zu betrachtende Liste in dieser Übung ist:
> `L =[("Apfel", 15), ("Banane", 8), ("Fräser", 12), ("Kiwi", 9), ("Pfirsich", 2)]`
> Die Liste `L`, die wir am Ende des Programms haben sollten (nach der Sortierung):
> `L = [("Pfirsich", 2), ("Banane", 8), ("Kiwi", 9), ("Fräser", 12), ("Apfel", 15)]`

```csharp
List<(string, int)> L = new List<(string, int)>()
{
	("Apfel", 15),
	("Banane", 8),
	("Fräser", 12),
	("Kiwi", 9),
	("Pfirsich", 2)
};
L.Sort((a, b) => a.Item2.CompareTo(b.Item2));
label2.Text = print(L);

//Ignore this part, its only for visualization
private string print(List<(string, int)> list)
{
	string result = "L = [";
	for (int i = 0; i < list.Count - 1; i++)
	{
		result += "( '" + list[i].Item1 + "', '" + list[i].Item2 + "'), ";
	}
	result += "( '" + list[list.Count - 1].Item1 + "', '" + list[list.Count - 1].Item2 + "')] ";
	return result;
}
```

## Aufgabe 3: 10 Punkte
> Schreiben Sie eine Funktion `AnzahlWertWörterbuch(d)`, die ein Dictionary `d` als Parameter erhält und die Anzahl der Werte zurückgibt, die den Schlüsseln zugeordnet sind.
> **Hinweis:** In diesem Beispiel gehen wir davon aus, dass alle Werte, dient den Schlüsseln zugeordnet sind, als Listen vorliegen.
> **Überprüfungstests:**
>`AnzahlWertWörterbuch({"a": [1,2,3], "b": [3, "p"], "c": [8]})`
>-> 6
>`AnzahlWertWörterbuch({"Julie": {12, 60.1}, "Fred": {26, 75.6}, "David": [ ]})`
>-> 4

```csharp
//hier nur code zur visualisierung
//object weil Liste verschiedene Typen nehmen können soll
Dictionary<string, List<object>> d = new Dictionary<string, List<object>>()
{
	{ "a", new List<object> { 1, 2, 3 } },
	{ "b", new List<object> { 3, "p" } },
	{ "c", new List<object> { 8 } }
};

label2.Text = "Das Dictionary hat " + anzahlWertWoerterbuch(d).ToString() + " Werte den Schlüsseln zugeordnet.";

//hier ist der wichtige code
private int anzahlWertWoerterbuch(Dictionary<string, List<object>> d)
{
	int sum = 0;

	foreach (var entry in d)
	{
		if (entry.Value != null)
		{
			sum += entry.Value.Count;
		}
	}

	return sum;
}
```

## Aufgabe 4: 12 Punkte
>Definieren Sie eine Klasse Angestellter mit 4 Attributen: dem Namen des Angestellter, sein Beruf, seinem Gehalt und der Anzahl der geleisteten Arbeitsstunden.
>Die Klasse Angestellter sollte den Konstruktor und die folgenden Methoden enthalten:
- _ init_(self, name, beruf, gehalt) : Dieser Konstruktor dient zur Initialisierung der Attribute der Klasse Angestellter. Das vierte Attribut, das die Anzahl der Arbeitsstunden darstellt, wird im Konstruktor auf 0 gesetzt, ohne dass sein lnitialwert als Parameter übergeben wird.
- arbeiten(self, anzahl_stunden): Diese Methode fügt die als Parameter übergebene Stundenzahl der im Konstruktor initialisierten Anzahl von Arbeitsstunden hinzu. Außerdem gibt diese Methode eine Zeichenkette zurück, die die Gesamtzahl der vom Mitarbeiter geleisteten Arbeitsstunden enthält. (Siehe Beispielausgaben auf der Konsole)
- gehaltsinfo(self) : Diese Methode gibt eine Zeichenkette zurück, die das Gehalt des Mitarbeiters enthält. (Siehe Ausgabe auf der Konsole).
- gehaltserhöhung_geben(self, betrag) : Diese Methode erhöht das aktuelle Gehalt des Mitarbeiters um den als Parameter übergebenen Betrag.
- beruf_info(self) : Diese Methode gibt eine Zeichenkette zurück, die die aktuelle Funktion des Mitarbeiters beschreibt.

> [!note]
Das ganze mit `self` braucht in C# niemand, das ist so ein Python ding.
-> Also das einfach ignorieren

```C#
//kommt noch, hatte kein bock
```

## Aufgabe 5: 6 Punkte
>Erstellen sie ein Klassendiagramm aus der Klasse Angestellter aus Aufgabe 4

![Aufgabe 5](https://github.com/very-many/UX-SE-S4/blob/main/1 Klausur pdf/Archive/Aufgabe-5.png)

## Aufgabe 6 : 4 Punkte
> Nennen Sie 3 Vorgehensmodelle, die im Softwareengineering angewendet werden, und beschreiben sie stichwortartig deren Eigenschaften.

*Kommt noch* -- könnt aber au chat gpt oder so fragen

## Aufgabe 7 : 4 Punkte
> Beschreiben sie kurz wie diversifizierende Softwaretest durchgeführt werden.

*Kommt noch* -- könnt aber au chat gpt oder so fragen