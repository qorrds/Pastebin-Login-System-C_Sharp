using System.Windows.Forms;
using Console = Colorful.Console;

namespace C.Sharp_Pastebin_Auth
{
    class Logs
    {
        static void Main(string[] args)
        {
            // Auto Updater {Working Pastebin Link: https://pastebin.com/raw/dzMnhS34}

            /*string Path = "";
            string Build = "1";
            string NewVersion = "2";
            System.Net.WebClient request = new System.Net.WebClient();
            string Update = request.DownloadString("PUT YOUR PASTEBIN LINK HERE");
            if (Update.Contains(Build))
            {
                Application.Run(new LoginForm());
            }
            else
            {
                Console.WriteLine($"Update Avaliable! Download Build '{Build}' --At '{Path}'", Color.Red);
                Thread.Sleep(3000);
                Process.Start($"{Path}");
                Thread.Sleep(500);
                Environment.Exit(0);
            }*/

            // End  | Only use this if you want to its not needed.


            // Load

            Console.Title = "Pastebin C# Login System";
            Application.Run(new LoginForm());
        }
    }
}
