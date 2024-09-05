using iText.Kernel.Pdf;
using iText.Kernel.Utils;
using System.Diagnostics;

namespace CropPDFiText7
{
    public partial class frmMain : Form
    {
        string[] PDFfiles;
        int fileCount = 0;
        string selected_path;
        public bool ischecked = false;
        public frmMain() => InitializeComponent();
        public static int SearchDirectoryTree(string path, out string[] PDFfiles)
        {
            PDFfiles = Directory.GetFiles(path, "*.pdf", SearchOption.AllDirectories);
            return PDFfiles.Length;
        }
        public void CropPDF(string srcPdfPath, int x, int y, int width, int height)
        {
            // Check if the file exists
            if (File.Exists(srcPdfPath))
            {
                using (PdfReader pdfReader = new PdfReader(srcPdfPath))
                using (PdfWriter pdfWriter = new PdfWriter("temp2.pdf")) // Write to a temporary file
                using (PdfDocument pdfDoc = new PdfDocument(pdfReader, pdfWriter))
                {
                    if (ischecked)
                    {
                        PdfPage firstpage = pdfDoc.GetPage(1); // Get the first page

                        // Define the new crop box
                        iText.Kernel.Geom.Rectangle cropBox = new iText.Kernel.Geom.Rectangle(x, y, width, height);

                        // Apply the crop box to the page
                        firstpage.SetCropBox(cropBox);
                    }
                    else
                    {
                        PdfPage firstpage = pdfDoc.GetPage(1); // Get the first page
                        PdfPage Secondpage = pdfDoc.GetPage(2); // Get the Second page
                        PdfPage Thirdpage = pdfDoc.GetPage(3); // Get the Third page

                        // Define the new crop box
                        iText.Kernel.Geom.Rectangle cropBox = new iText.Kernel.Geom.Rectangle(x, y, width, height);
                        iText.Kernel.Geom.Rectangle cropBox3 = new iText.Kernel.Geom.Rectangle(0, 0, 590, 1133);

                        // Apply the crop box to the page
                        firstpage.SetCropBox(cropBox);
                        Secondpage.SetCropBox(cropBox);
                        Thirdpage.SetCropBox(cropBox3);
                    }

                    // Save the document
                    pdfDoc.Close();
                }
                // Replace the original file with the modified file
                File.Delete(srcPdfPath);
                File.Move("temp2.pdf", srcPdfPath);
            }
        }

        public void DuplicatePage(string inputPdfPath, int pageNbr)
        {
            // Check if the file exists
            if (File.Exists(inputPdfPath))
            {
                string outputPdfPath = "temp1.pdf"; // Chemin du fichier PDF de destination

                // Load the original PDF
                using (PdfReader pdfReader = new PdfReader(inputPdfPath))
                using (PdfDocument pdfDoc = new PdfDocument(pdfReader))
                {
                    // Create a PdfWriter for the new PDF
                    using (PdfWriter pdfWriter = new PdfWriter(outputPdfPath))
                    {
                        // Create a new PdfDocument to write the duplicated content
                        using (PdfDocument newPdfDoc = new PdfDocument(pdfWriter))
                        {
                            // Create a PdfMerger to merge documents
                            PdfMerger pdfMerger = new PdfMerger(newPdfDoc);

                            // Loop through each page of the original PDF
                            int numberOfPages = pdfDoc.GetNumberOfPages();
                            for (int i = 1; i <= numberOfPages; i++)
                            {
                                // Merge the current page
                                pdfMerger.Merge(pdfDoc, i, i);
                            }
                            pdfMerger.Merge(pdfDoc, pageNbr, pageNbr);
                        }
                    }
                }
                // Replace the original file with the modified file
                File.Delete(inputPdfPath);
                File.Move(outputPdfPath, inputPdfPath);
            }
        }
        // Button Load ...
        private void btnLoad_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FD = new FolderBrowserDialog();
            if (selected_path != null)
                FD.SelectedPath = selected_path;

            if (FD.ShowDialog() == DialogResult.OK)
            {
                selected_path = FD.SelectedPath;
                txtBoxLoad.Text = FD.SelectedPath;
                fileCount = SearchDirectoryTree(FD.SelectedPath, out PDFfiles);
                // Check the Empty Folder
                lblFileCount.Text = fileCount == 0 ? "Your Folder is Empty" : fileCount + " files.";
                // Clear the Alert message and success message
                lblDone.Text = "";
                lblAlert.Text = "";
                IMGDone.Visible = false;
            }
        }

        // Button Start ...
        private void btnStart_Click(object sender, EventArgs e)
        {
            // Clear the Alert message and success message
            lblDone.Text = "";
            lblAlert.Text = "";
            IMGDone.Visible = false;

            // Check if the user has been selected a folder
            if (PDFfiles == null)
            {
                lblAlert.Text = "Please select or Drag your folder and try again!";
                return;
            }

            // Check the Empty Folder
            if (fileCount == 0)
            {
                lblAlert.Text = "Your Folder is Empty";
                return;
            }

            Cursor = Cursors.WaitCursor;

            try
            {
                foreach (string filePath in PDFfiles)
                {
                    // Start Convertion ...
                    // Convert String to Integer 
                    int x = Convert.ToInt32(txtBoxX.Text);
                    int y = Convert.ToInt32(txtBoxY.Text);
                    int width = Convert.ToInt32(txtBoxWidth.Text);
                    int height = Convert.ToInt32(txtBoxHeight.Text);
                    // Copy the first page to the last page (page 3)
                    if (!ischecked)
                    {
                        DuplicatePage(filePath, 1);
                    }

                    // Crop the pages
                    CropPDF(filePath, x, y, width, height);
                }
            }
            catch (Exception ex)
            {
                // Message Exception
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor = Cursors.Default;
                PDFfiles = null;
                txtBoxLoad.Text = "Select your folder ...";
                lblFileCount.Text = "...";
                return;
            }

            Cursor = Cursors.Default;
            lblDone.Text = "Done";
            IMGDone.Visible = true;
            PDFfiles = null;
            txtBoxLoad.Text = "Select your folder ...";
            lblFileCount.Text = "...";
        }

        // Start methode : Not Enter a Key String just a Key Number
        private static void Not_KeyString(KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                // if you press the BACKSPACE key, the Handled property is set to false, 
                e.Handled = e.KeyChar == 8 ? false : true;
            }
        }

        private void txtBoxX_KeyPress(object sender, KeyPressEventArgs e) => Not_KeyString(e);

        private void txtBoxY_KeyPress(object sender, KeyPressEventArgs e) => Not_KeyString(e);

        private void txtBoxHeight_KeyPress(object sender, KeyPressEventArgs e) => Not_KeyString(e);

        private void txtBoxWidth_KeyPress(object sender, KeyPressEventArgs e) => Not_KeyString(e);

        private void frmMain_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            // Condition >> Drag Folder
            if (Directory.Exists(path))
            {
                txtBoxLoad.Text = path;
                fileCount = SearchDirectoryTree(path, out PDFfiles);
                selected_path = path;
                // Check the Empty Folder
                lblFileCount.Text = fileCount == 0 ? "Your Folder is Empty" : fileCount + " files.";
            }
        }

        private void frmMain_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            IMGDone.Visible = false;
            txtBoxLoad.Text = "Select your folder ...";
            lblDone.Text = "";
            lblFileCount.Text = "...";
            lblAlert.Text = "";
            PDFfiles = null;
        }

        private void GitLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Go to Github repository
            string url = "https://github.com/abdessalam-aadel/CropPDFiText7";

            // Open the URL in the default web browser
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Ensures the URL is opened in the default web browser
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        // checkBox1 for crop yellow and green paper
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                ischecked = true;
                txtBoxX.Text = "793";
                txtBoxY.Text = "0";
                txtBoxWidth.Text = "793";
                txtBoxHeight.Text = "1122";
                checkBox2.Enabled = false;
            }
            else
            {
                ischecked = false;
                // Return default values
                txtBoxX.Text = "580";
                txtBoxY.Text = "0";
                txtBoxWidth.Text = "793";
                txtBoxHeight.Text = "1122";
                checkBox2.Enabled = true;
            }
        }

        // checkBox1 for crop bordereau
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                ischecked = true;
                txtBoxX.Text = "580";
                txtBoxY.Text = "0";
                txtBoxWidth.Text = "793";
                txtBoxHeight.Text = "1122";
                checkBox1.Enabled = false;
            }
            else
            {
                ischecked = false;
                // Return default values
                txtBoxX.Text = "580";
                txtBoxY.Text = "0";
                txtBoxWidth.Text = "793";
                txtBoxHeight.Text = "1122";
                checkBox1.Enabled = true;
            }
        }
    }
}
