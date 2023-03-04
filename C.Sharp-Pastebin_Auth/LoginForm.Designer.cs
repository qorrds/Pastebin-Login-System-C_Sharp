
namespace C.Sharp_Pastebin_Auth
{
    partial class LoginForm
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
            this.Auth = new Guna.UI2.WinForms.Guna2Button();
            this.End = new Guna.UI2.WinForms.Guna2Button();
            this.ResizeForm = new Guna.UI2.WinForms.Guna2ResizeBox();
            this.Dock_Top = new System.Windows.Forms.Label();
            this.Dock_Bottom = new System.Windows.Forms.Label();
            this.Dock_Left = new System.Windows.Forms.Label();
            this.Dock_Right = new System.Windows.Forms.Label();
            this.Key = new Guna.UI2.WinForms.Guna2TextBox();
            this.Logo = new System.Windows.Forms.Label();
            this.DragForm = new System.Windows.Forms.Label();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.SuspendLayout();
            // 
            // Auth
            // 
            this.Auth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Auth.Animated = true;
            this.Auth.BackColor = System.Drawing.Color.Transparent;
            this.Auth.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Auth.BorderRadius = 8;
            this.Auth.BorderThickness = 1;
            this.Auth.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.Auth.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Auth.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Auth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Auth.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Auth.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Auth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Auth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Auth.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.Auth.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.Auth.ForeColor = System.Drawing.Color.White;
            this.Auth.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.Auth.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.Auth.Location = new System.Drawing.Point(68, 88);
            this.Auth.Name = "Auth";
            this.Auth.PressedColor = System.Drawing.Color.Transparent;
            this.Auth.Size = new System.Drawing.Size(153, 25);
            this.Auth.TabIndex = 34;
            this.Auth.Text = "Login";
            this.Auth.Click += new System.EventHandler(this.Auth_Click);
            // 
            // End
            // 
            this.End.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.End.Animated = true;
            this.End.BackColor = System.Drawing.Color.Transparent;
            this.End.BorderRadius = 5;
            this.End.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.End.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.End.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.End.Cursor = System.Windows.Forms.Cursors.Hand;
            this.End.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.End.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.End.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.End.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.End.FillColor = System.Drawing.Color.Transparent;
            this.End.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End.ForeColor = System.Drawing.Color.White;
            this.End.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.End.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.End.Location = new System.Drawing.Point(260, -1);
            this.End.Name = "End";
            this.End.PressedColor = System.Drawing.Color.Transparent;
            this.End.Size = new System.Drawing.Size(41, 25);
            this.End.TabIndex = 33;
            this.End.Text = "X";
            this.End.UseTransparentBackground = true;
            this.End.Click += new System.EventHandler(this.End_Click);
            // 
            // ResizeForm
            // 
            this.ResizeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResizeForm.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.ResizeForm.FillColor = System.Drawing.Color.White;
            this.ResizeForm.ForeColor = System.Drawing.Color.Black;
            this.ResizeForm.Location = new System.Drawing.Point(272, 135);
            this.ResizeForm.Name = "ResizeForm";
            this.ResizeForm.Size = new System.Drawing.Size(20, 20);
            this.ResizeForm.TabIndex = 35;
            this.ResizeForm.TargetControl = this;
            // 
            // Dock_Top
            // 
            this.Dock_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dock_Top.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Dock_Top.Location = new System.Drawing.Point(-4, 0);
            this.Dock_Top.Name = "Dock_Top";
            this.Dock_Top.Size = new System.Drawing.Size(408, 1);
            this.Dock_Top.TabIndex = 39;
            // 
            // Dock_Bottom
            // 
            this.Dock_Bottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dock_Bottom.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Dock_Bottom.Location = new System.Drawing.Point(-25, 152);
            this.Dock_Bottom.Name = "Dock_Bottom";
            this.Dock_Bottom.Size = new System.Drawing.Size(408, 1);
            this.Dock_Bottom.TabIndex = 38;
            // 
            // Dock_Left
            // 
            this.Dock_Left.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Dock_Left.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Dock_Left.Location = new System.Drawing.Point(0, -14);
            this.Dock_Left.Name = "Dock_Left";
            this.Dock_Left.Size = new System.Drawing.Size(1, 292);
            this.Dock_Left.TabIndex = 36;
            // 
            // Dock_Right
            // 
            this.Dock_Right.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dock_Right.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Dock_Right.Location = new System.Drawing.Point(289, -52);
            this.Dock_Right.Name = "Dock_Right";
            this.Dock_Right.Size = new System.Drawing.Size(1, 292);
            this.Dock_Right.TabIndex = 40;
            // 
            // Key
            // 
            this.Key.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Key.Animated = true;
            this.Key.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Key.BorderRadius = 8;
            this.Key.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Key.DefaultText = "";
            this.Key.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Key.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Key.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Key.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Key.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.Key.FocusedState.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Key.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Key.ForeColor = System.Drawing.Color.White;
            this.Key.HoverState.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Key.Location = new System.Drawing.Point(68, 45);
            this.Key.Name = "Key";
            this.Key.PasswordChar = '●';
            this.Key.PlaceholderText = "Key";
            this.Key.SelectedText = "";
            this.Key.Size = new System.Drawing.Size(153, 27);
            this.Key.TabIndex = 41;
            this.Key.UseSystemPasswordChar = true;
            this.Key.TextChanged += new System.EventHandler(this.Key_TextChanged);
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Logo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.ForeColor = System.Drawing.Color.White;
            this.Logo.Location = new System.Drawing.Point(1, 3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(35, 15);
            this.Logo.TabIndex = 42;
            this.Logo.Text = " \'N/A\'";
            // 
            // DragForm
            // 
            this.DragForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DragForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.DragForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DragForm.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DragForm.ForeColor = System.Drawing.Color.White;
            this.DragForm.Location = new System.Drawing.Point(0, -1);
            this.DragForm.Name = "DragForm";
            this.DragForm.Size = new System.Drawing.Size(292, 25);
            this.DragForm.TabIndex = 43;
            // 
            // DragControl
            // 
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.TargetControl = this.DragForm;
            this.DragControl.TransparentWhileDrag = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(290, 153);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.Dock_Right);
            this.Controls.Add(this.Dock_Top);
            this.Controls.Add(this.Dock_Bottom);
            this.Controls.Add(this.Dock_Left);
            this.Controls.Add(this.Auth);
            this.Controls.Add(this.End);
            this.Controls.Add(this.ResizeForm);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.DragForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(630, 400);
            this.MinimumSize = new System.Drawing.Size(290, 153);
            this.Name = "LoginForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Auth;
        private Guna.UI2.WinForms.Guna2Button End;
        private Guna.UI2.WinForms.Guna2ResizeBox ResizeForm;
        private System.Windows.Forms.Label Dock_Top;
        private System.Windows.Forms.Label Dock_Bottom;
        private System.Windows.Forms.Label Dock_Left;
        private System.Windows.Forms.Label Dock_Right;
        private Guna.UI2.WinForms.Guna2TextBox Key;
        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.Label DragForm;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
    }
}