
namespace bakeNpack.forms
{
    partial class dashboard1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cashinfobtn = new Guna.UI2.WinForms.Guna2Button();
            this.employeeinfobtn = new Guna.UI2.WinForms.Guna2Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Removeitemsbtn = new Guna.UI2.WinForms.Guna2Button();
            this.updateitemsbtn = new Guna.UI2.WinForms.Guna2Button();
            this.additemsbtn = new Guna.UI2.WinForms.Guna2Button();
            this.placeorderbtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse7 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_CashInfo1 = new bakeNpack.user_control.UC_CashInfo();
            this.uC_RemoveItem1 = new bakeNpack.user_control.UC_RemoveItem();
            this.uC_UpdateItems1 = new bakeNpack.user_control.UC_UpdateItems();
            this.uC_additems1 = new bakeNpack.user_control.UC_additems();
            this.uC_welcome1 = new bakeNpack.user_control.UC_welcome();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.cashinfobtn);
            this.panel1.Controls.Add(this.employeeinfobtn);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.Removeitemsbtn);
            this.panel1.Controls.Add(this.updateitemsbtn);
            this.panel1.Controls.Add(this.additemsbtn);
            this.panel1.Controls.Add(this.placeorderbtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 502);
            this.panel1.TabIndex = 0;
            // 
            // cashinfobtn
            // 
            this.cashinfobtn.BackColor = System.Drawing.Color.Transparent;
            this.cashinfobtn.BorderRadius = 13;
            this.cashinfobtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.cashinfobtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.cashinfobtn.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.cashinfobtn.CheckedState.Parent = this.cashinfobtn;
            this.cashinfobtn.CustomImages.Parent = this.cashinfobtn;
            this.cashinfobtn.FillColor = System.Drawing.Color.IndianRed;
            this.cashinfobtn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashinfobtn.ForeColor = System.Drawing.Color.White;
            this.cashinfobtn.HoverState.Parent = this.cashinfobtn;
            this.cashinfobtn.Location = new System.Drawing.Point(4, 385);
            this.cashinfobtn.Name = "cashinfobtn";
            this.cashinfobtn.ShadowDecoration.Parent = this.cashinfobtn;
            this.cashinfobtn.Size = new System.Drawing.Size(196, 41);
            this.cashinfobtn.TabIndex = 8;
            this.cashinfobtn.Text = "Cash info";
            this.cashinfobtn.Click += new System.EventHandler(this.cashinfobtn_Click);
            // 
            // employeeinfobtn
            // 
            this.employeeinfobtn.BackColor = System.Drawing.Color.Transparent;
            this.employeeinfobtn.BorderRadius = 13;
            this.employeeinfobtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.employeeinfobtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.employeeinfobtn.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.employeeinfobtn.CheckedState.Parent = this.employeeinfobtn;
            this.employeeinfobtn.CustomImages.Parent = this.employeeinfobtn;
            this.employeeinfobtn.FillColor = System.Drawing.Color.IndianRed;
            this.employeeinfobtn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeinfobtn.ForeColor = System.Drawing.Color.White;
            this.employeeinfobtn.HoverState.Parent = this.employeeinfobtn;
            this.employeeinfobtn.Location = new System.Drawing.Point(1, 315);
            this.employeeinfobtn.Name = "employeeinfobtn";
            this.employeeinfobtn.ShadowDecoration.Parent = this.employeeinfobtn;
            this.employeeinfobtn.Size = new System.Drawing.Size(196, 41);
            this.employeeinfobtn.TabIndex = 7;
            this.employeeinfobtn.Text = "Employee Info";
            this.employeeinfobtn.Click += new System.EventHandler(this.employeeinfobtn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.LinkColor = System.Drawing.Color.Linen;
            this.linkLabel1.Location = new System.Drawing.Point(51, 469);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(90, 25);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "LogOut";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Removeitemsbtn
            // 
            this.Removeitemsbtn.BackColor = System.Drawing.Color.Transparent;
            this.Removeitemsbtn.BorderRadius = 13;
            this.Removeitemsbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Removeitemsbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.Removeitemsbtn.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.Removeitemsbtn.CheckedState.Parent = this.Removeitemsbtn;
            this.Removeitemsbtn.CustomImages.Parent = this.Removeitemsbtn;
            this.Removeitemsbtn.FillColor = System.Drawing.Color.IndianRed;
            this.Removeitemsbtn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Removeitemsbtn.ForeColor = System.Drawing.Color.White;
            this.Removeitemsbtn.HoverState.Parent = this.Removeitemsbtn;
            this.Removeitemsbtn.Location = new System.Drawing.Point(1, 243);
            this.Removeitemsbtn.Name = "Removeitemsbtn";
            this.Removeitemsbtn.ShadowDecoration.Parent = this.Removeitemsbtn;
            this.Removeitemsbtn.Size = new System.Drawing.Size(196, 41);
            this.Removeitemsbtn.TabIndex = 5;
            this.Removeitemsbtn.Text = "Remove items";
            this.Removeitemsbtn.Click += new System.EventHandler(this.Removeitemsbtn_Click);
            // 
            // updateitemsbtn
            // 
            this.updateitemsbtn.BackColor = System.Drawing.Color.Transparent;
            this.updateitemsbtn.BorderRadius = 13;
            this.updateitemsbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.updateitemsbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.updateitemsbtn.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.updateitemsbtn.CheckedState.Parent = this.updateitemsbtn;
            this.updateitemsbtn.CustomImages.Parent = this.updateitemsbtn;
            this.updateitemsbtn.FillColor = System.Drawing.Color.IndianRed;
            this.updateitemsbtn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateitemsbtn.ForeColor = System.Drawing.Color.White;
            this.updateitemsbtn.HoverState.Parent = this.updateitemsbtn;
            this.updateitemsbtn.Location = new System.Drawing.Point(4, 180);
            this.updateitemsbtn.Name = "updateitemsbtn";
            this.updateitemsbtn.ShadowDecoration.Parent = this.updateitemsbtn;
            this.updateitemsbtn.Size = new System.Drawing.Size(196, 41);
            this.updateitemsbtn.TabIndex = 4;
            this.updateitemsbtn.Text = "Update items";
            this.updateitemsbtn.Click += new System.EventHandler(this.updateitemsbtn_Click);
            // 
            // additemsbtn
            // 
            this.additemsbtn.BackColor = System.Drawing.Color.Transparent;
            this.additemsbtn.BorderRadius = 13;
            this.additemsbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.additemsbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.additemsbtn.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.additemsbtn.CheckedState.Parent = this.additemsbtn;
            this.additemsbtn.CustomImages.Parent = this.additemsbtn;
            this.additemsbtn.FillColor = System.Drawing.Color.IndianRed;
            this.additemsbtn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additemsbtn.ForeColor = System.Drawing.Color.White;
            this.additemsbtn.HoverState.Parent = this.additemsbtn;
            this.additemsbtn.Location = new System.Drawing.Point(3, 113);
            this.additemsbtn.Name = "additemsbtn";
            this.additemsbtn.ShadowDecoration.Parent = this.additemsbtn;
            this.additemsbtn.Size = new System.Drawing.Size(196, 41);
            this.additemsbtn.TabIndex = 3;
            this.additemsbtn.Text = "Add items";
            this.additemsbtn.Click += new System.EventHandler(this.additemsbtn_Click);
            // 
            // placeorderbtn
            // 
            this.placeorderbtn.BackColor = System.Drawing.Color.Transparent;
            this.placeorderbtn.BorderRadius = 13;
            this.placeorderbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.placeorderbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.placeorderbtn.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.placeorderbtn.CheckedState.Parent = this.placeorderbtn;
            this.placeorderbtn.CustomImages.Parent = this.placeorderbtn;
            this.placeorderbtn.FillColor = System.Drawing.Color.IndianRed;
            this.placeorderbtn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeorderbtn.ForeColor = System.Drawing.Color.White;
            this.placeorderbtn.HoverState.Parent = this.placeorderbtn;
            this.placeorderbtn.Location = new System.Drawing.Point(4, 46);
            this.placeorderbtn.Name = "placeorderbtn";
            this.placeorderbtn.ShadowDecoration.Parent = this.placeorderbtn;
            this.placeorderbtn.Size = new System.Drawing.Size(196, 41);
            this.placeorderbtn.TabIndex = 2;
            this.placeorderbtn.Text = "Place Order";
            this.placeorderbtn.Click += new System.EventHandler(this.placeorderbtn_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(206, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 106);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PeachPuff;
            this.panel3.Controls.Add(this.uC_CashInfo1);
            this.panel3.Controls.Add(this.uC_RemoveItem1);
            this.panel3.Controls.Add(this.uC_UpdateItems1);
            this.panel3.Controls.Add(this.uC_additems1);
            this.panel3.Controls.Add(this.uC_welcome1);
            this.panel3.Location = new System.Drawing.Point(211, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(781, 502);
            this.panel3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(960, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "TASTY TIME";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 25;
            this.guna2Elipse2.TargetControl = this.panel3;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 25;
            this.guna2Elipse3.TargetControl = this.panel3;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 25;
            this.guna2Elipse4.TargetControl = this.panel3;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 25;
            this.guna2Elipse5.TargetControl = this.panel3;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.BorderRadius = 25;
            this.guna2Elipse6.TargetControl = this.panel3;
            // 
            // guna2Elipse7
            // 
            this.guna2Elipse7.BorderRadius = 25;
            this.guna2Elipse7.TargetControl = this.panel3;
            // 
            // uC_CashInfo1
            // 
            this.uC_CashInfo1.BackColor = System.Drawing.Color.MistyRose;
            this.uC_CashInfo1.Location = new System.Drawing.Point(3, 3);
            this.uC_CashInfo1.Name = "uC_CashInfo1";
            this.uC_CashInfo1.Size = new System.Drawing.Size(781, 514);
            this.uC_CashInfo1.TabIndex = 4;
            // 
            // uC_RemoveItem1
            // 
            this.uC_RemoveItem1.BackColor = System.Drawing.Color.MistyRose;
            this.uC_RemoveItem1.Location = new System.Drawing.Point(3, 0);
            this.uC_RemoveItem1.Name = "uC_RemoveItem1";
            this.uC_RemoveItem1.Size = new System.Drawing.Size(781, 514);
            this.uC_RemoveItem1.TabIndex = 3;
            // 
            // uC_UpdateItems1
            // 
            this.uC_UpdateItems1.BackColor = System.Drawing.Color.MistyRose;
            this.uC_UpdateItems1.Location = new System.Drawing.Point(3, 3);
            this.uC_UpdateItems1.Name = "uC_UpdateItems1";
            this.uC_UpdateItems1.Size = new System.Drawing.Size(781, 514);
            this.uC_UpdateItems1.TabIndex = 2;
            // 
            // uC_additems1
            // 
            this.uC_additems1.BackColor = System.Drawing.Color.MistyRose;
            this.uC_additems1.Location = new System.Drawing.Point(3, 3);
            this.uC_additems1.Name = "uC_additems1";
            this.uC_additems1.Size = new System.Drawing.Size(771, 502);
            this.uC_additems1.TabIndex = 1;
            // 
            // uC_welcome1
            // 
            this.uC_welcome1.BackColor = System.Drawing.Color.Moccasin;
            this.uC_welcome1.Location = new System.Drawing.Point(3, 3);
            this.uC_welcome1.Name = "uC_welcome1";
            this.uC_welcome1.Size = new System.Drawing.Size(781, 514);
            this.uC_welcome1.TabIndex = 0;
            // 
            // dashboard1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1004, 538);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard1";
            this.Load += new System.EventHandler(this.dashboard1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button Removeitemsbtn;
        private Guna.UI2.WinForms.Guna2Button updateitemsbtn;
        private Guna.UI2.WinForms.Guna2Button additemsbtn;
        private Guna.UI2.WinForms.Guna2Button placeorderbtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private user_control.UC_welcome uC_welcome1;
        private Guna.UI2.WinForms.Guna2Button cashinfobtn;
        private Guna.UI2.WinForms.Guna2Button employeeinfobtn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private user_control.UC_additems uC_additems1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private user_control.UC_UpdateItems uC_UpdateItems1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private user_control.UC_RemoveItem uC_RemoveItem1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse7;
        private user_control.UC_CashInfo uC_CashInfo1;
    }
}