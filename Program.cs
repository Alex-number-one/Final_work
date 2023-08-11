//КОММИТЫ НЕ ЗАБЫТЬ

string [] Array1 = {"Ske", "32", "error", "qwerty", "65"};
string [] Array2 = new string[Array1.Length];
void first (string [] Array1, string [] Array2)
{
  int clone = 0;
for (int i = 0; i < Array1.Length; i++)
{
  if (Array1[i].Length <= 3 )
  {
Array2[clone] = Array1[i];
clone++;
  }
}
}
void second (string [] Array2)
{
{
for (int i = 0; i < Array1.Length; i++)
{
Console.Write( Array2[i]+ " ");
}
}
}
first(Array1, Array2);
second (Array2);