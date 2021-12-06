namespace archi_Template
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
            this.runCycleBtn = new System.Windows.Forms.Button();
            this.StartPCTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inializeBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PiplineGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.MipsRegisterGrid = new System.Windows.Forms.DataGridView();
            this.UserCodetxt = new System.Windows.Forms.TextBox();
            this.MemoryGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PiplineGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MipsRegisterGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // runCycleBtn
            // 
            this.runCycleBtn.Location = new System.Drawing.Point(721, 535);
            this.runCycleBtn.Margin = new System.Windows.Forms.Padding(4);
            this.runCycleBtn.Name = "runCycleBtn";
            this.runCycleBtn.Size = new System.Drawing.Size(193, 70);
            this.runCycleBtn.TabIndex = 23;
            this.runCycleBtn.Text = "Run 1 cycle";
            this.runCycleBtn.UseVisualStyleBackColor = true;
            this.runCycleBtn.Click += new System.EventHandler(this.runCycleBtn_Click);
            // 
            // StartPCTxt
            // 
            this.StartPCTxt.Location = new System.Drawing.Point(65, 554);
            this.StartPCTxt.Margin = new System.Windows.Forms.Padding(4);
            this.StartPCTxt.Name = "StartPCTxt";
            this.StartPCTxt.Size = new System.Drawing.Size(132, 22);
            this.StartPCTxt.TabIndex = 21;
            this.StartPCTxt.Text = "1000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 554);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "PC:";
            // 
            // inializeBtn
            // 
            this.inializeBtn.Location = new System.Drawing.Point(332, 534);
            this.inializeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.inializeBtn.Name = "inializeBtn";
            this.inializeBtn.Size = new System.Drawing.Size(193, 70);
            this.inializeBtn.TabIndex = 22;
            this.inializeBtn.Text = "Inisialize";
            this.inializeBtn.UseVisualStyleBackColor = true;
            this.inializeBtn.Click += new System.EventHandler(this.inializeBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1221, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Data memory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(857, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Pipline registers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(479, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "MIPS registers";
            // 
            // PiplineGrid
            // 
            this.PiplineGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PiplineGrid.Location = new System.Drawing.Point(861, 68);
            this.PiplineGrid.Margin = new System.Windows.Forms.Padding(4);
            this.PiplineGrid.Name = "PiplineGrid";
            this.PiplineGrid.ReadOnly = true;
            this.PiplineGrid.RowHeadersWidth = 51;
            this.PiplineGrid.Size = new System.Drawing.Size(321, 459);
            this.PiplineGrid.TabIndex = 14;
            this.PiplineGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PiplineGrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "user code";
            // 
            // MipsRegisterGrid
            // 
            this.MipsRegisterGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MipsRegisterGrid.Location = new System.Drawing.Point(483, 68);
            this.MipsRegisterGrid.Margin = new System.Windows.Forms.Padding(4);
            this.MipsRegisterGrid.Name = "MipsRegisterGrid";
            this.MipsRegisterGrid.ReadOnly = true;
            this.MipsRegisterGrid.RowHeadersWidth = 51;
            this.MipsRegisterGrid.Size = new System.Drawing.Size(323, 459);
            this.MipsRegisterGrid.TabIndex = 13;
            this.MipsRegisterGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MipsRegisterGrid_CellContentClick);
            // 
            // UserCodetxt
            // 
            this.UserCodetxt.Location = new System.Drawing.Point(21, 68);
            this.UserCodetxt.Margin = new System.Windows.Forms.Padding(4);
            this.UserCodetxt.Multiline = true;
            this.UserCodetxt.Name = "UserCodetxt";
            this.UserCodetxt.Size = new System.Drawing.Size(413, 458);
            this.UserCodetxt.TabIndex = 12;
            this.UserCodetxt.TextChanged += new System.EventHandler(this.UserCodetxt_TextChanged);
            // 
            // MemoryGrid
            // 
            this.MemoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemoryGrid.Location = new System.Drawing.Point(1225, 68);
            this.MemoryGrid.Margin = new System.Windows.Forms.Padding(4);
            this.MemoryGrid.Name = "MemoryGrid";
            this.MemoryGrid.ReadOnly = true;
            this.MemoryGrid.RowHeadersWidth = 51;
            this.MemoryGrid.Size = new System.Drawing.Size(321, 459);
            this.MemoryGrid.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 646);
            this.Controls.Add(this.runCycleBtn);
            this.Controls.Add(this.StartPCTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inializeBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MemoryGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PiplineGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MipsRegisterGrid);
            this.Controls.Add(this.UserCodetxt);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PiplineGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MipsRegisterGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoryGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runCycleBtn;
        private System.Windows.Forms.TextBox StartPCTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button inializeBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView PiplineGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView MipsRegisterGrid;
        private System.Windows.Forms.TextBox UserCodetxt;
        private System.Windows.Forms.DataGridView MemoryGrid;
    }
}

