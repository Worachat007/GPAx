
namespace GPAx
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
            btnAdd = new Button();
            GPA_sum = new Label();
            tbInputGPA = new TextBox();
            tbGPAx = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            tbGPAmin = new TextBox();
            tbGPAmax = new TextBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Lucida Bright", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(495, 62);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 222);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += getMaxGPA;
            // 
            // GPA_sum
            // 
            GPA_sum.AutoSize = true;
            GPA_sum.Font = new Font("Lucida Bright", 18F);
            GPA_sum.Location = new Point(149, 62);
            GPA_sum.Name = "GPA_sum";
            GPA_sum.Size = new Size(162, 34);
            GPA_sum.TabIndex = 1;
            GPA_sum.Text = "ใส่คะแนนGPA";
            // 
            // tbInputGPA
            // 
            tbInputGPA.Location = new Point(329, 62);
            tbInputGPA.Name = "tbInputGPA";
            tbInputGPA.Size = new Size(125, 27);
            tbInputGPA.TabIndex = 2;
            // 
            // tbGPAx
            // 
            tbGPAx.Location = new Point(329, 118);
            tbGPAx.Name = "tbGPAx";
            tbGPAx.Size = new Size(125, 27);
            tbGPAx.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Bright", 18F);
            label2.Location = new Point(168, 125);
            label2.Name = "label2";
            label2.Size = new Size(98, 34);
            label2.TabIndex = 3;
            label2.Text = "GPAX";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Bright", 18F);
            label1.Location = new Point(150, 241);
            label1.Name = "label1";
            label1.Size = new Size(144, 34);
            label1.TabIndex = 5;
            label1.Text = "คะแนนน้อยสุด";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Bright", 18F);
            label3.Location = new Point(151, 179);
            label3.Name = "label3";
            label3.Size = new Size(142, 34);
            label3.TabIndex = 6;
            label3.Text = "คะแนนมากสุด";
            // 
            // tbGPAmin
            // 
            tbGPAmin.Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbGPAmin.Location = new Point(329, 241);
            tbGPAmin.Name = "tbGPAmin";
            tbGPAmin.Size = new Size(125, 25);
            tbGPAmin.TabIndex = 7;
            tbGPAmin.TextChanged += textBox1_TextChanged;
            // 
            // tbGPAmax
            // 
            tbGPAmax.Location = new Point(329, 186);
            tbGPAmax.Name = "tbGPAmax";
            tbGPAmax.Size = new Size(125, 27);
            tbGPAmax.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbGPAmax);
            Controls.Add(tbGPAmin);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(tbGPAx);
            Controls.Add(label2);
            Controls.Add(tbInputGPA);
            Controls.Add(GPA_sum);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnAdd;
        private Label GPA_sum;
        private TextBox tbInputGPA;
        private TextBox tbGPAx;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox tbGPAmin;
        private TextBox tbGPAmax;
    }
}
