using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PatientAdmissionForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=HospitalDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");

        private void label14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text) ||
                string.IsNullOrWhiteSpace(comboBox1.Text) ||
                string.IsNullOrWhiteSpace(comboBox2.Text) ||
                string.IsNullOrWhiteSpace(comboBox3.Text))
            {
                MessageBox.Show("يرجى ملء جميع الحقول أولاً!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox5.Text.Trim(), out int age))
            {
                MessageBox.Show("يرجى إدخال عمر صحيح (أرقام فقط)!", "خطأ في الإدخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox5.Focus();
                return;
            }

            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Patient (Fname, Gname, Age, Ethnicity, ResidentialAddress, Eadd, Gender, BGrop, PNumber) VALUES (@Fname, @Gname, @Age, @Ethnicity, @ResAddress, @Eadd, @Gender, @BGrop, @PNumber)", con);

            cmd.Parameters.AddWithValue("@Fname", textBox1.Text);
            cmd.Parameters.AddWithValue("@Gname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Age", textBox5.Text);
            cmd.Parameters.AddWithValue("@Ethnicity", comboBox1.Text);
            cmd.Parameters.AddWithValue("@ResAddress", textBox4.Text);
            cmd.Parameters.AddWithValue("@Eadd", textBox3.Text);
            cmd.Parameters.AddWithValue("@Gender", comboBox2.Text);
            cmd.Parameters.AddWithValue("@BGrop", comboBox3.Text);
            cmd.Parameters.AddWithValue("@PNumber", textBox6.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("تم حفظ بيانات المريض بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

            con.Close();
        }
    }
}
