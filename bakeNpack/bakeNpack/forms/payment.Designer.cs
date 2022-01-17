
namespace bakeNpack.forms
{
    partial class payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payment));
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.txtCusGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtCusAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCusContact = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCusName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPaymentOption = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFoodReview = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCusPay = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCusEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.backbutton = new System.Windows.Forms.PictureBox();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backbutton)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.guna2ShadowPanel1.Controls.Add(this.label6);
            this.guna2ShadowPanel1.Controls.Add(this.txtCusEmail);
            this.guna2ShadowPanel1.Controls.Add(this.label5);
            this.guna2ShadowPanel1.Controls.Add(this.btnCusPay);
            this.guna2ShadowPanel1.Controls.Add(this.txtFoodReview);
            this.guna2ShadowPanel1.Controls.Add(this.label4);
            this.guna2ShadowPanel1.Controls.Add(this.txtPaymentOption);
            this.guna2ShadowPanel1.Controls.Add(this.label3);
            this.guna2ShadowPanel1.Controls.Add(this.txtAmount);
            this.guna2ShadowPanel1.Controls.Add(this.guna2TextBox1);
            this.guna2ShadowPanel1.Controls.Add(this.label2);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.Controls.Add(this.txtCusGender);
            this.guna2ShadowPanel1.Controls.Add(this.txtCusAddress);
            this.guna2ShadowPanel1.Controls.Add(this.txtCusContact);
            this.guna2ShadowPanel1.Controls.Add(this.txtCusName);
            this.guna2ShadowPanel1.Controls.Add(this.label13);
            this.guna2ShadowPanel1.Controls.Add(this.label12);
            this.guna2ShadowPanel1.Controls.Add(this.label11);
            this.guna2ShadowPanel1.Controls.Add(this.label10);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(26, 30);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(752, 467);
            this.guna2ShadowPanel1.TabIndex = 0;
            this.guna2ShadowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2ShadowPanel1_Paint);
            // 
            // txtCusGender
            // 
            this.txtCusGender.BackColor = System.Drawing.Color.Transparent;
            this.txtCusGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtCusGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCusGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusGender.FocusedState.Parent = this.txtCusGender;
            this.txtCusGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCusGender.ForeColor = System.Drawing.Color.Fuchsia;
            this.txtCusGender.HoverState.Parent = this.txtCusGender;
            this.txtCusGender.ItemHeight = 30;
            this.txtCusGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.txtCusGender.ItemsAppearance.Parent = this.txtCusGender;
            this.txtCusGender.Location = new System.Drawing.Point(94, 179);
            this.txtCusGender.Name = "txtCusGender";
            this.txtCusGender.ShadowDecoration.Parent = this.txtCusGender;
            this.txtCusGender.Size = new System.Drawing.Size(229, 36);
            this.txtCusGender.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCusGender.TabIndex = 36;
            // 
            // txtCusAddress
            // 
            this.txtCusAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCusAddress.DefaultText = "";
            this.txtCusAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCusAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCusAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusAddress.DisabledState.Parent = this.txtCusAddress;
            this.txtCusAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusAddress.FocusedState.Parent = this.txtCusAddress;
            this.txtCusAddress.ForeColor = System.Drawing.Color.Fuchsia;
            this.txtCusAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusAddress.HoverState.Parent = this.txtCusAddress;
            this.txtCusAddress.Location = new System.Drawing.Point(97, 394);
            this.txtCusAddress.Name = "txtCusAddress";
            this.txtCusAddress.PasswordChar = '\0';
            this.txtCusAddress.PlaceholderText = "Your address";
            this.txtCusAddress.SelectedText = "";
            this.txtCusAddress.ShadowDecoration.Parent = this.txtCusAddress;
            this.txtCusAddress.Size = new System.Drawing.Size(232, 31);
            this.txtCusAddress.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCusAddress.TabIndex = 35;
            // 
            // txtCusContact
            // 
            this.txtCusContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCusContact.DefaultText = "";
            this.txtCusContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCusContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCusContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusContact.DisabledState.Parent = this.txtCusContact;
            this.txtCusContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusContact.FocusedState.Parent = this.txtCusContact;
            this.txtCusContact.ForeColor = System.Drawing.Color.Fuchsia;
            this.txtCusContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusContact.HoverState.Parent = this.txtCusContact;
            this.txtCusContact.Location = new System.Drawing.Point(94, 243);
            this.txtCusContact.Name = "txtCusContact";
            this.txtCusContact.PasswordChar = '\0';
            this.txtCusContact.PlaceholderText = "Contact number";
            this.txtCusContact.SelectedText = "";
            this.txtCusContact.ShadowDecoration.Parent = this.txtCusContact;
            this.txtCusContact.Size = new System.Drawing.Size(232, 31);
            this.txtCusContact.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCusContact.TabIndex = 34;
            // 
            // txtCusName
            // 
            this.txtCusName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCusName.DefaultText = "";
            this.txtCusName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCusName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCusName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusName.DisabledState.Parent = this.txtCusName;
            this.txtCusName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusName.FocusedState.Parent = this.txtCusName;
            this.txtCusName.ForeColor = System.Drawing.Color.Fuchsia;
            this.txtCusName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusName.HoverState.Parent = this.txtCusName;
            this.txtCusName.Location = new System.Drawing.Point(94, 117);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.PasswordChar = '\0';
            this.txtCusName.PlaceholderText = "Enter your name";
            this.txtCusName.SelectedText = "";
            this.txtCusName.ShadowDecoration.Parent = this.txtCusName;
            this.txtCusName.Size = new System.Drawing.Size(232, 31);
            this.txtCusName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCusName.TabIndex = 33;
            this.txtCusName.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.OrangeRed;
            this.label13.Location = new System.Drawing.Point(94, 378);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 16);
            this.label13.TabIndex = 32;
            this.label13.Text = "Address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.OrangeRed;
            this.label12.Location = new System.Drawing.Point(91, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 16);
            this.label12.TabIndex = 31;
            this.label12.Text = "Contact Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.OrangeRed;
            this.label11.Location = new System.Drawing.Point(94, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 16);
            this.label11.TabIndex = 30;
            this.label11.Text = "Gender";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.OrangeRed;
            this.label10.Location = new System.Drawing.Point(94, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(518, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "PAYMENT METHOD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(516, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Amount";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Gold;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(802, 174);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(177, 69);
            this.guna2TextBox1.TabIndex = 39;
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.Transparent;
            this.txtAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.DefaultText = "";
            this.txtAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.DisabledState.Parent = this.txtAmount;
            this.txtAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.FocusedState.Parent = this.txtAmount;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmount.HoverState.Parent = this.txtAmount;
            this.txtAmount.Location = new System.Drawing.Point(602, 121);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.PlaceholderText = "";
            this.txtAmount.SelectedText = "";
            this.txtAmount.ShadowDecoration.Parent = this.txtAmount;
            this.txtAmount.Size = new System.Drawing.Size(81, 43);
            this.txtAmount.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(488, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Payment option";
            // 
            // txtPaymentOption
            // 
            this.txtPaymentOption.BackColor = System.Drawing.Color.Transparent;
            this.txtPaymentOption.BorderColor = System.Drawing.Color.DarkOrange;
            this.txtPaymentOption.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtPaymentOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPaymentOption.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaymentOption.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaymentOption.FocusedState.Parent = this.txtPaymentOption;
            this.txtPaymentOption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPaymentOption.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtPaymentOption.HoverState.Parent = this.txtPaymentOption;
            this.txtPaymentOption.ItemHeight = 30;
            this.txtPaymentOption.Items.AddRange(new object[] {
            "Bkash"});
            this.txtPaymentOption.ItemsAppearance.Parent = this.txtPaymentOption;
            this.txtPaymentOption.Location = new System.Drawing.Point(600, 202);
            this.txtPaymentOption.Name = "txtPaymentOption";
            this.txtPaymentOption.ShadowDecoration.Parent = this.txtPaymentOption;
            this.txtPaymentOption.Size = new System.Drawing.Size(101, 36);
            this.txtPaymentOption.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(499, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "Food Review";
            // 
            // txtFoodReview
            // 
            this.txtFoodReview.BackColor = System.Drawing.Color.Transparent;
            this.txtFoodReview.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtFoodReview.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFoodReview.DefaultText = "";
            this.txtFoodReview.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFoodReview.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFoodReview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFoodReview.DisabledState.Parent = this.txtFoodReview;
            this.txtFoodReview.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFoodReview.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFoodReview.FocusedState.Parent = this.txtFoodReview;
            this.txtFoodReview.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodReview.ForeColor = System.Drawing.Color.Teal;
            this.txtFoodReview.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFoodReview.HoverState.Parent = this.txtFoodReview;
            this.txtFoodReview.Location = new System.Drawing.Point(602, 280);
            this.txtFoodReview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFoodReview.Name = "txtFoodReview";
            this.txtFoodReview.PasswordChar = '\0';
            this.txtFoodReview.PlaceholderText = "";
            this.txtFoodReview.SelectedText = "";
            this.txtFoodReview.ShadowDecoration.Parent = this.txtFoodReview;
            this.txtFoodReview.Size = new System.Drawing.Size(125, 47);
            this.txtFoodReview.TabIndex = 44;
            // 
            // btnCusPay
            // 
            this.btnCusPay.BorderRadius = 20;
            this.btnCusPay.CheckedState.Parent = this.btnCusPay;
            this.btnCusPay.CustomImages.Parent = this.btnCusPay;
            this.btnCusPay.FillColor = System.Drawing.Color.IndianRed;
            this.btnCusPay.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusPay.ForeColor = System.Drawing.Color.White;
            this.btnCusPay.HoverState.Parent = this.btnCusPay;
            this.btnCusPay.Location = new System.Drawing.Point(522, 394);
            this.btnCusPay.Name = "btnCusPay";
            this.btnCusPay.ShadowDecoration.Parent = this.btnCusPay;
            this.btnCusPay.Size = new System.Drawing.Size(198, 44);
            this.btnCusPay.TabIndex = 45;
            this.btnCusPay.Text = "PAY";
            this.btnCusPay.Click += new System.EventHandler(this.btnCusPay_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(100, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Email-Address";
            // 
            // txtCusEmail
            // 
            this.txtCusEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCusEmail.DefaultText = "";
            this.txtCusEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCusEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCusEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusEmail.DisabledState.Parent = this.txtCusEmail;
            this.txtCusEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusEmail.FocusedState.Parent = this.txtCusEmail;
            this.txtCusEmail.ForeColor = System.Drawing.Color.Fuchsia;
            this.txtCusEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusEmail.HoverState.Parent = this.txtCusEmail;
            this.txtCusEmail.Location = new System.Drawing.Point(97, 321);
            this.txtCusEmail.Name = "txtCusEmail";
            this.txtCusEmail.PasswordChar = '\0';
            this.txtCusEmail.PlaceholderText = " email address";
            this.txtCusEmail.SelectedText = "";
            this.txtCusEmail.ShadowDecoration.Parent = this.txtCusEmail;
            this.txtCusEmail.Size = new System.Drawing.Size(232, 31);
            this.txtCusEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCusEmail.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label6.Location = new System.Drawing.Point(93, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 19);
            this.label6.TabIndex = 48;
            this.label6.Text = "PERSONAL INFORMATION";
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Red;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Location = new System.Drawing.Point(771, 2);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(31, 33);
            this.guna2CircleButton1.TabIndex = 1;
            this.guna2CircleButton1.Text = "X";
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.Transparent;
            this.backbutton.Image = ((System.Drawing.Image)(resources.GetObject("backbutton.Image")));
            this.backbutton.Location = new System.Drawing.Point(3, 2);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(38, 33);
            this.backbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backbutton.TabIndex = 2;
            this.backbutton.TabStop = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(804, 521);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "payment";
            this.Text = "payment";
            this.Load += new System.EventHandler(this.payment_Load);
            this.Enter += new System.EventHandler(this.payment_Enter);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backbutton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2ComboBox txtCusGender;
        private Guna.UI2.WinForms.Guna2TextBox txtCusAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtCusContact;
        private Guna.UI2.WinForms.Guna2TextBox txtCusName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtCusEmail;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnCusPay;
        private Guna.UI2.WinForms.Guna2TextBox txtFoodReview;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox txtPaymentOption;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private System.Windows.Forms.PictureBox backbutton;
    }
}