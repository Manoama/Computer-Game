using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAR2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.forward = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.gas = new System.Windows.Forms.Button();
            this.brake = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // forward
            // 
            this.forward.Location = new System.Drawing.Point(201, 78);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(50, 100);
            this.forward.TabIndex = 0;
            this.forward.Text = "w";
            this.forward.UseVisualStyleBackColor = true;
            this.forward.Click += new System.EventHandler(this.forward_Click);
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(257, 184);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(100, 50);
            this.right.TabIndex = 1;
            this.right.Text = "d";
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(201, 184);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(50, 100);
            this.back.TabIndex = 2;
            this.back.Text = "s";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // gas
            // 
            this.gas.Location = new System.Drawing.Point(444, 339);
            this.gas.Name = "gas";
            this.gas.Size = new System.Drawing.Size(75, 61);
            this.gas.TabIndex = 3;
            this.gas.Text = "Gas";
            this.gas.UseVisualStyleBackColor = true;
            this.gas.Click += new System.EventHandler(this.gas_Click);
            // 
            // brake
            // 
            this.brake.Location = new System.Drawing.Point(12, 339);
            this.brake.Name = "brake";
            this.brake.Size = new System.Drawing.Size(75, 61);
            this.brake.TabIndex = 4;
            this.brake.Text = "Brake";
            this.brake.UseVisualStyleBackColor = true;
            this.brake.Click += new System.EventHandler(this.brake_Click);
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(95, 184);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(100, 50);
            this.left.TabIndex = 5;
            this.left.Text = "a";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(410, 47);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(0, 13);
            this.info.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(531, 412);
            this.Controls.Add(this.info);
            this.Controls.Add(this.left);
            this.Controls.Add(this.brake);
            this.Controls.Add(this.gas);
            this.Controls.Add(this.back);
            this.Controls.Add(this.right);
            this.Controls.Add(this.forward);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void forward_Click(object sender, EventArgs e)
        {
            info.Text = " Moving forward";
        }

        private void left_Click(object sender, EventArgs e)
        {
            info.Text = " Turn left";
        }

        private void right_Click(object sender, EventArgs e)
        {
            info.Text = " Turn right";
        }

        private void back_Click(object sender, EventArgs e)
        {
            info.Text = " Moving back";
        }

        private void brake_Click(object sender, EventArgs e)
        {
            info.Text = " Stop";
        }

        private void gas_Click(object sender, EventArgs e)
        {
            info.Text = "Gas";
        }
    }
}
