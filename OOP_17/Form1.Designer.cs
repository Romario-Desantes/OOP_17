namespace OOP_17
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
            lbl_name = new Label();
            lbl_int = new Label();
            lbl_real = new Label();
            lbl_1 = new Label();
            lbl_2 = new Label();
            textBoxInt1 = new TextBox();
            textBoxInt2 = new TextBox();
            textBoxReal1 = new TextBox();
            textBoxReal2 = new TextBox();
            lblAdd = new Label();
            lblSub = new Label();
            lblMul = new Label();
            lblDiv = new Label();
            lblAddReal = new Label();
            lblSubReal = new Label();
            lblMulReal = new Label();
            lblDivReal = new Label();
            btnInt = new Button();
            btnReal = new Button();
            SuspendLayout();
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbl_name.Location = new Point(296, 23);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(113, 38);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "Числа";
            // 
            // lbl_int
            // 
            lbl_int.AutoSize = true;
            lbl_int.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbl_int.Location = new Point(73, 91);
            lbl_int.Name = "lbl_int";
            lbl_int.Size = new Size(149, 32);
            lbl_int.TabIndex = 1;
            lbl_int.Text = "Цілі числа";
            // 
            // lbl_real
            // 
            lbl_real.AutoSize = true;
            lbl_real.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbl_real.Location = new Point(473, 91);
            lbl_real.Name = "lbl_real";
            lbl_real.Size = new Size(174, 32);
            lbl_real.TabIndex = 2;
            lbl_real.Text = "Дійсні числа";
            // 
            // lbl_1
            // 
            lbl_1.AutoSize = true;
            lbl_1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbl_1.Location = new Point(12, 132);
            lbl_1.Name = "lbl_1";
            lbl_1.Size = new Size(287, 22);
            lbl_1.TabIndex = 3;
            lbl_1.Text = "Введіть числа у вівдведені поля:";
            // 
            // lbl_2
            // 
            lbl_2.AutoSize = true;
            lbl_2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbl_2.Location = new Point(418, 132);
            lbl_2.Name = "lbl_2";
            lbl_2.Size = new Size(287, 22);
            lbl_2.TabIndex = 4;
            lbl_2.Text = "Введіть числа у вівдведені поля:";
            // 
            // textBoxInt1
            // 
            textBoxInt1.Location = new Point(53, 170);
            textBoxInt1.Name = "textBoxInt1";
            textBoxInt1.Size = new Size(71, 27);
            textBoxInt1.TabIndex = 5;
            // 
            // textBoxInt2
            // 
            textBoxInt2.Location = new Point(179, 170);
            textBoxInt2.Name = "textBoxInt2";
            textBoxInt2.Size = new Size(71, 27);
            textBoxInt2.TabIndex = 6;
            // 
            // textBoxReal1
            // 
            textBoxReal1.Location = new Point(453, 170);
            textBoxReal1.Name = "textBoxReal1";
            textBoxReal1.Size = new Size(71, 27);
            textBoxReal1.TabIndex = 7;
            // 
            // textBoxReal2
            // 
            textBoxReal2.Location = new Point(576, 170);
            textBoxReal2.Name = "textBoxReal2";
            textBoxReal2.Size = new Size(71, 27);
            textBoxReal2.TabIndex = 8;
            // 
            // lblAdd
            // 
            lblAdd.AutoSize = true;
            lblAdd.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblAdd.Location = new Point(12, 221);
            lblAdd.Name = "lblAdd";
            lblAdd.Size = new Size(71, 26);
            lblAdd.TabIndex = 9;
            lblAdd.Text = "Сума:";
            // 
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblSub.Location = new Point(12, 258);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(95, 26);
            lblSub.TabIndex = 10;
            lblSub.Text = "Різниця:";
            // 
            // lblMul
            // 
            lblMul.AutoSize = true;
            lblMul.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblMul.Location = new Point(12, 295);
            lblMul.Name = "lblMul";
            lblMul.Size = new Size(109, 26);
            lblMul.TabIndex = 11;
            lblMul.Text = "Добуток:";
            // 
            // lblDiv
            // 
            lblDiv.AutoSize = true;
            lblDiv.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblDiv.Location = new Point(12, 331);
            lblDiv.Name = "lblDiv";
            lblDiv.Size = new Size(97, 26);
            lblDiv.TabIndex = 12;
            lblDiv.Text = "Частка:";
            // 
            // lblAddReal
            // 
            lblAddReal.AutoSize = true;
            lblAddReal.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblAddReal.Location = new Point(418, 221);
            lblAddReal.Name = "lblAddReal";
            lblAddReal.Size = new Size(71, 26);
            lblAddReal.TabIndex = 13;
            lblAddReal.Text = "Сума:";
            // 
            // lblSubReal
            // 
            lblSubReal.AutoSize = true;
            lblSubReal.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblSubReal.Location = new Point(418, 258);
            lblSubReal.Name = "lblSubReal";
            lblSubReal.Size = new Size(95, 26);
            lblSubReal.TabIndex = 14;
            lblSubReal.Text = "Різниця:";
            // 
            // lblMulReal
            // 
            lblMulReal.AutoSize = true;
            lblMulReal.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblMulReal.Location = new Point(418, 295);
            lblMulReal.Name = "lblMulReal";
            lblMulReal.Size = new Size(109, 26);
            lblMulReal.TabIndex = 15;
            lblMulReal.Text = "Добуток:";
            // 
            // lblDivReal
            // 
            lblDivReal.AutoSize = true;
            lblDivReal.Font = new Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            lblDivReal.Location = new Point(418, 331);
            lblDivReal.Name = "lblDivReal";
            lblDivReal.Size = new Size(97, 26);
            lblDivReal.TabIndex = 16;
            lblDivReal.Text = "Частка:";
            // 
            // btnInt
            // 
            btnInt.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnInt.Location = new Point(73, 385);
            btnInt.Name = "btnInt";
            btnInt.Size = new Size(149, 56);
            btnInt.TabIndex = 17;
            btnInt.Text = "Порахувати";
            btnInt.UseVisualStyleBackColor = true;
            btnInt.Click += btnInt_Click;
            // 
            // btnReal
            // 
            btnReal.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnReal.Location = new Point(483, 385);
            btnReal.Name = "btnReal";
            btnReal.Size = new Size(149, 56);
            btnReal.TabIndex = 18;
            btnReal.Text = "Порахувати";
            btnReal.UseVisualStyleBackColor = true;
            btnReal.Click += btnReal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 485);
            Controls.Add(btnReal);
            Controls.Add(btnInt);
            Controls.Add(lblDivReal);
            Controls.Add(lblMulReal);
            Controls.Add(lblSubReal);
            Controls.Add(lblAddReal);
            Controls.Add(lblDiv);
            Controls.Add(lblMul);
            Controls.Add(lblSub);
            Controls.Add(lblAdd);
            Controls.Add(textBoxReal2);
            Controls.Add(textBoxReal1);
            Controls.Add(textBoxInt2);
            Controls.Add(textBoxInt1);
            Controls.Add(lbl_2);
            Controls.Add(lbl_1);
            Controls.Add(lbl_real);
            Controls.Add(lbl_int);
            Controls.Add(lbl_name);
            Name = "Form1";
            ShowIcon = false;
            Text = "OOP 17";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_name;
        private Label lbl_int;
        private Label lbl_real;
        private Label lbl_1;
        private Label lbl_2;
        private TextBox textBoxInt1;
        private TextBox textBoxInt2;
        private TextBox textBoxReal1;
        private TextBox textBoxReal2;
        private Label lblAdd;
        private Label lblSub;
        private Label lblMul;
        private Label lblDiv;
        private Label lblAddReal;
        private Label lblSubReal;
        private Label lblMulReal;
        private Label lblDivReal;
        private Button btnInt;
        private Button btnReal;
    }
}
