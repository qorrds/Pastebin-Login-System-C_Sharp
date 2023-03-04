using System;
using System.Drawing;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Console = Colorful.Console;

namespace C.Sharp_Pastebin_Auth
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            string Name = "Login";
            Logo.Text = $"{Name}";
            Key.Text = Properties.Settings.Default.ID; // Key Saver

            /*if (Properties.Settings.Default.ID == "")
            {
                Logo.Text = $"{Name}";
            }
            else
            {
                string logoText = Properties.Settings.Default.ID;
                string Outcome = logoText.Substring((logoText.Length - 5), 5);
                Logo.Text = $"{Name}" + " " + $"'{Outcome}'";
                Key.Text = Properties.Settings.Default.ID;
            }*/
            // End
        }

        private void End_Click(object sender, EventArgs e)
        {
            // Exit App
            Environment.Exit(0);
            Application.Exit();
        }

        private void Key_TextChanged(object sender, EventArgs e)
        {
            // Saves the input of this textbox
            Properties.Settings.Default.ID = Key.Text;
            Properties.Settings.Default.Save();
            // End
        }

        private void Auth_Click(object sender, EventArgs e)
        {
            // Binding HWID To ID From Frist Login
            if (Properties.Settings.Default.First_Login == "true")
            {
                // IF Bind is true
                if (Properties.Settings.Default.Match == Properties.Settings.Default.ID + " - " + System.Security.Principal.WindowsIdentity.GetCurrent().User.Value)
                {
                    string ID = Properties.Settings.Default.ID;
                    string value = "'" + ID + "'";
                    string LINK = "PUT YOUR PASTEBIN LINK HERE"; // Working Pastebin Link { https://pastebin.com/raw/DN2m4SQT }
                    WebClient webClient = new WebClient();

                    bool flag3 = webClient.DownloadString($"{LINK}").Contains(value);
                    if (flag3)
                    {
                        Thread.Sleep(300);
                        Console.WriteLine("Login Worked!", Color.PaleGreen);
                        // IF LOGIN WORKED PUT YOUR CODE HERE
                    }
                    else
                    {
                        Console.WriteLine("ID Wasn't Found :(", Color.Yellow);
                        // IF LOGIN FAILED PUT YOUR CODE HERE
                    }
                }
                else
                {
                    // Login Bind
                    string Author = "N/A";
                    Console.WriteLine($"Possible HWID Problem, if problem continues contact {Author}!", Color.Yellow);
                }
            }
            else
            {
                string ID = Properties.Settings.Default.ID;
                string value = "'" + ID + "'";
                string LINK = "PUT YOUR PASTEBIN LINK HERE"; // Working Pastebin Link: { https://pastebin.com/raw/DN2m4SQT }
                WebClient webClient = new WebClient();
                bool flag3 = webClient.DownloadString($"{LINK}").Contains(value);
                if (flag3)
                {
                    // IF Login Worked
                    Thread.Sleep(300);
                    Properties.Settings.Default.First_Login = "true";
                    Properties.Settings.Default.Match = Properties.Settings.Default.ID + " - " + System.Security.Principal.WindowsIdentity.GetCurrent().User.Value;
                    Properties.Settings.Default.Save();
                    Thread.Sleep(600);
                    Console.WriteLine("HWID Binded! Please Relogin", Color.MediumSlateBlue);
                    // Bind Set
                }
                else
                {
                    // IF Login Failed
                    Console.WriteLine("ID Wasn't Found :(", Color.Yellow);
                }
            }
            // Custom Command - Clear Binds
            if (Key.Text == "Clear_Binds")
            {
                Properties.Settings.Default.First_Login = "";
                Properties.Settings.Default.ID = "";
                Properties.Settings.Default.Match = "";
                Properties.Settings.Default.Save();
                Console.Clear();
                Thread.Sleep(30);
                Console.WriteLine("Cleared Bind!", Color.MediumSlateBlue);
            }
            // End
        }
    }
}
