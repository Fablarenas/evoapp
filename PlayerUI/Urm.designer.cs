using System.Drawing;
using System.Windows.Forms;

namespace PlayerUI
{
    partial class Urm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Urm));
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
            Grupos.Size = new Size(66, 33);
            Grupos.TabIndex = 8;
            Grupos.Text = "Urm";
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
            dataGridView1.Location = new Point(12, 164);
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
            labelName.Size = new Size(47, 13);
            labelName.TabIndex = 15;
            labelName.Text = "Nombre";
            // 
            // labelNote
            // 
            labelNote.AutoSize = true;
            labelNote.Location = new Point(37, 101);
            labelNote.Name = "labelNote";
            labelNote.Size = new Size(31, 13);
            labelNote.TabIndex = 16;
            labelNote.Text = "Nota";
            // 
            // Urm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(684, 431);
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
            Name = "Urm";
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
    }
}