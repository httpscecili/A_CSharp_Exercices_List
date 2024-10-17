using System;

namespace StoryTime
{
  class Program
  {
    static void Main(string[] args)
    {
     string beginning = "Era uma vez, um pudim apaixonado. ";
     string middle = "Estava andando nas ruas quando foi atropelado. PLUFT. ";
     string end = "Pudim amassado.... Pudim amassadooo, pudim amassadooo..... Pudim amassado morreu.";

     string story = beginning + middle + end;
     Console.WriteLine(story);
    }
  }
}
