namespace MemoryPackViewer
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
            comboModels = new ComboBox();
            txtData = new TextBox();
            btnDeserialize = new Button();
            txtOutput = new TextBox();
            lblModel = new Label();
            lblData = new Label();
            SuspendLayout();
            // 
            // comboModels
            // 
            comboModels.DropDownStyle = ComboBoxStyle.DropDownList;
            comboModels.FormattingEnabled = true;
            comboModels.Location = new Point(168, 16);
            comboModels.Margin = new Padding(3, 4, 3, 4);
            comboModels.Name = "comboModels";
            comboModels.Size = new Size(342, 28);
            comboModels.TabIndex = 1;
            // 
            // txtData
            // 
            txtData.Location = new Point(168, 63);
            txtData.Margin = new Padding(3, 4, 3, 4);
            txtData.Multiline = true;
            txtData.Name = "txtData";
            txtData.ScrollBars = ScrollBars.Vertical;
            txtData.Size = new Size(342, 79);
            txtData.TabIndex = 3;
            // 
            // btnDeserialize
            // 
            btnDeserialize.Location = new Point(168, 153);
            btnDeserialize.Margin = new Padding(3, 4, 3, 4);
            btnDeserialize.Name = "btnDeserialize";
            btnDeserialize.Size = new Size(137, 40);
            btnDeserialize.TabIndex = 5;
            btnDeserialize.Text = "Deserialize";
            btnDeserialize.UseVisualStyleBackColor = true;
            btnDeserialize.Click += btnDeserialize_Click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(168, 213);
            txtOutput.Margin = new Padding(3, 4, 3, 4);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(428, 332);
            txtOutput.TabIndex = 6;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(70, 23);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(92, 20);
            lblModel.TabIndex = 0;
            lblModel.Text = "انتخاب مدل : ";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(12, 66);
            lblData.Name = "lblData";
            lblData.Size = new Size(150, 20);
            lblData.TabIndex = 2;
            lblData.Text = "داده به صورت باینری : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 573);
            Controls.Add(txtOutput);
            Controls.Add(btnDeserialize);
            Controls.Add(txtData);
            Controls.Add(lblData);
            Controls.Add(comboModels);
            Controls.Add(lblModel);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(701, 620);
            MinimumSize = new Size(701, 620);
            Name = "Form1";
            Text = "MemoryPack Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox comboModels;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnDeserialize;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblData;
    }
}
