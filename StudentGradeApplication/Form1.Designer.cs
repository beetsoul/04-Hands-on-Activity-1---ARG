namespace StudentGradeApplication
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
            this.name = new System.Windows.Forms.Label();
            this.grades = new System.Windows.Forms.Label();
            this.english = new System.Windows.Forms.Label();
            this.math = new System.Windows.Forms.Label();
            this.science = new System.Windows.Forms.Label();
            this.filipino = new System.Windows.Forms.Label();
            this.history = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.englishBox = new System.Windows.Forms.TextBox();
            this.mathBox = new System.Windows.Forms.TextBox();
            this.scienceBox = new System.Windows.Forms.TextBox();
            this.filipinoBox = new System.Windows.Forms.TextBox();
            this.historyBox = new System.Windows.Forms.TextBox();
            this.generatebtn = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Palatino Linotype", 9.2F, System.Drawing.FontStyle.Bold);
            this.name.Location = new System.Drawing.Point(23, 15);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(45, 18);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // grades
            // 
            this.grades.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grades.AutoSize = true;
            this.grades.BackColor = System.Drawing.Color.Transparent;
            this.grades.Font = new System.Drawing.Font("Palatino Linotype", 9.2F, System.Drawing.FontStyle.Bold);
            this.grades.Location = new System.Drawing.Point(66, 43);
            this.grades.Name = "grades";
            this.grades.Size = new System.Drawing.Size(52, 18);
            this.grades.TabIndex = 1;
            this.grades.Text = "Grades";
            this.grades.Click += new System.EventHandler(this.label1_Click);
            // 
            // english
            // 
            this.english.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.english.AutoSize = true;
            this.english.BackColor = System.Drawing.Color.Transparent;
            this.english.Font = new System.Drawing.Font("Palatino Linotype", 9.2F, System.Drawing.FontStyle.Bold);
            this.english.Location = new System.Drawing.Point(23, 73);
            this.english.Name = "english";
            this.english.Size = new System.Drawing.Size(54, 18);
            this.english.TabIndex = 2;
            this.english.Text = "English";
            // 
            // math
            // 
            this.math.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.math.AutoSize = true;
            this.math.BackColor = System.Drawing.Color.Transparent;
            this.math.Font = new System.Drawing.Font("Palatino Linotype", 9.2F, System.Drawing.FontStyle.Bold);
            this.math.Location = new System.Drawing.Point(23, 104);
            this.math.Name = "math";
            this.math.Size = new System.Drawing.Size(40, 18);
            this.math.TabIndex = 3;
            this.math.Text = "Math";
            // 
            // science
            // 
            this.science.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.science.AutoSize = true;
            this.science.BackColor = System.Drawing.Color.Transparent;
            this.science.Font = new System.Drawing.Font("Palatino Linotype", 9.2F, System.Drawing.FontStyle.Bold);
            this.science.Location = new System.Drawing.Point(23, 136);
            this.science.Name = "science";
            this.science.Size = new System.Drawing.Size(54, 18);
            this.science.TabIndex = 4;
            this.science.Text = "Science";
            // 
            // filipino
            // 
            this.filipino.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filipino.AutoSize = true;
            this.filipino.BackColor = System.Drawing.Color.Transparent;
            this.filipino.Font = new System.Drawing.Font("Palatino Linotype", 9.2F, System.Drawing.FontStyle.Bold);
            this.filipino.Location = new System.Drawing.Point(23, 170);
            this.filipino.Name = "filipino";
            this.filipino.Size = new System.Drawing.Size(56, 18);
            this.filipino.TabIndex = 5;
            this.filipino.Text = "Filipino";
            // 
            // history
            // 
            this.history.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.history.AutoSize = true;
            this.history.BackColor = System.Drawing.Color.Transparent;
            this.history.Font = new System.Drawing.Font("Palatino Linotype", 9.2F, System.Drawing.FontStyle.Bold);
            this.history.Location = new System.Drawing.Point(23, 205);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(53, 18);
            this.history.TabIndex = 6;
            this.history.Text = "History";
            // 
            // nameBox
            // 
            this.nameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameBox.Location = new System.Drawing.Point(75, 13);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(361, 20);
            this.nameBox.TabIndex = 7;
            // 
            // englishBox
            // 
            this.englishBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.englishBox.Location = new System.Drawing.Point(75, 73);
            this.englishBox.Name = "englishBox";
            this.englishBox.Size = new System.Drawing.Size(82, 20);
            this.englishBox.TabIndex = 8;
            // 
            // mathBox
            // 
            this.mathBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mathBox.Location = new System.Drawing.Point(75, 104);
            this.mathBox.Name = "mathBox";
            this.mathBox.Size = new System.Drawing.Size(82, 20);
            this.mathBox.TabIndex = 9;
            // 
            // scienceBox
            // 
            this.scienceBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scienceBox.Location = new System.Drawing.Point(75, 136);
            this.scienceBox.Name = "scienceBox";
            this.scienceBox.Size = new System.Drawing.Size(82, 20);
            this.scienceBox.TabIndex = 10;
            this.scienceBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // filipinoBox
            // 
            this.filipinoBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filipinoBox.Location = new System.Drawing.Point(75, 170);
            this.filipinoBox.Name = "filipinoBox";
            this.filipinoBox.Size = new System.Drawing.Size(82, 20);
            this.filipinoBox.TabIndex = 11;
            this.filipinoBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // historyBox
            // 
            this.historyBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.historyBox.Location = new System.Drawing.Point(75, 205);
            this.historyBox.Name = "historyBox";
            this.historyBox.Size = new System.Drawing.Size(82, 20);
            this.historyBox.TabIndex = 12;
            // 
            // generatebtn
            // 
            this.generatebtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.generatebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.generatebtn.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatebtn.Location = new System.Drawing.Point(26, 242);
            this.generatebtn.Name = "generatebtn";
            this.generatebtn.Size = new System.Drawing.Size(114, 57);
            this.generatebtn.TabIndex = 13;
            this.generatebtn.Text = "Generate Average";
            this.generatebtn.UseVisualStyleBackColor = false;
            this.generatebtn.Click += new System.EventHandler(this.generatebtn_Click);
            // 
            // output
            // 
            this.output.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.output.BackColor = System.Drawing.Color.Transparent;
            this.output.Font = new System.Drawing.Font("Palatino Linotype", 9.2F, System.Drawing.FontStyle.Bold);
            this.output.Location = new System.Drawing.Point(212, 116);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(224, 74);
            this.output.TabIndex = 14;
            this.output.Text = "Output";
            this.output.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::StudentGradeApplication.Properties.Resources.Back_To_School_Artistic_Background__Watercolor__Education__School_Background_Image_And_Wallpaper_for_Free_Download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(485, 311);
            this.Controls.Add(this.output);
            this.Controls.Add(this.generatebtn);
            this.Controls.Add(this.historyBox);
            this.Controls.Add(this.filipinoBox);
            this.Controls.Add(this.scienceBox);
            this.Controls.Add(this.mathBox);
            this.Controls.Add(this.englishBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.history);
            this.Controls.Add(this.filipino);
            this.Controls.Add(this.science);
            this.Controls.Add(this.math);
            this.Controls.Add(this.english);
            this.Controls.Add(this.grades);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Student Grade Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label grades;
        private System.Windows.Forms.Label english;
        private System.Windows.Forms.Label math;
        private System.Windows.Forms.Label science;
        private System.Windows.Forms.Label filipino;
        private System.Windows.Forms.Label history;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox englishBox;
        private System.Windows.Forms.TextBox mathBox;
        private System.Windows.Forms.TextBox scienceBox;
        private System.Windows.Forms.TextBox filipinoBox;
        private System.Windows.Forms.TextBox historyBox;
        private System.Windows.Forms.Button generatebtn;
        private System.Windows.Forms.Label output;
    }
}

