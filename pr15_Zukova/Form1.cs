namespace pr15_Zukova
{
    public partial class Form1 : Form
    {
        private Array array1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void ArrayFill(Array array)
        {
            Random rand = new Random();
            /*for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 100);
            }*/
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int size;
            if (int.TryParse(textBox1.Text, out size))
            {
                array1 = new Array(size);
                ArrayFill(array1);
                MessageBox.Show("Первый массив создан.");

            }
        }
    }
}
