namespace chapter1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text;
            string sex;
            if (r_man.Checked)
                sex = "ÄÐ";
            else
                sex = "Å®";
            
            string mojar = li_mojar.Text;
            string date = dp.Value.ToString();
            string hobbys = "";
            if (c1.Checked) hobbys += c1.Text;
            if (c2.Checked) hobbys += c2.Text;
            if (c3.Checked) hobbys += c3.Text;
            if (c4.Checked) hobbys += c4.Text;
            ListViewItem item = new ListViewItem(name);
            item.SubItems.Add(sex);
            item.SubItems.Add(mojar);
            item.SubItems.Add(date);
            item.SubItems.Add(hobbys);
            this.listView.Items.Add(item);

        }
    }
}