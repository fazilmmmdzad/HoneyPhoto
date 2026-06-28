using HoneyPhoto.Properties;
using Microsoft.Office.Core;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Word = Microsoft.Office.Interop.Word;

namespace HoneyPhoto
{
    public partial class MainForm : Form
    {
        private Bitmap? _originalImage;
        private Bitmap? _previewImage;
        private string? _filePath;
        private bool _isModified = false;

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            using OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.jfif;*.bmp;*.gif;*.ico;*.tiff";

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            LoadImage(dialog.FileName);
        }
        private void LoadImage(string path)
        {
            _originalImage?.Dispose();
            _previewImage?.Dispose();

            using Bitmap temp = new Bitmap(path);

            _originalImage = new Bitmap(temp);
            _previewImage = new Bitmap(temp);

            _filePath = path;
            _isModified = false;

            pictureBox.Image = _previewImage;

            nudWidth.Value = _previewImage.Width;
            nudHeight.Value = _previewImage.Height;

            string extension = Path.GetExtension(path).TrimStart('.').ToUpper();

            if (extension == "JPE")
                extension = "JPEG";

            int index = cmbFileType.FindStringExact(extension);

            if (index >= 0)
                cmbFileType.SelectedIndex = index;
            else
                cmbFileType.Text = extension;

            lblFileName.Visible = true;
            lblFileName.Text = $"⎢ {Path.GetFileName(path)}";

            UpdateStatusBar();
        }

        private void UpdateStatusBar()
        {
            if (_previewImage == null)
                return;

            FileInfo file = new FileInfo(_filePath!);

            lblStatus.Text = _isModified ? "Modified" : "Ready";

            lblType.Text = cmbFileType.SelectedItem?.ToString() ?? file.Extension.Replace(".", "").ToUpper();

            lblSize.Text = $"{_previewImage.Width} x {_previewImage.Height}";

            lblFileSize.Text = FormatFileSize(file.Length);
        }

        private string FormatFileSize(long bytes)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };

            double len = bytes;
            int order = 0;

            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len /= 1024;
            }

            return $"{len:0.##} {sizes[order]}";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (_originalImage == null)
                return;

            _previewImage?.Dispose();

            _previewImage = new Bitmap(_originalImage);

            pictureBox.Image = _previewImage;

            _isModified = false;

            string extension = Path.GetExtension(_filePath!).TrimStart('.').ToUpper();

            if (extension == "JPE")
                extension = "JPEG";

            int index = cmbFileType.FindStringExact(extension);

            if (index >= 0)
                cmbFileType.SelectedIndex = index;

            nudWidth.Value = _originalImage.Width;
            nudHeight.Value = _originalImage.Height;

            UpdateStatusBar();
        }

        private void ResizePreview(int width, int height)
        {
            if (_originalImage == null)
                return;

            _previewImage?.Dispose();

            Bitmap resized = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(resized))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                g.DrawImage(_originalImage, 0, 0, width, height);
            }

            _previewImage = resized;

            pictureBox.Image = _previewImage;

            _isModified = true;

            UpdateStatusBar();
        }

        private void btnApplyResize_Click(object sender, EventArgs e)
        {
            ResizePreview((int)nudWidth.Value, (int)nudHeight.Value);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cmbFileType.Items.AddRange(new object[]
            {
                "BMP",
                "GIF",
                "ICO",
                "JFIF",
                "JPEG",
                "JPG",
                "PNG",
                "TIFF"
            });

            #region
            label6.Visible = false;
            cmbFileType.Visible = false;
            btnConvert.Visible = false;
            panel10.Visible = false;
            panel14.Location = new Point(panel14.Location.X, 65);
            IsDownConvertToPanel = false;
            btnDownConvertToPanel.Image = Resources.above;
            #endregion

            #region
            label4.Visible = false;
            label5.Visible = false;
            nudHeight.Visible = false;
            nudWidth.Visible = false;
            btnApplyResize.Visible = false;
            panel11.Visible = false;
            IsDownResizePanel = false;
            btnDownResizePanel.Image = Resources.above;
            #endregion

            pnlHeader.MouseDown += new MouseEventHandler(pnlHeader_MouseDown);
            pnlHeader.MouseMove += new MouseEventHandler(pnlHeader_MouseMove);
            pnlHeader.MouseUp += new MouseEventHandler(pnlHeader_MouseUp);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                btnSaveFile.PerformClick();
                return true;
            }

            if (keyData == (Keys.Control | Keys.O))
            {
                btnOpenFile.PerformClick();
                return true;
            }

            if (keyData == (Keys.Control | Keys.R))
            {
                btnRefresh.PerformClick();
                return true;
            }

            if (keyData == (Keys.Control | Keys.L))
            {
                btnRotateLeft.PerformClick();
                return true;
            }

            if (keyData == (Keys.Control | Keys.F))
            {
                btnFlip.PerformClick();
                return true;
            }

            if (keyData == (Keys.Control | Keys.E))
            {
                btnExport.PerformClick();
                return true;
            }

            if (keyData == (Keys.Control | Keys.I))
            {
                btnInfo.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (cmbFileType.SelectedItem == null)
                return;

            _isModified = true;

            UpdateStatusBar();
        }

        private bool IsDownConvertToPanel = true;
        private void btnDownConvertToPanel_Click(object sender, EventArgs e)
        {
            if (IsDownConvertToPanel)
            {
                label6.Visible = false;
                cmbFileType.Visible = false;
                btnConvert.Visible = false;
                panel10.Visible = false;
                panel14.Location = new Point(panel14.Location.X, 65);
                IsDownConvertToPanel = false;
                btnDownConvertToPanel.Image = Resources.above;
            }
            else
            {

                label6.Visible = true;
                cmbFileType.Visible = true;
                btnConvert.Visible = true;
                panel10.Visible = true;
                panel14.Location = new Point(panel14.Location.X, 177);
                IsDownConvertToPanel = true;
                btnDownConvertToPanel.Image = Resources.down;
            }
        }

        private bool IsDownResizePanel = true;

        private void btnDownResizePanel_Click(object sender, EventArgs e)
        {
            if (IsDownResizePanel)
            {
                label4.Visible = false;
                label5.Visible = false;
                nudHeight.Visible = false;
                nudWidth.Visible = false;
                btnApplyResize.Visible = false;
                panel11.Visible = false;
                IsDownResizePanel = false;
                btnDownResizePanel.Image = Resources.above;
            }
            else
            {

                label4.Visible = true;
                label5.Visible = true;
                nudHeight.Visible = true;
                nudWidth.Visible = true;
                btnApplyResize.Visible = true;
                panel11.Visible = true;
                IsDownResizePanel = true;
                btnDownResizePanel.Image = Resources.down;
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (_previewImage == null)
                return;

            SaveFileDialog dialog = new SaveFileDialog();

            string extension = cmbFileType.SelectedItem!.ToString()!.ToLower();

            dialog.Filter = $"{extension.ToUpper()} File|*.{extension}";
            dialog.DefaultExt = extension;

            dialog.FileName = $"Honey Photo {Path.GetFileNameWithoutExtension(_filePath)}.{extension}";

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            SaveImage(dialog.FileName, extension);
        }

        private void SaveImage(string path, string extension)
        {
            switch (extension)
            {
                case "png":
                    _previewImage!.Save(path, System.Drawing.Imaging.ImageFormat.Png);
                    break;

                case "jfif":
                case "jpeg":
                case "jpg":
                    _previewImage!.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);
                    break;

                case "bmp":
                    _previewImage!.Save(path, System.Drawing.Imaging.ImageFormat.Bmp);
                    break;

                case "gif":
                    _previewImage!.Save(path, System.Drawing.Imaging.ImageFormat.Gif);
                    break;

                case "tiff":
                    _previewImage!.Save(path, System.Drawing.Imaging.ImageFormat.Tiff);
                    break;

                case "ico":
                    using (Icon icon = Icon.FromHandle(((Bitmap)_previewImage).GetHicon()))
                    using (FileStream fs = new FileStream(path, FileMode.Create))
                    {
                        icon.Save(fs);
                    }
                    break;
            }

            _isModified = false;

            UpdateStatusBar();

            MessageBox.Show("File saved successfully.", "Honey Photo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnRotateLeft_Click(object sender, EventArgs e)
        {
            if (_previewImage == null)
                return;

            _previewImage.RotateFlip(RotateFlipType.Rotate270FlipNone);

            pictureBox.Image = null;
            pictureBox.Image = _previewImage;

            _isModified = true;

            nudHeight.Value = _previewImage.Height;
            nudWidth.Value = _previewImage.Width;

            UpdateStatusBar();
        }

        private void btnFlip_Click(object sender, EventArgs e)
        {
            if (_previewImage == null)
                return;

            _previewImage.RotateFlip(RotateFlipType.RotateNoneFlipX);

            pictureBox.Image = null;
            pictureBox.Image = _previewImage;

            _isModified = true;

            UpdateStatusBar();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            pnlExportTo.Visible = pnlExportTo.Visible ? false : true;
            btnExport.BackColor = pnlExportTo.Visible ? Color.Silver : Color.Gainsboro;
        }

        private void btnPowerPoint_Click(object sender, EventArgs e)
        {
            if (_previewImage == null)
                return;

            string tempImage = Path.Combine(Path.GetTempPath(), Guid.NewGuid() + ".png");

            _previewImage.Save(tempImage, System.Drawing.Imaging.ImageFormat.Png);

            PowerPoint.Application app = new PowerPoint.Application();

            app.Visible = MsoTriState.msoTrue;

            PowerPoint.Presentation presentation = app.Presentations.Add();

            PowerPoint.Slide slide = presentation.Slides.Add(
                1,
                PowerPoint.PpSlideLayout.ppLayoutBlank);

            float slideWidth = presentation.PageSetup.SlideWidth;
            float slideHeight = presentation.PageSetup.SlideHeight;

            float imageWidth = _previewImage.Width;
            float imageHeight = _previewImage.Height;

            float scale = Math.Min(slideWidth / imageWidth, slideHeight / imageHeight);

            float newWidth = imageWidth * scale;
            float newHeight = imageHeight * scale;

            float left = (slideWidth - newWidth) / 2;
            float top = (slideHeight - newHeight) / 2;

            slide.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, 20, 10, 300, 30).TextFrame.TextRange.Text = "Honey Photo";

            slide.Shapes.AddPicture(
                tempImage,
                MsoTriState.msoFalse,
                MsoTriState.msoTrue,
                left,
                top,
                newWidth,
                newHeight);
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            if (_previewImage == null)
                return;

            string tempImage = Path.Combine(Path.GetTempPath(), Guid.NewGuid() + ".png");

            _previewImage.Save(tempImage, System.Drawing.Imaging.ImageFormat.Png);

            Word.Application app = new Word.Application();

            app.Visible = true;

            Word.Document document = app.Documents.Add();

            document.Content.Text = "Honey Photo\n\n";

            Word.InlineShape picture = document.InlineShapes.AddPicture(tempImage);

            picture.LockAspectRatio = MsoTriState.msoTrue;
            picture.Width = 450;
        }

        private void btnOutlook_Click(object sender, EventArgs e)
        {
            if (_previewImage == null)
                return;

            string tempImage = Path.Combine(Path.GetTempPath(), Guid.NewGuid() + ".png");

            _previewImage.Save(tempImage, System.Drawing.Imaging.ImageFormat.Png);

            Outlook.Application app = new Outlook.Application();

            Outlook.MailItem mail =
                (Outlook.MailItem)app.CreateItem(Outlook.OlItemType.olMailItem);

            mail.Subject = "Image from Honey Photo";

            mail.HTMLBody = "This image was exported from Honey Photo.";

            mail.Attachments.Add(tempImage);

            mail.Display();
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (_previewImage == null)
                return;

            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = "PDF File|*.pdf";
            dialog.FileName = $"Honey Photo {Path.GetFileNameWithoutExtension(_filePath)}.pdf";

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            CreatePdf(dialog.FileName);
        }
        private void CreatePdf(string filePath)
        {
            string tempImage = Path.Combine(Path.GetTempPath(), Guid.NewGuid() + ".png");

            _previewImage!.Save(tempImage, System.Drawing.Imaging.ImageFormat.Png);

            PdfDocument document = new PdfDocument();

            document.Info.Title = "Honey Photo";
            document.Info.Author = "Honey Photo";
            document.Info.Creator = "Honey Photo";
            document.Info.Subject = "Exported Image";

            PdfPage page = document.AddPage();

            XGraphics gfx = XGraphics.FromPdfPage(page);

            XImage image = XImage.FromFile(tempImage);

            double maxWidth = page.Width - 40;
            double maxHeight = page.Height - 100;

            double scale = Math.Min(maxWidth / image.PixelWidth,
                                    maxHeight / image.PixelHeight);

            double width = image.PixelWidth * scale;
            double height = image.PixelHeight * scale;

            double x = (page.Width - width) / 2;
            double y = 20;

            gfx.DrawImage(image, x, y, width, height);

            document.Save(filePath);

            image.Dispose();

            File.Delete(tempImage);

            MessageBox.Show("File saved successfully.", "Honey Photo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnClipboard_Click(object sender, EventArgs e)
        {
            if (_previewImage == null)
                return;

            Clipboard.SetImage(_previewImage);

            MessageBox.Show(
                "Image copied to clipboard successfully.",
                "Honey Photo");
        }

        private void btnPaint_Click(object sender, EventArgs e)
        {
            if (_previewImage == null)
                return;

            string extension = cmbFileType.SelectedItem!.ToString()!.ToLower();

            string tempImage = Path.Combine(
                Path.GetTempPath(),
                $"Honey Photo_{Guid.NewGuid()}.{extension}");

            SaveImage(tempImage, extension);

            Process.Start(new ProcessStartInfo
            {
                FileName = "mspaint.exe",
                Arguments = $"\"{tempImage}\"",
                UseShellExecute = true
            });
        }

        private void btnPhotos_Click(object sender, EventArgs e)
        {
            if (_previewImage == null)
                return;

            string extension = cmbFileType.SelectedItem!.ToString()!.ToLower();

            string tempImage = Path.Combine(
                Path.GetTempPath(),
                $"Honey Photo_{Guid.NewGuid()}.{extension}");

            SaveImage(tempImage, extension);

            Process.Start(new ProcessStartInfo
            {
                FileName = tempImage,
                UseShellExecute = true
            });
        }

        private void btnFileExplorer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_filePath))
                return;

            Process.Start("explorer.exe", $"/select,\"{_filePath}\"");
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            InformationForm form = new InformationForm();
            form.ShowDialog();
        }
    }
}
