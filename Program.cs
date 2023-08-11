//КОММИТЫ НЕ ЗАБЫТЬ
int clone = 0;
string [] Array1 = {"Snake", "32", "error", "qwerty", "65"};
string [] Array2 = {Array1.Length};
for (int i = 0; i < Array1.Length; i++)
{
  if (Array1[i].Length <= 3 )
  {
Array2[clone] = Array1[i];
clone++;
  }
}
