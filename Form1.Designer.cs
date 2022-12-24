
namespace CS3280_Assignment2
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
            this.game_info_text = new System.Windows.Forms.GroupBox();
            this.num_lost_label = new System.Windows.Forms.Label();
            this.num_won_label = new System.Windows.Forms.Label();
            this.num_played_label = new System.Windows.Forms.Label();
            this.lost_label = new System.Windows.Forms.Label();
            this.played_label = new System.Windows.Forms.Label();
            this.won_label = new System.Windows.Forms.Label();
            this.prompt_label = new System.Windows.Forms.Label();
            this.guess_text = new System.Windows.Forms.TextBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.roll_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.invalid_label = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.freq6_text = new System.Windows.Forms.Label();
            this.freq5_text = new System.Windows.Forms.Label();
            this.freq4_text = new System.Windows.Forms.Label();
            this.freq3_text = new System.Windows.Forms.Label();
            this.freq2_text = new System.Windows.Forms.Label();
            this.freq1_text = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.percent_text6 = new System.Windows.Forms.Label();
            this.percent_text5 = new System.Windows.Forms.Label();
            this.percent_text4 = new System.Windows.Forms.Label();
            this.percent_text3 = new System.Windows.Forms.Label();
            this.percent_text2 = new System.Windows.Forms.Label();
            this.percent_text1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.guess_text6 = new System.Windows.Forms.Label();
            this.guess_text5 = new System.Windows.Forms.Label();
            this.guess_text4 = new System.Windows.Forms.Label();
            this.guess_text3 = new System.Windows.Forms.Label();
            this.guess_text2 = new System.Windows.Forms.Label();
            this.guess_text1 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.game_info_text.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // game_info_text
            // 
            this.game_info_text.Controls.Add(this.num_lost_label);
            this.game_info_text.Controls.Add(this.num_won_label);
            this.game_info_text.Controls.Add(this.num_played_label);
            this.game_info_text.Controls.Add(this.lost_label);
            this.game_info_text.Controls.Add(this.played_label);
            this.game_info_text.Controls.Add(this.won_label);
            this.game_info_text.Location = new System.Drawing.Point(41, 30);
            this.game_info_text.Name = "game_info_text";
            this.game_info_text.Size = new System.Drawing.Size(235, 128);
            this.game_info_text.TabIndex = 0;
            this.game_info_text.TabStop = false;
            this.game_info_text.Text = "Game Info";
            // 
            // num_lost_label
            // 
            this.num_lost_label.AutoSize = true;
            this.num_lost_label.Location = new System.Drawing.Point(160, 93);
            this.num_lost_label.Name = "num_lost_label";
            this.num_lost_label.Size = new System.Drawing.Size(13, 13);
            this.num_lost_label.TabIndex = 6;
            this.num_lost_label.Text = "0";
            // 
            // num_won_label
            // 
            this.num_won_label.AutoSize = true;
            this.num_won_label.Location = new System.Drawing.Point(160, 62);
            this.num_won_label.Name = "num_won_label";
            this.num_won_label.Size = new System.Drawing.Size(13, 13);
            this.num_won_label.TabIndex = 5;
            this.num_won_label.Text = "0";
            // 
            // num_played_label
            // 
            this.num_played_label.AutoSize = true;
            this.num_played_label.Location = new System.Drawing.Point(160, 30);
            this.num_played_label.Name = "num_played_label";
            this.num_played_label.Size = new System.Drawing.Size(13, 13);
            this.num_played_label.TabIndex = 4;
            this.num_played_label.Text = "0";
            // 
            // lost_label
            // 
            this.lost_label.AutoSize = true;
            this.lost_label.Location = new System.Drawing.Point(25, 93);
            this.lost_label.Name = "lost_label";
            this.lost_label.Size = new System.Drawing.Size(113, 13);
            this.lost_label.TabIndex = 3;
            this.lost_label.Text = "Number of Times Lost:";
            // 
            // played_label
            // 
            this.played_label.AutoSize = true;
            this.played_label.Location = new System.Drawing.Point(25, 30);
            this.played_label.Name = "played_label";
            this.played_label.Size = new System.Drawing.Size(128, 13);
            this.played_label.TabIndex = 1;
            this.played_label.Text = "Number of Times Played: ";
            // 
            // won_label
            // 
            this.won_label.AutoSize = true;
            this.won_label.Location = new System.Drawing.Point(25, 62);
            this.won_label.Name = "won_label";
            this.won_label.Size = new System.Drawing.Size(119, 13);
            this.won_label.TabIndex = 2;
            this.won_label.Text = "Number of Times Won: ";
            // 
            // prompt_label
            // 
            this.prompt_label.AutoSize = true;
            this.prompt_label.Location = new System.Drawing.Point(38, 187);
            this.prompt_label.Name = "prompt_label";
            this.prompt_label.Size = new System.Drawing.Size(113, 13);
            this.prompt_label.TabIndex = 1;
            this.prompt_label.Text = "Enter your guess (1-6):";
            // 
            // guess_text
            // 
            this.guess_text.Location = new System.Drawing.Point(159, 180);
            this.guess_text.MaxLength = 1;
            this.guess_text.Name = "guess_text";
            this.guess_text.Size = new System.Drawing.Size(41, 20);
            this.guess_text.TabIndex = 2;
            this.guess_text.TextChanged += new System.EventHandler(this.guess_text_TextChanged);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(69, 245);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(75, 73);
            this.pbImage.TabIndex = 3;
            this.pbImage.TabStop = false;
            // 
            // roll_btn
            // 
            this.roll_btn.Enabled = false;
            this.roll_btn.Location = new System.Drawing.Point(159, 245);
            this.roll_btn.Name = "roll_btn";
            this.roll_btn.Size = new System.Drawing.Size(75, 23);
            this.roll_btn.TabIndex = 4;
            this.roll_btn.Text = "Roll";
            this.roll_btn.UseVisualStyleBackColor = true;
            this.roll_btn.Click += new System.EventHandler(this.roll_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(159, 294);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(75, 23);
            this.reset_btn.TabIndex = 5;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // invalid_label
            // 
            this.invalid_label.AutoSize = true;
            this.invalid_label.Location = new System.Drawing.Point(321, 180);
            this.invalid_label.Name = "invalid_label";
            this.invalid_label.Size = new System.Drawing.Size(0, 13);
            this.invalid_label.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(41, 383);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(473, 234);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "FACE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 585);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 552);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 519);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 490);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 463);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 436);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "1";
            // 
            // freq6_text
            // 
            this.freq6_text.AutoSize = true;
            this.freq6_text.Location = new System.Drawing.Point(151, 585);
            this.freq6_text.Name = "freq6_text";
            this.freq6_text.Size = new System.Drawing.Size(13, 13);
            this.freq6_text.TabIndex = 15;
            this.freq6_text.Text = "0";
            // 
            // freq5_text
            // 
            this.freq5_text.AutoSize = true;
            this.freq5_text.Location = new System.Drawing.Point(156, 552);
            this.freq5_text.Name = "freq5_text";
            this.freq5_text.Size = new System.Drawing.Size(13, 13);
            this.freq5_text.TabIndex = 16;
            this.freq5_text.Text = "0";
            // 
            // freq4_text
            // 
            this.freq4_text.AutoSize = true;
            this.freq4_text.Location = new System.Drawing.Point(151, 519);
            this.freq4_text.Name = "freq4_text";
            this.freq4_text.Size = new System.Drawing.Size(13, 13);
            this.freq4_text.TabIndex = 17;
            this.freq4_text.Text = "0";
            // 
            // freq3_text
            // 
            this.freq3_text.AutoSize = true;
            this.freq3_text.Location = new System.Drawing.Point(151, 490);
            this.freq3_text.Name = "freq3_text";
            this.freq3_text.Size = new System.Drawing.Size(13, 13);
            this.freq3_text.TabIndex = 18;
            this.freq3_text.Text = "0";
            // 
            // freq2_text
            // 
            this.freq2_text.AutoSize = true;
            this.freq2_text.Location = new System.Drawing.Point(151, 463);
            this.freq2_text.Name = "freq2_text";
            this.freq2_text.Size = new System.Drawing.Size(13, 13);
            this.freq2_text.TabIndex = 19;
            this.freq2_text.Text = "0";
            // 
            // freq1_text
            // 
            this.freq1_text.AutoSize = true;
            this.freq1_text.Location = new System.Drawing.Point(151, 436);
            this.freq1_text.Name = "freq1_text";
            this.freq1_text.Size = new System.Drawing.Size(13, 13);
            this.freq1_text.TabIndex = 20;
            this.freq1_text.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(151, 407);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "FREQUENCY";
            // 
            // percent_text6
            // 
            this.percent_text6.AutoSize = true;
            this.percent_text6.Location = new System.Drawing.Point(242, 585);
            this.percent_text6.Name = "percent_text6";
            this.percent_text6.Size = new System.Drawing.Size(13, 13);
            this.percent_text6.TabIndex = 22;
            this.percent_text6.Text = "0";
            // 
            // percent_text5
            // 
            this.percent_text5.AutoSize = true;
            this.percent_text5.Location = new System.Drawing.Point(242, 552);
            this.percent_text5.Name = "percent_text5";
            this.percent_text5.Size = new System.Drawing.Size(13, 13);
            this.percent_text5.TabIndex = 23;
            this.percent_text5.Text = "0";
            // 
            // percent_text4
            // 
            this.percent_text4.AutoSize = true;
            this.percent_text4.Location = new System.Drawing.Point(242, 519);
            this.percent_text4.Name = "percent_text4";
            this.percent_text4.Size = new System.Drawing.Size(13, 13);
            this.percent_text4.TabIndex = 24;
            this.percent_text4.Text = "0";
            // 
            // percent_text3
            // 
            this.percent_text3.AutoSize = true;
            this.percent_text3.Location = new System.Drawing.Point(242, 490);
            this.percent_text3.Name = "percent_text3";
            this.percent_text3.Size = new System.Drawing.Size(13, 13);
            this.percent_text3.TabIndex = 25;
            this.percent_text3.Text = "0";
            // 
            // percent_text2
            // 
            this.percent_text2.AutoSize = true;
            this.percent_text2.Location = new System.Drawing.Point(242, 463);
            this.percent_text2.Name = "percent_text2";
            this.percent_text2.Size = new System.Drawing.Size(13, 13);
            this.percent_text2.TabIndex = 26;
            this.percent_text2.Text = "0";
            // 
            // percent_text1
            // 
            this.percent_text1.AutoSize = true;
            this.percent_text1.Location = new System.Drawing.Point(242, 436);
            this.percent_text1.Name = "percent_text1";
            this.percent_text1.Size = new System.Drawing.Size(13, 13);
            this.percent_text1.TabIndex = 27;
            this.percent_text1.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(242, 407);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 13);
            this.label21.TabIndex = 28;
            this.label21.Text = "PERCENT";
            // 
            // guess_text6
            // 
            this.guess_text6.AutoSize = true;
            this.guess_text6.Location = new System.Drawing.Point(327, 585);
            this.guess_text6.Name = "guess_text6";
            this.guess_text6.Size = new System.Drawing.Size(13, 13);
            this.guess_text6.TabIndex = 29;
            this.guess_text6.Text = "0";
            // 
            // guess_text5
            // 
            this.guess_text5.AutoSize = true;
            this.guess_text5.Location = new System.Drawing.Point(327, 552);
            this.guess_text5.Name = "guess_text5";
            this.guess_text5.Size = new System.Drawing.Size(13, 13);
            this.guess_text5.TabIndex = 30;
            this.guess_text5.Text = "0";
            // 
            // guess_text4
            // 
            this.guess_text4.AutoSize = true;
            this.guess_text4.Location = new System.Drawing.Point(327, 519);
            this.guess_text4.Name = "guess_text4";
            this.guess_text4.Size = new System.Drawing.Size(13, 13);
            this.guess_text4.TabIndex = 31;
            this.guess_text4.Text = "0";
            // 
            // guess_text3
            // 
            this.guess_text3.AutoSize = true;
            this.guess_text3.Location = new System.Drawing.Point(327, 490);
            this.guess_text3.Name = "guess_text3";
            this.guess_text3.Size = new System.Drawing.Size(13, 13);
            this.guess_text3.TabIndex = 32;
            this.guess_text3.Text = "0";
            // 
            // guess_text2
            // 
            this.guess_text2.AutoSize = true;
            this.guess_text2.Location = new System.Drawing.Point(327, 463);
            this.guess_text2.Name = "guess_text2";
            this.guess_text2.Size = new System.Drawing.Size(13, 13);
            this.guess_text2.TabIndex = 33;
            this.guess_text2.Text = "0";
            // 
            // guess_text1
            // 
            this.guess_text1.AutoSize = true;
            this.guess_text1.Location = new System.Drawing.Point(327, 436);
            this.guess_text1.Name = "guess_text1";
            this.guess_text1.Size = new System.Drawing.Size(13, 13);
            this.guess_text1.TabIndex = 34;
            this.guess_text1.Text = "0";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(327, 407);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(162, 13);
            this.label28.TabIndex = 35;
            this.label28.Text = "NUMBER OF TIMES GUESSED";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 658);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.guess_text1);
            this.Controls.Add(this.guess_text2);
            this.Controls.Add(this.guess_text3);
            this.Controls.Add(this.guess_text4);
            this.Controls.Add(this.guess_text5);
            this.Controls.Add(this.guess_text6);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.percent_text1);
            this.Controls.Add(this.percent_text2);
            this.Controls.Add(this.percent_text3);
            this.Controls.Add(this.percent_text4);
            this.Controls.Add(this.percent_text5);
            this.Controls.Add(this.percent_text6);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.freq1_text);
            this.Controls.Add(this.freq2_text);
            this.Controls.Add(this.freq3_text);
            this.Controls.Add(this.freq4_text);
            this.Controls.Add(this.freq5_text);
            this.Controls.Add(this.freq6_text);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.invalid_label);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.roll_btn);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.guess_text);
            this.Controls.Add(this.prompt_label);
            this.Controls.Add(this.game_info_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.game_info_text.ResumeLayout(false);
            this.game_info_text.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox game_info_text;
        private System.Windows.Forms.Label lost_label;
        private System.Windows.Forms.Label played_label;
        private System.Windows.Forms.Label won_label;
        private System.Windows.Forms.Label prompt_label;
        private System.Windows.Forms.TextBox guess_text;
        private System.Windows.Forms.Label num_lost_label;
        private System.Windows.Forms.Label num_won_label;
        private System.Windows.Forms.Label num_played_label;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button roll_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Label invalid_label;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label freq6_text;
        private System.Windows.Forms.Label freq5_text;
        private System.Windows.Forms.Label freq4_text;
        private System.Windows.Forms.Label freq3_text;
        private System.Windows.Forms.Label freq2_text;
        private System.Windows.Forms.Label freq1_text;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label percent_text6;
        private System.Windows.Forms.Label percent_text5;
        private System.Windows.Forms.Label percent_text4;
        private System.Windows.Forms.Label percent_text3;
        private System.Windows.Forms.Label percent_text2;
        private System.Windows.Forms.Label percent_text1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label guess_text6;
        private System.Windows.Forms.Label guess_text5;
        private System.Windows.Forms.Label guess_text4;
        private System.Windows.Forms.Label guess_text3;
        private System.Windows.Forms.Label guess_text2;
        private System.Windows.Forms.Label guess_text1;
        private System.Windows.Forms.Label label28;
    }
}

