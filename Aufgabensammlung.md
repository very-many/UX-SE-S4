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
