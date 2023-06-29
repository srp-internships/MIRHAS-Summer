namespace EFCoreSampleProject
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
            this.students_list = new System.Windows.Forms.DataGridView();
            this.name_txb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.surname_txb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gpu_txb = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.students_list)).BeginInit();
            this.SuspendLayout();
            // 
            // students_list
            // 
            this.students_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.students_list.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.students_list.Location = new System.Drawing.Point(0, 162);
            this.students_list.Name = "students_list";
            this.students_list.RowHeadersWidth = 51;
            this.students_list.RowTemplate.Height = 29;
            this.students_list.Size = new System.Drawing.Size(1151, 484);
            this.students_list.TabIndex = 0;
            this.students_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.students_list_CellContentClick);
            // 
            // name_txb
            // 
            this.name_txb.Location = new System.Drawing.Point(319, 38);
            this.name_txb.Name = "name_txb";
            this.name_txb.Size = new System.Drawing.Size(125, 27);
            this.name_txb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Surname";
            // 
            // surname_txb
            // 
            this.surname_txb.Location = new System.Drawing.Point(494, 38);
            this.surname_txb.Name = "surname_txb";
            this.surname_txb.Size = new System.Drawing.Size(125, 27);
            this.surname_txb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(685, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "GPU";
            // 
            // gpu_txb
            // 
            this.gpu_txb.Location = new System.Drawing.Point(685, 38);
            this.gpu_txb.Name = "gpu_txb";
            this.gpu_txb.Size = new System.Drawing.Size(125, 27);
            this.gpu_txb.TabIndex = 5;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.Lime;
            this.add_btn.Location = new System.Drawing.Point(319, 98);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(125, 29);
            this.add_btn.TabIndex = 7;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(494, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(685, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(870, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 29);
            this.button3.TabIndex = 10;
            this.button3.Text = "Get Top Ten GPU\'s";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 646);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gpu_txb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.surname_txb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_txb);
            this.Controls.Add(this.students_list);
            this.Name = "Form1";
            this.Text = "StudentManagement";
            ((System.ComponentModel.ISupportInitialize)(this.students_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView students_list;
        private TextBox name_txb;
        private Label label1;
        private Label label2;
        private TextBox surname_txb;
        private Label label3;
        private TextBox gpu_txb;
        private Button add_btn;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}