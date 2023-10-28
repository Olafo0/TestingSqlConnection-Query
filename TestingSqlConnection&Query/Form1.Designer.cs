namespace TestingSqlConnection_Query
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
            OpnCnBT = new Button();
            RunQuery = new Button();
            InsertBTN = new Button();
            SuspendLayout();
            // 
            // OpnCnBT
            // 
            OpnCnBT.Location = new Point(24, 24);
            OpnCnBT.Name = "OpnCnBT";
            OpnCnBT.Size = new Size(166, 27);
            OpnCnBT.TabIndex = 0;
            OpnCnBT.Text = "Open connection";
            OpnCnBT.UseVisualStyleBackColor = true;
            OpnCnBT.Click += OpnCnBT_Click;
            // 
            // RunQuery
            // 
            RunQuery.Location = new Point(300, 24);
            RunQuery.Name = "RunQuery";
            RunQuery.Size = new Size(105, 27);
            RunQuery.TabIndex = 2;
            RunQuery.Text = "Query (Read)";
            RunQuery.UseVisualStyleBackColor = true;
            RunQuery.Click += RunQuery_Click;
            // 
            // InsertBTN
            // 
            InsertBTN.Location = new Point(300, 57);
            InsertBTN.Name = "InsertBTN";
            InsertBTN.Size = new Size(105, 27);
            InsertBTN.TabIndex = 3;
            InsertBTN.Text = "Query x2 (Insert)";
            InsertBTN.UseVisualStyleBackColor = true;
            InsertBTN.Click += InsertBTN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 118);
            Controls.Add(InsertBTN);
            Controls.Add(RunQuery);
            Controls.Add(OpnCnBT);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button OpnCnBT;
        private Button RunQuery;
        private Button InsertBTN;
    }
}