
namespace TopTutmaOyunu
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button buttonStart;
        private Label label1;
        private System.Windows.Forms.Timer timer1;

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

            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Form1));

            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            buttonStart = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);

            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();

            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(409, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;

            panel1.BackColor = Color.Black;
            panel1.Location = new Point(429, 817);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 37);
            panel1.TabIndex = 0;

            buttonStart.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonStart.Location = new Point(500, 433);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(186, 70);
            buttonStart.Text = "START";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;

            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(29, 25);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.Text = "Xal: 0";

            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;

            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 967);

            Controls.Add(label1);
            Controls.Add(buttonStart);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);

            KeyPreview = true;
            KeyDown += Form1_KeyDown;

            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Topu tut";

            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
