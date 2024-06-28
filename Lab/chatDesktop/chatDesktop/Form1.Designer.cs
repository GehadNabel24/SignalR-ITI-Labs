namespace chatDesktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ChatList = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_name = new TextBox();
            txt_group = new TextBox();
            txt_mess = new TextBox();
            sendToAll = new Button();
            Join = new Button();
            groupMess = new Button();
            SuspendLayout();
            // 
            // ChatList
            // 
            ChatList.FormattingEnabled = true;
            ChatList.Location = new Point(427, 24);
            ChatList.Name = "ChatList";
            ChatList.Size = new Size(340, 404);
            ChatList.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 78);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 143);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Group";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 225);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 3;
            label3.Text = "Message";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(129, 75);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(239, 27);
            txt_name.TabIndex = 4;
            // 
            // txt_group
            // 
            txt_group.Location = new Point(129, 143);
            txt_group.Name = "txt_group";
            txt_group.Size = new Size(239, 27);
            txt_group.TabIndex = 5;
            // 
            // txt_mess
            // 
            txt_mess.Location = new Point(129, 218);
            txt_mess.Name = "txt_mess";
            txt_mess.Size = new Size(239, 27);
            txt_mess.TabIndex = 6;
            // 
            // sendToAll
            // 
            sendToAll.Location = new Point(39, 309);
            sendToAll.Name = "sendToAll";
            sendToAll.Size = new Size(94, 29);
            sendToAll.TabIndex = 7;
            sendToAll.Text = "send to all";
            sendToAll.UseVisualStyleBackColor = true;
            sendToAll.Click += sendToAll_Click;
            // 
            // Join
            // 
            Join.Location = new Point(169, 309);
            Join.Name = "Join";
            Join.Size = new Size(94, 29);
            Join.TabIndex = 8;
            Join.Text = "Join Group";
            Join.UseVisualStyleBackColor = true;
            Join.Click += Join_Click;
            // 
            // groupMess
            // 
            groupMess.Location = new Point(279, 309);
            groupMess.Name = "groupMess";
            groupMess.Size = new Size(114, 29);
            groupMess.TabIndex = 9;
            groupMess.Text = "SendToGroup";
            groupMess.UseVisualStyleBackColor = true;
            groupMess.Click += groupMess_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupMess);
            Controls.Add(Join);
            Controls.Add(sendToAll);
            Controls.Add(txt_mess);
            Controls.Add(txt_group);
            Controls.Add(txt_name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ChatList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ChatList;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_name;
        private TextBox txt_group;
        private TextBox txt_mess;
        private Button sendToAll;
        private Button Join;
        private Button groupMess;
    }
}
