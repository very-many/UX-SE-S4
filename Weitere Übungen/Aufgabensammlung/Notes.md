## Passwortabfrage v1
```csharp
string adminPw = "ad2013min";
string userPw = "einUser";

string input = textBox2.Text;

if (input == adminPw)
{
	textBox1.Text = "Sie sind als Administrator angemeldet.";
}
else if (input == userPw)
{
	textBox1.Text = "Sie haben sich als User angemeldet.";
}
else
{
	textBox1.Text = "Sie sind nur als Gast angemeldet.";
}
```

## Passwortabfrage v2
```csharp
string[] adminPws = new string[]
{
	"ad2013min",
	"pipi kaka",
	"aksjhudl"
};
string[] userPws = new string[]
{
	"einUser",
	"Simeon"
};

string input = textBox2.Text;

for (int i = 0; i < adminPws.Length; i++)
{
	if (input == adminPws[i])
	{
		textBox1.Text = "Sie sind als Administrator angemeldet.";
		return;
	}
}

foreach (string userPw in userPws) 
{
	if (input == userPw)
	{
		textBox1.Text = "Sie haben sich als User angemeldet.";
		return;
	}
}

textBox1.Text = "Sie sind nur als Gast angemeldet.";
```

## Some cars
```csharp
static void Main()
{
	Auto VW = new Auto("Grün", 2012);
	Auto Opel = new Auto("Braun", -6);
	
	Console.WriteLine("Auto VW Farbe: " + VW.GetFarbe() + " Baujahr: " + VW.GetBaujahr());
	Console.WriteLine("Auto Opel Farbe: " + Opel.GetFarbe() + " Baujahr: " + Opel.GetBaujahr());
	
	VW.SetFarbe("Rot");
	VW.SetBaujahr(4);
	
	Opel.SetFarbe("Lila");
	Opel.SetBaujahr(2013);
	
	Console.WriteLine("Auto VW Farbe: " + VW.GetFarbe() + " Baujahr: " + VW.GetBaujahr());
	Console.WriteLine("Auto Opel Farbe: " + Opel.GetFarbe() + " Baujahr: " + Opel.GetBaujahr());

}


class Auto
{
	private int baujahr;
	private string farbe;

	public Auto(string farbe, int baujahr)
	{
		this.farbe = farbe;
		this.baujahr = baujahr;
	}

	public string GetFarbe()
	{
		return farbe;
	}
	public void SetFarbe(string farbe)
	{
		this.farbe = farbe;
	}

	public int GetBaujahr()
	{
		return baujahr;
	}
	public void SetBaujahr(int baujahr)
	{
		this.baujahr = baujahr;
	}
}
```

## Ueberladen
```csharp
static void Main()
{
	int gz = 1;
	double d = 2.5;
	string s = "hallo";

	Wert.print(gz);
	Wert.print(d);
	Wert.print(s);
}

class Wert
{
	public static void print(int zahl)
	{
		Console.WriteLine("Die Ganzzahl lautet: " + zahl);
	}

	public static void print(double zahl)
	{
		Console.WriteLine("Die Dezimalzahl lautet: " + zahl);
	}

	public static void print(string text)
	{
		Console.WriteLine("Der Text lautet: " + text);
	}
}
```