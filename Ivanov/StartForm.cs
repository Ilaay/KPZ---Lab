using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ivanov
{
    public partial class StartForm : Form
    {
        private int counter = 1;
        private List<Task> tasks { get; set; } = new List<Task>();
        public StartForm()
        {
            InitializeComponent();
        }

        private void newBS_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.Show();
            form.FormClosing += Form_FormClosing;
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            var alg = (sender as Form1).ProgramAlgorithm;
            tasks.Add(new Task(() => alg.DoAlgorithm(counter++)));
        }

        private void start_Click(object sender, EventArgs e)
        {
            foreach(var task in tasks)
            {
                task.Start();
            }
        }
    }
}
