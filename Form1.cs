namespace VectorGeneration
{
    public partial class Form1 : Form
    {
        private int[] vector;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtLength.Text, out int length) && length > 0)
            {
                vector = new int[length];
                dgvVector.Rows.Clear();
                dgvVector.Columns.Clear();

                dgvVector.Columns.Add("Index", "Index");
                dgvVector.Columns.Add("Value", "Value");

                for (int i = 0; i < length; i++)
                {
                    vector[i] = 0; // Inicializamos en 0
                    dgvVector.Rows.Add(i, vector[i]);
                }

                MessageBox.Show("Vector generated successfully!");
            }
            else
            {
                MessageBox.Show("Enter a valid positive integer for the length.");
            }
        }

        private void dgvVector_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && int.TryParse(dgvVector.Rows[e.RowIndex].Cells[1].Value.ToString(), out int value))
            {
                vector[e.RowIndex] = value;
            }
        }
    }
}
    

