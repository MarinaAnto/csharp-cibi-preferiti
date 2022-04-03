// See https://aka.ms/new-console-template for more information

string[] cibi = { "carbonara", "nutella", "cappuccino", "pizza", "quacker" };
int pos = -1;
foreach (string s in cibi){
    pos++;
    Console.WriteLine(pos + " : " + s);
}
Console.WriteLine("La lunghezza è: " + cibi.Length);
Console.WriteLine("Il mio cibo top è: " + cibi[0]);
Console.WriteLine("Il mio cibo preferito ma non troppo è: " + cibi[cibi.Length - 1]);
