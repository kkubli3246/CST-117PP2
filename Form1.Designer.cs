namespace ProgrammingProject2
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
            this.lb_words = new System.Windows.Forms.ListBox();
            this.rb_blue = new System.Windows.Forms.RadioButton();
            this.rb_red = new System.Windows.Forms.RadioButton();
            this.rb_green = new System.Windows.Forms.RadioButton();
            this.ch_bold = new System.Windows.Forms.CheckBox();
            this.cb_italicize = new System.Windows.Forms.CheckBox();
            this.cb_underline = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_result = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_words
            // 
            this.lb_words.FormattingEnabled = true;
            this.lb_words.Items.AddRange(new object[] {
            "Once upon a midnight dreary, while I pondered, weak and weary,",
            "Over many a quaint and curious volume of forgotten lore—",
            "    While I nodded, nearly napping, suddenly there came a tapping,",
            "As of some one gently rapping, rapping at my chamber door.",
            "“’Tis some visitor,” I muttered, “tapping at my chamber door—",
            "            Only this and nothing more.”",
            "",
            "    Ah, distinctly I remember it was in the bleak December;",
            "And each separate dying ember wrought its ghost upon the floor.",
            "    Eagerly I wished the morrow;—vainly I had sought to borrow",
            "    From my books surcease of sorrow—sorrow for the lost Lenore—",
            "For the rare and radiant maiden whom the angels name Lenore—",
            "            Nameless here for evermore."});
            this.lb_words.Location = new System.Drawing.Point(45, 42);
            this.lb_words.Name = "lb_words";
            this.lb_words.Size = new System.Drawing.Size(335, 95);
            this.lb_words.TabIndex = 0;
            this.lb_words.SelectedIndexChanged += new System.EventHandler(this.lb_words_SelectedIndexChanged);
            // 
            // rb_blue
            // 
            this.rb_blue.AutoSize = true;
            this.rb_blue.Location = new System.Drawing.Point(18, 21);
            this.rb_blue.Name = "rb_blue";
            this.rb_blue.Size = new System.Drawing.Size(46, 17);
            this.rb_blue.TabIndex = 1;
            this.rb_blue.TabStop = true;
            this.rb_blue.Text = "Blue";
            this.rb_blue.UseVisualStyleBackColor = true;
            this.rb_blue.CheckedChanged += new System.EventHandler(this.rb_blue_CheckedChanged);
            // 
            // rb_red
            // 
            this.rb_red.AutoSize = true;
            this.rb_red.Location = new System.Drawing.Point(18, 44);
            this.rb_red.Name = "rb_red";
            this.rb_red.Size = new System.Drawing.Size(45, 17);
            this.rb_red.TabIndex = 2;
            this.rb_red.TabStop = true;
            this.rb_red.Text = "Red";
            this.rb_red.UseVisualStyleBackColor = true;
            this.rb_red.CheckedChanged += new System.EventHandler(this.rb_red_CheckedChanged);
            // 
            // rb_green
            // 
            this.rb_green.AutoSize = true;
            this.rb_green.Location = new System.Drawing.Point(18, 67);
            this.rb_green.Name = "rb_green";
            this.rb_green.Size = new System.Drawing.Size(54, 17);
            this.rb_green.TabIndex = 3;
            this.rb_green.TabStop = true;
            this.rb_green.Text = "Green";
            this.rb_green.UseVisualStyleBackColor = true;
            this.rb_green.CheckedChanged += new System.EventHandler(this.rb_green_CheckedChanged);
            // 
            // ch_bold
            // 
            this.ch_bold.AutoSize = true;
            this.ch_bold.Location = new System.Drawing.Point(18, 20);
            this.ch_bold.Name = "ch_bold";
            this.ch_bold.Size = new System.Drawing.Size(47, 17);
            this.ch_bold.TabIndex = 4;
            this.ch_bold.Text = "Bold";
            this.ch_bold.UseVisualStyleBackColor = true;
            this.ch_bold.CheckedChanged += new System.EventHandler(this.ch_bold_CheckedChanged);
            // 
            // cb_italicize
            // 
            this.cb_italicize.AutoSize = true;
            this.cb_italicize.Location = new System.Drawing.Point(18, 44);
            this.cb_italicize.Name = "cb_italicize";
            this.cb_italicize.Size = new System.Drawing.Size(61, 17);
            this.cb_italicize.TabIndex = 5;
            this.cb_italicize.Text = "Italicize";
            this.cb_italicize.UseVisualStyleBackColor = true;
            this.cb_italicize.CheckedChanged += new System.EventHandler(this.cb_italicize_CheckedChanged);
            // 
            // cb_underline
            // 
            this.cb_underline.AutoSize = true;
            this.cb_underline.Location = new System.Drawing.Point(18, 68);
            this.cb_underline.Name = "cb_underline";
            this.cb_underline.Size = new System.Drawing.Size(71, 17);
            this.cb_underline.TabIndex = 6;
            this.cb_underline.Text = "Underline";
            this.cb_underline.UseVisualStyleBackColor = true;
            this.cb_underline.CheckedChanged += new System.EventHandler(this.cb_underline_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_underline);
            this.groupBox1.Controls.Add(this.ch_bold);
            this.groupBox1.Controls.Add(this.cb_italicize);
            this.groupBox1.Location = new System.Drawing.Point(45, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text Style";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_red);
            this.groupBox2.Controls.Add(this.rb_blue);
            this.groupBox2.Controls.Add(this.rb_green);
            this.groupBox2.Location = new System.Drawing.Point(45, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font Color";
            // 
            // txt_result
            // 
            this.txt_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_result.Location = new System.Drawing.Point(26, 24);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(319, 58);
            this.txt_result.TabIndex = 9;
            this.txt_result.Text = "(Change the Text here)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_result);
            this.groupBox3.Location = new System.Drawing.Point(335, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 100);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edit Text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_words);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_words;
        private System.Windows.Forms.RadioButton rb_blue;
        private System.Windows.Forms.RadioButton rb_red;
        private System.Windows.Forms.RadioButton rb_green;
        private System.Windows.Forms.CheckBox ch_bold;
        private System.Windows.Forms.CheckBox cb_italicize;
        private System.Windows.Forms.CheckBox cb_underline;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txt_result;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

