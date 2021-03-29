namespace FitnessApp
{
    partial class Fat_Reduction
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_title_reduction = new System.Windows.Forms.Label();
            this.comboBox_sex = new System.Windows.Forms.ComboBox();
            this.panel_body_reduction = new System.Windows.Forms.Panel();
            this.textBox_weight = new System.Windows.Forms.TextBox();
            this.textBox_height = new System.Windows.Forms.TextBox();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.comboBox_move = new System.Windows.Forms.ComboBox();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.button_count = new System.Windows.Forms.Button();
            this.panel_body_reduction.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title_reduction
            // 
            this.label_title_reduction.AutoSize = true;
            this.label_title_reduction.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title_reduction.Location = new System.Drawing.Point(248, 15);
            this.label_title_reduction.Name = "label_title_reduction";
            this.label_title_reduction.Size = new System.Drawing.Size(346, 27);
            this.label_title_reduction.TabIndex = 1;
            this.label_title_reduction.Text = "Redukcja masy - kalkulator";
            // 
            // comboBox_sex
            // 
            this.comboBox_sex.FormattingEnabled = true;
            this.comboBox_sex.Location = new System.Drawing.Point(7, 108);
            this.comboBox_sex.Name = "comboBox_sex";
            this.comboBox_sex.Size = new System.Drawing.Size(109, 21);
            this.comboBox_sex.TabIndex = 4;
            this.comboBox_sex.SelectedIndexChanged += new System.EventHandler(this.comboBox_sex_SelectedIndexChanged);
            // 
            // panel_body_reduction
            // 
            this.panel_body_reduction.Controls.Add(this.button_count);
            this.panel_body_reduction.Controls.Add(this.textBox_result);
            this.panel_body_reduction.Controls.Add(this.button_0);
            this.panel_body_reduction.Controls.Add(this.button_3);
            this.panel_body_reduction.Controls.Add(this.button_2);
            this.panel_body_reduction.Controls.Add(this.button_1);
            this.panel_body_reduction.Controls.Add(this.button_9);
            this.panel_body_reduction.Controls.Add(this.button_8);
            this.panel_body_reduction.Controls.Add(this.button_7);
            this.panel_body_reduction.Controls.Add(this.button_6);
            this.panel_body_reduction.Controls.Add(this.button_4);
            this.panel_body_reduction.Controls.Add(this.button_5);
            this.panel_body_reduction.Controls.Add(this.comboBox_move);
            this.panel_body_reduction.Controls.Add(this.textBox_age);
            this.panel_body_reduction.Controls.Add(this.textBox_height);
            this.panel_body_reduction.Controls.Add(this.textBox_weight);
            this.panel_body_reduction.Controls.Add(this.comboBox_sex);
            this.panel_body_reduction.Controls.Add(this.label_title_reduction);
            this.panel_body_reduction.Location = new System.Drawing.Point(0, 0);
            this.panel_body_reduction.Name = "panel_body_reduction";
            this.panel_body_reduction.Size = new System.Drawing.Size(860, 700);
            this.panel_body_reduction.TabIndex = 2;
            // 
            // textBox_weight
            // 
            this.textBox_weight.Location = new System.Drawing.Point(145, 108);
            this.textBox_weight.Name = "textBox_weight";
            this.textBox_weight.Size = new System.Drawing.Size(100, 20);
            this.textBox_weight.TabIndex = 5;
            // 
            // textBox_height
            // 
            this.textBox_height.Location = new System.Drawing.Point(278, 108);
            this.textBox_height.Name = "textBox_height";
            this.textBox_height.Size = new System.Drawing.Size(100, 20);
            this.textBox_height.TabIndex = 6;
            // 
            // textBox_age
            // 
            this.textBox_age.Location = new System.Drawing.Point(420, 108);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(100, 20);
            this.textBox_age.TabIndex = 7;
            // 
            // comboBox_move
            // 
            this.comboBox_move.FormattingEnabled = true;
            this.comboBox_move.Location = new System.Drawing.Point(556, 108);
            this.comboBox_move.Name = "comboBox_move";
            this.comboBox_move.Size = new System.Drawing.Size(264, 21);
            this.comboBox_move.TabIndex = 8;
            this.comboBox_move.SelectedIndexChanged += new System.EventHandler(this.comboBox_move_SelectedIndexChanged);
            // 
            // button_5
            // 
            this.button_5.BackColor = System.Drawing.Color.Black;
            this.button_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_5.FlatAppearance.BorderSize = 0;
            this.button_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_5.ForeColor = System.Drawing.Color.White;
            this.button_5.Location = new System.Drawing.Point(410, 309);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(40, 40);
            this.button_5.TabIndex = 9;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = false;
            // 
            // button_4
            // 
            this.button_4.BackColor = System.Drawing.Color.Black;
            this.button_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_4.FlatAppearance.BorderSize = 0;
            this.button_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_4.ForeColor = System.Drawing.Color.White;
            this.button_4.Location = new System.Drawing.Point(350, 309);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(40, 40);
            this.button_4.TabIndex = 10;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = false;
            // 
            // button_6
            // 
            this.button_6.BackColor = System.Drawing.Color.Black;
            this.button_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_6.FlatAppearance.BorderSize = 0;
            this.button_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_6.ForeColor = System.Drawing.Color.White;
            this.button_6.Location = new System.Drawing.Point(470, 309);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(40, 40);
            this.button_6.TabIndex = 11;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = false;
            // 
            // button_7
            // 
            this.button_7.BackColor = System.Drawing.Color.Black;
            this.button_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_7.FlatAppearance.BorderSize = 0;
            this.button_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_7.ForeColor = System.Drawing.Color.White;
            this.button_7.Location = new System.Drawing.Point(350, 253);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(40, 40);
            this.button_7.TabIndex = 12;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = false;
            // 
            // button_8
            // 
            this.button_8.BackColor = System.Drawing.Color.Black;
            this.button_8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_8.FlatAppearance.BorderSize = 0;
            this.button_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_8.ForeColor = System.Drawing.Color.White;
            this.button_8.Location = new System.Drawing.Point(410, 253);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(40, 40);
            this.button_8.TabIndex = 13;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = false;
            // 
            // button_9
            // 
            this.button_9.BackColor = System.Drawing.Color.Black;
            this.button_9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_9.FlatAppearance.BorderSize = 0;
            this.button_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_9.ForeColor = System.Drawing.Color.White;
            this.button_9.Location = new System.Drawing.Point(470, 253);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(40, 40);
            this.button_9.TabIndex = 14;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = false;
            // 
            // button_1
            // 
            this.button_1.BackColor = System.Drawing.Color.Black;
            this.button_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_1.FlatAppearance.BorderSize = 0;
            this.button_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_1.ForeColor = System.Drawing.Color.White;
            this.button_1.Location = new System.Drawing.Point(350, 365);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(40, 40);
            this.button_1.TabIndex = 15;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = false;
            // 
            // button_2
            // 
            this.button_2.BackColor = System.Drawing.Color.Black;
            this.button_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_2.FlatAppearance.BorderSize = 0;
            this.button_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_2.ForeColor = System.Drawing.Color.White;
            this.button_2.Location = new System.Drawing.Point(410, 365);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(40, 40);
            this.button_2.TabIndex = 16;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = false;
            // 
            // button_3
            // 
            this.button_3.BackColor = System.Drawing.Color.Black;
            this.button_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_3.FlatAppearance.BorderSize = 0;
            this.button_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_3.ForeColor = System.Drawing.Color.White;
            this.button_3.Location = new System.Drawing.Point(470, 365);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(40, 40);
            this.button_3.TabIndex = 17;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = false;
            // 
            // button_0
            // 
            this.button_0.BackColor = System.Drawing.Color.Black;
            this.button_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_0.FlatAppearance.BorderSize = 0;
            this.button_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_0.ForeColor = System.Drawing.Color.White;
            this.button_0.Location = new System.Drawing.Point(410, 421);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(40, 40);
            this.button_0.TabIndex = 18;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = false;
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(375, 176);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(135, 20);
            this.textBox_result.TabIndex = 19;
            // 
            // button_count
            // 
            this.button_count.BackColor = System.Drawing.Color.Black;
            this.button_count.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_count.FlatAppearance.BorderSize = 0;
            this.button_count.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_count.ForeColor = System.Drawing.Color.White;
            this.button_count.Location = new System.Drawing.Point(577, 177);
            this.button_count.Name = "button_count";
            this.button_count.Size = new System.Drawing.Size(75, 23);
            this.button_count.TabIndex = 20;
            this.button_count.Text = "Oblicz!";
            this.button_count.UseVisualStyleBackColor = false;
            this.button_count.Click += new System.EventHandler(this.button_count_Click);
            // 
            // Fat_Reduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel_body_reduction);
            this.Name = "Fat_Reduction";
            this.Size = new System.Drawing.Size(860, 700);
            this.panel_body_reduction.ResumeLayout(false);
            this.panel_body_reduction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_title_reduction;
        private System.Windows.Forms.ComboBox comboBox_sex;
        private System.Windows.Forms.Panel panel_body_reduction;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.ComboBox comboBox_move;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.TextBox textBox_height;
        private System.Windows.Forms.TextBox textBox_weight;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button button_count;
    }
}
