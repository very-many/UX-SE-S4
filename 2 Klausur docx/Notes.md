## Aufgabe 1: 5 Punkte
> Schreiben sie eine Befehlssequenz, in der sie den Benutzer auffordern eine Fließkommazahl einzugeben. Speichern sie anschließend den eingegebenen Wert in einer dafür geeigneten Variablen und geben sie diese und ihren Typ wieder am Terminal aus.

```csharp
try
{
	Console.WriteLine("Bitte geben sie eine FKZ ein: ");
	double input = Convert.ToDouble(Console.ReadLine());
	Console.WriteLine("Deine Zahl ist: " + input);
}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}
```

## Aufgabe 2: 6 Punkte 
> Erstellen Sie ein Wörterbuch (Datenstruktur: Dictionary) namens Farben, das als Schlüssel- Wert-Paare die Farben Schwarz, Blau, Grün und Orange mit ihren entsprechenden englischen Übersetzungen enthält. Schreiben Sie nun ein Programm, das die Nutzerinnen zunächst dazu auffordert, eine Farbe einzugeben, deren englische Übersetzung daraufhin angezeigt wird. Das Programm soll sowohl Groß- als auch Kleinbuchstaben als dasselbe Wort erkennen können (Tipp: lower-Funktion). Sehen Sie dabei auch einen Fall für ungültige Eingaben vor.

```csharp
Dictionary<string, string> farben = new Dictionary<string, string>()
{
	{"orange", "orange"},
	{"blau", "blue"},
	{"grün", "green"},
	{"schwarz", "black"}
};

Console.WriteLine("Bitte gib eine Farbe aus der Liste ein: ");
try
{
	string input = Console.ReadLine();
	Console.WriteLine("Die Farbe "+ input + " heißt auf Englisch: " + farben[input.ToLower()]);
}
catch
{
	Console.WriteLine("Ungültige Eingabe");
}

Console.ReadLine();
```

## Aufgabe 3: 8 Punkte 
> Definieren Sie eine Funktion, die die Werte zwischen zwei Zahlen (inkl. der beiden Zahlen) in Zweierschritten ausgibt. Für die Ausgabe müssen Sie zwischen zwei Fällen unterscheiden – je nachdem, ob die erste oder die zweite Zahl größer ist. Die beiden Zahlen sollen im Hauptprogramm durch eine Nutzereingabe vorgegeben werden.

```csharp
private static void zaehlenInZweierSchrittenHelper (int z1, int z2)
{
	if (z1 < z2)
	{
		zaehlenInZweierSchritten(z1, z2);
	}
	else if (z1 > z2)
	{
		zaehlenInZweierSchritten(z2, z1);
	}
	else
	{
		Console.WriteLine(z1);
	}
}

private static void zaehlenInZweierSchritten(int z1, int z2)
{
	for (int i = z1; i < z2; i = i + 2)
	{
		Console.Write(i + ", ");
	}
	Console.WriteLine("und " + z2);
}
```

## Aufgabe 4: 11 Punkte
Berichtigen und vervollständigen sie folgenden Quelltext damit er voll funktionsfähig wird: Hinweis: Die relevanten Zeilen sind farblich markiert
```diff
ABSOLUTER_NP_K = 0.0 # absoluter Nullpunkt in Kelvin 
ABSOLUTER_NP_C = -273.15 # absoluter Nullpunkt in Celsius 
ABSOLUTER_NP_F = -459.67 # absoluter Nullpunkt in Fahrenheit 

NULL_F = 32.0 # 0° C in Fahrenheit 
FAKTOR_F_C = 9/5 # Umrechnungsfaktor zwischen Fahrenheit und Celsius 

def get_float(msg = "Bitte Zahl eingeben: "): 
+	f = float(input(msg))
	return f 

def Celsius_Kelvin(t): 
-	return t - 
+	return t - ABSOLUTER_NP_C

-def Celsius_Fahrenheit( ): 
-	return 
+def Celsius_Fahrenheit(t):
+	return t * FAKTOR_F_C + NULL_F

def Kelvin_Celsius(t): 
	return t + ABSOLUTER_NP_C 

def Fahrenheit_Celsius(t): 
	return (t - NULL_F)/FAKTOR_F_C 

print("*----------------------*") 
print("* Temperatur Umwandler *") 
print("*----------------------*") 

wahl = -1 
while wahl != 0: 
	print("(1) Umrechnung von Celsius nach Kelvin") 
	print("(2) Umrechnung von Celsius nach Fahrenheit") 
	print("(3) Umrechnung von Kelvin nach Celsius") 
	print("(4) Umrechnung von Fahrenheit nach Celsius") 
	print() 
	print("(0) Programm schliessen") 
	print() 
	print() 
	wahl = int(input("Bitte wählen: ")) 
	print() 
	if wahl == 1: 
		t = get_float("Temperatur in Celsius: ") 
-		print(t, "° = ", , "K", sep = "") 
+		print(t, "° = ", Celsius_Kelvin(t), "K", sep = "")
	elif wahl == 2: 
		t = get_float("Temperatur in Celsius: ") 
		print(t, "° = ", Celsius_Fahrenheit(t), "F", sep = "") 
+	elif wahl == 3:		
		t = get_float("Temperatur in Kelvin: ") 
-		print(t, "K = ", Kelvin_Celsius( ), "°", sep = "") 
+		print(t, "K = ", Kelvin_Celsius(t), "°", sep = "")
	elif wahl == 4: 
		t = get_float("Temperatur in Fahrenheit: ") 
		print(t, "F = ", Fahrenheit_Celsius(t), "°", sep = "") 
	else: 
		print("Programm wird vom Benutzer beendet.") 
		break
```

-> Alles andere kommt noch

## Aufgabe 5: 10 Punkte

> Erstellen sie ausfolgendem Klassendiagramm eine Python Klasse: Geben sie als Rückgabewerte der Methoden jeweils mit den Standardwerten initialisierte Variablen zurück. Beispiel: String -> Standardwert ´´, int -> Standardwert 0, usw.

.......

## Aufgabe 7: 12 Punkte
> Erstellen sie ein UML-Sequenzdiagramm eines typischen Restaurantbesuchs. Beteiligte Klassen sind der Gast, der Kellner und der Koch. Der Gast betritt das Restaurant und setzt sich an einen Tisch. Er bestellt beim Kellner ein Getränk, während dieser ihm die Speisekarte aushändigt. Danach bestellt er sein ausgewähltes Essen beim Kellner. Nach einer Wartezeit bekommt er sein Essen und verspeist es. Nachdem der Kellner ihm seine Rechnung gebracht hat, bezahlt der Gast und geht. Bitte modellieren sie auch die Sequenz der Kommunikation des Kellners mit dem Koch.

![[Aufgabe-7.png]]
