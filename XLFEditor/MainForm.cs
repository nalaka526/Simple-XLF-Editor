using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace XlfEditor
{
    public partial class MainForm : Form
    {
        enum Mode
        {
            List,
            Detail
        }

        enum ListFilter
        {
            All,
            NotTranslated,
            Translated
        }

        enum MessageType
        {
            Error,
            Success
        }

        static readonly Regex trimmer = new Regex(@"\s\s+");


        ListFilter translationsListFilter = ListFilter.All;

        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Width = 995;
            this.Height = 630;
            dgvTranslations.RowTemplate.Height = 20;
            openXLFDialog.Filter = "XLF files|*.xlf";
            SetMode(Mode.List);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                ReadData();
            }
            catch (Exception exception)
            {
                ShowStatus(MessageType.Error, exception.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsFileSelected())
                    return;

                if (dgvTranslations.Rows.Count == 0)
                    return;

                XDocument doc = GetDocument();

                foreach (DataGridViewRow row in dgvTranslations.Rows)
                {
                    doc = UpdateTarget(doc, row.Index);
                }

                SaveXMLDocument(doc);

                ShowStatus(MessageType.Success, "All translations saved successfully.");

            }
            catch (Exception exception)
            {
                ShowStatus(MessageType.Error, exception.Message);
            }
        }

        private void dgvTranslations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    XDocument doc = GetDocument();
                    doc = UpdateTarget(doc, e.RowIndex);
                    SaveXMLDocument(doc);
                    ShowStatus(MessageType.Success, "Translation saved successfully.");
                }
            }
        }

        private void btnCloseDetails_Click(object sender, EventArgs e)
        {
            SetMode(Mode.List);
        }

        private void btnDetailsSave_Click(object sender, EventArgs e)
        {
            try
            {
                dgvTranslations.Rows[Convert.ToInt32(lblDetailsRowId.Text)].Cells["tbcTarget"].Value = txtDetaillsTarget.Text;

                XDocument doc = GetDocument();
                doc = UpdateTarget(doc, Convert.ToInt32(lblDetailsRowId.Text));
                SaveXMLDocument(doc);
                SetMode(Mode.List);
                ShowStatus(MessageType.Success, "Translation saved successfully.");
            }
            catch (Exception exception)
            {
                ShowStatus(MessageType.Error, exception.Message);
            }
        }

        private XDocument UpdateTarget(XDocument doc, int rowIndex)
        {
            XNamespace df = doc.Root.Name.Namespace;
            var transUnit = doc.Descendants(df + "trans-unit").Single(r => r.Attribute("id").Value == dgvTranslations.Rows[rowIndex].Cells["tbcId"].Value.ToString());
            var source = transUnit.Element(df + "source");
            var target = transUnit.Element(df + "target");
            var inputTarget = dgvTranslations.Rows[rowIndex].Cells["tbcTarget"].Value == null ? string.Empty : dgvTranslations.Rows[rowIndex].Cells["tbcTarget"].Value.ToString();

            if (target == null)
            {
                source.AddAfterSelf(new XElement(df + "target", inputTarget));
            }
            else
            {
                target.Value = inputTarget;
            }
            return doc;
        }

        private string GetSourceText(XElement element, XNamespace df)
        {
            return GetElementText(element, df, "source");
        }

        private string GetTargetText(XElement element, XNamespace df)
        {
            return GetElementText(element, df, "target");
        }

        private string GetElementText(XElement element, XNamespace df, string elementType)
        {
            var innerElm = element.Element(df + elementType);

            if (innerElm == null)
            {
                return string.Empty;
            }

            if (innerElm.HasElements)
            {
                var xReader = innerElm.CreateReader();
                xReader.MoveToContent();

                var innerXml = xReader.ReadInnerXml();
                return trimmer.Replace(innerXml, " ").Trim();
            }

            return trimmer.Replace(innerElm.Value, " ").Trim();
        }

        private void SetMode(Mode mode)
        {
            switch (mode)
            {
                case Mode.List:
                    pnlList.Visible = true;
                    pnlDetails.Visible = false;
                    dgvTranslations.Visible = true;
                    btnSave.Visible = true;
                    lblStatus.Text = string.Empty;
                    break;
                case Mode.Detail:
                    pnlList.Visible = false;
                    pnlDetails.Visible = true;
                    dgvTranslations.Visible = true;
                    btnSave.Visible = false;
                    lblStatus.Text = string.Empty;
                    break;
            }
        }

        private string UnescapeXML(string inputString)
        {
            if (string.IsNullOrEmpty(inputString) || !inputString.Contains('&')) return inputString;

            string returnString = inputString;
            returnString = returnString.Replace("&apos;", "'");
            returnString = returnString.Replace("&quot;", "\"");
            returnString = returnString.Replace("&gt;", ">");
            returnString = returnString.Replace("&lt;", "<");
            returnString = returnString.Replace("&amp;", "&");

            return returnString;
        }

        bool TryParseXml(string xmlString)
        {
            try
            {
                XElement.Parse(xmlString);
                return true;
            }
            catch (XmlException e)
            {
                return false;
            }
        }

        private void SaveXMLDocument(XDocument doc)
        {
            string xmlString = UnescapeXML(doc.ToString());

            if (TryParseXml(xmlString))
            {
                File.WriteAllText(lblFilePath.Text, xmlString);
            }
            else
            {
                ShowStatus(MessageType.Error, "Invalid XML data");
            }
        }

        private void dgvTranslations_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 3)
            {
                ShowRowDetails(e.RowIndex);
                SetMode(Mode.Detail);
            }
        }

        private void ShowRowDetails(int rowIndex)
        {
            lblDetailsRowId.Text = rowIndex.ToString();
            XDocument doc = GetDocument();
            XNamespace df = doc.Root.Name.Namespace;
            var transUnit = doc.Descendants(df + "trans-unit").Single(r => r.Attribute("id").Value == dgvTranslations.Rows[rowIndex].Cells["tbcId"].Value.ToString());
            txtDetaillsId.Text = transUnit.Attribute("id").Value;
            txtDetaillsDescription.Text = transUnit.Elements(df + "note").FirstOrDefault(r => r.Attribute("from").Value == "description")?.Value ?? string.Empty;
            txtDetaillsMeaning.Text = transUnit.Elements(df + "note").FirstOrDefault(r => r.Attribute("from").Value == "meaning")?.Value ?? string.Empty;
            txtDetaillsSource.Text = transUnit.Element(df + "source").Value;
            txtDetaillsTarget.Text = transUnit.Element(df + "target").Value;
        }

 

        private XDocument GetDocument()
        {
            return XDocument.Load(lblFilePath.Text);
        }

        private void ShowStatus(MessageType type, string message)
        {
            if (type == MessageType.Success)
            {
                lblStatus.ForeColor = Color.DarkGreen;
            }
            else
            {
                lblStatus.ForeColor = Color.OrangeRed;
            }

            lblStatus.Text = message;
        }

        private bool IsFileSelected()
        {
            if (string.IsNullOrEmpty(lblFilePath.Text))
                return false;

            return true;
        }

         private void ReadData()
        {
            if (!IsFileSelected())
                return;

            lblStatus.Text = string.Empty;
            dgvTranslations.Rows.Clear();

            List<Translation> translationsList = new List<Translation>();

            XDocument doc = GetDocument();

            if (!TryParseXml(doc.ToString()))
            {
                ShowStatus(MessageType.Error, "Invalid XML");
            }

            var filter = translationsListFilter;

            XNamespace df = doc.Root.Name.Namespace;
            foreach (XElement transUnitNode in doc.Descendants(df + "trans-unit"))
            {
                XElement sourceNode = transUnitNode.Element(df + "source");

                var sourceText = GetSourceText(transUnitNode, df);
                var targetText = GetTargetText(transUnitNode, df);
                if (!string.IsNullOrEmpty(sourceText))
                {
                    switch (filter)
                    {
                        case ListFilter.All:
                            translationsList.Add(new Translation() { Id = transUnitNode.Attribute("id").Value, Source = sourceText, Target = targetText });
                            break;
                        case ListFilter.NotTranslated:
                            if (targetText == string.Empty)
                            {
                                translationsList.Add(new Translation() { Id = transUnitNode.Attribute("id").Value, Source = sourceText, Target = targetText });
                            }
                            break;
                        case ListFilter.Translated:
                            if (targetText != string.Empty)
                            {
                                translationsList.Add(new Translation() { Id = transUnitNode.Attribute("id").Value, Source = sourceText, Target = targetText });
                            }
                            break;
                        default:
                            break;
                    }

                }
            }

            var source = new BindingSource(translationsList, null);
            dgvTranslations.DataSource = source;
            ShowStatus(MessageType.Success, source.Count + " translation(s) found");
        }

        private void rdoFilterAll_CheckedChanged(object sender, EventArgs e)
        {
            translationsListFilter = ListFilter.All;
            ReadData();
        }

        private void rdoFilterNotTranslated_CheckedChanged(object sender, EventArgs e)
        {
            translationsListFilter = ListFilter.NotTranslated;
            ReadData();
        }

        private void rdoFilterTranslated_CheckedChanged(object sender, EventArgs e)
        {
            translationsListFilter = ListFilter.Translated;
            ReadData();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openXLFDialog.ShowDialog() == DialogResult.OK)
                {
                    lblFileName.Text = Path.GetFileName(openXLFDialog.FileName);
                    lblFilePath.Text = openXLFDialog.FileName;
                    SetMode(Mode.List);
                    ReadData();
                }
            }
            catch (Exception exception)
            {
                ShowStatus(MessageType.Error, exception.Message);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
}