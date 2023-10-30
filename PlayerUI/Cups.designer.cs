using System.Drawing;
using System.Windows.Forms;

namespace PlayerUI
{
    partial class Cups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cups));
            button5 = new Button();
            Grupos = new Label();
            buttonAdd = new Button();
            dataGridView1 = new DataGridView();
            buttonEdit = new Button();
            buttonDelete = new Button();
            textBoxName = new TextBox();
            textBoxGrade = new TextBox();
            labelName = new Label();
            labelNote = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(235, 42, 83);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.LightGray;
            button5.Location = new Point(0, 0);
            button5.Name = "button5";
            button5.Size = new Size(25, 25);
            button5.TabIndex = 7;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Grupos
            // 
            Grupos.AutoSize = true;
            Grupos.Font = new Font("Roboto", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Grupos.ForeColor = SystemColors.ControlDarkDark;
            Grupos.Location = new Point(31, 21);
            Grupos.Name = "Grupos";
            Grupos.Size = new Size(77, 33);
            Grupos.TabIndex = 8;
            Grupos.Text = "Cups";
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAdd.AutoSize = true;
            buttonAdd.BackColor = Color.FromArgb(0, 123, 255);
            buttonAdd.FlatAppearance.BorderColor = Color.FromArgb(0, 123, 255);
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Roboto", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Image = (Image)resources.GetObject("buttonAdd.Image");
            buttonAdd.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAdd.Location = new Point(524, 151);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(126, 37);
            buttonAdd.TabIndex = 9;
            buttonAdd.Text = "Nuevo Grupo";
            buttonAdd.TextAlign = ContentAlignment.MiddleRight;
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 175);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(431, 255);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // buttonEdit
            // 
            buttonEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonEdit.AutoSize = true;
            buttonEdit.BackColor = Color.FromArgb(0, 192, 0);
            buttonEdit.FlatAppearance.BorderColor = Color.FromArgb(0, 123, 255);
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Roboto", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.ForeColor = Color.White;
            buttonEdit.Image = (Image)resources.GetObject("buttonEdit.Image");
            buttonEdit.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEdit.Location = new Point(524, 205);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(126, 37);
            buttonEdit.TabIndex = 11;
            buttonEdit.Text = "Editar";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDelete.AutoSize = true;
            buttonDelete.BackColor = Color.Red;
            buttonDelete.FlatAppearance.BorderColor = Color.FromArgb(0, 123, 255);
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Roboto", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Image = (Image)resources.GetObject("buttonDelete.Image");
            buttonDelete.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDelete.Location = new Point(524, 260);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(126, 37);
            buttonDelete.TabIndex = 12;
            buttonDelete.Text = "Eliminar";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(84, 71);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 21);
            textBoxName.TabIndex = 13;
            // 
            // textBoxGrade
            // 
            textBoxGrade.Location = new Point(84, 98);
            textBoxGrade.Name = "textBoxGrade";
            textBoxGrade.Size = new Size(100, 21);
            textBoxGrade.TabIndex = 14;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(31, 74);
            labelName.Name = "labelName";
            labelName.Size = new Size(31, 13);
            labelName.TabIndex = 15;
            labelName.Text = "cups";
            // 
            // labelNote
            // 
            labelNote.AutoSize = true;
            labelNote.Location = new Point(12, 101);
            labelNote.Name = "labelNote";
            labelNote.Size = new Size(62, 13);
            labelNote.TabIndex = 16;
            labelNote.Text = "Suministro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 128);
            label1.Name = "label1";
            label1.Size = new Size(52, 13);
            label1.TabIndex = 18;
            label1.Text = "Prioridad";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(84, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 21);
            textBox1.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(207, 128);
            label4.Name = "label4";
            label4.Size = new Size(0, 13);
            label4.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(190, 78);
            label5.Name = "label5";
            label5.Size = new Size(31, 13);
            label5.TabIndex = 30;
            label5.Text = "Nota";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(227, 74);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 21);
            textBox5.TabIndex = 29;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(350, 47);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(49, 17);
            checkBox1.TabIndex = 31;
            checkBox1.Text = "Auto";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(350, 116);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(108, 17);
            checkBox2.TabIndex = 32;
            checkBox2.Text = "Actividad Trama";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(350, 138);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(112, 17);
            checkBox3.TabIndex = 33;
            checkBox3.Text = "Actividad Horaria";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(350, 70);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(104, 17);
            checkBox4.TabIndex = 34;
            checkBox4.Text = "Actividad Diaria";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(350, 93);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(93, 17);
            checkBox5.TabIndex = 35;
            checkBox5.Text = "Actividad Log";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // Cups
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(684, 431);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(labelNote);
            Controls.Add(labelName);
            Controls.Add(textBoxGrade);
            Controls.Add(textBoxName);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(dataGridView1);
            Controls.Add(buttonAdd);
            Controls.Add(Grupos);
            Controls.Add(button5);
            Font = new Font("Roboto", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Cups";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button5;
        private Label Grupos;
        private Button buttonAdd;
        private DataGridView dataGridView1;
        private Button buttonEdit;
        private Button buttonDelete;
        private TextBox textBoxName;
        private TextBox textBoxGrade;
        private Label labelName;
        private Label labelNote;
        private Label label1;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private TextBox textBox5;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
    }
}