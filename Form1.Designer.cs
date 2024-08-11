namespace FormularioContacto
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
            Enviarmensj = new Button();
            name = new Label();
            Email = new Label();
            mensj = new Label();
            NameBox = new TextBox();
            EmailBox = new TextBox();
            MensjBox = new TextBox();
            SuspendLayout();
            // 
            // Enviarmensj
            // 
            Enviarmensj.Font = new Font("SimSun", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Enviarmensj.Location = new Point(348, 290);
            Enviarmensj.Name = "Enviarmensj";
            Enviarmensj.Size = new Size(75, 23);
            Enviarmensj.TabIndex = 0;
            Enviarmensj.Text = "Enviar";
            Enviarmensj.UseVisualStyleBackColor = true;
            Enviarmensj.Click += Enviarmensj_Click;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("NSimSun", 11.25F, FontStyle.Bold);
            name.Location = new Point(112, 43);
            name.Name = "name";
            name.Size = new Size(70, 15);
            name.TabIndex = 1;
            name.Text = "Nombre:";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("NSimSun", 11.25F, FontStyle.Bold);
            Email.Location = new Point(25, 91);
            Email.Name = "Email";
            Email.Size = new Size(178, 15);
            Email.TabIndex = 2;
            Email.Text = "Correo Electronico:";
            Email.Click += label2_Click;
            // 
            // mensj
            // 
            mensj.AutoSize = true;
            mensj.Font = new Font("NSimSun", 11.25F, FontStyle.Bold);
            mensj.Location = new Point(103, 132);
            mensj.Name = "mensj";
            mensj.Size = new Size(79, 15);
            mensj.TabIndex = 3;
            mensj.Text = "Mensaje:";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(207, 43);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(200, 23);
            NameBox.TabIndex = 4;
            NameBox.TextChanged += textBox1_TextChanged;
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(207, 89);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(216, 23);
            EmailBox.TabIndex = 5;
            // 
            // MensjBox
            // 
            MensjBox.Location = new Point(207, 130);
            MensjBox.Multiline = true;
            MensjBox.Name = "MensjBox";
            MensjBox.Size = new Size(216, 134);
            MensjBox.TabIndex = 6;
            MensjBox.TextChanged += MensjBox_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 338);
            Controls.Add(MensjBox);
            Controls.Add(EmailBox);
            Controls.Add(NameBox);
            Controls.Add(mensj);
            Controls.Add(Email);
            Controls.Add(name);
            Controls.Add(Enviarmensj);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Enviarmensj;
        private Label name;
        private Label Email;
        private Label mensj;
        private TextBox NameBox;
        private TextBox EmailBox;
        private TextBox MensjBox;
    }
}
