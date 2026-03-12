namespace Review_Q2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Oil and Lube Services
        private System.Windows.Forms.GroupBox grpOilAndLube;
        private System.Windows.Forms.CheckBox chkChangeOil;
        private System.Windows.Forms.CheckBox chkLube;

        // Wash Services
        private System.Windows.Forms.GroupBox grpWash;
        private System.Windows.Forms.CheckBox chkRadiatorWash;
        private System.Windows.Forms.CheckBox chkTransmissionWash;

        // Other Services
        private System.Windows.Forms.GroupBox grpOtherServices;
        private System.Windows.Forms.CheckBox chkInspection;
        private System.Windows.Forms.CheckBox chkReplaceMuffler;
        private System.Windows.Forms.CheckBox chkTireChange;

        // Parts and Labor Hours
        private System.Windows.Forms.GroupBox grpPartsHours;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.TextBox txtParts;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.TextBox txtHours;

        // Cost Summary
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblServiceAndLabor;
        private System.Windows.Forms.TextBox txtServiceAndLabor;
        private System.Windows.Forms.Label lblPartsOut;
        private System.Windows.Forms.TextBox txtPartsOut;
        private System.Windows.Forms.Label lblPartsTax;
        private System.Windows.Forms.TextBox txtPartsTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;

        // Buttons
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            
            this.Text = "汽車維修服務";
            this.ClientSize = new System.Drawing.Size(540, 480);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10f);

            // ===== Group 1: 機油和潤滑 =====
            grpOilAndLube = new System.Windows.Forms.GroupBox
            {
                Text = "機油和潤滑",
                Location = new System.Drawing.Point(12, 12),
                Size = new System.Drawing.Size(250, 100),
                TabIndex = 0
            };

            chkChangeOil = new System.Windows.Forms.CheckBox
            {
                Text = "更換機油 (NT$780)",
                Location = new System.Drawing.Point(15, 25),
                AutoSize = true,
                TabIndex = 1
            };

            chkLube = new System.Windows.Forms.CheckBox
            {
                Text = "潤滑保養 (NT$540)",
                Location = new System.Drawing.Point(15, 55),
                AutoSize = true,
                TabIndex = 2
            };

            grpOilAndLube.Controls.AddRange(new System.Windows.Forms.Control[] { chkChangeOil, chkLube });

            // ===== Group 2: 清洗服務 =====
            grpWash = new System.Windows.Forms.GroupBox
            {
                Text = "清洗服務",
                Location = new System.Drawing.Point(278, 12),
                Size = new System.Drawing.Size(250, 100),
                TabIndex = 3
            };

            chkRadiatorWash = new System.Windows.Forms.CheckBox
            {
                Text = "水箱清洗 (NT$900)",
                Location = new System.Drawing.Point(15, 25),
                AutoSize = true,
                TabIndex = 4
            };

            chkTransmissionWash = new System.Windows.Forms.CheckBox
            {
                Text = "變速箱清洗 (NT$2,400)",
                Location = new System.Drawing.Point(15, 55),
                AutoSize = true,
                TabIndex = 5
            };

            grpWash.Controls.AddRange(new System.Windows.Forms.Control[] { chkRadiatorWash, chkTransmissionWash });

            // ===== Group 3: 其他服務 =====
            grpOtherServices = new System.Windows.Forms.GroupBox
            {
                Text = "其他服務",
                Location = new System.Drawing.Point(12, 122),
                Size = new System.Drawing.Size(250, 130),
                TabIndex = 6
            };

            chkInspection = new System.Windows.Forms.CheckBox
            {
                Text = "檢驗 (NT$450)",
                Location = new System.Drawing.Point(15, 25),
                AutoSize = true,
                TabIndex = 7
            };

            chkReplaceMuffler = new System.Windows.Forms.CheckBox
            {
                Text = "更換消音器 (NT$3,000)",
                Location = new System.Drawing.Point(15, 55),
                AutoSize = true,
                TabIndex = 8
            };

            chkTireChange = new System.Windows.Forms.CheckBox
            {
                Text = "輪胎換位 (NT$600)",
                Location = new System.Drawing.Point(15, 85),
                AutoSize = true,
                TabIndex = 9
            };

            grpOtherServices.Controls.AddRange(new System.Windows.Forms.Control[] { chkInspection, chkReplaceMuffler, chkTireChange });

            // ===== Group 4: 零件和工時 =====
            grpPartsHours = new System.Windows.Forms.GroupBox
            {
                Text = "零件和工時",
                Location = new System.Drawing.Point(278, 122),
                Size = new System.Drawing.Size(250, 130),
                TabIndex = 10
            };

            lblParts = new System.Windows.Forms.Label
            {
                Text = "零件 (NT$)",
                Location = new System.Drawing.Point(15, 30),
                AutoSize = true,
                TabIndex = 11
            };

            txtParts = new System.Windows.Forms.TextBox
            {
                Location = new System.Drawing.Point(125, 25),
                Size = new System.Drawing.Size(110, 27),
                TabIndex = 12
            };
            txtParts.KeyPress += NumericTextBox_KeyPress;

            lblHours = new System.Windows.Forms.Label
            {
                Text = "工時數 (小時)",
                Location = new System.Drawing.Point(15, 70),
                AutoSize = true,
                TabIndex = 13
            };

            txtHours = new System.Windows.Forms.TextBox
            {
                Location = new System.Drawing.Point(125, 65),
                Size = new System.Drawing.Size(110, 27),
                TabIndex = 14
            };
            txtHours.KeyPress += NumericTextBox_KeyPress;

            grpPartsHours.Controls.AddRange(new System.Windows.Forms.Control[] { lblParts, txtParts, lblHours, txtHours });

            // ===== Group 5: 費用摘要 =====
            grpSummary = new System.Windows.Forms.GroupBox
            {
                Text = "費用摘要",
                Location = new System.Drawing.Point(12, 262),
                Size = new System.Drawing.Size(516, 140),
                TabIndex = 15
            };

            lblServiceAndLabor = new System.Windows.Forms.Label
            {
                Text = "服務與工資",
                Location = new System.Drawing.Point(15, 30),
                AutoSize = true,
                TabIndex = 16
            };

            txtServiceAndLabor = new System.Windows.Forms.TextBox
            {
                Location = new System.Drawing.Point(130, 25),
                Size = new System.Drawing.Size(150, 27),
                ReadOnly = true,
                TabIndex = 17
            };

            lblPartsOut = new System.Windows.Forms.Label
            {
                Text = "零件",
                Location = new System.Drawing.Point(15, 65),
                AutoSize = true,
                TabIndex = 18
            };

            txtPartsOut = new System.Windows.Forms.TextBox
            {
                Location = new System.Drawing.Point(130, 60),
                Size = new System.Drawing.Size(150, 27),
                ReadOnly = true,
                TabIndex = 19
            };

            lblPartsTax = new System.Windows.Forms.Label
            {
                Text = "稅金 (零件)",
                Location = new System.Drawing.Point(300, 30),
                AutoSize = true,
                TabIndex = 20
            };

            txtPartsTax = new System.Windows.Forms.TextBox
            {
                Location = new System.Drawing.Point(385, 25),
                Size = new System.Drawing.Size(115, 27),
                ReadOnly = true,
                TabIndex = 21
            };

            lblTotal = new System.Windows.Forms.Label
            {
                Text = "總費用",
                Location = new System.Drawing.Point(300, 65),
                AutoSize = true,
                TabIndex = 22
            };

            txtTotal = new System.Windows.Forms.TextBox
            {
                Location = new System.Drawing.Point(385, 60),
                Size = new System.Drawing.Size(115, 27),
                ReadOnly = true,
                TabIndex = 23
            };

            grpSummary.Controls.AddRange(new System.Windows.Forms.Control[] { 
                lblServiceAndLabor, txtServiceAndLabor, lblPartsOut, txtPartsOut, lblPartsTax, txtPartsTax, lblTotal, txtTotal 
            });

            // ===== Buttons =====
            btnCalculate = new System.Windows.Forms.Button
            {
                Text = "計算總額",
                Location = new System.Drawing.Point(80, 415),
                Size = new System.Drawing.Size(120, 40),
                TabIndex = 24
            };
            btnCalculate.Click += new System.EventHandler(btnCalculate_Click);

            btnClear = new System.Windows.Forms.Button
            {
                Text = "清除",
                Location = new System.Drawing.Point(235, 415),
                Size = new System.Drawing.Size(120, 40),
                TabIndex = 25
            };
            btnClear.Click += new System.EventHandler(btnClear_Click);

            btnExit = new System.Windows.Forms.Button
            {
                Text = "離開",
                Location = new System.Drawing.Point(390, 415),
                Size = new System.Drawing.Size(120, 40),
                TabIndex = 26
            };
            btnExit.Click += new System.EventHandler(btnExit_Click);

            // ===== Add all controls to form =====
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                grpOilAndLube, grpWash, grpOtherServices, grpPartsHours, grpSummary,
                btnCalculate, btnClear, btnExit
            });
        }
    }
}
