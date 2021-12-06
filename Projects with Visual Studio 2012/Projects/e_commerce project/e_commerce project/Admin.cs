using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
namespace e_commerce_project
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
       
        private void NewBrand_Click(object sender, EventArgs e)
        {
            New_Brand form = new New_Brand();
            this.Hide();
            form.Show();
        }

         public void NewItem_Click(object sender, EventArgs e)
        {
            New_Item form = new New_Item();
            this.Hide();
            form.Show();
            
        }

         private void UpdateBrand_Click(object sender, EventArgs e)
         {
             Update_Brand form = new Update_Brand();
             this.Hide();
             form.Show();
         }

         private void UpdateItem_Click(object sender, EventArgs e)
         {
             Update_Item form = new Update_Item();
             this.Hide();
             form.Show();
         }

         private void DisplayBrand_Click(object sender, EventArgs e)
         {
             Display_Brand form = new Display_Brand();
             this.Hide();
             form.Show();
         }

         private void DIsplayItem_Click(object sender, EventArgs e)
         {
             Display_Item form = new Display_Item();
             this.Hide();
             form.Show();
         }
         
    }
}
