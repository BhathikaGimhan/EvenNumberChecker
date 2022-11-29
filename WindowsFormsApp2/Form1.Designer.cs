namespace WindowsFormsApp2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Input = new System.Windows.Forms.TextBox();
            this.SubmittonButton = new System.Windows.Forms.Button();
            this.ListView = new System.Windows.Forms.ListView();
            this.Number = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Number";
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(131, 55);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(161, 20);
            this.Input.TabIndex = 1;
            // 
            // SubmittonButton
            // 
            this.SubmittonButton.Location = new System.Drawing.Point(217, 81);
            this.SubmittonButton.Name = "SubmittonButton";
            this.SubmittonButton.Size = new System.Drawing.Size(75, 23);
            this.SubmittonButton.TabIndex = 2;
            this.SubmittonButton.Text = "Submit";
            this.SubmittonButton.UseVisualStyleBackColor = true;
            this.SubmittonButton.Click += new System.EventHandler(this.SubmittonButton_Click);
            // 
            // ListView
            // 
            this.ListView.HideSelection = false;
            this.ListView.Location = new System.Drawing.Point(15, 126);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(277, 326);
            this.ListView.TabIndex = 3;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.List;
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Location = new System.Drawing.Point(15, 107);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(0, 13);
            this.Number.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 464);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.SubmittonButton);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button SubmittonButton;
        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.Label Number;
    }
}

