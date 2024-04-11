int[] arrayInt = new int [3];

arrayInt[0] = 10;
arrayInt[1] = 20;
arrayInt[2] = 30;

// Array.Resize(ref arrayInt, arrayInt.Length * 2);
int[] arrayIntDouble = new int[arrayInt.Length * 2];
Array.Copy(arrayInt, arrayIntDouble, arrayInt.Length);

Console.WriteLine("\nfor loop:");
for (int i = 0; i < arrayInt.Length; i++){
  Console.WriteLine($"index: {i}: value: {arrayInt[i]}");
}

Console.WriteLine("\nforeach:");
foreach (int value in arrayInt){
  Console.WriteLine($"value: {value}");
}
