namespace StringManipulation2
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
            menuStrip1 = new MenuStrip();
            stringOperationToolStripMenuItem = new ToolStripMenuItem();
            addAWordToolStripMenuItem = new ToolStripMenuItem();
            deleteAWordToolStripMenuItem = new ToolStripMenuItem();
            verifyEmailIsValidToolStripMenuItem = new ToolStripMenuItem();
            verifyDateIsValidToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            StringBox = new TextBox();
            label2 = new Label();
            WordBox = new TextBox();
            AddBTN = new Button();
            DeleteBTN = new Button();
            EmailBTN = new Button();
            VerifyDateBTN = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { stringOperationToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(485, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // stringOperationToolStripMenuItem
            // 
            stringOperationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addAWordToolStripMenuItem, deleteAWordToolStripMenuItem, verifyEmailIsValidToolStripMenuItem, verifyDateIsValidToolStripMenuItem });
            stringOperationToolStripMenuItem.Name = "stringOperationToolStripMenuItem";
            stringOperationToolStripMenuItem.Size = new Size(106, 20);
            stringOperationToolStripMenuItem.Text = "String Operation";
            // 
            // addAWordToolStripMenuItem
            // 
            addAWordToolStripMenuItem.Name = "addAWordToolStripMenuItem";
            addAWordToolStripMenuItem.Size = new Size(180, 22);
            addAWordToolStripMenuItem.Text = "Add A Word";
            addAWordToolStripMenuItem.Click += addAWordToolStripMenuItem_Click;
            // 
            // deleteAWordToolStripMenuItem
            // 
            deleteAWordToolStripMenuItem.Name = "deleteAWordToolStripMenuItem";
            deleteAWordToolStripMenuItem.Size = new Size(180, 22);
            deleteAWordToolStripMenuItem.Text = "Delete A Word";
            deleteAWordToolStripMenuItem.Click += deleteAWordToolStripMenuItem_Click;
            // 
            // verifyEmailIsValidToolStripMenuItem
            // 
            verifyEmailIsValidToolStripMenuItem.Name = "verifyEmailIsValidToolStripMenuItem";
            verifyEmailIsValidToolStripMenuItem.Size = new Size(180, 22);
            verifyEmailIsValidToolStripMenuItem.Text = "Verify Email is Valid";
            verifyEmailIsValidToolStripMenuItem.Click += verifyEmailIsValidToolStripMenuItem_Click;
            // 
            // verifyDateIsValidToolStripMenuItem
            // 
            verifyDateIsValidToolStripMenuItem.Name = "verifyDateIsValidToolStripMenuItem";
            verifyDateIsValidToolStripMenuItem.Size = new Size(180, 22);
            verifyDateIsValidToolStripMenuItem.Text = "Verify Date Is Valid";
            verifyDateIsValidToolStripMenuItem.Click += verifyDateIsValidToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 58);
            label1.Name = "label1";
            label1.Size = new Size(217, 21);
            label1.TabIndex = 1;
            label1.Text = "String You wish to manipulate";
            label1.Visible = false;
            // 
            // StringBox
            // 
            StringBox.Location = new Point(70, 92);
            StringBox.Name = "StringBox";
            StringBox.Size = new Size(280, 23);
            StringBox.TabIndex = 2;
            StringBox.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(70, 181);
            label2.Name = "label2";
            label2.Size = new Size(227, 21);
            label2.TabIndex = 3;
            label2.Text = "Word you wish to add or delete";
            label2.Visible = false;
            // 
            // WordBox
            // 
            WordBox.Location = new Point(70, 217);
            WordBox.Name = "WordBox";
            WordBox.Size = new Size(100, 23);
            WordBox.TabIndex = 4;
            WordBox.Visible = false;
            // 
            // AddBTN
            // 
            AddBTN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddBTN.Location = new Point(70, 260);
            AddBTN.Name = "AddBTN";
            AddBTN.Size = new Size(114, 35);
            AddBTN.TabIndex = 5;
            AddBTN.Text = "Add A Word";
            AddBTN.UseVisualStyleBackColor = true;
            AddBTN.Visible = false;
            AddBTN.Click += AddBTN_Click;
            // 
            // DeleteBTN
            // 
            DeleteBTN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteBTN.Location = new Point(265, 260);
            DeleteBTN.Name = "DeleteBTN";
            DeleteBTN.Size = new Size(128, 35);
            DeleteBTN.TabIndex = 6;
            DeleteBTN.Text = "Delete A Word";
            DeleteBTN.UseVisualStyleBackColor = true;
            DeleteBTN.Visible = false;
            DeleteBTN.Click += DeleteBTN_Click;
            // 
            // EmailBTN
            // 
            EmailBTN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailBTN.Location = new Point(70, 134);
            EmailBTN.Name = "EmailBTN";
            EmailBTN.Size = new Size(178, 35);
            EmailBTN.TabIndex = 7;
            EmailBTN.Text = "Verify Email Address";
            EmailBTN.UseVisualStyleBackColor = true;
            EmailBTN.Visible = false;
            EmailBTN.Click += EmailBTN_Click;
            // 
            // VerifyDateBTN
            // 
            VerifyDateBTN.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VerifyDateBTN.Location = new Point(267, 134);
            VerifyDateBTN.Name = "VerifyDateBTN";
            VerifyDateBTN.Size = new Size(126, 35);
            VerifyDateBTN.TabIndex = 8;
            VerifyDateBTN.Text = "VerifyDate";
            VerifyDateBTN.UseVisualStyleBackColor = true;
            VerifyDateBTN.Visible = false;
            VerifyDateBTN.Click += VerifyDateBTN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 450);
            Controls.Add(VerifyDateBTN);
            Controls.Add(EmailBTN);
            Controls.Add(DeleteBTN);
            Controls.Add(AddBTN);
            Controls.Add(WordBox);
            Controls.Add(label2);
            Controls.Add(StringBox);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem stringOperationToolStripMenuItem;
        private ToolStripMenuItem addAWordToolStripMenuItem;
        private ToolStripMenuItem deleteAWordToolStripMenuItem;
        private ToolStripMenuItem verifyEmailIsValidToolStripMenuItem;
        private ToolStripMenuItem verifyDateIsValidToolStripMenuItem;
        private Label label1;
        private TextBox StringBox;
        private Label label2;
        private TextBox WordBox;
        private Button AddBTN;
        private Button DeleteBTN;
        private Button EmailBTN;
        private Button VerifyDateBTN;
    }
}
