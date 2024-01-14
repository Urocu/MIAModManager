namespace MIAModManager
{
    partial class Form1
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
            Add_Mod = new System.Windows.Forms.Button();
            Remove_Mod = new System.Windows.Forms.Button();
            Order_Up = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            listBox1 = new System.Windows.Forms.ListBox();
            textBox1 = new System.Windows.Forms.TextBox();
            Locate_Game = new System.Windows.Forms.Button();
            Start_Game = new System.Windows.Forms.Button();
            textBox2 = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // Add_Mod
            // 
            Add_Mod.Location = new System.Drawing.Point(12, 511);
            Add_Mod.Name = "Add_Mod";
            Add_Mod.Size = new System.Drawing.Size(100, 30);
            Add_Mod.TabIndex = 0;
            Add_Mod.Text = "Add";
            Add_Mod.UseVisualStyleBackColor = true;
            // 
            // Remove_Mod
            // 
            Remove_Mod.Location = new System.Drawing.Point(118, 511);
            Remove_Mod.Name = "Remove_Mod";
            Remove_Mod.Size = new System.Drawing.Size(100, 30);
            Remove_Mod.TabIndex = 1;
            Remove_Mod.Text = "Remove";
            Remove_Mod.UseVisualStyleBackColor = true;
            // 
            // Order_Up
            // 
            Order_Up.Location = new System.Drawing.Point(224, 511);
            Order_Up.Name = "Order_Up";
            Order_Up.Size = new System.Drawing.Size(100, 30);
            Order_Up.TabIndex = 2;
            Order_Up.Text = "Order up";
            Order_Up.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(330, 511);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(100, 30);
            button4.TabIndex = 3;
            button4.Text = "Order down";
            button4.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new System.Drawing.Point(12, 21);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(418, 484);
            listBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(480, 21);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(514, 381);
            textBox1.TabIndex = 5;
            textBox1.Text = "Maybe Info of selected mod here?";
            // 
            // Locate_Game
            // 
            Locate_Game.Location = new System.Drawing.Point(480, 455);
            Locate_Game.Name = "Locate_Game";
            Locate_Game.Size = new System.Drawing.Size(200, 50);
            Locate_Game.TabIndex = 6;
            Locate_Game.Text = "Locate game";
            Locate_Game.UseVisualStyleBackColor = true;
            // 
            // Start_Game
            // 
            Start_Game.Location = new System.Drawing.Point(794, 455);
            Start_Game.Name = "Start_Game";
            Start_Game.Size = new System.Drawing.Size(200, 50);
            Start_Game.TabIndex = 7;
            Start_Game.Text = "Start game";
            Start_Game.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.BackColor = System.Drawing.SystemColors.Control;
            textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox2.Location = new System.Drawing.Point(480, 511);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(200, 20);
            textBox2.TabIndex = 8;
            textBox2.Text = "Game located/not located";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1006, 553);
            Controls.Add(textBox2);
            Controls.Add(Start_Game);
            Controls.Add(Locate_Game);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(button4);
            Controls.Add(Order_Up);
            Controls.Add(Remove_Mod);
            Controls.Add(Add_Mod);
            MaximumSize = new System.Drawing.Size(1024, 600);
            MinimumSize = new System.Drawing.Size(1024, 600);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button Add_Mod;
        private System.Windows.Forms.Button Remove_Mod;
        private System.Windows.Forms.Button Order_Up;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Locate_Game;
        private System.Windows.Forms.Button Start_Game;
        private System.Windows.Forms.TextBox textBox2;
    }
}

