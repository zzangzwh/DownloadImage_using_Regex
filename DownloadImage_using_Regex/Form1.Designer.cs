
namespace DownloadImage_using_Regex
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
            this.UI_btn_status = new System.Windows.Forms.Button();
            this.UI_tBox_input = new System.Windows.Forms.TextBox();
            this.UI_btn_openfile = new System.Windows.Forms.Button();
            this.UI_Btn_clear = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.UI_btn_result = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UI_btn_status
            // 
            this.UI_btn_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_btn_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_btn_status.Location = new System.Drawing.Point(814, -118);
            this.UI_btn_status.Name = "UI_btn_status";
            this.UI_btn_status.Size = new System.Drawing.Size(153, 82);
            this.UI_btn_status.TabIndex = 17;
            this.UI_btn_status.Text = "Result";
            this.UI_btn_status.UseVisualStyleBackColor = true;
            // 
            // UI_tBox_input
            // 
            this.UI_tBox_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_tBox_input.Font = new System.Drawing.Font("Microsoft YaHei", 15F);
            this.UI_tBox_input.Location = new System.Drawing.Point(-22, -113);
            this.UI_tBox_input.Multiline = true;
            this.UI_tBox_input.Name = "UI_tBox_input";
            this.UI_tBox_input.Size = new System.Drawing.Size(781, 51);
            this.UI_tBox_input.TabIndex = 15;
            // 
            // UI_btn_openfile
            // 
            this.UI_btn_openfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_btn_openfile.Location = new System.Drawing.Point(742, 136);
            this.UI_btn_openfile.Name = "UI_btn_openfile";
            this.UI_btn_openfile.Size = new System.Drawing.Size(153, 80);
            this.UI_btn_openfile.TabIndex = 23;
            this.UI_btn_openfile.Text = "Image Location";
            this.UI_btn_openfile.UseVisualStyleBackColor = true;
            // 
            // UI_Btn_clear
            // 
            this.UI_Btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Btn_clear.Location = new System.Drawing.Point(742, 550);
            this.UI_Btn_clear.Name = "UI_Btn_clear";
            this.UI_Btn_clear.Size = new System.Drawing.Size(153, 82);
            this.UI_Btn_clear.TabIndex = 22;
            this.UI_Btn_clear.Text = "Clear";
            this.UI_Btn_clear.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(50, 112);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(637, 608);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(742, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 82);
            this.button1.TabIndex = 20;
            this.button1.Text = "Result";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UI_btn_result
            // 
            this.UI_btn_result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_btn_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_btn_result.Location = new System.Drawing.Point(742, 651);
            this.UI_btn_result.Name = "UI_btn_result";
            this.UI_btn_result.Size = new System.Drawing.Size(153, 69);
            this.UI_btn_result.TabIndex = 19;
            this.UI_btn_result.Text = "Images";
            this.UI_btn_result.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 15F);
            this.textBox1.Location = new System.Drawing.Point(50, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(637, 51);
            this.textBox1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 755);
            this.Controls.Add(this.UI_btn_openfile);
            this.Controls.Add(this.UI_Btn_clear);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UI_btn_result);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.UI_btn_status);
            this.Controls.Add(this.UI_tBox_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button UI_btn_status;
        private System.Windows.Forms.TextBox UI_tBox_input;
        private System.Windows.Forms.Button UI_btn_openfile;
        private System.Windows.Forms.Button UI_Btn_clear;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button UI_btn_result;
        private System.Windows.Forms.TextBox textBox1;
    }
}

