namespace CitiesGameByTDD
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
            components = new System.ComponentModel.Container();
            timerMove = new System.Windows.Forms.Timer(components);
            buttonEnterCity = new Button();
            textBoxCity = new TextBox();
            labelCurrentLetter = new Label();
            label1 = new Label();
            label2 = new Label();
            labelPlayer = new Label();
            buttonSurrender = new Button();
            richTextBoxUsedCities = new RichTextBox();
            label3 = new Label();
            labelMessage = new Label();
            label4 = new Label();
            labelTime = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // timerMove
            // 
            timerMove.Tick += timerMove_Tick;
            // 
            // buttonEnterCity
            // 
            buttonEnterCity.AutoSize = true;
            buttonEnterCity.Location = new Point(363, 153);
            buttonEnterCity.Name = "buttonEnterCity";
            buttonEnterCity.Size = new Size(129, 35);
            buttonEnterCity.TabIndex = 0;
            buttonEnterCity.Text = "Подтвердить";
            buttonEnterCity.UseVisualStyleBackColor = true;
            buttonEnterCity.Click += buttonEnterCity_Click;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(45, 153);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(312, 31);
            textBoxCity.TabIndex = 1;
            // 
            // labelCurrentLetter
            // 
            labelCurrentLetter.AutoSize = true;
            labelCurrentLetter.Location = new Point(439, 90);
            labelCurrentLetter.Name = "labelCurrentLetter";
            labelCurrentLetter.Size = new Size(64, 25);
            labelCurrentLetter.TabIndex = 2;
            labelCurrentLetter.Text = "БУКВА";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(290, 90);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 3;
            label1.Text = "Город на букву:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 90);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 4;
            label2.Text = "Ход игрока:";
            // 
            // labelPlayer
            // 
            labelPlayer.AutoSize = true;
            labelPlayer.Location = new Point(159, 90);
            labelPlayer.Name = "labelPlayer";
            labelPlayer.Size = new Size(67, 25);
            labelPlayer.TabIndex = 5;
            labelPlayer.Text = "ИГРОК";
            // 
            // buttonSurrender
            // 
            buttonSurrender.AutoSize = true;
            buttonSurrender.Location = new Point(200, 403);
            buttonSurrender.Name = "buttonSurrender";
            buttonSurrender.Size = new Size(129, 35);
            buttonSurrender.TabIndex = 6;
            buttonSurrender.Text = "Я сдаюсь";
            buttonSurrender.UseVisualStyleBackColor = true;
            buttonSurrender.Click += buttonSurrender_Click;
            // 
            // richTextBoxUsedCities
            // 
            richTextBoxUsedCities.Location = new Point(556, 41);
            richTextBoxUsedCities.Name = "richTextBoxUsedCities";
            richTextBoxUsedCities.Size = new Size(232, 397);
            richTextBoxUsedCities.TabIndex = 7;
            richTextBoxUsedCities.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(587, 9);
            label3.Name = "label3";
            label3.Size = new Size(167, 25);
            label3.TabIndex = 8;
            label3.Text = "Названные города";
            // 
            // labelMessage
            // 
            labelMessage.Location = new Point(45, 255);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(447, 38);
            labelMessage.TabIndex = 9;
            labelMessage.Text = "Сообщение";
            labelMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(143, 203);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 10;
            label4.Text = "Осталось";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(247, 203);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(68, 25);
            labelTime.TabIndex = 12;
            labelTime.Text = "ВРЕМЯ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(332, 203);
            label7.Name = "label7";
            label7.Size = new Size(42, 25);
            label7.TabIndex = 14;
            label7.Text = "сек.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(labelTime);
            Controls.Add(label4);
            Controls.Add(labelMessage);
            Controls.Add(label3);
            Controls.Add(richTextBoxUsedCities);
            Controls.Add(buttonSurrender);
            Controls.Add(labelPlayer);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelCurrentLetter);
            Controls.Add(textBoxCity);
            Controls.Add(buttonEnterCity);
            Name = "Form1";
            Text = "Города";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timerMove;
        private Button buttonEnterCity;
        private TextBox textBoxCity;
        private Label labelCurrentLetter;
        private Label label1;
        private Label label2;
        private Label labelPlayer;
        private Button buttonSurrender;
        private RichTextBox richTextBoxUsedCities;
        private Label label3;
        private Label labelMessage;
        private Label label4;
        private Label labelTime;
        private Label label7;
    }
}