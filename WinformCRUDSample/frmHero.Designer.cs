namespace WinformCRUDSample
{
    partial class frmHero
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
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            heroBindingSource = new BindingSource(components);
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            txtPicture = new TextBox();
            pictureHero = new PictureBox();
            cmbHeroType = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            txtDescription = new TextBox();
            label1 = new Label();
            txtName = new TextBox();
            heroFileDialog = new OpenFileDialog();
            heroDetailError = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)heroBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureHero).BeginInit();
            ((System.ComponentModel.ISupportInitialize)heroDetailError).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridView1.DataSource = heroBindingSource;
            dataGridView1.Location = new Point(322, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(532, 547);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            dataGridViewTextBoxColumn1.HeaderText = "Name";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            dataGridViewTextBoxColumn2.HeaderText = "Description";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "HeroType";
            dataGridViewTextBoxColumn3.HeaderText = "HeroType";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // heroBindingSource
            // 
            heroBindingSource.DataSource = typeof(Hero);
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(12, 488);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 11;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(103, 488);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(193, 488);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(193, 517);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(103, 517);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtPicture);
            groupBox1.Controls.Add(pictureHero);
            groupBox1.Controls.Add(cmbHeroType);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtName);
            groupBox1.Location = new Point(23, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(277, 460);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hero Details";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 145);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 19;
            label4.Text = "Picture Path";
            // 
            // txtPicture
            // 
            txtPicture.DataBindings.Add(new Binding("Text", heroBindingSource, "PictureUrl", true));
            txtPicture.Enabled = false;
            txtPicture.Location = new Point(5, 163);
            txtPicture.Name = "txtPicture";
            txtPicture.Size = new Size(256, 23);
            txtPicture.TabIndex = 18;
            txtPicture.TextChanged += txtPicture_TextChanged;
            // 
            // pictureHero
            // 
            pictureHero.Location = new Point(19, 24);
            pictureHero.Name = "pictureHero";
            pictureHero.Size = new Size(229, 101);
            pictureHero.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureHero.TabIndex = 17;
            pictureHero.TabStop = false;
            pictureHero.Click += pictureHero_Click;
            // 
            // cmbHeroType
            // 
            cmbHeroType.DataBindings.Add(new Binding("Text", heroBindingSource, "HeroType", true));
            cmbHeroType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHeroType.FormattingEnabled = true;
            cmbHeroType.Items.AddRange(new object[] { "Tank ", "Fighter", "Mage", "Assasin", "Support", "Marksman" });
            cmbHeroType.Location = new Point(5, 413);
            cmbHeroType.Name = "cmbHeroType";
            cmbHeroType.Size = new Size(256, 23);
            cmbHeroType.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Location = new Point(5, 379);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 15;
            label3.Text = "Hero Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Location = new Point(5, 273);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 14;
            label2.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.DataBindings.Add(new Binding("Text", heroBindingSource, "Description", true));
            txtDescription.Location = new Point(5, 291);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(256, 66);
            txtDescription.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 199);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 12;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.DataBindings.Add(new Binding("Text", heroBindingSource, "Name", true));
            txtName.Location = new Point(5, 217);
            txtName.Name = "txtName";
            txtName.Size = new Size(256, 23);
            txtName.TabIndex = 11;
            // 
            // heroFileDialog
            // 
            heroFileDialog.FileName = "openFileDialog1";
            // 
            // heroDetailError
            // 
            heroDetailError.ContainerControl = this;
            heroDetailError.DataSource = heroBindingSource;
            // 
            // frmHero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 545);
            Controls.Add(groupBox1);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(dataGridView1);
            Name = "frmHero";
            Text = " ";
            Load += frmHero_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)heroBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureHero).EndInit();
            ((System.ComponentModel.ISupportInitialize)heroDetailError).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn heroTypeDataGridViewTextBoxColumn;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSave;
        private Button btnCancel;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtPicture;
        private PictureBox pictureHero;
        private ComboBox cmbHeroType;
        private Label label3;
        private Label label2;
        private TextBox txtDescription;
        private Label label1;
        private TextBox txtName;
        private OpenFileDialog heroFileDialog;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private BindingSource heroBindingSource;
        private ErrorProvider heroDetailError;
    }
}