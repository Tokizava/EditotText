using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Font = System.Drawing.Font;
using Word = Microsoft.Office.Interop.Word;

namespace EditorText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // а почему бы и нет
            /*
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (System.IO.StreamWriter sr = new System.IO.StreamWriter(sfd.FileName, false))
                {
                    foreach(var line in richTextBox1.Lines)
                    {
                        sr.WriteLine(line, Encoding.UTF8);
                    }
                }
            }
            */
            // а разве не понятно? это же сохранить
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "txt";
            saveFile1.Filter = "Text | *.txt";
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFile1.FileName.Length > 0)
            {
                using (StreamWriter sw = new StreamWriter(saveFile1.FileName, true))
                {
                    sw.WriteLine(richTextBox1.Text);
                    sw.Close();
                }
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ну это открыть
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                richTextBox1.Text = File.ReadAllText(openFileDialog.FileName);

            richTextBox1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            //выравнивание
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //тоже выравнивание
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //и это выравнивание
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            //очистить
            richTextBox1.Text = "";
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Style == FontStyle.Bold)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.Name, richTextBox1.SelectionFont.Size, FontStyle.Regular);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.Name, richTextBox1.SelectionFont.Size, FontStyle.Bold);
            }
        }

        private void очиститьЭффектыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String Text = richTextBox1.Text;
            richTextBox1.Text = Text;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Style == FontStyle.Italic)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.Name, richTextBox1.SelectionFont.Size, FontStyle.Regular);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.Name, richTextBox1.SelectionFont.Size, FontStyle.Italic);
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Style == FontStyle.Underline)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.Name, richTextBox1.SelectionFont.Size, FontStyle.Regular);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.Name, richTextBox1.SelectionFont.Size, FontStyle.Underline);
            }
        }

        private void очиститьЭффектывыделениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            richTextBox1.SelectionColor = Color.FromArgb(0);
        }

        private void открытьДляПросмотраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName))
                {
                    richTextBox1.Text = sr.ReadToEnd();
                }
            }

            richTextBox1.Enabled = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int size = int.Parse(numericUpDown1.Text);

            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.Name, size, richTextBox1.SelectionFont.Style);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string font = comboBox1.Text;
            
            richTextBox1.SelectionFont = new Font(font, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);
        }

        private void сохранитьКакДокументWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            SendKeys.SendWait("^(a)");
            SendKeys.SendWait("^(c)");

            //создаем документ Microsoft Word
            Word.Application wordApp = new Word.Application();
            Word.Document wordDoc = wordApp.Documents.Add();
            
            Word.Paragraph par = wordDoc.Paragraphs.Last;

            //par.Range.Text = richTextBox1.Text;
            
            wordApp.Visible = true;

            SendKeys.SendWait("^(v)");
        }

        private void EditorTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "et";
            saveFile1.Filter = "Text | *.et";
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFile1.FileName.Length > 0)
            {
                using (StreamWriter sw = new StreamWriter(saveFile1.FileName, true))
                {
                    sw.WriteLine(richTextBox1.Text);
                    sw.Close();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            FileDialog fDialog = new OpenFileDialog();
            fDialog.CheckFileExists = true;
            fDialog.CheckPathExists = true;
            fDialog.RestoreDirectory = true;
            fDialog.Title = "Choose file to import";
            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                string lstrFile = fDialog.FileName;
                Bitmap myBitmap = new Bitmap(lstrFile);
                Clipboard.SetDataObject(myBitmap);
                DataFormats.Format format = DataFormats.GetFormat(DataFormats.Bitmap);
                richTextBox1.Paste(format);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var color = comboBox2.Text;

            if (color == "Black")
            {
                richTextBox1.SelectionColor = Color.FromArgb(0);
            }
            if (color == "Red")
            {
                richTextBox1.SelectionColor = Color.FromArgb(255, 0, 0);
            }
            if (color == "Green")
            {
                richTextBox1.SelectionColor = Color.FromArgb(0, 255, 0);
            }
            if (color == "Blue")
            {
                richTextBox1.SelectionColor = Color.FromArgb(0, 0, 255);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.Show();
        }

        private void сохранитьДокументКакRtfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == DialogResult.OK && saveFile1.FileName.Length > 0)
            {
                richTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void открытьДокументRtfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile1 = new OpenFileDialog();

            openFile1.DefaultExt = "*.rtf";
            openFile1.Filter = "RTF Files|*.rtf";

            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               openFile1.FileName.Length > 0)
            {
                richTextBox1.LoadFile(openFile1.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void открытьДокументWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // это недоразумение выкопал на форуме, но работает как часы
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MS Word dosuments (*.docx)|*.docx|Rich text format (*.rtf)|*.rtf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FilterIndex == 1)//если формат документа Word 2007
                {
                    Word.Application app = new Microsoft.Office.Interop.Word.Application();//процесс ворда
                    Object docxFileName = openFileDialog.FileName;//имя файла
                    Object missing = Type.Missing;
                    //открыли дркумент
                    app.Documents.Open(ref docxFileName, ref missing,
                        ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref missing);
                    //путь к папке с временными файлами
                    string temp = System.IO.Path.GetTempPath();
                    //для передачи параметров при пересохранении
                    Object lookComments = false;
                    Object password = String.Empty;
                    Object AddToRecentFiles = true;
                    Object WritePassword = String.Empty;
                    Object ReadOnlyRecommended = false;
                    Object EmbedTrueTypeFonts = false;
                    Object SaveFormsData = false;
                    Object SaveAsAOCELetter = false;
                    //имя файла без расширения
                    Object rtfFileName = openFileDialog.SafeFileName.Substring(0, openFileDialog.SafeFileName.Length - ".docx".Length);
                    //создали рандом
                    Random random = new Random();
                    //проверяем есть ли файл с таким именем
                    while (System.IO.File.Exists(rtfFileName + ".rtf"))
                        //генерируем случайное имя файла
                        rtfFileName += random.Next(0, 9).ToString();
                    //формат RTF
                    Object wdFormatRTF = Word.WdSaveFormat.wdFormatRTF;
                    //приписали расширение
                    rtfFileName += ".rtf";
                    //приписали путь к временным файлам
                    rtfFileName = temp + rtfFileName;
                    //пересохранили
                    app.ActiveDocument.SaveAs(ref rtfFileName,
                        ref wdFormatRTF, ref lookComments, ref password, ref AddToRecentFiles, ref WritePassword, ref ReadOnlyRecommended,
                        ref EmbedTrueTypeFonts, ref missing, ref SaveFormsData, ref SaveAsAOCELetter, ref missing,
                        ref missing, ref missing, ref missing, ref missing);
                    //переменная
                    Object @false = false;
                    //закрыли текущий документ
                    app.ActiveDocument.Close(ref @false, ref missing, ref missing);
                    //вышли из ворда
                    app.Quit(ref @false, ref missing, ref missing);
                    //прочли файл
                    richTextBox1.LoadFile((String)rtfFileName);
                }
                if (openFileDialog.FilterIndex == 2)
                    richTextBox1.LoadFile(openFileDialog.FileName);
            }
        }
    }
}