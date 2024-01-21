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
            Start_Game = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // Add_Mod
            // 
            Add_Mod.Location = new System.Drawing.Point(10, 383);
            Add_Mod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Add_Mod.Name = "Add_Mod";
            Add_Mod.Size = new System.Drawing.Size(88, 22);
            Add_Mod.TabIndex = 0;
            Add_Mod.Text = "Add";
            Add_Mod.UseVisualStyleBackColor = true;
            // 
            // Remove_Mod
            // 
            Remove_Mod.Location = new System.Drawing.Point(103, 383);
            Remove_Mod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Remove_Mod.Name = "Remove_Mod";
            Remove_Mod.Size = new System.Drawing.Size(88, 22);
            Remove_Mod.TabIndex = 1;
            Remove_Mod.Text = "Remove";
            Remove_Mod.UseVisualStyleBackColor = true;
            // 
            // Order_Up
            // 
            Order_Up.Location = new System.Drawing.Point(196, 383);
            Order_Up.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Order_Up.Name = "Order_Up";
            Order_Up.Size = new System.Drawing.Size(88, 22);
            Order_Up.TabIndex = 2;
            Order_Up.Text = "Order up";
            Order_Up.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(289, 383);
            button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(88, 22);
            button4.TabIndex = 3;
            button4.Text = "Order down";
            button4.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new System.Drawing.Point(10, 16);
            listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(366, 364);
            listBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(420, 16);
            textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(450, 287);
            textBox1.TabIndex = 5;
            textBox1.Text = "Maybe Info of selected mod here?";
            // 
            // Start_Game
            // 
            Start_Game.Location = new System.Drawing.Point(695, 341);
            Start_Game.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Start_Game.Name = "Start_Game";
            Start_Game.Size = new System.Drawing.Size(175, 38);
            Start_Game.TabIndex = 7;
            Start_Game.Text = "Start game";
            Start_Game.UseVisualStyleBackColor = true;
            Start_Game.Click += Start_Game_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(882, 421);
            Controls.Add(Start_Game);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(button4);
            Controls.Add(Order_Up);
            Controls.Add(Remove_Mod);
            Controls.Add(Add_Mod);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            MaximumSize = new System.Drawing.Size(898, 460);
            MinimumSize = new System.Drawing.Size(898, 460);
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
        private System.Windows.Forms.Button Start_Game;
    }
}

