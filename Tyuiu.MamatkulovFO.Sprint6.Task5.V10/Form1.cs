using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tyuiu.MamatkulovFO.Sprint6.Task5.V10
{
    public partial class Form1 : Form
    {
        private DataService _dataService;
        private object chart1;
        private object labelStatus;
        private object series;
        private object dataGridView1;

        public Form1()
        {
            InitializeComponent();
            _dataService = new DataService();
            this.Load += Form1_Load; // Load event ga ulanish
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string filePath = "InPutDataFileTask5V10.txt";

            try
            {
                var data = _dataService.LoadDataFromFile(filePath);

              


              

               



                // Status label (agar bor bo'lsa)
                if (labelStatus != null) ;
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xato: {ex.Message}", "Xato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    internal class DataService
    {
        public DataService()
        {
        }

        internal object LoadDataFromFile(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}