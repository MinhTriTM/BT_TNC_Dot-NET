namespace BT_TNC_Dot_NET.Forms
{
    partial class VoiceEditorForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeaderCard = new BT_TNC_Dot_NET.Controls.RoundedPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.cboAge = new System.Windows.Forms.ComboBox();
            this.lblPersona = new System.Windows.Forms.Label();
            this.cboPersona = new System.Windows.Forms.ComboBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.cboRegion = new System.Windows.Forms.ComboBox();
            this.btnSave = new BT_TNC_Dot_NET.Controls.ModernButton();
            this.btnCancel = new BT_TNC_Dot_NET.Controls.ModernButton();
            this.pnlHeaderCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeaderCard
            // 
            this.pnlHeaderCard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.pnlHeaderCard.BorderRadius = 0;
            this.pnlHeaderCard.BorderWidth = 1;
            this.pnlHeaderCard.Controls.Add(this.lblTitle);
            this.pnlHeaderCard.Controls.Add(this.btnClose);
            this.pnlHeaderCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderCard.GradientAngle = 90F;
            this.pnlHeaderCard.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlHeaderCard.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(75)))));
            this.pnlHeaderCard.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderCard.Name = "pnlHeaderCard";
            this.pnlHeaderCard.Size = new System.Drawing.Size(420, 50);
            this.pnlHeaderCard.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Bold", 12F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.lblTitle.Location = new System.Drawing.Point(16, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(258, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🎙️ Quản Lý Mục Giọng Đọc AI";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnClose.Location = new System.Drawing.Point(380, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "✕";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblName.Location = new System.Drawing.Point(20, 65);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(126, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Tên Giọng Hiển Thị:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtName.Location = new System.Drawing.Point(20, 83);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(380, 24);
            this.txtName.TabIndex = 2;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblId.Location = new System.Drawing.Point(20, 115);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(130, 15);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Mã ID (VieNeu / File):";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtId.Location = new System.Drawing.Point(20, 133);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(380, 24);
            this.txtId.TabIndex = 4;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblGender.Location = new System.Drawing.Point(20, 165);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 15);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Giới Tính:";
            // 
            // cboGender
            // 
            this.cboGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboGender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender.Location = new System.Drawing.Point(20, 183);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(180, 23);
            this.cboGender.TabIndex = 6;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblAge.Location = new System.Drawing.Point(220, 165);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(53, 15);
            this.lblAge.TabIndex = 7;
            this.lblAge.Text = "Độ Tuổi:";
            // 
            // cboAge
            // 
            this.cboAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cboAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboAge.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cboAge.FormattingEnabled = true;
            this.cboAge.Items.AddRange(new object[] {
            "Child",
            "Young",
            "Adult",
            "Senior"});
            this.cboAge.Location = new System.Drawing.Point(220, 183);
            this.cboAge.Name = "cboAge";
            this.cboAge.Size = new System.Drawing.Size(180, 23);
            this.cboAge.TabIndex = 8;
            // 
            // lblPersona
            // 
            this.lblPersona.AutoSize = true;
            this.lblPersona.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblPersona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblPersona.Location = new System.Drawing.Point(20, 215);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(65, 15);
            this.lblPersona.TabIndex = 9;
            this.lblPersona.Text = "Tính Cách:";
            // 
            // cboPersona
            // 
            this.cboPersona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cboPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPersona.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboPersona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cboPersona.FormattingEnabled = true;
            this.cboPersona.Items.AddRange(new object[] {
            "Excited",
            "Warm",
            "Serious",
            "Mysterious"});
            this.cboPersona.Location = new System.Drawing.Point(20, 233);
            this.cboPersona.Name = "cboPersona";
            this.cboPersona.Size = new System.Drawing.Size(180, 23);
            this.cboPersona.TabIndex = 10;
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblRegion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblRegion.Location = new System.Drawing.Point(220, 215);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(66, 15);
            this.lblRegion.TabIndex = 11;
            this.lblRegion.Text = "Vùng Miền:";
            // 
            // cboRegion
            // 
            this.cboRegion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cboRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRegion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRegion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboRegion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.cboRegion.FormattingEnabled = true;
            this.cboRegion.Items.AddRange(new object[] {
            "MienBac",
            "MienNam",
            "MienTrung"});
            this.cboRegion.Location = new System.Drawing.Point(220, 233);
            this.cboRegion.Name = "cboRegion";
            this.cboRegion.Size = new System.Drawing.Size(180, 23);
            this.cboRegion.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(139)))), ((int)(((byte)(250)))));
            this.btnSave.BorderRadius = 10;
            this.btnSave.BorderSize = 1;
            this.btnSave.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btnSave.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(56)))), ((int)(((byte)(202)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnSave.Location = new System.Drawing.Point(80, 280);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 36);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "💾 Lưu Thông Tin";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.BorderSize = 1;
            this.btnCancel.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnCancel.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCancel.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnCancel.Location = new System.Drawing.Point(220, 280);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 36);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "❌ Hủy Bỏ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // VoiceEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(420, 335);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboRegion);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.cboPersona);
            this.Controls.Add(this.lblPersona);
            this.Controls.Add(this.cboAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pnlHeaderCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VoiceEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu Hình Mục Giọng Đọc";
            this.Load += new System.EventHandler(this.VoiceEditorForm_Load);
            this.pnlHeaderCard.ResumeLayout(false);
            this.pnlHeaderCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.RoundedPanel pnlHeaderCard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.ComboBox cboAge;
        private System.Windows.Forms.Label lblPersona;
        private System.Windows.Forms.ComboBox cboPersona;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.ComboBox cboRegion;
        private Controls.ModernButton btnSave;
        private Controls.ModernButton btnCancel;
    }
}
