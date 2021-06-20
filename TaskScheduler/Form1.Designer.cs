namespace TaskScheduler
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MonthGbx = new System.Windows.Forms.GroupBox();
            this.chKasim = new System.Windows.Forms.CheckBox();
            this.chEkim = new System.Windows.Forms.CheckBox();
            this.chEylul = new System.Windows.Forms.CheckBox();
            this.chAgustos = new System.Windows.Forms.CheckBox();
            this.chTemmuz = new System.Windows.Forms.CheckBox();
            this.chAralik = new System.Windows.Forms.CheckBox();
            this.chHaziran = new System.Windows.Forms.CheckBox();
            this.chMayis = new System.Windows.Forms.CheckBox();
            this.chNisan = new System.Windows.Forms.CheckBox();
            this.chMart = new System.Windows.Forms.CheckBox();
            this.chSubat = new System.Windows.Forms.CheckBox();
            this.chOcak = new System.Windows.Forms.CheckBox();
            this.DaysGbx = new System.Windows.Forms.GroupBox();
            this.chPazar = new System.Windows.Forms.CheckBox();
            this.chCumartesi = new System.Windows.Forms.CheckBox();
            this.chCuma = new System.Windows.Forms.CheckBox();
            this.chPersembe = new System.Windows.Forms.CheckBox();
            this.chCarsamba = new System.Windows.Forms.CheckBox();
            this.chSali = new System.Windows.Forms.CheckBox();
            this.chpazartesi = new System.Windows.Forms.CheckBox();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.Ok_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.second = new System.Windows.Forms.NumericUpDown();
            this.Minute = new System.Windows.Forms.NumericUpDown();
            this.Hour = new System.Windows.Forms.NumericUpDown();
            this.monthly_cbx = new System.Windows.Forms.CheckBox();
            this.weekly_cbx = new System.Windows.Forms.CheckBox();
            this.Daily_Cbx = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.description_bx = new System.Windows.Forms.TextBox();
            this.taskName_bx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.MonthGbx.SuspendLayout();
            this.DaysGbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.second)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Location = new System.Drawing.Point(5, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(736, 546);
            this.TabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.MonthGbx);
            this.tabPage1.Controls.Add(this.DaysGbx);
            this.tabPage1.Controls.Add(this.Cancel_btn);
            this.tabPage1.Controls.Add(this.Ok_btn);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.second);
            this.tabPage1.Controls.Add(this.Minute);
            this.tabPage1.Controls.Add(this.Hour);
            this.tabPage1.Controls.Add(this.monthly_cbx);
            this.tabPage1.Controls.Add(this.weekly_cbx);
            this.tabPage1.Controls.Add(this.Daily_Cbx);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.description_bx);
            this.tabPage1.Controls.Add(this.taskName_bx);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(728, 520);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create Task";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MonthGbx
            // 
            this.MonthGbx.Controls.Add(this.chKasim);
            this.MonthGbx.Controls.Add(this.chEkim);
            this.MonthGbx.Controls.Add(this.chEylul);
            this.MonthGbx.Controls.Add(this.chAgustos);
            this.MonthGbx.Controls.Add(this.chTemmuz);
            this.MonthGbx.Controls.Add(this.chAralik);
            this.MonthGbx.Controls.Add(this.chHaziran);
            this.MonthGbx.Controls.Add(this.chMayis);
            this.MonthGbx.Controls.Add(this.chNisan);
            this.MonthGbx.Controls.Add(this.chMart);
            this.MonthGbx.Controls.Add(this.chSubat);
            this.MonthGbx.Controls.Add(this.chOcak);
            this.MonthGbx.Location = new System.Drawing.Point(369, 228);
            this.MonthGbx.Name = "MonthGbx";
            this.MonthGbx.Size = new System.Drawing.Size(213, 181);
            this.MonthGbx.TabIndex = 25;
            this.MonthGbx.TabStop = false;
            this.MonthGbx.Text = "Months";
            // 
            // chKasim
            // 
            this.chKasim.AutoSize = true;
            this.chKasim.Location = new System.Drawing.Point(110, 125);
            this.chKasim.Name = "chKasim";
            this.chKasim.Size = new System.Drawing.Size(75, 17);
            this.chKasim.TabIndex = 12;
            this.chKasim.Text = "November";
            this.chKasim.UseVisualStyleBackColor = true;
            // 
            // chEkim
            // 
            this.chEkim.AutoSize = true;
            this.chEkim.Location = new System.Drawing.Point(110, 101);
            this.chEkim.Name = "chEkim";
            this.chEkim.Size = new System.Drawing.Size(64, 17);
            this.chEkim.TabIndex = 11;
            this.chEkim.Text = "October";
            this.chEkim.UseVisualStyleBackColor = true;
            // 
            // chEylul
            // 
            this.chEylul.AutoSize = true;
            this.chEylul.Location = new System.Drawing.Point(110, 77);
            this.chEylul.Name = "chEylul";
            this.chEylul.Size = new System.Drawing.Size(77, 17);
            this.chEylul.TabIndex = 10;
            this.chEylul.Text = "September";
            this.chEylul.UseVisualStyleBackColor = true;
            // 
            // chAgustos
            // 
            this.chAgustos.AutoSize = true;
            this.chAgustos.Location = new System.Drawing.Point(110, 53);
            this.chAgustos.Name = "chAgustos";
            this.chAgustos.Size = new System.Drawing.Size(59, 17);
            this.chAgustos.TabIndex = 9;
            this.chAgustos.Text = "August";
            this.chAgustos.UseVisualStyleBackColor = true;
            // 
            // chTemmuz
            // 
            this.chTemmuz.AutoSize = true;
            this.chTemmuz.Location = new System.Drawing.Point(110, 27);
            this.chTemmuz.Name = "chTemmuz";
            this.chTemmuz.Size = new System.Drawing.Size(44, 17);
            this.chTemmuz.TabIndex = 8;
            this.chTemmuz.Text = "July";
            this.chTemmuz.UseVisualStyleBackColor = true;
            // 
            // chAralik
            // 
            this.chAralik.AutoSize = true;
            this.chAralik.Location = new System.Drawing.Point(110, 150);
            this.chAralik.Name = "chAralik";
            this.chAralik.Size = new System.Drawing.Size(75, 17);
            this.chAralik.TabIndex = 7;
            this.chAralik.Text = "December";
            this.chAralik.UseVisualStyleBackColor = true;
            // 
            // chHaziran
            // 
            this.chHaziran.AutoSize = true;
            this.chHaziran.Location = new System.Drawing.Point(19, 147);
            this.chHaziran.Name = "chHaziran";
            this.chHaziran.Size = new System.Drawing.Size(49, 17);
            this.chHaziran.TabIndex = 6;
            this.chHaziran.Text = "June";
            this.chHaziran.UseVisualStyleBackColor = true;
            // 
            // chMayis
            // 
            this.chMayis.AutoSize = true;
            this.chMayis.Location = new System.Drawing.Point(19, 124);
            this.chMayis.Name = "chMayis";
            this.chMayis.Size = new System.Drawing.Size(46, 17);
            this.chMayis.TabIndex = 5;
            this.chMayis.Text = "May";
            this.chMayis.UseVisualStyleBackColor = true;
            // 
            // chNisan
            // 
            this.chNisan.AutoSize = true;
            this.chNisan.Location = new System.Drawing.Point(19, 101);
            this.chNisan.Name = "chNisan";
            this.chNisan.Size = new System.Drawing.Size(46, 17);
            this.chNisan.TabIndex = 4;
            this.chNisan.Text = "April";
            this.chNisan.UseVisualStyleBackColor = true;
            // 
            // chMart
            // 
            this.chMart.AutoSize = true;
            this.chMart.Location = new System.Drawing.Point(19, 77);
            this.chMart.Name = "chMart";
            this.chMart.Size = new System.Drawing.Size(56, 17);
            this.chMart.TabIndex = 3;
            this.chMart.Text = "March";
            this.chMart.UseVisualStyleBackColor = true;
            // 
            // chSubat
            // 
            this.chSubat.AutoSize = true;
            this.chSubat.Location = new System.Drawing.Point(19, 53);
            this.chSubat.Name = "chSubat";
            this.chSubat.Size = new System.Drawing.Size(67, 17);
            this.chSubat.TabIndex = 2;
            this.chSubat.Text = "February";
            this.chSubat.UseVisualStyleBackColor = true;
            // 
            // chOcak
            // 
            this.chOcak.AutoSize = true;
            this.chOcak.Location = new System.Drawing.Point(19, 27);
            this.chOcak.Name = "chOcak";
            this.chOcak.Size = new System.Drawing.Size(63, 17);
            this.chOcak.TabIndex = 1;
            this.chOcak.Text = "January";
            this.chOcak.UseVisualStyleBackColor = true;
            // 
            // DaysGbx
            // 
            this.DaysGbx.Controls.Add(this.chPazar);
            this.DaysGbx.Controls.Add(this.chCumartesi);
            this.DaysGbx.Controls.Add(this.chCuma);
            this.DaysGbx.Controls.Add(this.chPersembe);
            this.DaysGbx.Controls.Add(this.chCarsamba);
            this.DaysGbx.Controls.Add(this.chSali);
            this.DaysGbx.Controls.Add(this.chpazartesi);
            this.DaysGbx.Location = new System.Drawing.Point(143, 228);
            this.DaysGbx.Name = "DaysGbx";
            this.DaysGbx.Size = new System.Drawing.Size(209, 181);
            this.DaysGbx.TabIndex = 24;
            this.DaysGbx.TabStop = false;
            this.DaysGbx.Text = "Days";
            // 
            // chPazar
            // 
            this.chPazar.AutoSize = true;
            this.chPazar.Location = new System.Drawing.Point(117, 101);
            this.chPazar.Name = "chPazar";
            this.chPazar.Size = new System.Drawing.Size(62, 17);
            this.chPazar.TabIndex = 6;
            this.chPazar.Text = "Sunday";
            this.chPazar.UseVisualStyleBackColor = true;
            // 
            // chCumartesi
            // 
            this.chCumartesi.AutoSize = true;
            this.chCumartesi.Location = new System.Drawing.Point(117, 73);
            this.chCumartesi.Name = "chCumartesi";
            this.chCumartesi.Size = new System.Drawing.Size(68, 17);
            this.chCumartesi.TabIndex = 5;
            this.chCumartesi.Text = "Saturday";
            this.chCumartesi.UseVisualStyleBackColor = true;
            // 
            // chCuma
            // 
            this.chCuma.AutoSize = true;
            this.chCuma.Location = new System.Drawing.Point(18, 141);
            this.chCuma.Name = "chCuma";
            this.chCuma.Size = new System.Drawing.Size(54, 17);
            this.chCuma.TabIndex = 4;
            this.chCuma.Text = "Friday";
            this.chCuma.UseVisualStyleBackColor = true;
            // 
            // chPersembe
            // 
            this.chPersembe.AutoSize = true;
            this.chPersembe.Location = new System.Drawing.Point(18, 110);
            this.chPersembe.Name = "chPersembe";
            this.chPersembe.Size = new System.Drawing.Size(70, 17);
            this.chPersembe.TabIndex = 3;
            this.chPersembe.Text = "Thursday";
            this.chPersembe.UseVisualStyleBackColor = true;
            // 
            // chCarsamba
            // 
            this.chCarsamba.AutoSize = true;
            this.chCarsamba.Location = new System.Drawing.Point(18, 81);
            this.chCarsamba.Name = "chCarsamba";
            this.chCarsamba.Size = new System.Drawing.Size(83, 17);
            this.chCarsamba.TabIndex = 2;
            this.chCarsamba.Text = "Wednesday";
            this.chCarsamba.UseVisualStyleBackColor = true;
            // 
            // chSali
            // 
            this.chSali.AutoSize = true;
            this.chSali.Location = new System.Drawing.Point(18, 51);
            this.chSali.Name = "chSali";
            this.chSali.Size = new System.Drawing.Size(67, 17);
            this.chSali.TabIndex = 1;
            this.chSali.Text = "Tuesday";
            this.chSali.UseVisualStyleBackColor = true;
            // 
            // chpazartesi
            // 
            this.chpazartesi.AutoSize = true;
            this.chpazartesi.Location = new System.Drawing.Point(18, 21);
            this.chpazartesi.Name = "chpazartesi";
            this.chpazartesi.Size = new System.Drawing.Size(64, 17);
            this.chpazartesi.TabIndex = 0;
            this.chpazartesi.Text = "Monday";
            this.chpazartesi.UseVisualStyleBackColor = true;
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cancel_btn.Location = new System.Drawing.Point(384, 447);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(81, 34);
            this.Cancel_btn.TabIndex = 23;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            // 
            // Ok_btn
            // 
            this.Ok_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ok_btn.Location = new System.Drawing.Point(260, 447);
            this.Ok_btn.Name = "Ok_btn";
            this.Ok_btn.Size = new System.Drawing.Size(81, 34);
            this.Ok_btn.TabIndex = 22;
            this.Ok_btn.Text = "Ok";
            this.Ok_btn.UseVisualStyleBackColor = true;
            this.Ok_btn.Click += new System.EventHandler(this.Ok_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Second";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Minute";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hour";
            // 
            // second
            // 
            this.second.Location = new System.Drawing.Point(424, 201);
            this.second.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(92, 20);
            this.second.TabIndex = 10;
            this.second.ValueChanged += new System.EventHandler(this.second_ValueChanged);
            // 
            // Minute
            // 
            this.Minute.Location = new System.Drawing.Point(315, 202);
            this.Minute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.Minute.Name = "Minute";
            this.Minute.Size = new System.Drawing.Size(92, 20);
            this.Minute.TabIndex = 9;
            this.Minute.ValueChanged += new System.EventHandler(this.Minute_ValueChanged);
            // 
            // Hour
            // 
            this.Hour.Location = new System.Drawing.Point(201, 202);
            this.Hour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(92, 20);
            this.Hour.TabIndex = 8;
            this.Hour.ValueChanged += new System.EventHandler(this.Hour_ValueChanged);
            // 
            // monthly_cbx
            // 
            this.monthly_cbx.AutoSize = true;
            this.monthly_cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.monthly_cbx.Location = new System.Drawing.Point(424, 151);
            this.monthly_cbx.Name = "monthly_cbx";
            this.monthly_cbx.Size = new System.Drawing.Size(79, 22);
            this.monthly_cbx.TabIndex = 7;
            this.monthly_cbx.Text = "Monthly";
            this.monthly_cbx.UseVisualStyleBackColor = true;
            this.monthly_cbx.CheckedChanged += new System.EventHandler(this.monthly_cbx_CheckedChanged);
            // 
            // weekly_cbx
            // 
            this.weekly_cbx.AutoSize = true;
            this.weekly_cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.weekly_cbx.Location = new System.Drawing.Point(307, 151);
            this.weekly_cbx.Name = "weekly_cbx";
            this.weekly_cbx.Size = new System.Drawing.Size(76, 22);
            this.weekly_cbx.TabIndex = 6;
            this.weekly_cbx.Text = "Weekly";
            this.weekly_cbx.UseVisualStyleBackColor = true;
            this.weekly_cbx.CheckedChanged += new System.EventHandler(this.weekly_cbx_CheckedChanged);
            // 
            // Daily_Cbx
            // 
            this.Daily_Cbx.AutoSize = true;
            this.Daily_Cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Daily_Cbx.Location = new System.Drawing.Point(205, 151);
            this.Daily_Cbx.Name = "Daily_Cbx";
            this.Daily_Cbx.Size = new System.Drawing.Size(59, 22);
            this.Daily_Cbx.TabIndex = 5;
            this.Daily_Cbx.Text = "Daily";
            this.Daily_Cbx.UseVisualStyleBackColor = true;
            this.Daily_Cbx.CheckedChanged += new System.EventHandler(this.Daily_Cbx_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(33, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Repetition Interval:";
            // 
            // description_bx
            // 
            this.description_bx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.description_bx.ForeColor = System.Drawing.SystemColors.ControlText;
            this.description_bx.Location = new System.Drawing.Point(181, 58);
            this.description_bx.Multiline = true;
            this.description_bx.Name = "description_bx";
            this.description_bx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.description_bx.Size = new System.Drawing.Size(262, 74);
            this.description_bx.TabIndex = 3;
            this.description_bx.TextChanged += new System.EventHandler(this.description_bx_TextChanged);
            // 
            // taskName_bx
            // 
            this.taskName_bx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.taskName_bx.ForeColor = System.Drawing.SystemColors.ControlText;
            this.taskName_bx.Location = new System.Drawing.Point(181, 26);
            this.taskName_bx.Name = "taskName_bx";
            this.taskName_bx.Size = new System.Drawing.Size(137, 26);
            this.taskName_bx.TabIndex = 2;
            this.taskName_bx.TextChanged += new System.EventHandler(this.taskName_bx_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(44, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Task Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(82, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(728, 520);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Created Tasks";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(318, 250);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(92, 20);
            this.numericUpDown1.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 547);
            this.Controls.Add(this.TabControl);
            this.Name = "Form1";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.MonthGbx.ResumeLayout(false);
            this.MonthGbx.PerformLayout();
            this.DaysGbx.ResumeLayout(false);
            this.DaysGbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.second)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox description_bx;
        private System.Windows.Forms.TextBox taskName_bx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox monthly_cbx;
        private System.Windows.Forms.CheckBox weekly_cbx;
        private System.Windows.Forms.CheckBox Daily_Cbx;
        private System.Windows.Forms.NumericUpDown Hour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown second;
        private System.Windows.Forms.NumericUpDown Minute;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Ok_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.GroupBox MonthGbx;
        private System.Windows.Forms.GroupBox DaysGbx;
        private System.Windows.Forms.CheckBox chCuma;
        private System.Windows.Forms.CheckBox chPersembe;
        private System.Windows.Forms.CheckBox chCarsamba;
        private System.Windows.Forms.CheckBox chSali;
        private System.Windows.Forms.CheckBox chpazartesi;
        private System.Windows.Forms.CheckBox chPazar;
        private System.Windows.Forms.CheckBox chCumartesi;
        private System.Windows.Forms.CheckBox chAralik;
        private System.Windows.Forms.CheckBox chHaziran;
        private System.Windows.Forms.CheckBox chMayis;
        private System.Windows.Forms.CheckBox chNisan;
        private System.Windows.Forms.CheckBox chMart;
        private System.Windows.Forms.CheckBox chSubat;
        private System.Windows.Forms.CheckBox chOcak;
        private System.Windows.Forms.CheckBox chKasim;
        private System.Windows.Forms.CheckBox chEkim;
        private System.Windows.Forms.CheckBox chEylul;
        private System.Windows.Forms.CheckBox chAgustos;
        private System.Windows.Forms.CheckBox chTemmuz;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

