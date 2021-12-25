namespace ArinaWebsiteManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRun = new System.Windows.Forms.Button();
            this.lbxInfo = new System.Windows.Forms.ListBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnProduceJS = new System.Windows.Forms.Button();
            this.btnLoadPerson = new System.Windows.Forms.Button();
            this.pnlEditArea = new System.Windows.Forms.Panel();
            this.btnSavePerosn = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShowBestowRecords = new System.Windows.Forms.Button();
            this.btnSaveBestowRecords = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tslMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.btnShowPersonData = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnBestowHistory = new System.Windows.Forms.Button();
            this.btnRefreshNo = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(1172, 485);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(211, 52);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run Script";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lbxInfo
            // 
            this.lbxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxInfo.FormattingEnabled = true;
            this.lbxInfo.ItemHeight = 20;
            this.lbxInfo.Location = new System.Drawing.Point(47, 28);
            this.lbxInfo.Margin = new System.Windows.Forms.Padding(4);
            this.lbxInfo.Name = "lbxInfo";
            this.lbxInfo.Size = new System.Drawing.Size(535, 684);
            this.lbxInfo.TabIndex = 1;
            this.lbxInfo.SelectedIndexChanged += new System.EventHandler(this.lbxInfo_SelectedIndexChanged);
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(1172, 605);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(211, 52);
            this.btnBackup.TabIndex = 2;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnProduceJS
            // 
            this.btnProduceJS.Location = new System.Drawing.Point(1172, 333);
            this.btnProduceJS.Margin = new System.Windows.Forms.Padding(4);
            this.btnProduceJS.Name = "btnProduceJS";
            this.btnProduceJS.Size = new System.Drawing.Size(211, 52);
            this.btnProduceJS.TabIndex = 3;
            this.btnProduceJS.Text = "Update Date";
            this.btnProduceJS.UseVisualStyleBackColor = true;
            this.btnProduceJS.Click += new System.EventHandler(this.btnProduceJS_Click);
            // 
            // btnLoadPerson
            // 
            this.btnLoadPerson.Location = new System.Drawing.Point(1172, 28);
            this.btnLoadPerson.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadPerson.Name = "btnLoadPerson";
            this.btnLoadPerson.Size = new System.Drawing.Size(211, 52);
            this.btnLoadPerson.TabIndex = 4;
            this.btnLoadPerson.Text = "Reload All";
            this.btnLoadPerson.UseVisualStyleBackColor = true;
            this.btnLoadPerson.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pnlEditArea
            // 
            this.pnlEditArea.AutoScroll = true;
            this.pnlEditArea.Location = new System.Drawing.Point(611, 28);
            this.pnlEditArea.Margin = new System.Windows.Forms.Padding(4);
            this.pnlEditArea.Name = "pnlEditArea";
            this.pnlEditArea.Size = new System.Drawing.Size(485, 689);
            this.pnlEditArea.TabIndex = 5;
            // 
            // btnSavePerosn
            // 
            this.btnSavePerosn.Location = new System.Drawing.Point(1172, 211);
            this.btnSavePerosn.Margin = new System.Windows.Forms.Padding(4);
            this.btnSavePerosn.Name = "btnSavePerosn";
            this.btnSavePerosn.Size = new System.Drawing.Size(211, 52);
            this.btnSavePerosn.TabIndex = 6;
            this.btnSavePerosn.Text = "Save Person Data";
            this.btnSavePerosn.UseVisualStyleBackColor = true;
            this.btnSavePerosn.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(611, 733);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(211, 50);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(885, 733);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(211, 50);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnShowBestowRecords
            // 
            this.btnShowBestowRecords.Location = new System.Drawing.Point(1172, 150);
            this.btnShowBestowRecords.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowBestowRecords.Name = "btnShowBestowRecords";
            this.btnShowBestowRecords.Size = new System.Drawing.Size(211, 52);
            this.btnShowBestowRecords.TabIndex = 9;
            this.btnShowBestowRecords.Text = "Show Bestow Records";
            this.btnShowBestowRecords.UseVisualStyleBackColor = true;
            this.btnShowBestowRecords.Click += new System.EventHandler(this.btnShowBestowRecords_Click);
            // 
            // btnSaveBestowRecords
            // 
            this.btnSaveBestowRecords.Location = new System.Drawing.Point(1172, 272);
            this.btnSaveBestowRecords.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveBestowRecords.Name = "btnSaveBestowRecords";
            this.btnSaveBestowRecords.Size = new System.Drawing.Size(211, 52);
            this.btnSaveBestowRecords.TabIndex = 10;
            this.btnSaveBestowRecords.Text = "Save Bestow Records";
            this.btnSaveBestowRecords.UseVisualStyleBackColor = true;
            this.btnSaveBestowRecords.Click += new System.EventHandler(this.btnSaveBestowRecords_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslMain});
            this.statusStrip.Location = new System.Drawing.Point(0, 796);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1429, 22);
            this.statusStrip.TabIndex = 11;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tslMain
            // 
            this.tslMain.Name = "tslMain";
            this.tslMain.Size = new System.Drawing.Size(0, 16);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(47, 733);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 50);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(431, 733);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(150, 50);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Enabled = false;
            this.btnAddRecord.Location = new System.Drawing.Point(239, 733);
            this.btnAddRecord.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(150, 50);
            this.btnAddRecord.TabIndex = 14;
            this.btnAddRecord.Text = "AddRecord";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // btnShowPersonData
            // 
            this.btnShowPersonData.Location = new System.Drawing.Point(1172, 89);
            this.btnShowPersonData.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowPersonData.Name = "btnShowPersonData";
            this.btnShowPersonData.Size = new System.Drawing.Size(211, 52);
            this.btnShowPersonData.TabIndex = 15;
            this.btnShowPersonData.Text = "Show Person Data";
            this.btnShowPersonData.UseVisualStyleBackColor = true;
            this.btnShowPersonData.Click += new System.EventHandler(this.btnShowPersonData_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1172, 730);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(211, 52);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(1172, 665);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(211, 52);
            this.btnBrowse.TabIndex = 17;
            this.btnBrowse.Text = "Browse Website";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnBestowHistory
            // 
            this.btnBestowHistory.Location = new System.Drawing.Point(1172, 393);
            this.btnBestowHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnBestowHistory.Name = "btnBestowHistory";
            this.btnBestowHistory.Size = new System.Drawing.Size(211, 52);
            this.btnBestowHistory.TabIndex = 18;
            this.btnBestowHistory.Text = "Produce Text File";
            this.btnBestowHistory.UseVisualStyleBackColor = true;
            this.btnBestowHistory.Click += new System.EventHandler(this.btnBestowHistory_Click);
            // 
            // btnRefreshNo
            // 
            this.btnRefreshNo.Location = new System.Drawing.Point(1172, 545);
            this.btnRefreshNo.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefreshNo.Name = "btnRefreshNo";
            this.btnRefreshNo.Size = new System.Drawing.Size(211, 52);
            this.btnRefreshNo.TabIndex = 19;
            this.btnRefreshNo.Text = "RefreshNo";
            this.btnRefreshNo.UseVisualStyleBackColor = true;
            this.btnRefreshNo.Click += new System.EventHandler(this.btnRefreshNo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 818);
            this.Controls.Add(this.btnRefreshNo);
            this.Controls.Add(this.btnBestowHistory);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShowPersonData);
            this.Controls.Add(this.btnShowBestowRecords);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnSaveBestowRecords);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSavePerosn);
            this.Controls.Add(this.pnlEditArea);
            this.Controls.Add(this.btnLoadPerson);
            this.Controls.Add(this.btnProduceJS);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.lbxInfo);
            this.Controls.Add(this.btnRun);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Arina Organizaiton Website Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ListBox lbxInfo;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnProduceJS;
        private System.Windows.Forms.Button btnLoadPerson;
        private System.Windows.Forms.Panel pnlEditArea;
        private System.Windows.Forms.Button btnSavePerosn;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnShowBestowRecords;
        private System.Windows.Forms.Button btnSaveBestowRecords;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tslMain;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Button btnShowPersonData;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnBestowHistory;
        private System.Windows.Forms.Button btnRefreshNo;
    }
}

