using ClassLibrary1;
using ClassModel;
using System.CodeDom;
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Bd Bd;
        public Form1()
        {
            Bd= new Bd();
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(Bd.Valutes.ToArray());
            comboBox2.Items.AddRange(Bd.Valutes.ToArray());
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;
            if(comboBox2.SelectedItem == null) return;

            try
            {
               
                textBox1.Text= Bd.Convet((double)numericUpDown1.Value,
                    comboBox1.SelectedItem as Valute,
                    comboBox2.SelectedItem as Valute).ToString();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}