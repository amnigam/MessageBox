using System;
using System.Runtime.InteropServices; 

namespace MessageBox
{
    internal class Program
    {
        [DllImport("user32.dll")]
        public static extern int MessageBox(IntPtr hWnd, string lpText, string lpCaption, uint uType); 
        static void Main(string[] args)
        {
            MessageBox(IntPtr.Zero, "Hello.. We are here!", "Sampark", 0); 
        }
    }
}
