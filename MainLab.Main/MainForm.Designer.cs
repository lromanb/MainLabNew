namespace MainLab.Main
{
    partial class MainForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.pMenuPanel = new System.Windows.Forms.Panel();
            this.btmEditTarif = new System.Windows.Forms.Button();
            this.btmCreateTarif = new System.Windows.Forms.Button();
            this.btmEditAbonent = new System.Windows.Forms.Button();
            this.btmCreateAbonent = new System.Windows.Forms.Button();
            this.btmChooseTarif = new System.Windows.Forms.Button();
            this.btmPayAccount = new System.Windows.Forms.Button();
            this.btmTrafficReport = new System.Windows.Forms.Button();
            this.btmAccBalanceReport = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpAccBalanceReport = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbBalanceReport = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btAccBalanceReport = new System.Windows.Forms.Button();
            this.tpTrafficReport = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbTrafficReport = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btTrafficReport = new System.Windows.Forms.Button();
            this.tpPayAccount = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btPayAccount = new System.Windows.Forms.Button();
            this.tpChooseTarif = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btChooseTarif = new System.Windows.Forms.Button();
            this.tpCreateAbonent = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btCreateAbonent = new System.Windows.Forms.Button();
            this.tpEditAbonent = new System.Windows.Forms.TabPage();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btEditAbonent = new System.Windows.Forms.Button();
            this.tpCreateTarif = new System.Windows.Forms.TabPage();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btCreateTarif = new System.Windows.Forms.Button();
            this.tpEditTarif = new System.Windows.Forms.TabPage();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.btEditTarif = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.pMenuPanel.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpAccBalanceReport.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpTrafficReport.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tpPayAccount.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tpChooseTarif.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tpCreateAbonent.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tpEditAbonent.SuspendLayout();
            this.panel11.SuspendLayout();
            this.tpCreateTarif.SuspendLayout();
            this.panel13.SuspendLayout();
            this.tpEditTarif.SuspendLayout();
            this.panel17.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslMain});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslMain
            // 
            this.tsslMain.Name = "tsslMain";
            this.tsslMain.Size = new System.Drawing.Size(0, 17);
            // 
            // pMenuPanel
            // 
            this.pMenuPanel.Controls.Add(this.btmEditTarif);
            this.pMenuPanel.Controls.Add(this.btmCreateTarif);
            this.pMenuPanel.Controls.Add(this.btmEditAbonent);
            this.pMenuPanel.Controls.Add(this.btmCreateAbonent);
            this.pMenuPanel.Controls.Add(this.btmChooseTarif);
            this.pMenuPanel.Controls.Add(this.btmPayAccount);
            this.pMenuPanel.Controls.Add(this.btmTrafficReport);
            this.pMenuPanel.Controls.Add(this.btmAccBalanceReport);
            this.pMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.pMenuPanel.Name = "pMenuPanel";
            this.pMenuPanel.Size = new System.Drawing.Size(231, 428);
            this.pMenuPanel.TabIndex = 1;
            // 
            // btmEditTarif
            // 
            this.btmEditTarif.Dock = System.Windows.Forms.DockStyle.Top;
            this.btmEditTarif.Location = new System.Drawing.Point(0, 161);
            this.btmEditTarif.Name = "btmEditTarif";
            this.btmEditTarif.Size = new System.Drawing.Size(231, 23);
            this.btmEditTarif.TabIndex = 8;
            this.btmEditTarif.Text = "Редактировать тариф";
            this.btmEditTarif.UseVisualStyleBackColor = true;
            this.btmEditTarif.Click += new System.EventHandler(this.CustomMenuButClick);
            // 
            // btmCreateTarif
            // 
            this.btmCreateTarif.Dock = System.Windows.Forms.DockStyle.Top;
            this.btmCreateTarif.Location = new System.Drawing.Point(0, 138);
            this.btmCreateTarif.Name = "btmCreateTarif";
            this.btmCreateTarif.Size = new System.Drawing.Size(231, 23);
            this.btmCreateTarif.TabIndex = 7;
            this.btmCreateTarif.Text = "Создать тариф";
            this.btmCreateTarif.UseVisualStyleBackColor = true;
            this.btmCreateTarif.Click += new System.EventHandler(this.CustomMenuButClick);
            // 
            // btmEditAbonent
            // 
            this.btmEditAbonent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btmEditAbonent.Location = new System.Drawing.Point(0, 115);
            this.btmEditAbonent.Name = "btmEditAbonent";
            this.btmEditAbonent.Size = new System.Drawing.Size(231, 23);
            this.btmEditAbonent.TabIndex = 5;
            this.btmEditAbonent.Text = "Редактирование абонента";
            this.btmEditAbonent.UseVisualStyleBackColor = true;
            this.btmEditAbonent.Click += new System.EventHandler(this.CustomMenuButClick);
            // 
            // btmCreateAbonent
            // 
            this.btmCreateAbonent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btmCreateAbonent.Location = new System.Drawing.Point(0, 92);
            this.btmCreateAbonent.Name = "btmCreateAbonent";
            this.btmCreateAbonent.Size = new System.Drawing.Size(231, 23);
            this.btmCreateAbonent.TabIndex = 4;
            this.btmCreateAbonent.Text = "Создание абонента";
            this.btmCreateAbonent.UseVisualStyleBackColor = true;
            this.btmCreateAbonent.Click += new System.EventHandler(this.CustomMenuButClick);
            // 
            // btmChooseTarif
            // 
            this.btmChooseTarif.Dock = System.Windows.Forms.DockStyle.Top;
            this.btmChooseTarif.Location = new System.Drawing.Point(0, 69);
            this.btmChooseTarif.Name = "btmChooseTarif";
            this.btmChooseTarif.Size = new System.Drawing.Size(231, 23);
            this.btmChooseTarif.TabIndex = 3;
            this.btmChooseTarif.Text = "Выбор тарифа";
            this.btmChooseTarif.UseVisualStyleBackColor = true;
            this.btmChooseTarif.Click += new System.EventHandler(this.CustomMenuButClick);
            // 
            // btmPayAccount
            // 
            this.btmPayAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btmPayAccount.Location = new System.Drawing.Point(0, 46);
            this.btmPayAccount.Name = "btmPayAccount";
            this.btmPayAccount.Size = new System.Drawing.Size(231, 23);
            this.btmPayAccount.TabIndex = 2;
            this.btmPayAccount.Text = "Пополнение счета";
            this.btmPayAccount.UseVisualStyleBackColor = true;
            this.btmPayAccount.Click += new System.EventHandler(this.CustomMenuButClick);
            // 
            // btmTrafficReport
            // 
            this.btmTrafficReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btmTrafficReport.Location = new System.Drawing.Point(0, 23);
            this.btmTrafficReport.Name = "btmTrafficReport";
            this.btmTrafficReport.Size = new System.Drawing.Size(231, 23);
            this.btmTrafficReport.TabIndex = 1;
            this.btmTrafficReport.Text = "Объем трафика";
            this.btmTrafficReport.UseVisualStyleBackColor = true;
            this.btmTrafficReport.Click += new System.EventHandler(this.CustomMenuButClick);
            // 
            // btmAccBalanceReport
            // 
            this.btmAccBalanceReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btmAccBalanceReport.Location = new System.Drawing.Point(0, 0);
            this.btmAccBalanceReport.Name = "btmAccBalanceReport";
            this.btmAccBalanceReport.Size = new System.Drawing.Size(231, 23);
            this.btmAccBalanceReport.TabIndex = 0;
            this.btmAccBalanceReport.Text = "Баланс счета";
            this.btmAccBalanceReport.UseVisualStyleBackColor = true;
            this.btmAccBalanceReport.Click += new System.EventHandler(this.CustomMenuButClick);
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Location = new System.Drawing.Point(231, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 428);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpAccBalanceReport);
            this.tcMain.Controls.Add(this.tpTrafficReport);
            this.tcMain.Controls.Add(this.tpPayAccount);
            this.tcMain.Controls.Add(this.tpChooseTarif);
            this.tcMain.Controls.Add(this.tpCreateAbonent);
            this.tcMain.Controls.Add(this.tpEditAbonent);
            this.tcMain.Controls.Add(this.tpCreateTarif);
            this.tcMain.Controls.Add(this.tpEditTarif);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(234, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(566, 428);
            this.tcMain.TabIndex = 3;
            // 
            // tpAccBalanceReport
            // 
            this.tpAccBalanceReport.Controls.Add(this.panel2);
            this.tpAccBalanceReport.Controls.Add(this.panel1);
            this.tpAccBalanceReport.Location = new System.Drawing.Point(4, 22);
            this.tpAccBalanceReport.Name = "tpAccBalanceReport";
            this.tpAccBalanceReport.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccBalanceReport.Size = new System.Drawing.Size(558, 402);
            this.tpAccBalanceReport.TabIndex = 0;
            this.tpAccBalanceReport.Text = "Баланс счета";
            this.tpAccBalanceReport.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbBalanceReport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 362);
            this.panel2.TabIndex = 2;
            // 
            // tbBalanceReport
            // 
            this.tbBalanceReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBalanceReport.Location = new System.Drawing.Point(0, 0);
            this.tbBalanceReport.Multiline = true;
            this.tbBalanceReport.Name = "tbBalanceReport";
            this.tbBalanceReport.Size = new System.Drawing.Size(552, 362);
            this.tbBalanceReport.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btAccBalanceReport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 365);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 34);
            this.panel1.TabIndex = 1;
            // 
            // btAccBalanceReport
            // 
            this.btAccBalanceReport.Location = new System.Drawing.Point(440, 6);
            this.btAccBalanceReport.Name = "btAccBalanceReport";
            this.btAccBalanceReport.Size = new System.Drawing.Size(107, 23);
            this.btAccBalanceReport.TabIndex = 0;
            this.btAccBalanceReport.Text = "Создать отчет";
            this.btAccBalanceReport.UseVisualStyleBackColor = true;
            this.btAccBalanceReport.Click += new System.EventHandler(this.btAccBalanceReport_Click);
            // 
            // tpTrafficReport
            // 
            this.tpTrafficReport.Controls.Add(this.panel4);
            this.tpTrafficReport.Controls.Add(this.panel3);
            this.tpTrafficReport.Location = new System.Drawing.Point(4, 22);
            this.tpTrafficReport.Name = "tpTrafficReport";
            this.tpTrafficReport.Padding = new System.Windows.Forms.Padding(3);
            this.tpTrafficReport.Size = new System.Drawing.Size(558, 402);
            this.tpTrafficReport.TabIndex = 7;
            this.tpTrafficReport.Text = "Трафик";
            this.tpTrafficReport.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbTrafficReport);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(552, 362);
            this.panel4.TabIndex = 1;
            // 
            // tbTrafficReport
            // 
            this.tbTrafficReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTrafficReport.Location = new System.Drawing.Point(0, 0);
            this.tbTrafficReport.Multiline = true;
            this.tbTrafficReport.Name = "tbTrafficReport";
            this.tbTrafficReport.Size = new System.Drawing.Size(552, 362);
            this.tbTrafficReport.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btTrafficReport);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 365);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(552, 34);
            this.panel3.TabIndex = 0;
            // 
            // btTrafficReport
            // 
            this.btTrafficReport.Location = new System.Drawing.Point(440, 6);
            this.btTrafficReport.Name = "btTrafficReport";
            this.btTrafficReport.Size = new System.Drawing.Size(109, 23);
            this.btTrafficReport.TabIndex = 0;
            this.btTrafficReport.Text = "Создать отчет";
            this.btTrafficReport.UseVisualStyleBackColor = true;
            this.btTrafficReport.Click += new System.EventHandler(this.btTrafficReport_Click);
            // 
            // tpPayAccount
            // 
            this.tpPayAccount.Controls.Add(this.panel6);
            this.tpPayAccount.Controls.Add(this.panel5);
            this.tpPayAccount.Location = new System.Drawing.Point(4, 22);
            this.tpPayAccount.Name = "tpPayAccount";
            this.tpPayAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpPayAccount.Size = new System.Drawing.Size(558, 402);
            this.tpPayAccount.TabIndex = 1;
            this.tpPayAccount.Text = "Пополнение счета";
            this.tpPayAccount.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(552, 362);
            this.panel6.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btPayAccount);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 365);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(552, 34);
            this.panel5.TabIndex = 0;
            // 
            // btPayAccount
            // 
            this.btPayAccount.Location = new System.Drawing.Point(446, 6);
            this.btPayAccount.Name = "btPayAccount";
            this.btPayAccount.Size = new System.Drawing.Size(101, 23);
            this.btPayAccount.TabIndex = 0;
            this.btPayAccount.Text = "Пополнить счет";
            this.btPayAccount.UseVisualStyleBackColor = true;
            this.btPayAccount.Click += new System.EventHandler(this.btPayAccount_Click);
            // 
            // tpChooseTarif
            // 
            this.tpChooseTarif.Controls.Add(this.panel8);
            this.tpChooseTarif.Controls.Add(this.panel7);
            this.tpChooseTarif.Location = new System.Drawing.Point(4, 22);
            this.tpChooseTarif.Name = "tpChooseTarif";
            this.tpChooseTarif.Padding = new System.Windows.Forms.Padding(3);
            this.tpChooseTarif.Size = new System.Drawing.Size(558, 402);
            this.tpChooseTarif.TabIndex = 2;
            this.tpChooseTarif.Text = "Выбор тарифа";
            this.tpChooseTarif.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(552, 362);
            this.panel8.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btChooseTarif);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(3, 365);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(552, 34);
            this.panel7.TabIndex = 0;
            // 
            // btChooseTarif
            // 
            this.btChooseTarif.Location = new System.Drawing.Point(472, 6);
            this.btChooseTarif.Name = "btChooseTarif";
            this.btChooseTarif.Size = new System.Drawing.Size(75, 23);
            this.btChooseTarif.TabIndex = 0;
            this.btChooseTarif.Text = "Выбрать тариф";
            this.btChooseTarif.UseVisualStyleBackColor = true;
            this.btChooseTarif.Click += new System.EventHandler(this.btChooseTarif_Click);
            // 
            // tpCreateAbonent
            // 
            this.tpCreateAbonent.Controls.Add(this.panel10);
            this.tpCreateAbonent.Controls.Add(this.panel9);
            this.tpCreateAbonent.Location = new System.Drawing.Point(4, 22);
            this.tpCreateAbonent.Name = "tpCreateAbonent";
            this.tpCreateAbonent.Padding = new System.Windows.Forms.Padding(3);
            this.tpCreateAbonent.Size = new System.Drawing.Size(558, 402);
            this.tpCreateAbonent.TabIndex = 3;
            this.tpCreateAbonent.Text = "Создание абонента";
            this.tpCreateAbonent.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(552, 362);
            this.panel10.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btCreateAbonent);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(3, 365);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(552, 34);
            this.panel9.TabIndex = 0;
            // 
            // btCreateAbonent
            // 
            this.btCreateAbonent.Location = new System.Drawing.Point(420, 6);
            this.btCreateAbonent.Name = "btCreateAbonent";
            this.btCreateAbonent.Size = new System.Drawing.Size(127, 23);
            this.btCreateAbonent.TabIndex = 0;
            this.btCreateAbonent.Text = "Создать абонента";
            this.btCreateAbonent.UseVisualStyleBackColor = true;
            this.btCreateAbonent.Click += new System.EventHandler(this.btCreateAbonent_Click);
            // 
            // tpEditAbonent
            // 
            this.tpEditAbonent.Controls.Add(this.panel12);
            this.tpEditAbonent.Controls.Add(this.panel11);
            this.tpEditAbonent.Location = new System.Drawing.Point(4, 22);
            this.tpEditAbonent.Name = "tpEditAbonent";
            this.tpEditAbonent.Padding = new System.Windows.Forms.Padding(3);
            this.tpEditAbonent.Size = new System.Drawing.Size(558, 402);
            this.tpEditAbonent.TabIndex = 4;
            this.tpEditAbonent.Text = "Редактирование абонента";
            this.tpEditAbonent.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(3, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(552, 362);
            this.panel12.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btEditAbonent);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(3, 365);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(552, 34);
            this.panel11.TabIndex = 0;
            // 
            // btEditAbonent
            // 
            this.btEditAbonent.Location = new System.Drawing.Point(409, 6);
            this.btEditAbonent.Name = "btEditAbonent";
            this.btEditAbonent.Size = new System.Drawing.Size(138, 23);
            this.btEditAbonent.TabIndex = 0;
            this.btEditAbonent.Text = "Сохранить абонента";
            this.btEditAbonent.UseVisualStyleBackColor = true;
            this.btEditAbonent.Click += new System.EventHandler(this.btEditAbonent_Click);
            // 
            // tpCreateTarif
            // 
            this.tpCreateTarif.Controls.Add(this.panel14);
            this.tpCreateTarif.Controls.Add(this.panel13);
            this.tpCreateTarif.Location = new System.Drawing.Point(4, 22);
            this.tpCreateTarif.Name = "tpCreateTarif";
            this.tpCreateTarif.Padding = new System.Windows.Forms.Padding(3);
            this.tpCreateTarif.Size = new System.Drawing.Size(558, 402);
            this.tpCreateTarif.TabIndex = 5;
            this.tpCreateTarif.Text = "Создание тарифа";
            this.tpCreateTarif.UseVisualStyleBackColor = true;
            // 
            // panel14
            // 
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(3, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(552, 362);
            this.panel14.TabIndex = 1;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btCreateTarif);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(3, 365);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(552, 34);
            this.panel13.TabIndex = 0;
            // 
            // btCreateTarif
            // 
            this.btCreateTarif.Location = new System.Drawing.Point(442, 6);
            this.btCreateTarif.Name = "btCreateTarif";
            this.btCreateTarif.Size = new System.Drawing.Size(105, 23);
            this.btCreateTarif.TabIndex = 0;
            this.btCreateTarif.Text = "Создать тариф";
            this.btCreateTarif.UseVisualStyleBackColor = true;
            this.btCreateTarif.Click += new System.EventHandler(this.btCreateTarif_Click);
            // 
            // tpEditTarif
            // 
            this.tpEditTarif.Controls.Add(this.panel16);
            this.tpEditTarif.Controls.Add(this.panel17);
            this.tpEditTarif.Location = new System.Drawing.Point(4, 22);
            this.tpEditTarif.Name = "tpEditTarif";
            this.tpEditTarif.Padding = new System.Windows.Forms.Padding(3);
            this.tpEditTarif.Size = new System.Drawing.Size(558, 402);
            this.tpEditTarif.TabIndex = 6;
            this.tpEditTarif.Text = "Редактирвование тарифа";
            this.tpEditTarif.UseVisualStyleBackColor = true;
            // 
            // panel16
            // 
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(3, 3);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(552, 362);
            this.panel16.TabIndex = 1;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.btEditTarif);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel17.Location = new System.Drawing.Point(3, 365);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(552, 34);
            this.panel17.TabIndex = 0;
            // 
            // btEditTarif
            // 
            this.btEditTarif.Location = new System.Drawing.Point(421, 6);
            this.btEditTarif.Name = "btEditTarif";
            this.btEditTarif.Size = new System.Drawing.Size(128, 23);
            this.btEditTarif.TabIndex = 0;
            this.btEditTarif.Text = "Сохранить тариф";
            this.btEditTarif.UseVisualStyleBackColor = true;
            this.btEditTarif.Click += new System.EventHandler(this.btEditTarif_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pMenuPanel);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MainForm";
            this.Text = "Личный кабинет клиента провайдера интернет-услуг";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pMenuPanel.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tpAccBalanceReport.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tpTrafficReport.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tpPayAccount.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tpChooseTarif.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.tpCreateAbonent.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.tpEditAbonent.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.tpCreateTarif.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.tpEditTarif.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslMain;
        private System.Windows.Forms.Panel pMenuPanel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btmChooseTarif;
        private System.Windows.Forms.Button btmPayAccount;
        private System.Windows.Forms.Button btmTrafficReport;
        private System.Windows.Forms.Button btmAccBalanceReport;
        private System.Windows.Forms.Button btmEditAbonent;
        private System.Windows.Forms.Button btmCreateAbonent;
        private System.Windows.Forms.Button btmEditTarif;
        private System.Windows.Forms.Button btmCreateTarif;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpAccBalanceReport;
        private System.Windows.Forms.TabPage tpPayAccount;
        private System.Windows.Forms.TabPage tpChooseTarif;
        private System.Windows.Forms.TabPage tpCreateAbonent;
        private System.Windows.Forms.TabPage tpEditAbonent;
        private System.Windows.Forms.TabPage tpCreateTarif;
        private System.Windows.Forms.TabPage tpEditTarif;
        private System.Windows.Forms.TabPage tpTrafficReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbBalanceReport;
        private System.Windows.Forms.Button btAccBalanceReport;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btTrafficReport;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbTrafficReport;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btPayAccount;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btChooseTarif;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btCreateAbonent;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btEditAbonent;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btCreateTarif;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button btEditTarif;
    }
}

