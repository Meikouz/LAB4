namespace LAB4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox cmbBouquetType;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnNextStep;
        private System.Windows.Forms.Button btnBuildAll;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListBox lstSteps;
        private System.Windows.Forms.TextBox txtBouquetInfo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Label lblInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbBouquetType = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnNextStep = new System.Windows.Forms.Button();
            this.btnBuildAll = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lstSteps = new System.Windows.Forms.ListBox();
            this.txtBouquetInfo = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblChoose = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbBouquetType
            // 
            this.cmbBouquetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBouquetType.FormattingEnabled = true;
            this.cmbBouquetType.Items.AddRange(new object[] {
            "Романтичний букет",
            "Весільний букет",
            "Весняний букет"});
            this.cmbBouquetType.Location = new System.Drawing.Point(190, 58);
            this.cmbBouquetType.Name = "cmbBouquetType";
            this.cmbBouquetType.Size = new System.Drawing.Size(220, 24);
            this.cmbBouquetType.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(430, 55);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(110, 35);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Створити";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnNextStep
            // 
            this.btnNextStep.Location = new System.Drawing.Point(20, 110);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(150, 40);
            this.btnNextStep.TabIndex = 2;
            this.btnNextStep.Text = "Наступний крок";
            this.btnNextStep.UseVisualStyleBackColor = true;
            this.btnNextStep.Click += new System.EventHandler(this.btnNextStep_Click);
            // 
            // btnBuildAll
            // 
            this.btnBuildAll.Location = new System.Drawing.Point(190, 110);
            this.btnBuildAll.Name = "btnBuildAll";
            this.btnBuildAll.Size = new System.Drawing.Size(150, 40);
            this.btnBuildAll.TabIndex = 3;
            this.btnBuildAll.Text = "Зібрати повністю";
            this.btnBuildAll.UseVisualStyleBackColor = true;
            this.btnBuildAll.Click += new System.EventHandler(this.btnBuildAll_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(360, 110);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 40);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Скинути";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lstSteps
            // 
            this.lstSteps.FormattingEnabled = true;
            this.lstSteps.ItemHeight = 16;
            this.lstSteps.Location = new System.Drawing.Point(20, 270);
            this.lstSteps.Name = "lstSteps";
            this.lstSteps.Size = new System.Drawing.Size(400, 244);
            this.lstSteps.TabIndex = 5;
            this.lstSteps.SelectedIndexChanged += new System.EventHandler(this.lstSteps_SelectedIndexChanged);
            // 
            // txtBouquetInfo
            // 
            this.txtBouquetInfo.Location = new System.Drawing.Point(450, 270);
            this.txtBouquetInfo.Multiline = true;
            this.txtBouquetInfo.Name = "txtBouquetInfo";
            this.txtBouquetInfo.ReadOnly = true;
            this.txtBouquetInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBouquetInfo.Size = new System.Drawing.Size(400, 244);
            this.txtBouquetInfo.TabIndex = 6;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 165);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(132, 16);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Статус: очікування";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(20, 195);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(460, 25);
            this.progressBar.TabIndex = 8;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(234, 16);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Формування букетів квітів (Builder)";
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Location = new System.Drawing.Point(20, 61);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(136, 16);
            this.lblChoose.TabIndex = 10;
            this.lblChoose.Text = "Оберіть тип букета:";
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(20, 240);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(155, 16);
            this.lblLog.TabIndex = 11;
            this.lblLog.Text = "Покрокове виконання:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(450, 240);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(171, 16);
            this.lblInfo.TabIndex = 12;
            this.lblInfo.Text = "Склад поточного букета:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(880, 540);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtBouquetInfo);
            this.Controls.Add(this.lstSteps);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBuildAll);
            this.Controls.Add(this.btnNextStep);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cmbBouquetType);
            this.Name = "Form1";
            this.Text = "Патерн Будівельник - Формування букетів";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}