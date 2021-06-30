
namespace WinFormTestApp
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelŞehir = new System.Windows.Forms.Label();
            this.labelSıcaklık = new System.Windows.Forms.Label();
            this.labelDurum = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Getir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelŞehir
            // 
            this.labelŞehir.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelŞehir.Location = new System.Drawing.Point(12, 231);
            this.labelŞehir.Name = "labelŞehir";
            this.labelŞehir.Size = new System.Drawing.Size(306, 45);
            this.labelŞehir.TabIndex = 3;
            this.labelŞehir.Text = "labelŞehir";
            this.labelŞehir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSıcaklık
            // 
            this.labelSıcaklık.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelSıcaklık.Location = new System.Drawing.Point(12, 285);
            this.labelSıcaklık.Name = "labelSıcaklık";
            this.labelSıcaklık.Size = new System.Drawing.Size(306, 45);
            this.labelSıcaklık.TabIndex = 3;
            this.labelSıcaklık.Text = "labelSıcaklık";
            this.labelSıcaklık.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDurum
            // 
            this.labelDurum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDurum.Location = new System.Drawing.Point(12, 330);
            this.labelDurum.Name = "labelDurum";
            this.labelDurum.Size = new System.Drawing.Size(306, 67);
            this.labelDurum.TabIndex = 3;
            this.labelDurum.Text = "labelDurum";
            this.labelDurum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // webBrowser1
            // 
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(12, 39);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(306, 189);
            this.webBrowser1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(330, 403);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.labelDurum);
            this.Controls.Add(this.labelSıcaklık);
            this.Controls.Add(this.labelŞehir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "HavaApi Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelŞehir;
        private System.Windows.Forms.Label labelSıcaklık;
        private System.Windows.Forms.Label labelDurum;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

