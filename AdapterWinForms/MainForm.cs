
using System;
using System.Drawing;
using System.Windows.Forms;
using AdapterWinForms.Adapters;

namespace AdapterWinForms
{
    public partial class MainForm : Form
    {
        private TextBox txtEditor;

        private string currentPath = "";

        public MainForm()
        {
            InitializeComponent();
            CreateTextEditor();
            cmbFormat.SelectedIndex = 0;
            lblFormatInfo.Text = "Обраний формат: Word (.docx)";
        }

        private void CreateTextEditor()
        {
            txtEditor = new TextBox();

            txtEditor.Location = new Point(34, 265);
            txtEditor.Size = new Size(620, 270);

            txtEditor.Multiline = true;
            txtEditor.ScrollBars = ScrollBars.Both;
            txtEditor.AcceptsReturn = true;
            txtEditor.AcceptsTab = true;
            txtEditor.WordWrap = false;

            txtEditor.Font = new Font("Consolas", 10);
            txtEditor.BackColor = Color.White;
            txtEditor.ForeColor = Color.FromArgb(45, 58, 78);

            txtEditor.Anchor = AnchorStyles.Top |
                               AnchorStyles.Left |
                               AnchorStyles.Right;

            pnlMain.Controls.Add(txtEditor);
        }

        private string GetExtension()
        {
            switch (cmbFormat.SelectedIndex)
            {
                case 0:
                    return ".docx";

                case 1:
                    return ".xlsx";

                default:
                    return ".txt";
            }
        }

        private ITextAdapter CreateAdapter(string path)
        {
            switch (cmbFormat.SelectedIndex)
            {
                case 0:
                    return new WordAdapter(path);

                case 1:
                    return new ExcelAdapter(path);

                default:
                    return new PlainTextAdapter(path);
            }
        }

        private void cmbFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPath = "";

            lblFile.Text = "Файл ще не вибрано";

            if (cmbFormat.SelectedIndex == 0)
                lblFormatInfo.Text = "Обраний формат: Word (.docx)";

            else if (cmbFormat.SelectedIndex == 1)
                lblFormatInfo.Text = "Обраний формат: Excel (.xlsx)";

            else
                lblFormatInfo.Text = "Обраний формат: звичайний текст (.txt)";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Відкрити документ";
                dialog.Filter = "Документи (*" + GetExtension() +
                                ")|*" + GetExtension();

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        currentPath = dialog.FileName;

                        ITextAdapter adapter = CreateAdapter(currentPath);

                        txtEditor.Text = adapter.ReadText();

                        lblFile.Text = currentPath;

                        MessageBox.Show(
                            "Документ успішно відкрито!",
                            "Успіх",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "Не вдалося відкрити документ:\n" + ex.Message,
                            "Помилка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = currentPath;

            if (string.IsNullOrEmpty(path))
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Title = "Зберегти документ";

                    dialog.Filter = "Документи (*" + GetExtension() +
                                    ")|*" + GetExtension();

                    dialog.DefaultExt = GetExtension().TrimStart('.');
                    dialog.AddExtension = true;

                    if (dialog.ShowDialog() != DialogResult.OK)
                        return;

                    path = dialog.FileName;
                }
            }

            try
            {
                ITextAdapter adapter = CreateAdapter(path);

                adapter.WriteText(txtEditor.Text);

                currentPath = path;
                lblFile.Text = currentPath;

                MessageBox.Show(
                    "Документ успішно збережено!",
                    "Успіх",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Не вдалося зберегти документ:\n" + ex.Message,
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentPath))
            {
                MessageBox.Show(
                    "Спочатку відкрийте або збережіть документ!",
                    "Увага",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                ITextAdapter adapter = CreateAdapter(currentPath);

                txtEditor.Text = adapter.ReadText();

                MessageBox.Show(
                    "Дані документа успішно прочитано!",
                    "Успіх",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Помилка читання документа:\n" + ex.Message,
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEditor.Clear();

            MessageBox.Show(
                "Текстове поле очищено!",
                "Інформація",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
