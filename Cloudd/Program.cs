using System;
using System.Drawing;
using System.Drawing.Text;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Cloudd
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new LoginForm());
        }
        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();


        // helpers
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(
          int nLeftRect, // X-coordinate of upper-left corner or padding at start
            int nTopRect,// Y-coordinate of upper-left corner or padding at the top of the textbox
            int nRightRect, // X-coordinate of lower-right corner or Width of the object
            int nBottomRect,// Y-coordinate of lower-right corner or Height of the object
            int nheightRect, //height of ellipse 
            int nweightRect //width of ellipse
        );
        public static void AddFont(string font, params Control[] controls)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile($@"..\..\Resources\{font}.ttf");
            foreach (Control control in controls)
                control.Font = new Font(pfc.Families[0], control.Font.Size);
        }
        public static bool IsEmailAddrValid(string emailAddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailAddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        public static string GetSha2Hash(string text)
        {
            byte[] result = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(text));
            // not all the bytes in the result are printable characters
            // therefore we'll just store the hexadecimal representation of the byte array
            StringBuilder hash = new StringBuilder();
            foreach (byte b in result)
            {
                hash.Append(b.ToString("x2")); // hexadecimal format
            }
            return hash.ToString();
        }
        public static void IsInputValid(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.KeyChar = char.MinValue;
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
