using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Средство просмотра изображений: при нажатии на кнопку «Открыть»
        //пользователь выбирает файл изображения, и оно показывается на форме.
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var ofd = new OpenFileDialog();
                ofd.Filter = "Image Files (*.BMP; *.JPG; *.GIF; *.PNG)|*.BMP; *.JPG; *.GIF; *.PNG|All files(*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                    pictureBox1.ImageLocation = ofd.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error.\n\nError message: {ex.Message}\n\n" +
                   $"Details:\n\n{ex.StackTrace}");
            }
        }
    }
}
