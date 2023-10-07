// Task 34
int[] array = new int[12];
int count = 0;

for (int i = 0; i < array.Length; i++) {
    array[i] = new Random().Next(100, 999);
    System.Console.Write(array[i] + " ");

    if (array[i] % 2 == 0) count++;
}
System.Console.WriteLine();
System.Console.WriteLine("Even numbers count = " + count);
System.Console.WriteLine("------------------------------------------------------------");

// Task 36
int[] massiv = new int[12];
int summ = 0;

for (int i = 0; i < massiv.Length; i++) {
    massiv[i] = new Random().Next(-99, 99);
    System.Console.Write(massiv[i] + " ");

    if (massiv[i] % 2 != 0) summ += massiv[i];
}
System.Console.WriteLine();
System.Console.WriteLine("Summ of the numbers on odd positions = " + summ);
System.Console.WriteLine("------------------------------------------------------------");

// Task 38
double[] drobi = new double[12];
double max = -99;
double min = 99;

for (int i = 0; i < drobi.Length; i++) {
    drobi[i] = new Random().NextDouble();
    System.Console.Write("{0:f3}   ", drobi[i]);

    if (max < drobi[i]) max = drobi[i];
    if (min > drobi[i]) min = drobi[i];
}
System.Console.WriteLine();
System.Console.WriteLine("Difference between max and min = {0:f3}", (max - min));
System.Console.WriteLine("------------------------------------------------------------");