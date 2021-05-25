
namespace dz7_2_try2
{
    partial class mainmenu
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
            this.menu_wrapper2 = new System.Windows.Forms.GroupBox();
            this.tb3 = new System.Windows.Forms.TableLayoutPanel();
            this.mainExit = new System.Windows.Forms.Button();
            this.newgame = new System.Windows.Forms.Button();
            this.menu_wrapper2.SuspendLayout();
            this.tb3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_wrapper2
            // 
            this.menu_wrapper2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu_wrapper2.Controls.Add(this.tb3);
            this.menu_wrapper2.Location = new System.Drawing.Point(12, 12);
            this.menu_wrapper2.Name = "menu_wrapper2";
            this.menu_wrapper2.Size = new System.Drawing.Size(776, 426);
            this.menu_wrapper2.TabIndex = 7;
            this.menu_wrapper2.TabStop = false;
            this.menu_wrapper2.Text = "Главное меню";
            // 
            // tb3
            // 
            this.tb3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb3.ColumnCount = 3;
            this.tb3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tb3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tb3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tb3.Controls.Add(this.mainExit, 1, 5);
            this.tb3.Controls.Add(this.newgame, 1, 1);
            this.tb3.Location = new System.Drawing.Point(6, 19);
            this.tb3.Name = "tb3";
            this.tb3.RowCount = 7;
            this.tb3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tb3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tb3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tb3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tb3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tb3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tb3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tb3.Size = new System.Drawing.Size(770, 401);
            this.tb3.TabIndex = 4;
            // 
            // mainExit
            // 
            this.mainExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainExit.Location = new System.Drawing.Point(311, 275);
            this.mainExit.Name = "mainExit";
            this.mainExit.Size = new System.Drawing.Size(148, 58);
            this.mainExit.TabIndex = 2;
            this.mainExit.Text = "Выход";
            this.mainExit.UseVisualStyleBackColor = true;
            this.mainExit.Click += new System.EventHandler(this.mainExit_Click);
            // 
            // newgame
            // 
            this.newgame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newgame.Location = new System.Drawing.Point(311, 67);
            this.newgame.Name = "newgame";
            this.newgame.Size = new System.Drawing.Size(148, 58);
            this.newgame.TabIndex = 0;
            this.newgame.Text = "Новая игра";
            this.newgame.UseVisualStyleBackColor = true;
            this.newgame.Click += new System.EventHandler(this.newgame_Click);
            // 
            // mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menu_wrapper2);
            this.Name = "mainmenu";
            this.Text = "mainmenu";
            this.menu_wrapper2.ResumeLayout(false);
            this.tb3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox menu_wrapper2;
        private System.Windows.Forms.TableLayoutPanel tb3;
        private System.Windows.Forms.Button mainExit;
        private System.Windows.Forms.Button newgame;
    }
}