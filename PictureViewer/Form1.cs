using Microsoft.VisualBasic;

namespace PictureViewer
{

    //przykladowy url https://localist-images.azureedge.net/photos/38634324197092/original/4a37e2cbf36ca098deee95971abe9166a2841952.png
    public partial class Form1 : Form
    {
        private OpenFileDialog _filedialog;
        private string _filePath;
        private string _filePathUrl;
        AddURL addUrl = new AddURL();
        public Form1()
        {
            InitializeComponent();
            _filePath = Path.Combine(Environment.CurrentDirectory, "text.txt");
            ChekingFileOnStart(_filePath);
            HideRemoveBtn();
        }

        private void HideRemoveBtn()
        {
            if (pbPicture.Image != null)
            {
                btnRemove.Visible = true;
            }
            else
            {
                btnRemove.Visible = false;
            }
        }
        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            ImportImageFroimFile();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            pbPicture.Image = null;
            File.WriteAllText(_filePath, "");
            HideRemoveBtn();
        }

        private void btnAddUrl_Click(object sender, EventArgs e)
        {
            addUrl.FormClosing += AddUrl_FormClosing;
            addUrl.ShowDialog();
        }

        private void AddUrl_FormClosing(object? sender, FormClosingEventArgs e)
        {
            _filePathUrl = addUrl.AdresUrl;

            LoadImageFromUrl(_filePathUrl);
            File.WriteAllText(_filePath, _filePathUrl);
        }
        private void LoadImageFromUrl(string imageUrl)
        {
            pbPicture.WaitOnLoad = false;
            pbPicture.LoadAsync(imageUrl);
            lbNazwaPliku.Text = Path.GetFileName(imageUrl);
            lbNazwaPliku.TextAlign = ContentAlignment.MiddleCenter;
            pbPicture.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void importFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportImageFroimFile();
        }

        private void ImportImageFroimFile()
        {
            _filedialog = new OpenFileDialog();

            if (_filedialog.ShowDialog() == DialogResult.OK)
            {
                ShowImage(_filedialog.FileName);

                var pathText = _filedialog.FileName;
                File.WriteAllText(_filePath, pathText);

                HideRemoveBtn();
            }
        }

        private void importFromURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addUrl.FormClosing += AddUrl_FormClosing;
            addUrl.ShowDialog();
        }
        private void ShowImage(string imageFile)
        {
            if (imageFile.Contains("http"))
            {
                LoadImageFromUrl(imageFile);
                
                return;
            }
            pbPicture.SizeMode = PictureBoxSizeMode.Zoom;
            pbPicture.Image = Image.FromFile(imageFile);
            lbNazwaPliku.Text = Path.GetFileName(imageFile);
            lbNazwaPliku.TextAlign = ContentAlignment.MiddleCenter;
        }
        private void ChekingFileOnStart(string filePath)
        {
            if (File.Exists(filePath) && File.ReadAllText(filePath) != "")
            {
                ShowImage(File.ReadAllText(filePath));
            }
        }
    }
}