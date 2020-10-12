using CheckWIP.DAO;
using CheckWIP.Helpers;
using ExcelDataReader;
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

namespace CheckWIP
{
    public partial class FrmMain : Form
    {
        DataSet dsExcelSystem;
        DataSet dsExcelActual;
        public FrmMain()
        {
            InitializeComponent();
            InitComponents();
            InventoryPeriodBinding();
        }


        #region Events Inventory Period Tab
        private void btnCreatePeriod_Click(object sender, EventArgs e)
        {
            string periodCode = txtPeriodCode.Text.Trim();
            string description = txtInventoryPeriodDesc.Text.Trim();
            DateTime checkDate = dtpkCheckDate.Value.Date;


            if (periodCode != "")
            {
                InventoryPeriod.Instance.AddInventoryPeriod(periodCode, description, checkDate);
                // reload data gridview
                dtInventoryPeriod.DataSource = InventoryPeriod.Instance.LoadInventoryPeriod();
                InitComponents();
            }
            else
            {
                MessageBox.Show("Please fill Period Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnConfig_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmConfig frm = new FrmConfig();
            frm.Show();
        }

        private void btnDeleteInvPeriod_Click(object sender, EventArgs e)
        {
            string periodCode = txtPeriodCode.Text.Trim();
            if (MessageBox.Show($"Are you sure you want to delete {periodCode}?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                InventoryPeriod.Instance.deleteInventoryPeriod(periodCode);
                LoadInventoryPeriod();
            }
        }

        #endregion

        #region Events Parts in System Tab

        private void btnOpenFileSystem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel Workbook 97-2003|*.xls", ValidateNames = true })
            {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    txtExcelSystem.Text = open.FileName;
                    using (var stream = File.Open(open.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            dsExcelSystem = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            cbSheetSystem.Items.Clear();
                            foreach (DataTable dt in dsExcelSystem.Tables)
                            {
                                cbSheetSystem.Items.Add(dt.TableName);
                            }
                            reader.Close();
                        }
                    }
                }
            }
        }

        private void btnImportSystem_Click(object sender, EventArgs e)
        {
            string periodCode = (cbInventoryPeriodSystem.SelectedItem as DataRowView).Row["PeriodCode"] as string;
            DataTable dt = dsExcelSystem.Tables[cbSheetSystem.SelectedIndex];
            progressSystem.Visible = true;
            progressSystem.Maximum = dt.Rows.Count;
            progressSystem.Value = progressSystem.Minimum;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string seri = "";
                string station = "";
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    seri = dt.Rows[i][0].ToString().Trim();
                    station = dt.Rows[i][1].ToString().Trim();

                }
                PartsInSystem.Instance.addPart(seri, station, periodCode);
                progressSystem.Value++;
            }
            MessageBox.Show("Import done!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            progressSystem.Visible = false;
            LoadPartsInSystem(periodCode);
        }

        private void cbInventoryPeriodSystem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string periodCode = (cbInventoryPeriodSystem.SelectedItem as DataRowView).Row["PeriodCode"] as string;
            LoadPartsInSystem(periodCode);
        }

        private void btnDeleteSystem_Click(object sender, EventArgs e)
        {
            string periodCode = (cbInventoryPeriodSystem.SelectedItem as DataRowView).Row["PeriodCode"] as string;
            if (MessageBox.Show($"Are you sure you want to delete all parts in {periodCode.Trim()}?", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                PartsInSystem.Instance.deletePartsByPeriodCode(periodCode);
                LoadPartsInSystem(periodCode);
            }
        }

        #endregion

        #region Events Parts in Actual Tab
        private void btnImportActual_Click(object sender, EventArgs e)
        {
            string periodCode = (cbInventoryPeriodActual.SelectedItem as DataRowView).Row["PeriodCode"] as string;
            DataTable dt = dsExcelActual.Tables[cbSheetActual.SelectedIndex];
            progressActual.Visible = true;
            progressActual.Maximum = dt.Rows.Count;
            progressActual.Value = progressActual.Minimum;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string seri = "";
                string station = "";
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    seri = dt.Rows[i][1].ToString().Trim();
                    station = dt.Rows[i][2].ToString().Trim();

                }
                PartsInActual.Instance.addPart(seri.Replace(Environment.NewLine, ""), station.Replace(Environment.NewLine, ""), periodCode);
                progressActual.Value++;
            }
            MessageBox.Show("Import done!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            progressActual.Visible = false;
            LoadPartsInActual(periodCode);
        }

        private void btnOpenActual_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel Workbook 97-2003|*.xls", ValidateNames = true })
            {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    txtExcelActual.Text = open.FileName;
                    using (var stream = File.Open(open.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            dsExcelActual = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            cbSheetActual.Items.Clear();
                            foreach (DataTable dt in dsExcelActual.Tables)
                            {
                                cbSheetActual.Items.Add(dt.TableName);
                            }
                            reader.Close();
                        }
                    }
                }
            }
        }

        private void btnDeleteActual_Click(object sender, EventArgs e)
        {
            string periodCode = (cbInventoryPeriodActual.SelectedItem as DataRowView).Row["PeriodCode"] as string;
            if (MessageBox.Show($"Are you sure you want to delete all parts in {periodCode.Trim()}?", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                PartsInActual.Instance.deletePartsByPeriodCode(periodCode);
                LoadPartsInActual(periodCode);
            }
        }

        private void cbInventoryPeriodActual_SelectedIndexChanged(object sender, EventArgs e)
        {
            string periodCode = (cbInventoryPeriodActual.SelectedItem as DataRowView).Row["PeriodCode"] as string;
            LoadPartsInActual(periodCode);
        }
        #endregion

        #region Methods

        void InitComponents()
        {
            LoadInventoryPeriod();

            cbInventoryPeriodSystem.DataSource = InventoryPeriod.Instance.LoadInventoryPeriod();
            cbInventoryPeriodSystem.DisplayMember = "PeriodCode";
            cbInventoryPeriodSystem.ValueMember = "PeriodCode";

            cbInventoryPeriodActual.DataSource = InventoryPeriod.Instance.LoadInventoryPeriod();
            cbInventoryPeriodActual.DisplayMember = "PeriodCode";
            cbInventoryPeriodActual.ValueMember = "PeriodCode";
        }


        void LoadPartsInSystem(string periodCode)
        {
            DataTable dt = PartsInSystem.Instance.LoadPartsInSystem(periodCode);
            dtPartInSystem.DataSource = dt;
            lblTotalSystem.Text = $"Total: {dt.Rows.Count} parts";
        }
        void LoadPartsInActual(string periodCode)
        {
            DataTable dt = PartsInActual.Instance.LoadPartsInActual(periodCode);
            dtPartInActual.DataSource = dt;
            lblTotalActual.Text = $"Total: {dt.Rows.Count} parts";
        }


        void LoadInventoryPeriod()
        {
            dtInventoryPeriod.DataSource = InventoryPeriod.Instance.LoadInventoryPeriod();
        }


        void InventoryPeriodBinding()
        {
            txtPeriodCode.DataBindings.Add(new Binding("Text", dtInventoryPeriod.DataSource, "PeriodCode"));
            txtInventoryPeriodDesc.DataBindings.Add(new Binding("Text", dtInventoryPeriod.DataSource, "Description"));
            dtpkCheckDate.DataBindings.Add(new Binding("Value", dtInventoryPeriod.DataSource, "Check Date"));
        }

        #endregion

    }
}
