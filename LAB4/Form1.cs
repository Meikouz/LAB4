using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB4
{
    public partial class Form1 : Form
    {
        private BouquetDirector director = new BouquetDirector();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbBouquetType.SelectedIndex = 0;

            btnNextStep.Enabled = false;
            btnBuildAll.Enabled = false;
            btnReset.Enabled = false;

            progressBar.Minimum = 0;
            progressBar.Maximum = 8;
            progressBar.Value = 0;

            lblStatus.Text = "Статус: очікування";
            txtBouquetInfo.Clear();
            lstSteps.Items.Clear();
        }

        private BouquetBuilder GetSelectedBuilder()
        {
            switch (cmbBouquetType.SelectedIndex)
            {
                case 0: return new RomanticBouquetBuilder();
                case 1: return new WeddingBouquetBuilder();
                case 2: return new SpringBouquetBuilder();
                default: return new RomanticBouquetBuilder();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            BouquetBuilder builder = GetSelectedBuilder();
            director.SetBuilder(builder);

            lstSteps.Items.Clear();
            txtBouquetInfo.Clear();
            progressBar.Value = 0;

            lblStatus.Text = "Статус: обрано будівельник, можна виконувати кроки";

            btnNextStep.Enabled = true;
            btnBuildAll.Enabled = true;
            btnReset.Enabled = true;

            UpdateBouquetInfo();
        }

        private void btnNextStep_Click(object sender, EventArgs e)
        {
            string stepResult = director.BuildStep();
            lstSteps.Items.Add(stepResult);

            if (progressBar.Value < progressBar.Maximum)
                progressBar.Value = director.CurrentStep;

            UpdateBouquetInfo();

            if (director.IsFinished())
            {
                lblStatus.Text = "Статус: букет повністю сформовано";
                btnNextStep.Enabled = false;
                btnBuildAll.Enabled = false;
            }
            else
            {
                lblStatus.Text = $"Статус: виконано {director.CurrentStep} з {director.TotalSteps} кроків";
            }
        }

        private void btnBuildAll_Click(object sender, EventArgs e)
        {
            List<string> results = director.BuildAll();

            foreach (string item in results)
                lstSteps.Items.Add(item);

            progressBar.Value = progressBar.Maximum;
            UpdateBouquetInfo();

            lblStatus.Text = "Статус: букет повністю сформовано";
            btnNextStep.Enabled = false;
            btnBuildAll.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            BouquetBuilder builder = GetSelectedBuilder();
            director.SetBuilder(builder);

            lstSteps.Items.Clear();
            txtBouquetInfo.Clear();
            progressBar.Value = 0;

            lblStatus.Text = "Статус: скинуто, можна почати заново";
            btnNextStep.Enabled = true;
            btnBuildAll.Enabled = true;
            btnReset.Enabled = true;

            UpdateBouquetInfo();
        }

        private void UpdateBouquetInfo()
        {
            Bouquet bouquet = director.GetBouquet();

            if (bouquet != null)
                txtBouquetInfo.Text = bouquet.GetDescription();
        }

        private void lstSteps_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}