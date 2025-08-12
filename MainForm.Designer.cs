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
            comboModels.Location = new Point(138, 16);
            comboModels.Margin = new Padding(3, 4, 3, 4);
            comboModels.Name = "comboModels";
            comboModels.Size = new Size(346, 28);
            comboModels.TabIndex = 1;
            // 
            // txtData
            // 
            txtData.Location = new Point(138, 63);
            txtData.Margin = new Padding(3, 4, 3, 4);
            txtData.Multiline = true;
            txtData.Name = "txtData";
            txtData.ScrollBars = ScrollBars.Vertical;
            txtData.Size = new Size(607, 79);
            txtData.TabIndex = 3;
            // 
            // btnDeserialize
            // 
            btnDeserialize.Location = new Point(138, 150);
            btnDeserialize.Margin = new Padding(3, 4, 3, 4);
            btnDeserialize.Name = "btnDeserialize";
            btnDeserialize.Size = new Size(167, 40);
            btnDeserialize.TabIndex = 5;
            btnDeserialize.Text = "Deserialize";
            btnDeserialize.UseVisualStyleBackColor = true;
            btnDeserialize.Click += btnDeserialize_Click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(138, 229);
            txtOutput.Margin = new Padding(3, 4, 3, 4);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(607, 482);
            txtOutput.TabIndex = 6;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(70, 24);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(63, 20);
            lblModel.TabIndex = 0;
            lblModel.Text = "Model : ";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(36, 66);
            lblData.Name = "lblData";
            lblData.Size = new Size(97, 20);
            lblData.TabIndex = 2;
            lblData.Text = "Binary Data : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 738);
            Controls.Add(txtOutput);
            Controls.Add(btnDeserialize);
            Controls.Add(txtData);
            Controls.Add(lblData);
            Controls.Add(comboModels);
            Controls.Add(lblModel);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(805, 785);
            MinimumSize = new Size(805, 785);
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
