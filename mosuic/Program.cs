
internal class Program
{
    static
        float[] notes = {16.35f, 18.35f,
        20.60f,21.83f,
        24.5f,27.5f,30.87f,29.14f,25.96f,23.12f,19.45f,17.32f
    };
    static float tempo = 1;
    static string song = "c4e c4e g4e g4e a4e a4e g4e f4e f4e e4e e4e d4e d4e c4e g4e g4e f4e f4e e4e e4e d4e c4e g4e g4e a4e g4e f4e f4e e4e e4e d4e c4e";
    static string tempsong = "";
    static string temptempo = "";
    static void mygudsong(char note, int oct, char dur)
    {
        float frequency;
        switch (note)

        {
            case 'c':
                frequency = notes[0];
                break;
            case 'd':
                frequency = notes[1];
                break;
            case 'e':
                frequency = notes[2];
                break;
            case 'f':
                frequency = notes[3];
                break;
            case 'g':
                frequency = notes[4];
                break;
            case 'b':
                frequency = notes[5];
                break;
            case 'a':
                frequency = notes[6];
                break;
            case 'A':
                frequency = notes[7];
                    break;
            case 'C':
                frequency = notes[12];
                break;
            case 'D':
                frequency = notes[11];
                break;
            case 'E':
                frequency = notes[10];
                break;
            case 'F':
                frequency = notes[9];
                break;
            case 'G':
                frequency = notes[8];
                break;
            default:
                frequency = 0;
                break;

        }
        int delay = 0;
        for (int i = 0; i < oct; i++)
        {
            frequency *= 2;

        }

        switch (dur)
        {
            case 'e':
                delay = 125;
                break;
            case 'a':
                delay = 300;
                break;
            case 'c':
                delay = 250;
                break;
            case 'f':
                delay = 200;
                break;
            case 'g':
                delay = 150;
                break;
            case 'b':
                delay = 100;
                break;
            case 'w':
                delay = 1000;
                break;
            case 'h':
                delay = 500;
                break;
        }
        delay = (int)(delay / tempo);
        if (frequency > 36 && frequency < 32000)
            Console.Beep((int)frequency, delay);
        else
        {
            DateTime target = DateTime.Now.AddMilliseconds(delay);
            while (DateTime.Now <= target) ;
        }
    }
    private static void Main(string[] args)
    {
        do
        {

            Console.WriteLine("Write your beautiful song");
            tempsong = Console.ReadLine();
            if (!string.IsNullOrEmpty(tempsong))
            {
                song = tempsong;
            }
            else
            {
                Console.WriteLine("So, my good rendition of Twinkle Twinkle it is then?");
            }
            Console.WriteLine("HOW FAST SHOULD I BE?");
            temptempo = Console.ReadLine();
                if (!string.IsNullOrEmpty(temptempo)) {
                tempo = float.Parse(temptempo);
            }
            else
            {
                Console.WriteLine("I could not hear you, so I'll just go with 1");
            }
            Console.WriteLine("HERE IT IS! THE BEST SONG IN THE WORLD, i hope");
            for (int i = 0; i < song.Length; i += 4)
               
            {
                string s = (song.Substring(i + 1, 1));
                mygudsong(song[i],
                    int.Parse(s),
                    song[i + 2]); ;
            }
            Console.Clear();
        } 
        while (song != "");
    }
}
