namespace Happy_Tech_Gui_Main
{
    partial class Form
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
            this.components = new System.ComponentModel.Container();
            this.SendFeedback = new System.Windows.Forms.Button();
            this.Templates = new System.Windows.Forms.ListBox();
            this.EntrName = new System.Windows.Forms.TextBox();
            this.RecipientOfFeedback = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.FeedbackTopic = new System.Windows.Forms.ListBox();
            this.ShortcutCheckbox = new System.Windows.Forms.CheckedListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SendFeedback
            // 
            this.SendFeedback.Location = new System.Drawing.Point(483, 466);
            this.SendFeedback.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SendFeedback.Name = "SendFeedback";
            this.SendFeedback.Size = new System.Drawing.Size(100, 28);
            this.SendFeedback.TabIndex = 0;
            this.SendFeedback.Text = "Send Email";
            this.SendFeedback.UseVisualStyleBackColor = true;
            this.SendFeedback.Click += new System.EventHandler(this.button1_Click);
            // 
            // Templates
            // 
            this.Templates.FormattingEnabled = true;
            this.Templates.ItemHeight = 16;
            this.Templates.Location = new System.Drawing.Point(88, 262);
            this.Templates.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Templates.Name = "Templates";
            this.Templates.Size = new System.Drawing.Size(158, 100);
            this.Templates.TabIndex = 1;
            this.Templates.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // EntrName
            // 
            this.EntrName.Location = new System.Drawing.Point(88, 94);
            this.EntrName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EntrName.Name = "EntrName";
            this.EntrName.Size = new System.Drawing.Size(158, 22);
            this.EntrName.TabIndex = 3;
            this.EntrName.Text = "YourName";
            this.EntrName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RecipientOfFeedback
            // 
            this.RecipientOfFeedback.Location = new System.Drawing.Point(88, 124);
            this.RecipientOfFeedback.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RecipientOfFeedback.Name = "RecipientOfFeedback";
            this.RecipientOfFeedback.Size = new System.Drawing.Size(158, 22);
            this.RecipientOfFeedback.TabIndex = 4;
            this.RecipientOfFeedback.Text = "FeedbackRecipient";
            this.RecipientOfFeedback.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // FeedbackTopic
            // 
            this.FeedbackTopic.FormattingEnabled = true;
            this.FeedbackTopic.ItemHeight = 16;
            this.FeedbackTopic.Location = new System.Drawing.Point(88, 154);
            this.FeedbackTopic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FeedbackTopic.Name = "FeedbackTopic";
            this.FeedbackTopic.Size = new System.Drawing.Size(158, 100);
            this.FeedbackTopic.TabIndex = 5;
            this.FeedbackTopic.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // ShortcutCheckbox
            // 
            this.ShortcutCheckbox.FormattingEnabled = true;
            this.ShortcutCheckbox.Location = new System.Drawing.Point(823, 94);
            this.ShortcutCheckbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShortcutCheckbox.Name = "ShortcutCheckbox";
            this.ShortcutCheckbox.Size = new System.Drawing.Size(158, 106);
            this.ShortcutCheckbox.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(88, 369);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(166, 21);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "SuccessfullApplication";
            this.checkBox1.UseVisualStyleBackColor = true;
            
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Location = new System.Drawing.Point(88, 396);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(182, 21);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "UnsuccessfullApplication";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(289, 93);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(498, 323);
            this.textBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "HappyTech";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 545);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ShortcutCheckbox);
            this.Controls.Add(this.FeedbackTopic);
            this.Controls.Add(this.RecipientOfFeedback);
            this.Controls.Add(this.EntrName);
            this.Controls.Add(this.Templates);
            this.Controls.Add(this.SendFeedback);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendFeedback;
        private System.Windows.Forms.ListBox Templates;
        private System.Windows.Forms.TextBox EntrName;
        private System.Windows.Forms.TextBox RecipientOfFeedback;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox FeedbackTopic;
        private System.Windows.Forms.CheckedListBox ShortcutCheckbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

