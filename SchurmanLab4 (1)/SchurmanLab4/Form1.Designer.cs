namespace SchurmanLab4
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
            this.grpBook = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPeople = new System.Windows.Forms.TextBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.radCash = new System.Windows.Forms.RadioButton();
            this.radCreditCard = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radMexico = new System.Windows.Forms.RadioButton();
            this.radFlorida = new System.Windows.Forms.RadioButton();
            this.radCuba = new System.Windows.Forms.RadioButton();
            this.chkFlightIncluded = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTripInformation = new System.Windows.Forms.GroupBox();
            this.lblTripInformation = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.grpBook.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpTripInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBook
            // 
            this.grpBook.Controls.Add(this.lblPrice);
            this.grpBook.Controls.Add(this.txtPeople);
            this.grpBook.Controls.Add(this.btnBook);
            this.grpBook.Controls.Add(this.btnReset);
            this.grpBook.Controls.Add(this.label2);
            this.grpBook.Controls.Add(this.radCash);
            this.grpBook.Controls.Add(this.radCreditCard);
            this.grpBook.Controls.Add(this.groupBox3);
            this.grpBook.Controls.Add(this.label1);
            this.grpBook.Location = new System.Drawing.Point(12, 12);
            this.grpBook.Name = "grpBook";
            this.grpBook.Size = new System.Drawing.Size(207, 300);
            this.grpBook.TabIndex = 0;
            this.grpBook.TabStop = false;
            this.grpBook.Text = "Book";
            // 
            // lblPrice
            // 
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice.Location = new System.Drawing.Point(75, 233);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(126, 27);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPeople
            // 
            this.txtPeople.Location = new System.Drawing.Point(83, 20);
            this.txtPeople.Name = "txtPeople";
            this.txtPeople.Size = new System.Drawing.Size(100, 27);
            this.txtPeople.TabIndex = 1;
            this.txtPeople.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(116, 265);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(75, 29);
            this.btnBook.TabIndex = 6;
            this.btnBook.Text = "&Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(16, 265);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 29);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price:";
            // 
            // radCash
            // 
            this.radCash.AutoSize = true;
            this.radCash.Location = new System.Drawing.Point(10, 210);
            this.radCash.Name = "radCash";
            this.radCash.Size = new System.Drawing.Size(72, 24);
            this.radCash.TabIndex = 4;
            this.radCash.TabStop = true;
            this.radCash.Text = "Cash";
            this.radCash.UseVisualStyleBackColor = true;
            // 
            // radCreditCard
            // 
            this.radCreditCard.AutoSize = true;
            this.radCreditCard.Location = new System.Drawing.Point(10, 187);
            this.radCreditCard.Name = "radCreditCard";
            this.radCreditCard.Size = new System.Drawing.Size(127, 24);
            this.radCreditCard.TabIndex = 3;
            this.radCreditCard.TabStop = true;
            this.radCreditCard.Text = "Credit Card";
            this.radCreditCard.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.radMexico);
            this.groupBox3.Controls.Add(this.radFlorida);
            this.groupBox3.Controls.Add(this.radCuba);
            this.groupBox3.Controls.Add(this.chkFlightIncluded);
            this.groupBox3.Location = new System.Drawing.Point(10, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 135);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Location";
            // 
            // radMexico
            // 
            this.radMexico.AutoSize = true;
            this.radMexico.Location = new System.Drawing.Point(6, 75);
            this.radMexico.Name = "radMexico";
            this.radMexico.Size = new System.Drawing.Size(88, 24);
            this.radMexico.TabIndex = 2;
            this.radMexico.TabStop = true;
            this.radMexico.Text = "Mexico";
            this.radMexico.UseVisualStyleBackColor = true;
            this.radMexico.CheckedChanged += new System.EventHandler(this.radMexico_CheckedChanged);
            // 
            // radFlorida
            // 
            this.radFlorida.AutoSize = true;
            this.radFlorida.Location = new System.Drawing.Point(6, 50);
            this.radFlorida.Name = "radFlorida";
            this.radFlorida.Size = new System.Drawing.Size(88, 24);
            this.radFlorida.TabIndex = 2;
            this.radFlorida.TabStop = true;
            this.radFlorida.Text = "Florida";
            this.radFlorida.UseVisualStyleBackColor = true;
            this.radFlorida.CheckedChanged += new System.EventHandler(this.radFlorida_CheckedChanged);
            // 
            // radCuba
            // 
            this.radCuba.AutoSize = true;
            this.radCuba.Location = new System.Drawing.Point(6, 26);
            this.radCuba.Name = "radCuba";
            this.radCuba.Size = new System.Drawing.Size(74, 24);
            this.radCuba.TabIndex = 2;
            this.radCuba.TabStop = true;
            this.radCuba.Text = "Cuba";
            this.radCuba.UseVisualStyleBackColor = true;
            this.radCuba.CheckedChanged += new System.EventHandler(this.radCuba_CheckedChanged);
            // 
            // chkFlightIncluded
            // 
            this.chkFlightIncluded.AutoSize = true;
            this.chkFlightIncluded.Enabled = false;
            this.chkFlightIncluded.Location = new System.Drawing.Point(6, 105);
            this.chkFlightIncluded.Name = "chkFlightIncluded";
            this.chkFlightIncluded.Size = new System.Drawing.Size(154, 24);
            this.chkFlightIncluded.TabIndex = 0;
            this.chkFlightIncluded.Text = "Flight Included";
            this.chkFlightIncluded.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "People:";
            // 
            // grpTripInformation
            // 
            this.grpTripInformation.Controls.Add(this.lblTripInformation);
            this.grpTripInformation.Controls.Add(this.btnConfirm);
            this.grpTripInformation.Location = new System.Drawing.Point(225, 12);
            this.grpTripInformation.Name = "grpTripInformation";
            this.grpTripInformation.Size = new System.Drawing.Size(239, 300);
            this.grpTripInformation.TabIndex = 1;
            this.grpTripInformation.TabStop = false;
            this.grpTripInformation.Text = "Trip Information";
            // 
            // lblTripInformation
            // 
            this.lblTripInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTripInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTripInformation.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTripInformation.Location = new System.Drawing.Point(6, 23);
            this.lblTripInformation.Name = "lblTripInformation";
            this.lblTripInformation.Size = new System.Drawing.Size(227, 237);
            this.lblTripInformation.TabIndex = 2;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(76, 265);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(85, 29);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "&Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnBook;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(492, 328);
            this.Controls.Add(this.grpTripInformation);
            this.Controls.Add(this.grpBook);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking by Kristian Schurman";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBook.ResumeLayout(false);
            this.grpBook.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpTripInformation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBook;
        private System.Windows.Forms.GroupBox grpTripInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radCash;
        private System.Windows.Forms.RadioButton radCreditCard;
        private System.Windows.Forms.RadioButton radMexico;
        private System.Windows.Forms.RadioButton radFlorida;
        private System.Windows.Forms.RadioButton radCuba;
        private System.Windows.Forms.CheckBox chkFlightIncluded;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtPeople;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTripInformation;
    }
}

