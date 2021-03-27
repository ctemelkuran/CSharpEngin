using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameWorkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // using kullanarak Garbage Collector beklemeden nesneyi bellekten atıyoruz
            // çünkü context pahalı bir nesne, IDisposable interface i .Net'e ait
            using (ETradeCSharpEnginContext context = new ETradeCSharpEnginContext())
            {
                //EntityFramework'te tabloya erişim kodu bu kadar
                //AdoNetDemo örneğinde GetAll() yazmamız gerekti
                dgwProducts.DataSource = context.Products.ToList();
            }
        }
    }
}
