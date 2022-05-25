
namespace RAVEL
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.FichasRavel = new System.Windows.Forms.TableLayoutPanel();
            this.picReiniciar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.PicGanador = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblplayer1 = new System.Windows.Forms.Label();
            this.lblplayer2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicGanador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // FichasRavel
            // 
            this.FichasRavel.ColumnCount = 3;
            this.FichasRavel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.9685F));
            this.FichasRavel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.0315F));
            this.FichasRavel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.FichasRavel.Location = new System.Drawing.Point(76, 88);
            this.FichasRavel.Name = "FichasRavel";
            this.FichasRavel.RowCount = 3;
            this.FichasRavel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FichasRavel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FichasRavel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.FichasRavel.Size = new System.Drawing.Size(180, 180);
            this.FichasRavel.TabIndex = 0;
            // 
            // picReiniciar
            // 
            this.picReiniciar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picReiniciar.BackgroundImage")));
            this.picReiniciar.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picReiniciar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.picReiniciar.Location = new System.Drawing.Point(76, 274);
            this.picReiniciar.Name = "picReiniciar";
            this.picReiniciar.Size = new System.Drawing.Size(180, 40);
            this.picReiniciar.TabIndex = 1;
            this.picReiniciar.Text = "reiniciar";
            this.picReiniciar.UseVisualStyleBackColor = true;
            this.picReiniciar.Click += new System.EventHandler(this.picReiniciar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RAVEL.Properties.Resources.f_2_whith_marco;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(670, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(625, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "VS";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Beige;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Unispace", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 46);
            this.button2.TabIndex = 8;
            this.button2.Text = "<--";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PicGanador
            // 
            this.PicGanador.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PicGanador.BackgroundImage = global::RAVEL.Properties.Resources.f_11;
            this.PicGanador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicGanador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicGanador.Location = new System.Drawing.Point(645, 161);
            this.PicGanador.Name = "PicGanador";
            this.PicGanador.Size = new System.Drawing.Size(120, 120);
            this.PicGanador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicGanador.TabIndex = 9;
            this.PicGanador.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(661, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "ganador";
            // 
            // lblplayer1
            // 
            this.lblplayer1.AutoSize = true;
            this.lblplayer1.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayer1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblplayer1.Image = ((System.Drawing.Image)(resources.GetObject("lblplayer1.Image")));
            this.lblplayer1.Location = new System.Drawing.Point(560, 125);
            this.lblplayer1.Name = "lblplayer1";
            this.lblplayer1.Size = new System.Drawing.Size(22, 23);
            this.lblplayer1.TabIndex = 11;
            this.lblplayer1.Text = "0";
            // 
            // lblplayer2
            // 
            this.lblplayer2.AutoSize = true;
            this.lblplayer2.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayer2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblplayer2.Image = ((System.Drawing.Image)(resources.GetObject("lblplayer2.Image")));
            this.lblplayer2.Location = new System.Drawing.Point(707, 125);
            this.lblplayer2.Name = "lblplayer2";
            this.lblplayer2.Size = new System.Drawing.Size(22, 23);
            this.lblplayer2.TabIndex = 12;
            this.lblplayer2.Text = "0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::RAVEL.Properties.Resources.f_1_whith_marco;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(524, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(95, 95);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(804, 431);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblplayer2);
            this.Controls.Add(this.lblplayer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PicGanador);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picReiniciar);
            this.Controls.Add(this.FichasRavel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "RAVEL 1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicGanador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel FichasRavel;
        private System.Windows.Forms.Button picReiniciar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox PicGanador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblplayer1;
        private System.Windows.Forms.Label lblplayer2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}