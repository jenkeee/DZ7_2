
namespace dz7_2_try2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Main_menu_forms = new System.Windows.Forms.ToolStripMenuItem();
            this.takeHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.topmenubtn_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_menu_layout = new System.Windows.Forms.ToolStripMenuItem();
            this.topmenubtnPause = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.game_wrapper = new System.Windows.Forms.GroupBox();
            this.taked = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTakeAnswer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menu_wrapper = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pause_wrapper = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.game_wrapper.SuspendLayout();
            this.menu_wrapper.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pause_wrapper.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Main_menu_forms,
            this.takeHelp,
            this.topmenubtn_Exit,
            this.Main_menu_layout,
            this.topmenubtnPause});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Main_menu_forms
            // 
            this.Main_menu_forms.Name = "Main_menu_forms";
            this.Main_menu_forms.Size = new System.Drawing.Size(156, 20);
            this.Main_menu_forms.Text = "Главное меню формами";
            this.Main_menu_forms.Click += new System.EventHandler(this.Main_menu_forms_Click);
            // 
            // takeHelp
            // 
            this.takeHelp.Name = "takeHelp";
            this.takeHelp.Size = new System.Drawing.Size(76, 20);
            this.takeHelp.Text = "Подсказка";
            // 
            // topmenubtn_Exit
            // 
            this.topmenubtn_Exit.Name = "topmenubtn_Exit";
            this.topmenubtn_Exit.Size = new System.Drawing.Size(54, 20);
            this.topmenubtn_Exit.Text = "Выход";
            this.topmenubtn_Exit.Click += new System.EventHandler(this.topmenubtn_Exit_Click);
            // 
            // Main_menu_layout
            // 
            this.Main_menu_layout.Name = "Main_menu_layout";
            this.Main_menu_layout.Size = new System.Drawing.Size(144, 20);
            this.Main_menu_layout.Text = "Главное меню слоями";
            this.Main_menu_layout.Click += new System.EventHandler(this.Main_menu_layout_Click);
            // 
            // topmenubtnPause
            // 
            this.topmenubtnPause.Name = "topmenubtnPause";
            this.topmenubtnPause.Size = new System.Drawing.Size(51, 20);
            this.topmenubtnPause.Text = "Пауза";
            this.topmenubtnPause.Click += new System.EventHandler(this.topmenubtnPause_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 449);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(782, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // game_wrapper
            // 
            this.game_wrapper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.game_wrapper.Controls.Add(this.label2);
            this.game_wrapper.Controls.Add(this.taked);
            this.game_wrapper.Controls.Add(this.label4);
            this.game_wrapper.Controls.Add(this.label3);
            this.game_wrapper.Controls.Add(this.label1);
            this.game_wrapper.Controls.Add(this.btnTakeAnswer);
            this.game_wrapper.Controls.Add(this.textBox1);
            this.game_wrapper.Location = new System.Drawing.Point(12, 27);
            this.game_wrapper.Name = "game_wrapper";
            this.game_wrapper.Size = new System.Drawing.Size(758, 416);
            this.game_wrapper.TabIndex = 3;
            this.game_wrapper.TabStop = false;
            this.game_wrapper.Text = "Игра";
            // 
            // taked
            // 
            this.taked.AutoSize = true;
            this.taked.Location = new System.Drawing.Point(362, 31);
            this.taked.Name = "taked";
            this.taked.Size = new System.Drawing.Size(280, 13);
            this.taked.TabIndex = 8;
            this.taked.Text = "Сюда я хочу записывать числа которые вводил игрок";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Человек предоставил для сравнения число :\r\n";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 52);
            this.label3.TabIndex = 5;
            this.label3.Text = "В этом лабеле я укажу сколько попыток сдела игрок .\r\n и какие числа он \r\nуже ввод" +
    "ил и относительно какого числа \r\nполучаем польше или меньше\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // btnTakeAnswer
            // 
            this.btnTakeAnswer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnTakeAnswer.Enabled = false;
            this.btnTakeAnswer.Location = new System.Drawing.Point(677, 182);
            this.btnTakeAnswer.Name = "btnTakeAnswer";
            this.btnTakeAnswer.Size = new System.Drawing.Size(75, 23);
            this.btnTakeAnswer.TabIndex = 1;
            this.btnTakeAnswer.Text = "Играем";
            this.btnTakeAnswer.UseVisualStyleBackColor = true;
            this.btnTakeAnswer.Click += new System.EventHandler(this.btnTakeAnswer_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(6, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // menu_wrapper
            // 
            this.menu_wrapper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu_wrapper.Controls.Add(this.tableLayoutPanel2);
            this.menu_wrapper.Location = new System.Drawing.Point(18, 27);
            this.menu_wrapper.Name = "menu_wrapper";
            this.menu_wrapper.Size = new System.Drawing.Size(752, 416);
            this.menu_wrapper.TabIndex = 6;
            this.menu_wrapper.TabStop = false;
            this.menu_wrapper.Text = "Главное меню";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(746, 391);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(301, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(301, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 56);
            this.button2.TabIndex = 0;
            this.button2.Text = "Новая игра";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pause_wrapper
            // 
            this.pause_wrapper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pause_wrapper.Controls.Add(this.tableLayoutPanel1);
            this.pause_wrapper.Location = new System.Drawing.Point(12, 27);
            this.pause_wrapper.Name = "pause_wrapper";
            this.pause_wrapper.Size = new System.Drawing.Size(758, 416);
            this.pause_wrapper.TabIndex = 7;
            this.pause_wrapper.TabStop = false;
            this.pause_wrapper.Text = "Пауза";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.btnExit, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnNewGame, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnContinue, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(746, 391);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(301, 267);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 56);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewGame.Location = new System.Drawing.Point(301, 166);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(143, 56);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "Новая игра";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContinue.Location = new System.Drawing.Point(301, 65);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(143, 56);
            this.btnContinue.TabIndex = 1;
            this.btnContinue.Text = "Продолжить игру";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 472);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.game_wrapper);
            this.Controls.Add(this.pause_wrapper);
            this.Controls.Add(this.menu_wrapper);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.game_wrapper.ResumeLayout(false);
            this.game_wrapper.PerformLayout();
            this.menu_wrapper.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pause_wrapper.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Main_menu_forms;
        private System.Windows.Forms.ToolStripMenuItem takeHelp;
        private System.Windows.Forms.ToolStripMenuItem topmenubtn_Exit;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox game_wrapper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTakeAnswer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem Main_menu_layout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox menu_wrapper;
        private System.Windows.Forms.ToolStripMenuItem topmenubtnPause;
        private System.Windows.Forms.GroupBox pause_wrapper;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label taked;
    }
}

