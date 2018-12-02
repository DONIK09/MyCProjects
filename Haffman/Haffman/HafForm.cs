using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haffman
{
    public partial class HafForm : Form
    {
        public HafForm()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Picture(*.bmp)|*.bmp|Haffman File(*.dat)|*.dat";
            openFileDialog.InitialDirectory = "c:\\";
        }
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            loadImage();
        }
        private void loadImage()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                labelFileName.Text = Path.GetFileName(filePath);
                labelFileName.Visible = true;
                pictureOut.Image = Image.FromFile(filePath);
                convertToByteArray();
            }
        }
        private void convertToByteArray()
        {
            Image image = Image.FromFile(filePath);
            ImageConverter imageConverter = new ImageConverter();
            imageByteArray = (byte[])imageConverter.ConvertTo(image, typeof(byte[]));
        }
        public string filePath { get; set; }
        public OpenFileDialog openFileDialog { get; set; }
        public byte[] imageByteArray { get; set; }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            if (imageByteArray == null) return;
            HaffmanTree haffmanTree = new HaffmanTree(imageByteArray);
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                labelFileName.Text = Path.GetFileName(filePath);
                labelFileName.Visible = true;
                HaffmanTree haffmanTree = new HaffmanTree();
                ImageConverter imageConverter = new ImageConverter();
                ArrayList decrypted = haffmanTree.decrypt(haffmanTree.deserialize(filePath));
                byte[] imageByte = decrypted.OfType<byte>().ToArray();
                pictureOut.Image = (Image)imageConverter.ConvertFrom(imageByte);
            }
        }
    }
}
