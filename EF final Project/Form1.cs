namespace EF_final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { }

        private void LoadForm(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            mainForm.Controls.Clear();
            mainForm.Controls.Add(form);
            form.Show();
        }

        private void Products_Click(object sender, EventArgs e)
        {
            LoadForm(new ProductForm());
        }

        private void Categories_Click(object sender, EventArgs e)
        {
            LoadForm(new ProductLineForm());
        }

        private void Order_Click(object sender, EventArgs e)
        {
            LoadForm(new OrderForm());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            LoadForm(new OrderProductForm());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            LoadForm(new EmployeeForm());
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            LoadForm(new CustomerForm());
        }

        private void Offices_Click(object sender, EventArgs e)
        {
            LoadForm(new OfficeForm());
        }
    }
}

