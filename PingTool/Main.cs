using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace PingTool
{
    public partial class MainFrame : Form
    {
        private Timer timer;
        public MainFrame()
        {
            InitializeComponent();
            InitializeTimer();
            stop_btn.Visible = false;
            start_btn.Visible = true;
            ping_result_box.Text = "";
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            string user_input = user_input_box.Text;

            if (!string.IsNullOrWhiteSpace(user_input))
            {
                Ping ping = new Ping();
                try
                {

                    PingReply reply = ping.Send(user_input);

                    if (reply.Status == IPStatus.Success)
                    {
                        int responseTime = (int)reply.RoundtripTime;

                        ping_result_box.Text = reply.RoundtripTime.ToString();

                        if (responseTime <= 60)
                        {
                            ping_result_box.ForeColor = Color.LimeGreen;
                        }
                        else if (responseTime >= 61 && responseTime <= 100)
                        {
                            ping_result_box.ForeColor = Color.Orange;
                        }
                        else
                        {
                            ping_result_box.ForeColor = Color.Red;
                        }

                        ping_result_box.Refresh();

                    }
                }
                catch (PingException)
                {
                    MessageBox.Show("Ping request timed out. Restarting the process...");
                    ping_result_box.ForeColor = Color.Black; // Reset color in case of timeout

                    // Restart the process by stopping and then starting the timer
                    ping_result_box.Text = "";
                    stop_btn.Visible = false;
                    start_btn.Visible = true;
                    timer.Stop();
                    timer.Start();
                }
                catch (Exception ex)
                {
                    timer.Stop();
                    MessageBox.Show($"Error while pinging: {ex.Message}", "Ping Result");
                    ping_result_box.ForeColor = Color.Black;
                    ping_result_box.Text = "";
                    stop_btn.Visible = false;
                    start_btn.Visible = true;
                }
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Please enter a target IP address or hostname.", "Error");
                ping_result_box.ForeColor = Color.Black;
                ping_result_box.Text = "";
                stop_btn.Visible = false;
                start_btn.Visible = true;
            }
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            timer.Start();
            stop_btn.Visible = true;
            start_btn.Visible = false;
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            timer.Stop();
            ping_result_box.ForeColor = Color.Black;
            ping_result_box.Text = "";
            stop_btn.Visible = false;
            start_btn.Visible = true;
        }

        private void Settings_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Work In Progress");
        }

        private void btn_x_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
