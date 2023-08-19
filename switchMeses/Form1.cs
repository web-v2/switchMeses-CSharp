namespace switchMeses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void changeMes(object sender, EventArgs e)
        {
            int num = int.Parse(comboBox1.SelectedItem.ToString());

            //MessageBox.Show("" + num);

            switch (num)
            {
                case 1:
                    {
                        label1.Text = "ENERO";
                        break;
                    }
                case 2:
                    {
                        label1.Text = "FEBRERO";
                        break;
                    }
                case 3:
                    {
                        label1.Text = "MARZO";
                        break;
                    }
                case 4:
                    {
                        label1.Text = "ABRIL";
                        break;
                    }
                case 5:
                    {
                        label1.Text = "MAYO";
                        break;
                    }
                case 6:
                    {
                        label1.Text = "JUNIO";
                        break;
                    }
                case 7:
                    {
                        label1.Text = "JULIO";
                        break;
                    }
                case 8:
                    {
                        label1.Text = "AGOSTO";
                        break;
                    }
                case 9:
                    {
                        label1.Text = "SEPTIEMBRE";
                        break;
                    }
                case 10:
                    {
                        label1.Text = "OCTUBRE";
                        break;
                    }
                case 11:
                    {
                        label1.Text = "NOVIEMBRE";
                        break;
                    }
                case 12:
                    {
                        label1.Text = "DICIEMBRE";
                        break;
                    }
            }
        }
    }
}