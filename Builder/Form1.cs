using Builder.BuilderMonitors;
using System.Threading;

namespace Builder
{
    public partial class Form1 : Form
    {
        private readonly MonitorDirector director = new MonitorDirector();
        private Monitor lastMonitor;
        private List<Monitor> monitors = new List<Monitor>();
        public Form1()
        {
            InitializeComponent();
        }
        private void ShowMonitor(Monitor monitor, bool isClone = false)
        {
            lastMonitor = monitor;
            var header = isClone ? "КЛОН МОНІТОРА\r\n" : "";
            textBox1.Text = header + monitor.ShowInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var builder = new GamingMonitorBuilder();
            director.SetBuilder(builder);
            var monitor = director.BuildMonitor("Gaming 27\" QHD 165Hz");
            ShowMonitor(monitor);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var builder = new OfficeMonitorBuilder();
            director.SetBuilder(builder);
            var monitor = director.BuildMonitor("Office 24\"");
            ShowMonitor(monitor);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var builder = new DesignerMonitorBuilder();
            director.SetBuilder(builder);
            var monitor = director.BuildMonitor("Designer 32\" 4K");
            ShowMonitor(monitor);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lastMonitor == null)
            {
                MessageBox.Show("Спочатку створіть монітор за допомогою одного з будівельників.");
                return;
            }

            var clone = lastMonitor.Clone();
            monitors.Add(clone);
            ShowMonitor(clone, isClone: true);
            textBox2.Clear();
            foreach (var monitor in monitors)
            {
                textBox2.AppendText("\r\n-----\r\n");
                textBox2.AppendText(monitor.Model);
                textBox2.AppendText("\r\n-----\r\n");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
