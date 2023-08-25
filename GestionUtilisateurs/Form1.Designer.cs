namespace GestionUtilisateurs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btRefresh = new Button();
            btAjouter = new Button();
            btSupprimer = new Button();
            dgvUtilisateur = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNom = new TextBox();
            txtPrenom = new TextBox();
            dtpNaiss = new DateTimePicker();
            bsUtilisateur = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUtilisateur).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsUtilisateur).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 2);
            tableLayoutPanel1.Controls.Add(dgvUtilisateur, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(851, 499);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btRefresh);
            flowLayoutPanel1.Controls.Add(btAjouter);
            flowLayoutPanel1.Controls.Add(btSupprimer);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 449);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(845, 47);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btRefresh
            // 
            btRefresh.Image = (Image)resources.GetObject("btRefresh.Image");
            btRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btRefresh.Location = new Point(3, 3);
            btRefresh.Name = "btRefresh";
            btRefresh.Size = new Size(138, 37);
            btRefresh.TabIndex = 0;
            btRefresh.Text = "Actualiser";
            btRefresh.TextAlign = ContentAlignment.MiddleRight;
            btRefresh.UseVisualStyleBackColor = true;
            btRefresh.Click += btRefresh_Click_1;
            // 
            // btAjouter
            // 
            btAjouter.Image = Properties.Resources.addusergroup_1251;
            btAjouter.ImageAlign = ContentAlignment.MiddleLeft;
            btAjouter.Location = new Point(147, 3);
            btAjouter.Name = "btAjouter";
            btAjouter.Size = new Size(138, 37);
            btAjouter.TabIndex = 1;
            btAjouter.Text = "Ajouter";
            btAjouter.TextAlign = ContentAlignment.MiddleRight;
            btAjouter.UseVisualStyleBackColor = true;
            btAjouter.Click += btAjouter_Click;
            // 
            // btSupprimer
            // 
            btSupprimer.Image = Properties.Resources.filesystems_garbage_full_6701;
            btSupprimer.ImageAlign = ContentAlignment.MiddleLeft;
            btSupprimer.Location = new Point(291, 3);
            btSupprimer.Name = "btSupprimer";
            btSupprimer.Size = new Size(151, 37);
            btSupprimer.TabIndex = 2;
            btSupprimer.Text = "Supprimer";
            btSupprimer.TextAlign = ContentAlignment.MiddleRight;
            btSupprimer.UseVisualStyleBackColor = true;
            btSupprimer.Click += btSupprimer_Click;
            // 
            // dgvUtilisateur
            // 
            dgvUtilisateur.AllowUserToAddRows = false;
            dgvUtilisateur.AllowUserToDeleteRows = false;
            dgvUtilisateur.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUtilisateur.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUtilisateur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUtilisateur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUtilisateur.Dock = DockStyle.Fill;
            dgvUtilisateur.EnableHeadersVisualStyles = false;
            dgvUtilisateur.Location = new Point(3, 3);
            dgvUtilisateur.MultiSelect = false;
            dgvUtilisateur.Name = "dgvUtilisateur";
            dgvUtilisateur.ReadOnly = true;
            dgvUtilisateur.RowHeadersVisible = false;
            dgvUtilisateur.RowHeadersWidth = 62;
            dgvUtilisateur.RowTemplate.Height = 33;
            dgvUtilisateur.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUtilisateur.Size = new Size(845, 299);
            dgvUtilisateur.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(txtNom, 1, 0);
            tableLayoutPanel2.Controls.Add(txtPrenom, 1, 1);
            tableLayoutPanel2.Controls.Add(dtpNaiss, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(10, 325);
            tableLayoutPanel2.Margin = new Padding(10, 20, 10, 10);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(831, 111);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(154, 37);
            label1.TabIndex = 0;
            label1.Text = "Nom";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 37);
            label2.Name = "label2";
            label2.Size = new Size(154, 37);
            label2.TabIndex = 1;
            label2.Text = "Prénom";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 74);
            label3.Name = "label3";
            label3.Size = new Size(154, 37);
            label3.TabIndex = 2;
            label3.Text = "Date de naissance";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNom
            // 
            txtNom.Dock = DockStyle.Fill;
            txtNom.Location = new Point(163, 3);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(665, 31);
            txtNom.TabIndex = 3;
            // 
            // txtPrenom
            // 
            txtPrenom.Dock = DockStyle.Fill;
            txtPrenom.Location = new Point(163, 40);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(665, 31);
            txtPrenom.TabIndex = 4;
            // 
            // dtpNaiss
            // 
            dtpNaiss.Dock = DockStyle.Fill;
            dtpNaiss.Location = new Point(163, 77);
            dtpNaiss.Name = "dtpNaiss";
            dtpNaiss.Size = new Size(665, 31);
            dtpNaiss.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 499);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Utilisateur";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUtilisateur).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsUtilisateur).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btRefresh;
        private DataGridView dgvUtilisateur;
        private BindingSource bsUtilisateur;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNom;
        private TextBox txtPrenom;
        private DateTimePicker dtpNaiss;
        private Button btAjouter;
        private Button btSupprimer;
    }
}