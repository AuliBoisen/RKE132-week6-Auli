string hello = "we are champions?";

int stringlength = hello.Length;

//string trimmedstring = hello.Trim();
Char firstletter = hello[0];
hello = hello.Trim();

hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?', '!');

firstletter= hello[0];
Console.WriteLine(firstletter);

Console.WriteLine(hello);

//int wordcounter = 1;
//for (int i = 0; i < hello.Length; i++)
//{
  //  if (char.IsWhiteSpace(hello[i]))
    //{
      //  wordcounter++;
    //}
//}

//Console.WriteLine($"word count in {hello}: {wordcounter}words.");
