namespace EnergyGridApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tabPage3 = new TabPage();
            btnDeletePart = new Button();
            btnDeleteInsp = new Button();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            txtDelSerial = new TextBox();
            txtDelInspID = new TextBox();
            txtDelUnitID = new TextBox();
            tabPage2 = new TabPage();
            button2 = new Button();
            button1 = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            txtEffInspID = new TextBox();
            txtEffUnitID = new TextBox();
            txtNewEff = new TextBox();
            txtUpdUnitID = new TextBox();
            txtUpdMaxOut = new TextBox();
            Inserts = new TabPage();
            label6 = new Label();
            txtPartUnitID = new TextBox();
            txtSiteID = new TextBox();
            txtPartInspID = new TextBox();
            txtTechID = new TextBox();
            txtPartSerial = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnInsertPart = new Button();
            btnInsertInspection = new Button();
            tabControl1 = new TabControl();
            Select = new TabPage();
            dataGridView1 = new DataGridView();
            btnJoinSelect = new Button();
            btnSimpleSelect = new Button();
            btnSeedData = new Button();
            tabPage3.SuspendLayout();
            tabPage2.SuspendLayout();
            Inserts.SuspendLayout();
            tabControl1.SuspendLayout();
            Select.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnDeletePart);
            tabPage3.Controls.Add(btnDeleteInsp);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(txtDelSerial);
            tabPage3.Controls.Add(txtDelInspID);
            tabPage3.Controls.Add(txtDelUnitID);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(755, 392);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Delete";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnDeletePart
            // 
            btnDeletePart.Location = new Point(275, 175);
            btnDeletePart.Name = "btnDeletePart";
            btnDeletePart.Size = new Size(121, 25);
            btnDeletePart.TabIndex = 7;
            btnDeletePart.Text = "Delete part";
            btnDeletePart.UseVisualStyleBackColor = true;
            btnDeletePart.Click += btnDeletePart_Click;
            // 
            // btnDeleteInsp
            // 
            btnDeleteInsp.Location = new Point(275, 83);
            btnDeleteInsp.Name = "btnDeleteInsp";
            btnDeleteInsp.Size = new Size(121, 22);
            btnDeleteInsp.TabIndex = 6;
            btnDeleteInsp.Text = "Delete uninspected unit";
            btnDeleteInsp.UseVisualStyleBackColor = true;
            btnDeleteInsp.Click += btnDeleteInsp_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(28, 180);
            label13.Name = "label13";
            label13.Size = new Size(82, 15);
            label13.TabIndex = 5;
            label13.Text = "Serial Number";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(29, 83);
            label12.Name = "label12";
            label12.Size = new Size(59, 15);
            label12.TabIndex = 4;
            label12.Text = "Inspect ID";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(29, 47);
            label11.Name = "label11";
            label11.Size = new Size(43, 15);
            label11.TabIndex = 3;
            label11.Text = "Unit ID";
            // 
            // txtDelSerial
            // 
            txtDelSerial.Location = new Point(126, 177);
            txtDelSerial.Name = "txtDelSerial";
            txtDelSerial.Size = new Size(100, 23);
            txtDelSerial.TabIndex = 2;
            // 
            // txtDelInspID
            // 
            txtDelInspID.Location = new Point(127, 80);
            txtDelInspID.Name = "txtDelInspID";
            txtDelInspID.Size = new Size(100, 23);
            txtDelInspID.TabIndex = 1;
            // 
            // txtDelUnitID
            // 
            txtDelUnitID.Location = new Point(126, 44);
            txtDelUnitID.Name = "txtDelUnitID";
            txtDelUnitID.Size = new Size(100, 23);
            txtDelUnitID.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(txtEffInspID);
            tabPage2.Controls.Add(txtEffUnitID);
            tabPage2.Controls.Add(txtNewEff);
            tabPage2.Controls.Add(txtUpdUnitID);
            tabPage2.Controls.Add(txtUpdMaxOut);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(781, 410);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Update";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(332, 315);
            button2.Name = "button2";
            button2.Size = new Size(111, 23);
            button2.TabIndex = 11;
            button2.Text = "Update Efficiency";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnUpdateEff_Click;
            // 
            // button1
            // 
            button1.Location = new Point(332, 89);
            button1.Name = "button1";
            button1.Size = new Size(111, 23);
            button1.TabIndex = 10;
            button1.Text = "Update Output";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnUpdateOutput_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 318);
            label10.Name = "label10";
            label10.Size = new Size(76, 15);
            label10.TabIndex = 9;
            label10.Text = "Inspection ID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 269);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 8;
            label9.Text = "Unit ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 226);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 7;
            label8.Text = "New Efficiency";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 89);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 6;
            label7.Text = "Unit ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 32);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 5;
            label5.Text = "Max Output";
            // 
            // txtEffInspID
            // 
            txtEffInspID.Location = new Point(113, 315);
            txtEffInspID.Name = "txtEffInspID";
            txtEffInspID.Size = new Size(100, 23);
            txtEffInspID.TabIndex = 4;
            // 
            // txtEffUnitID
            // 
            txtEffUnitID.Location = new Point(113, 266);
            txtEffUnitID.Name = "txtEffUnitID";
            txtEffUnitID.Size = new Size(100, 23);
            txtEffUnitID.TabIndex = 3;
            // 
            // txtNewEff
            // 
            txtNewEff.Location = new Point(113, 223);
            txtNewEff.Name = "txtNewEff";
            txtNewEff.Size = new Size(100, 23);
            txtNewEff.TabIndex = 2;
            // 
            // txtUpdUnitID
            // 
            txtUpdUnitID.Location = new Point(113, 86);
            txtUpdUnitID.Name = "txtUpdUnitID";
            txtUpdUnitID.Size = new Size(100, 23);
            txtUpdUnitID.TabIndex = 1;
            // 
            // txtUpdMaxOut
            // 
            txtUpdMaxOut.Location = new Point(113, 29);
            txtUpdMaxOut.Name = "txtUpdMaxOut";
            txtUpdMaxOut.Size = new Size(100, 23);
            txtUpdMaxOut.TabIndex = 0;
            // 
            // Inserts
            // 
            Inserts.Controls.Add(label6);
            Inserts.Controls.Add(txtPartUnitID);
            Inserts.Controls.Add(txtSiteID);
            Inserts.Controls.Add(txtPartInspID);
            Inserts.Controls.Add(txtTechID);
            Inserts.Controls.Add(txtPartSerial);
            Inserts.Controls.Add(label4);
            Inserts.Controls.Add(label3);
            Inserts.Controls.Add(label2);
            Inserts.Controls.Add(label1);
            Inserts.Controls.Add(btnInsertPart);
            Inserts.Controls.Add(btnInsertInspection);
            Inserts.Location = new Point(4, 24);
            Inserts.Name = "Inserts";
            Inserts.Padding = new Padding(3);
            Inserts.Size = new Size(781, 410);
            Inserts.TabIndex = 0;
            Inserts.Text = "Inserts";
            Inserts.UseVisualStyleBackColor = true;
            Inserts.Click += tabPage1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 316);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 14;
            label6.Text = "Unit ID";
            // 
            // txtPartUnitID
            // 
            txtPartUnitID.Location = new Point(103, 313);
            txtPartUnitID.Name = "txtPartUnitID";
            txtPartUnitID.Size = new Size(100, 23);
            txtPartUnitID.TabIndex = 13;
            // 
            // txtSiteID
            // 
            txtSiteID.Location = new Point(103, 31);
            txtSiteID.Name = "txtSiteID";
            txtSiteID.Size = new Size(100, 23);
            txtSiteID.TabIndex = 4;
            // 
            // txtPartInspID
            // 
            txtPartInspID.Location = new Point(103, 233);
            txtPartInspID.Name = "txtPartInspID";
            txtPartInspID.Size = new Size(100, 23);
            txtPartInspID.TabIndex = 3;
            // 
            // txtTechID
            // 
            txtTechID.Location = new Point(103, 60);
            txtTechID.Name = "txtTechID";
            txtTechID.Size = new Size(100, 23);
            txtTechID.TabIndex = 2;
            // 
            // txtPartSerial
            // 
            txtPartSerial.Location = new Point(103, 275);
            txtPartSerial.Name = "txtPartSerial";
            txtPartSerial.Size = new Size(100, 23);
            txtPartSerial.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 278);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 11;
            label4.Text = "Serial Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 236);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 10;
            label3.Text = "Inspection ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 63);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 9;
            label2.Text = "Technician ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 34);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(40, 15);
            label1.TabIndex = 8;
            label1.Text = "Site ID";
            label1.Click += label1_Click;
            // 
            // btnInsertPart
            // 
            btnInsertPart.Location = new Point(358, 308);
            btnInsertPart.Name = "btnInsertPart";
            btnInsertPart.Size = new Size(114, 23);
            btnInsertPart.TabIndex = 7;
            btnInsertPart.Text = "Insert used part";
            btnInsertPart.UseVisualStyleBackColor = true;
            btnInsertPart.Click += btnInsertPart_Click;
            // 
            // btnInsertInspection
            // 
            btnInsertInspection.Location = new Point(358, 59);
            btnInsertInspection.Name = "btnInsertInspection";
            btnInsertInspection.Size = new Size(114, 23);
            btnInsertInspection.TabIndex = 6;
            btnInsertInspection.Text = "Insert inspection";
            btnInsertInspection.UseVisualStyleBackColor = true;
            btnInsertInspection.Click += btnInsertInspection_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Inserts);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(Select);
            tabControl1.Location = new Point(12, 30);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(763, 420);
            tabControl1.TabIndex = 0;
            // 
            // Select
            // 
            Select.Controls.Add(dataGridView1);
            Select.Controls.Add(btnJoinSelect);
            Select.Controls.Add(btnSimpleSelect);
            Select.Location = new Point(4, 24);
            Select.Name = "Select";
            Select.Padding = new Padding(3);
            Select.Size = new Size(781, 410);
            Select.TabIndex = 3;
            Select.Text = "Select";
            Select.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(205, 193);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(326, 151);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnJoinSelect
            // 
            btnJoinSelect.Location = new Point(295, 115);
            btnJoinSelect.Name = "btnJoinSelect";
            btnJoinSelect.Size = new Size(125, 26);
            btnJoinSelect.TabIndex = 1;
            btnJoinSelect.Text = "Join select";
            btnJoinSelect.UseVisualStyleBackColor = true;
            btnJoinSelect.Click += btnJoinSelect_Click;
            // 
            // btnSimpleSelect
            // 
            btnSimpleSelect.Location = new Point(295, 73);
            btnSimpleSelect.Name = "btnSimpleSelect";
            btnSimpleSelect.Size = new Size(125, 23);
            btnSimpleSelect.TabIndex = 0;
            btnSimpleSelect.Text = "Simple select";
            btnSimpleSelect.UseVisualStyleBackColor = true;
            btnSimpleSelect.Click += btnSimpleSelect_Click;
            // 
            // btnSeedData
            // 
            btnSeedData.Location = new Point(713, 12);
            btnSeedData.Name = "btnSeedData";
            btnSeedData.Size = new Size(75, 23);
            btnSeedData.TabIndex = 8;
            btnSeedData.Text = "Seed Data";
            btnSeedData.UseVisualStyleBackColor = true;
            btnSeedData.Click += btnSeedData_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSeedData);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            Inserts.ResumeLayout(false);
            Inserts.PerformLayout();
            tabControl1.ResumeLayout(false);
            Select.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private TabPage tabPage3;
        private Button btnDeletePart;
        private Button btnDeleteInsp;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox txtDelSerial;
        private TextBox txtDelInspID;
        private TextBox txtDelUnitID;
        private TabPage tabPage2;
        private Button button2;
        private Button button1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private TextBox txtEffInspID;
        private TextBox txtEffUnitID;
        private TextBox txtNewEff;
        private TextBox txtUpdUnitID;
        private TextBox txtUpdMaxOut;
        private TabPage Inserts;
        private Label label6;
        private TextBox txtPartUnitID;
        private TextBox txtSiteID;
        private TextBox txtPartInspID;
        private TextBox txtTechID;
        private TextBox txtPartSerial;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnInsertPart;
        private Button btnInsertInspection;
        private TabControl tabControl1;
        private TabPage Select;
        private DataGridView dataGridView1;
        private Button btnJoinSelect;
        private Button btnSimpleSelect;
        private Button btnSeedData;
    }
}
