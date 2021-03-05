using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototypesCSharpWindowsFormsApp
{
    public partial class FormTasks : Form
    {
        private CultureInfo ci = CultureInfo.InvariantCulture;

        private Dictionary<string, string> months = new Dictionary<string, string>()
            {
        {"01","January"},
        {"02","February"},
        {"03","March"},
        {"04","April"},
        {"05","May"},
        {"06","June"},
        {"07","July"},
        {"08","August"},
        {"09","September"},
        {"10","October"},
        {"11","November"},
        {"12","December"},
            };

        public FormTasks()
        {
            InitializeComponent();
        }

        public async Task<List<string>> RunAsync(Dictionary<string, string> months)
        {
            var tasks = new List<Task>();
            var reultsts = new List<string>();
            Console.WriteLine("Start RunAsync");
            dataGridView1.ReadOnly = false; //Before modifying, it is required.
            foreach (KeyValuePair<string, string> month in months)
            {
                dataGridView1.Rows.Add(); //Inserting first row if yet there is no row, first row number is '0'
                dataGridView1.Rows[Convert.ToInt32(month.Key) - 1].Cells[0].Value = month.Key;
                dataGridView1.Rows[Convert.ToInt32(month.Key) - 1].Cells[1].Value = month.Value;

                tasks.Add(Task.Run(() =>
                {
                    reultsts.AddRange(TaskRun(month.Key, month.Value).Result);
                }));
            }
            Task t = Task.WhenAll(tasks);
            try
            {
                t.Wait();
            }
            catch { }
            Console.WriteLine("End RunAsync");
            return reultsts;
        }

        public async Task<List<string>> TaskRun(string monthNo, string monthName)
        {
            Random random = new Random();
            string time;
            int sleep;
            var results = new List<string>();

            for (int a = 1; a <= 3; a++)
            {
                sleep = random.Next(1, 10) * 1000;
                System.Threading.Thread.Sleep(sleep);

                time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", ci);

                dataGridView1.Rows[Convert.ToInt32(monthNo) - 1].Cells[a + 1].Value = time;
                results.Add(monthName.PadRight(100) + "try on " + a + " -> " + time);
            }

            return results;
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            var reultsts = new List<string>();
            dataGridView1.ClearSelection();

            MessageBox.Show("Start Main");

            reultsts = RunAsync(months).Result;

            textBox1.Text = String.Join(Environment.NewLine, reultsts);

            MessageBox.Show("End Main get reultsts " + reultsts.Count() + " months");
        }

    }
}