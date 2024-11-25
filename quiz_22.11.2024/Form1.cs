namespace quiz_22._11._2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (radioButton2.Checked) s++;
            if (checkBox2.Checked) s++;
            if (checkBox4.Checked) s++;
            if (checkBox5.Checked) s++;
            if (checkBox1.Checked || checkBox3.Checked) s=0;
            MessageBox.Show("Punctaj=" + s.ToString());


        }
    }
}
