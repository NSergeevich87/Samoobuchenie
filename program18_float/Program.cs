byte a = 1;
byte b = 2;

byte c = (byte)(a - b);
System.Console.WriteLine(c);

int? d = null;

int? e = null;

System.Console.WriteLine(e == null);
System.Console.WriteLine(e.GetValueOrDefault());
System.Console.WriteLine(e.GetValueOrDefault(55));
System.Console.WriteLine(e ?? 55);
System.Console.WriteLine(e.HasValue);
System.Console.WriteLine(e.Value);