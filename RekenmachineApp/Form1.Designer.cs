namespace RekenmachineApp
{
    partial class Rekenmachine
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rekenmachine));
            tb1 = new TextBox();
            panel1 = new Panel();
            btnDiv = new Button();
            btnSub = new Button();
            ans = new Label();
            btnAdd = new Button();
            tb2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            bar = new ProgressBar();
            calcTimer = new System.Windows.Forms.Timer(components);
            info = new Button();
            panel2 = new Panel();
            extra = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tb1
            // 
            tb1.BorderStyle = BorderStyle.None;
            tb1.Dock = DockStyle.Top;
            tb1.Location = new Point(0, 60);
            tb1.Name = "tb1";
            tb1.Size = new Size(273, 24);
            tb1.TabIndex = 0;
            tb1.Text = "Kansloos";
            tb1.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDiv);
            panel1.Controls.Add(btnSub);
            panel1.Controls.Add(ans);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(tb2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tb1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 370);
            panel1.TabIndex = 1;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiv.Location = new Point(178, 288);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(70, 70);
            btnDiv.TabIndex = 7;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnSub
            // 
            btnSub.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSub.Location = new Point(102, 288);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(70, 70);
            btnSub.TabIndex = 6;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // ans
            // 
            ans.BackColor = Color.FromArgb(0, 64, 0);
            ans.ForeColor = Color.White;
            ans.Location = new Point(86, 180);
            ans.Name = "ans";
            ans.Size = new Size(100, 40);
            ans.TabIndex = 5;
            ans.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(26, 288);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 70);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tb2
            // 
            tb2.BorderStyle = BorderStyle.None;
            tb2.Dock = DockStyle.Top;
            tb2.Location = new Point(0, 144);
            tb2.Name = "tb2";
            tb2.Size = new Size(273, 24);
            tb2.TabIndex = 3;
            tb2.Text = "Kansloos";
            tb2.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 84);
            label2.Name = "label2";
            label2.Size = new Size(273, 60);
            label2.TabIndex = 2;
            label2.Text = "Getal 2:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(273, 60);
            label1.TabIndex = 1;
            label1.Text = "Getal 1:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bar
            // 
            bar.Location = new Point(306, 60);
            bar.Name = "bar";
            bar.Size = new Size(161, 34);
            bar.Step = 1;
            bar.TabIndex = 2;
            // 
            // calcTimer
            // 
            calcTimer.Interval = 10;
            calcTimer.Tick += calcTimer_Tick;
            // 
            // info
            // 
            info.Dock = DockStyle.Right;
            info.Location = new Point(307, 0);
            info.Name = "info";
            info.Size = new Size(120, 38);
            info.TabIndex = 3;
            info.Text = "Info";
            info.UseVisualStyleBackColor = true;
            info.Click += info_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(extra);
            panel2.Controls.Add(info);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(273, 332);
            panel2.Name = "panel2";
            panel2.Size = new Size(427, 38);
            panel2.TabIndex = 4;
            // 
            // extra
            // 
            extra.Dock = DockStyle.Left;
            extra.Font = new Font("Segoe UI", 9F);
            extra.Location = new Point(0, 0);
            extra.Name = "extra";
            extra.Size = new Size(120, 38);
            extra.TabIndex = 8;
            extra.Text = "Extra";
            extra.UseVisualStyleBackColor = true;
            extra.Click += extra_Click;
            // 
            // Rekenmachine
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 370);
            Controls.Add(panel2);
            Controls.Add(bar);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Rekenmachine";
            Text = "Calculator";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox tb1;
        private Panel panel1;
        private Label label1;
        private TextBox tb2;
        private Label label2;
        private ProgressBar bar;
        private Label ans;
        private Button btnAdd;
        private Button btnDiv;
        private Button btnSub;
        private System.Windows.Forms.Timer calcTimer;
        private Button info;
        private Panel panel2;
        private Button extra;
    }
}
