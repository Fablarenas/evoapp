using System.Drawing;
using System.Windows.Forms;

namespace PlayerUI
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
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
            cifBox = new TextBox();
            gruposComboBox = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Grupos
            // 
            Grupos.AutoSize = true;
            Grupos.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Grupos.ForeColor = SystemColors.ControlDarkDark;
            Grupos.Location = new Point(31, 21);
            Grupos.Name = "Grupos";
            Grupos.Size = new Size(99, 31);
            Grupos.TabIndex = 8;
            Grupos.Text = "Cliente";
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAdd.AutoSize = true;
            buttonAdd.BackColor = Color.FromArgb(0, 123, 255);
            buttonAdd.FlatAppearance.BorderColor = Color.FromArgb(0, 123, 255);
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Image = (Image)resources.GetObject("buttonAdd.Image");
            buttonAdd.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAdd.Location = new Point(575, 162);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(126, 37);
            buttonAdd.TabIndex = 9;
            buttonAdd.Text = "Nuevo Cliente\r\n";
            buttonAdd.TextAlign = ContentAlignment.MiddleRight;
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 162);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(544, 255);
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
            buttonEdit.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.ForeColor = Color.White;
            buttonEdit.Image = (Image)resources.GetObject("buttonEdit.Image");
            buttonEdit.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEdit.Location = new Point(575, 215);
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
            buttonDelete.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Image = (Image)resources.GetObject("buttonDelete.Image");
            buttonDelete.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDelete.Location = new Point(575, 272);
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
            textBoxName.Size = new Size(100, 20);
            textBoxName.TabIndex = 13;
            // 
            // textBoxGrade
            // 
            textBoxGrade.Location = new Point(84, 98);
            textBoxGrade.Name = "textBoxGrade";
            textBoxGrade.Size = new Size(100, 20);
            textBoxGrade.TabIndex = 14;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(31, 74);
            labelName.Name = "labelName";
            labelName.Size = new Size(44, 13);
            labelName.TabIndex = 15;
            labelName.Text = "Nombre";
            // 
            // labelNote
            // 
            labelNote.AutoSize = true;
            labelNote.Location = new Point(37, 101);
            labelNote.Name = "labelNote";
            labelNote.Size = new Size(30, 13);
            labelNote.TabIndex = 16;
            labelNote.Text = "Nota";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 132);
            label1.Name = "label1";
            label1.Size = new Size(23, 13);
            label1.TabIndex = 17;
            label1.Text = "CIF";
            label1.Click += label1_Click;
            // 
            // cifBox
            // 
            cifBox.Location = new Point(84, 129);
            cifBox.Name = "cifBox";
            cifBox.Size = new Size(100, 20);
            cifBox.TabIndex = 18;
            // 
            // gruposComboBox
            // 
            gruposComboBox.FormattingEnabled = true;
            gruposComboBox.Location = new Point(296, 98);
            gruposComboBox.Name = "gruposComboBox";
            gruposComboBox.Size = new Size(121, 21);
            gruposComboBox.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 101);
            label2.Name = "label2";
            label2.Size = new Size(36, 13);
            label2.TabIndex = 20;
            label2.Text = "Grupo";
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(706, 431);
            Controls.Add(label2);
            Controls.Add(gruposComboBox);
            Controls.Add(cifBox);
            Controls.Add(label1);
            Controls.Add(labelNote);
            Controls.Add(labelName);
            Controls.Add(textBoxGrade);
            Controls.Add(textBoxName);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(dataGridView1);
            Controls.Add(buttonAdd);
            Controls.Add(Grupos);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Client";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private TextBox cifBox;
        private ComboBox gruposComboBox;
        private Label label2;
    }
}