using System.Text;

var text = new StringBuilder();
bool start = false;
Console.WriteLine("Write 'start' to start writing journal and 'stop' to stop writing");
while (true)
{
   var input = Console.ReadLine();
    if(input == "stop")
    {
        text.Append("Jean-Luc Picard");
        break; 
    }

    if (input == "start")
    {
        start = true;
        text.Append("Captain's log");
        text.Append("Stardate <" + DateTime.Now.ToString("MM/dd/yyyy") + ">");
        continue;
    }

    if (start)  
        text.Append(input + "\n"); 
    else
        Console.WriteLine("You'r not writing to your Journal\n");
}
string path = DateTime.Now.ToString("MMddyyyy") + ".txt";
File.WriteAllText(path, text.ToString());