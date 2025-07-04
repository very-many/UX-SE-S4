## Klassen
> [!caution]
> Die Aufgabe ist in verschiedensten Hinsichten absoluter Rotz.
> ~Jonas


```csharp
//Elternklasse
internal class Lamp
{
	private int watt;

	public Lamp (int watt)
	{
		this.watt = watt;
	}

	public int annualPowerConsumption(int hoursPerDay)
	{
		return (watt * hoursPerDay * 365) / 1000;
	}

	public int getWatt()
	{
		return watt;
	}
}

//Kindklassen:
internal class Bulb: Lamp
{
	public Bulb(int watt) : base(watt){ }

	public string toString(int hoursPerDay)
	{
		return "A bulb consumes " + annualPowerConsumption(hoursPerDay) + " kWh per year.";
	}
}

internal class LED_Bulb: Lamp
{
	public LED_Bulb(int watt) : base(watt){ }

	public string toString(int hoursPerDay)
	{
		return "A led bulb consumes " + annualPowerConsumption(hoursPerDay) + " kWh per year.";
	}
}
```

## Hauptprogramm
```csharp
static void Main()
{
	int dailyHours = 10;

	Bulb bulb = new Bulb(60);
	LED_Bulb led = new LED_Bulb(9);

	Console.WriteLine(bulb.toString(dailyHours));
	Console.WriteLine(led.toString(dailyHours));
}
```