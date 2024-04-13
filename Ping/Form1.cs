using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace Ping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        static void Main(string[] args)
        {
            try
            {
                Ping myPing = new Ping();
                PingReply reply = myPing.Send("192.168.1.3", 1000);
                if (reply != null)
                {
                    Console.WriteLine("Status :  " + reply.Status + " \n Time : " + reply.RoundtripTime.ToString() + " \n Address : " + reply.Address);
                    //Console.WriteLine(reply.ToString());

                }
            }
            catch
            {
                Console.WriteLine("ERROR: You have Some TIMEOUT issue");
            }
            Console.ReadKey();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}


namespace PingProto
{
    public class Program
    {
        
    }
}
