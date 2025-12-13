using Builder.BuilderMonitors;

namespace Builder
{
    public partial class Form1 : Form
    {
        private readonly MonitorDirector director = new MonitorDirector();
        public Form1()
        {
            InitializeComponent();
        }
        private void ShowMonitor(Monitor monitor)
        {

            textBox1.Text = monitor.ShowInfo();
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
    }
}
