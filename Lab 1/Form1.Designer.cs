namespace Lab_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvOperators = new System.Windows.Forms.DataGridView();
            this.cOperator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAmountOperators = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOperands = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStart = new System.Windows.Forms.Button();
            this.lOperator = new System.Windows.Forms.Label();
            this.lOperand = new System.Windows.Forms.Label();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.lUOperator = new System.Windows.Forms.Label();
            this.lUOperand = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperators)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperands)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOperators
            // 
            this.dgvOperators.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvOperators.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOperators.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOperators.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperators.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cOperator,
            this.cAmountOperators});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOperators.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOperators.EnableHeadersVisualStyles = false;
            this.dgvOperators.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvOperators.Location = new System.Drawing.Point(1, 12);
            this.dgvOperators.Name = "dgvOperators";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOperators.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOperators.Size = new System.Drawing.Size(350, 768);
            this.dgvOperators.TabIndex = 0;
            // 
            // cOperator
            // 
            this.cOperator.HeaderText = "Оператор";
            this.cOperator.Name = "cOperator";
            this.cOperator.Width = 150;
            // 
            // cAmountOperators
            // 
            this.cAmountOperators.HeaderText = "Количество";
            this.cAmountOperators.Name = "cAmountOperators";
            this.cAmountOperators.Width = 110;
            // 
            // dgvOperands
            // 
            this.dgvOperands.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvOperands.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOperands.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOperands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOperands.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOperands.EnableHeadersVisualStyles = false;
            this.dgvOperands.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvOperands.Location = new System.Drawing.Point(365, 12);
            this.dgvOperands.Name = "dgvOperands";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOperands.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvOperands.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvOperands.Size = new System.Drawing.Size(337, 768);
            this.dgvOperands.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Операнд";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(763, 714);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(524, 64);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Рассчитать";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lOperator
            // 
            this.lOperator.AutoSize = true;
            this.lOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lOperator.Location = new System.Drawing.Point(724, 24);
            this.lOperator.Name = "lOperator";
            this.lOperator.Size = new System.Drawing.Size(212, 20);
            this.lOperator.TabIndex = 3;
            this.lOperator.Text = "Общее число операторов: ";
            // 
            // lOperand
            // 
            this.lOperand.AutoSize = true;
            this.lOperand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lOperand.Location = new System.Drawing.Point(1019, 24);
            this.lOperand.Name = "lOperand";
            this.lOperand.Size = new System.Drawing.Size(205, 20);
            this.lOperand.TabIndex = 4;
            this.lOperand.Text = "Общее число операндов: ";
            // 
            // rtbText
            // 
            this.rtbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbText.Location = new System.Drawing.Point(728, 197);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(559, 511);
            this.rtbText.TabIndex = 5;
            this.rtbText.Text = "";
            this.rtbText.TextChanged += new System.EventHandler(this.rtbText_TextChanged);
            // 
            // lUOperator
            // 
            this.lUOperator.AutoSize = true;
            this.lUOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lUOperator.Location = new System.Drawing.Point(724, 57);
            this.lUOperator.Name = "lUOperator";
            this.lUOperator.Size = new System.Drawing.Size(247, 20);
            this.lUOperator.TabIndex = 6;
            this.lUOperator.Text = "Число уникальных операторов:";
            // 
            // lUOperand
            // 
            this.lUOperand.AutoSize = true;
            this.lUOperand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lUOperand.Location = new System.Drawing.Point(1019, 57);
            this.lUOperand.Name = "lUOperand";
            this.lUOperand.Size = new System.Drawing.Size(240, 20);
            this.lUOperand.TabIndex = 7;
            this.lUOperand.Text = "Число уникальных операндов:";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l3.Location = new System.Drawing.Point(1019, 130);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(158, 20);
            this.l3.TabIndex = 8;
            this.l3.Text = "Объём программы: ";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l2.Location = new System.Drawing.Point(724, 164);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(147, 20);
            this.l2.TabIndex = 9;
            this.l2.Text = "Длина программы";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l1.Location = new System.Drawing.Point(724, 130);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(164, 20);
            this.l1.TabIndex = 10;
            this.l1.Text = "Словарь программы";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 790);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.lUOperand);
            this.Controls.Add(this.lUOperator);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.lOperand);
            this.Controls.Add(this.lOperator);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.dgvOperands);
            this.Controls.Add(this.dgvOperators);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperators)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperands)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOperators;
        private System.Windows.Forms.DataGridView dgvOperands;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lOperator;
        private System.Windows.Forms.Label lOperand;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOperator;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAmountOperators;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label lUOperator;
        private System.Windows.Forms.Label lUOperand;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l1;
    }
}

