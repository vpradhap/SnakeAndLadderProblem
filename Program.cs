using System;

int position = 0,dieroll;
Console.WriteLine("Player Start Position : "+position);
Random random = new Random();
dieroll = random.Next(1,7);
Console.WriteLine("Dieroll Number is : "+dieroll);