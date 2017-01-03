namespace WISPushNoticationsTestClient
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
            this.textBoxConnectionString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxSendPushText = new System.Windows.Forms.TextBox();
            this.buttonSendPush = new System.Windows.Forms.Button();
            this.listBoxRegistrations = new System.Windows.Forms.ListBox();
            this.radioButtonUknown = new System.Windows.Forms.RadioButton();
            this.radioButtonWindows = new System.Windows.Forms.RadioButton();
            this.radioButtonGoogle = new System.Windows.Forms.RadioButton();
            this.radioButtonApple = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelUnknownPhones = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelWindowsPhones = new System.Windows.Forms.Label();
            this.labelGooglePhones = new System.Windows.Forms.Label();
            this.labelApplePhones = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxHubName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxConnectionString
            // 
            this.textBoxConnectionString.Location = new System.Drawing.Point(15, 29);
            this.textBoxConnectionString.Name = "textBoxConnectionString";
            this.textBoxConnectionString.Size = new System.Drawing.Size(218, 20);
            this.textBoxConnectionString.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connection String";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(376, 26);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBoxSendPushText);
            this.panel1.Controls.Add(this.buttonSendPush);
            this.panel1.Controls.Add(this.listBoxRegistrations);
            this.panel1.Controls.Add(this.radioButtonUknown);
            this.panel1.Controls.Add(this.radioButtonWindows);
            this.panel1.Controls.Add(this.radioButtonGoogle);
            this.panel1.Controls.Add(this.radioButtonApple);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(15, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 471);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSendPushText
            // 
            this.textBoxSendPushText.Location = new System.Drawing.Point(169, 438);
            this.textBoxSendPushText.Name = "textBoxSendPushText";
            this.textBoxSendPushText.Size = new System.Drawing.Size(175, 20);
            this.textBoxSendPushText.TabIndex = 8;
            this.textBoxSendPushText.Text = "Push Notification Test Message";
            // 
            // buttonSendPush
            // 
            this.buttonSendPush.Location = new System.Drawing.Point(350, 436);
            this.buttonSendPush.Name = "buttonSendPush";
            this.buttonSendPush.Size = new System.Drawing.Size(75, 23);
            this.buttonSendPush.TabIndex = 7;
            this.buttonSendPush.Text = "Send Push";
            this.buttonSendPush.UseVisualStyleBackColor = true;
            this.buttonSendPush.Click += new System.EventHandler(this.buttonSendPush_Click);
            // 
            // listBoxRegistrations
            // 
            this.listBoxRegistrations.FormattingEnabled = true;
            this.listBoxRegistrations.Location = new System.Drawing.Point(169, 116);
            this.listBoxRegistrations.Name = "listBoxRegistrations";
            this.listBoxRegistrations.Size = new System.Drawing.Size(256, 316);
            this.listBoxRegistrations.TabIndex = 5;
            this.listBoxRegistrations.SelectedIndexChanged += new System.EventHandler(this.listBoxRegistrations_SelectedIndexChanged);
            // 
            // radioButtonUknown
            // 
            this.radioButtonUknown.AutoSize = true;
            this.radioButtonUknown.Location = new System.Drawing.Point(15, 187);
            this.radioButtonUknown.Name = "radioButtonUknown";
            this.radioButtonUknown.Size = new System.Drawing.Size(110, 17);
            this.radioButtonUknown.TabIndex = 4;
            this.radioButtonUknown.Text = "Unknown Phones";
            this.radioButtonUknown.UseVisualStyleBackColor = true;
            this.radioButtonUknown.CheckedChanged += new System.EventHandler(this.radioButtonUknown_CheckedChanged);
            // 
            // radioButtonWindows
            // 
            this.radioButtonWindows.AutoSize = true;
            this.radioButtonWindows.Location = new System.Drawing.Point(15, 164);
            this.radioButtonWindows.Name = "radioButtonWindows";
            this.radioButtonWindows.Size = new System.Drawing.Size(108, 17);
            this.radioButtonWindows.TabIndex = 3;
            this.radioButtonWindows.Text = "Windows Phones";
            this.radioButtonWindows.UseVisualStyleBackColor = true;
            this.radioButtonWindows.CheckedChanged += new System.EventHandler(this.radioButtonWindows_CheckedChanged);
            // 
            // radioButtonGoogle
            // 
            this.radioButtonGoogle.AutoSize = true;
            this.radioButtonGoogle.Location = new System.Drawing.Point(15, 140);
            this.radioButtonGoogle.Name = "radioButtonGoogle";
            this.radioButtonGoogle.Size = new System.Drawing.Size(98, 17);
            this.radioButtonGoogle.TabIndex = 2;
            this.radioButtonGoogle.Text = "Google Phones";
            this.radioButtonGoogle.UseVisualStyleBackColor = true;
            this.radioButtonGoogle.CheckedChanged += new System.EventHandler(this.radioButtonGoogle_CheckedChanged);
            // 
            // radioButtonApple
            // 
            this.radioButtonApple.AutoSize = true;
            this.radioButtonApple.Location = new System.Drawing.Point(15, 116);
            this.radioButtonApple.Name = "radioButtonApple";
            this.radioButtonApple.Size = new System.Drawing.Size(91, 17);
            this.radioButtonApple.TabIndex = 1;
            this.radioButtonApple.Text = "Apple Phones";
            this.radioButtonApple.UseVisualStyleBackColor = true;
            this.radioButtonApple.CheckedChanged += new System.EventHandler(this.radioButtonApple_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelUnknownPhones);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labelWindowsPhones);
            this.groupBox1.Controls.Add(this.labelGooglePhones);
            this.groupBox1.Controls.Add(this.labelApplePhones);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics";
            // 
            // labelUnknownPhones
            // 
            this.labelUnknownPhones.AutoSize = true;
            this.labelUnknownPhones.Location = new System.Drawing.Point(107, 71);
            this.labelUnknownPhones.Name = "labelUnknownPhones";
            this.labelUnknownPhones.Size = new System.Drawing.Size(13, 13);
            this.labelUnknownPhones.TabIndex = 7;
            this.labelUnknownPhones.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Unkown Phones";
            // 
            // labelWindowsPhones
            // 
            this.labelWindowsPhones.AutoSize = true;
            this.labelWindowsPhones.Location = new System.Drawing.Point(107, 53);
            this.labelWindowsPhones.Name = "labelWindowsPhones";
            this.labelWindowsPhones.Size = new System.Drawing.Size(13, 13);
            this.labelWindowsPhones.TabIndex = 5;
            this.labelWindowsPhones.Text = "0";
            // 
            // labelGooglePhones
            // 
            this.labelGooglePhones.AutoSize = true;
            this.labelGooglePhones.Location = new System.Drawing.Point(107, 35);
            this.labelGooglePhones.Name = "labelGooglePhones";
            this.labelGooglePhones.Size = new System.Drawing.Size(13, 13);
            this.labelGooglePhones.TabIndex = 4;
            this.labelGooglePhones.Text = "0";
            // 
            // labelApplePhones
            // 
            this.labelApplePhones.AutoSize = true;
            this.labelApplePhones.Location = new System.Drawing.Point(107, 17);
            this.labelApplePhones.Name = "labelApplePhones";
            this.labelApplePhones.Size = new System.Drawing.Size(13, 13);
            this.labelApplePhones.TabIndex = 3;
            this.labelApplePhones.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Windows Phones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Google Phones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apple Phones";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Enabled = false;
            this.buttonRefresh.Location = new System.Drawing.Point(457, 26);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 4;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Hub Name";
            // 
            // textBoxHubName
            // 
            this.textBoxHubName.Location = new System.Drawing.Point(241, 29);
            this.textBoxHubName.Name = "textBoxHubName";
            this.textBoxHubName.Size = new System.Drawing.Size(129, 20);
            this.textBoxHubName.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 539);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxHubName);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxConnectionString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxConnectionString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelWindowsPhones;
        private System.Windows.Forms.Label labelGooglePhones;
        private System.Windows.Forms.Label labelApplePhones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelUnknownPhones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonUknown;
        private System.Windows.Forms.RadioButton radioButtonWindows;
        private System.Windows.Forms.RadioButton radioButtonGoogle;
        private System.Windows.Forms.RadioButton radioButtonApple;
        private System.Windows.Forms.ListBox listBoxRegistrations;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonSendPush;
        private System.Windows.Forms.TextBox textBoxSendPushText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxHubName;
    }
}

