namespace PlugNPlayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblWelcome = new Label();
            btnSearch = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            tbSearch = new TextBox();
            listBox1 = new ListBox();
            lblName = new Label();
            tbName = new TextBox();
            lblPick = new Label();
            rbGuitar = new RadioButton();
            rbPedal = new RadioButton();
            rbAmplifier = new RadioButton();
            pictureBox1 = new PictureBox();
            btnSendEmail = new Button(); // ✅ New Send Email button
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Snap ITC", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = SystemColors.HighlightText;
            lblWelcome.Location = new Point(324, 24);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(488, 30);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "PLUG AND PLAY GEAR MANAGER";
            lblWelcome.TextAlign = ContentAlignment.BottomRight;
            // 
            // btnSearch
            // 
            btnSearch.AccessibleRole = AccessibleRole.None;
            btnSearch.BackColor = SystemColors.ButtonFace;
            btnSearch.Font = new Font("Swis721 Blk BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(1013, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(127, 25);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "SEARCH ID:";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.GrayText;
            btnAdd.Font = new Font("Swis721 Blk BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(738, 416);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(169, 44);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "ADD GEAR";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSendEmail
            // 
            btnSendEmail.BackColor = Color.LightGreen;
            btnSendEmail.Font = new Font("Swis721 Blk BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSendEmail.Location = new Point(738, 470);
            btnSendEmail.Name = "btnSendEmail";
            btnSendEmail.Size = new Size(169, 44);
            btnSendEmail.TabIndex = 16;
            btnSendEmail.Text = "SEND EMAIL";
            btnSendEmail.UseVisualStyleBackColor = false;
            btnSendEmail.Click += btnSendEmail_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ButtonFace;
            btnEdit.Font = new Font("Swis721 Blk BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(244, 149);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(169, 44);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "EDIT GEAR";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ButtonFace;
            btnDelete.Font = new Font("Swis721 Blk BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(69, 149);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(169, 44);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "DELETE GEAR";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Swis721 Blk BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(3, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(102, 34);
            btnExit.TabIndex = 6;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // tbSearch
            // 
            tbSearch.ForeColor = Color.Transparent;
            tbSearch.Location = new Point(886, 12);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(121, 27);
            tbSearch.TabIndex = 7;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.DimGray;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 24;
            listBox1.Location = new Point(50, 211);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(392, 360);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Gray;
            lblName.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(638, 247);
            lblName.Name = "lblName";
            lblName.Size = new Size(160, 24);
            lblName.TabIndex = 9;
            lblName.Text = "ENTER NAME:";
            lblName.Click += lblName_Click;
            // 
            // tbName
            // 
            tbName.BackColor = SystemColors.ButtonHighlight;
            tbName.Location = new Point(804, 244);
            tbName.Name = "tbName";
            tbName.Size = new Size(217, 27);
            tbName.TabIndex = 10;
            tbName.TextChanged += textBox1_TextChanged;
            // 
            // lblPick
            // 
            lblPick.AutoSize = true;
            lblPick.BackColor = Color.Gray;
            lblPick.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPick.Location = new Point(662, 300);
            lblPick.Name = "lblPick";
            lblPick.Size = new Size(136, 24);
            lblPick.TabIndex = 11;
            lblPick.Text = "PICK TYPE:";
            // 
            // rbGuitar
            // 
            rbGuitar.AutoSize = true;
            rbGuitar.BackColor = Color.Gray;
            rbGuitar.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbGuitar.Location = new Point(804, 303);
            rbGuitar.Name = "rbGuitar";
            rbGuitar.Size = new Size(79, 22);
            rbGuitar.TabIndex = 12;
            rbGuitar.TabStop = true;
            rbGuitar.Text = "Guitar";
            rbGuitar.UseVisualStyleBackColor = false;
            rbGuitar.CheckedChanged += rbGuitar_CheckedChanged;
            // 
            // rbPedal
            // 
            rbPedal.AutoSize = true;
            rbPedal.BackColor = Color.Gray;
            rbPedal.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbPedal.Location = new Point(804, 331);
            rbPedal.Name = "rbPedal";
            rbPedal.Size = new Size(75, 22);
            rbPedal.TabIndex = 13;
            rbPedal.TabStop = true;
            rbPedal.Text = "Pedal";
            rbPedal.UseVisualStyleBackColor = false;
            rbPedal.CheckedChanged += rbPedal_CheckedChanged;
            // 
            // rbAmplifier
            // 
            rbAmplifier.AutoSize = true;
            rbAmplifier.BackColor = Color.Gray;
            rbAmplifier.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbAmplifier.Location = new Point(804, 359);
            rbAmplifier.Name = "rbAmplifier";
            rbAmplifier.Size = new Size(103, 22);
            rbAmplifier.TabIndex = 14;
            rbAmplifier.TabStop = true;
            rbAmplifier.Text = "Amplifier";
            rbAmplifier.UseVisualStyleBackColor = false;
            rbAmplifier.CheckedChanged += rbAmplifier_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gray;
            pictureBox1.Location = new Point(579, 211);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(486, 360);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1152, 669);
            Controls.Add(btnSendEmail); // ✅ added Send Email button
            Controls.Add(rbAmplifier);
            Controls.Add(rbPedal);
            Controls.Add(rbGuitar);
            Controls.Add(lblPick);
            Controls.Add(tbName);
            Controls.Add(lblName);
            Controls.Add(listBox1);
            Controls.Add(tbSearch);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(lblWelcome);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "PLUG AND PLAY GEAR MANAGER";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnExit;
        private TextBox tbSearch;
        private ListBox listBox1;
        private Label lblName;
        private TextBox tbName;
        private Label lblPick;
        private RadioButton rbGuitar;
        private RadioButton rbPedal;
        private RadioButton rbAmplifier;
        private PictureBox pictureBox1;
        private Button btnSendEmail; // ✅ Send Email button declaration
    }
}
