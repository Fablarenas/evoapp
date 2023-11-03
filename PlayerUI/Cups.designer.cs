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
            Grupos = new Label();
            buttonAdd = new Button();
            dataGridView1 = new DataGridView();
            buttonEdit = new Button();
            buttonDelete = new Button();
            textBoxCup = new TextBox();
            textBoxSuministro = new TextBox();
            labelName = new Label();
            labelNote = new Label();
            label1 = new Label();
            textBoxPrioridad = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBoxNote = new TextBox();
            boxAuto = new CheckBox();
            boxActTrama = new CheckBox();
            boxActHoraria = new CheckBox();
            boxActDiaria = new CheckBox();
            boxActLog = new CheckBox();
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
            Grupos.Size = new Size(78, 31);
            Grupos.TabIndex = 8;
            Grupos.Text = "Cups";
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.None;
            buttonAdd.AutoSize = true;
            buttonAdd.BackColor = Color.FromArgb(0, 123, 255);
            buttonAdd.FlatAppearance.BorderColor = Color.FromArgb(0, 123, 255);
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Image = (Image)resources.GetObject("buttonAdd.Image");
            buttonAdd.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAdd.Location = new Point(551, 211);
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
            dataGridView1.Location = new Point(12, 211);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(523, 219);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // buttonEdit
            // 
            buttonEdit.Anchor = AnchorStyles.None;
            buttonEdit.AutoSize = true;
            buttonEdit.BackColor = Color.FromArgb(0, 192, 0);
            buttonEdit.FlatAppearance.BorderColor = Color.FromArgb(0, 123, 255);
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.ForeColor = Color.White;
            buttonEdit.Image = (Image)resources.GetObject("buttonEdit.Image");
            buttonEdit.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEdit.Location = new Point(551, 280);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(126, 37);
            buttonEdit.TabIndex = 11;
            buttonEdit.Text = "Editar";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.None;
            buttonDelete.AutoSize = true;
            buttonDelete.BackColor = Color.Red;
            buttonDelete.FlatAppearance.BorderColor = Color.FromArgb(0, 123, 255);
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Image = (Image)resources.GetObject("buttonDelete.Image");
            buttonDelete.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDelete.Location = new Point(551, 345);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(126, 37);
            buttonDelete.TabIndex = 12;
            buttonDelete.Text = "Eliminar";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBoxCup
            // 
            textBoxCup.Location = new Point(112, 69);
            textBoxCup.Name = "textBoxCup";
            textBoxCup.Size = new Size(100, 20);
            textBoxCup.TabIndex = 13;
            // 
            // textBoxSuministro
            // 
            textBoxSuministro.Location = new Point(112, 96);
            textBoxSuministro.Name = "textBoxSuministro";
            textBoxSuministro.Size = new Size(100, 20);
            textBoxSuministro.TabIndex = 14;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(59, 72);
            labelName.Name = "labelName";
            labelName.Size = new Size(30, 13);
            labelName.TabIndex = 15;
            labelName.Text = "cups";
            // 
            // labelNote
            // 
            labelNote.AutoSize = true;
            labelNote.Location = new Point(40, 99);
            labelNote.Name = "labelNote";
            labelNote.Size = new Size(55, 13);
            labelNote.TabIndex = 16;
            labelNote.Text = "Suministro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 126);
            label1.Name = "label1";
            label1.Size = new Size(48, 13);
            label1.TabIndex = 18;
            label1.Text = "Prioridad";
            // 
            // textBoxPrioridad
            // 
            textBoxPrioridad.Location = new Point(112, 123);
            textBoxPrioridad.Name = "textBoxPrioridad";
            textBoxPrioridad.Size = new Size(100, 20);
            textBoxPrioridad.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(235, 126);
            label4.Name = "label4";
            label4.Size = new Size(0, 13);
            label4.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 153);
            label5.Name = "label5";
            label5.Size = new Size(30, 13);
            label5.TabIndex = 30;
            label5.Text = "Nota";
            // 
            // textBoxNote
            // 
            textBoxNote.Location = new Point(110, 149);
            textBoxNote.Name = "textBoxNote";
            textBoxNote.Size = new Size(102, 20);
            textBoxNote.TabIndex = 29;
            // 
            // boxAuto
            // 
            boxAuto.AutoSize = true;
            boxAuto.Location = new Point(428, 78);
            boxAuto.Name = "boxAuto";
            boxAuto.Size = new Size(48, 17);
            boxAuto.TabIndex = 31;
            boxAuto.Text = "Auto";
            boxAuto.UseVisualStyleBackColor = true;
            // 
            // boxActTrama
            // 
            boxActTrama.AutoSize = true;
            boxActTrama.Location = new Point(428, 147);
            boxActTrama.Name = "boxActTrama";
            boxActTrama.Size = new Size(103, 17);
            boxActTrama.TabIndex = 32;
            boxActTrama.Text = "Actividad Trama";
            boxActTrama.UseVisualStyleBackColor = true;
            // 
            // boxActHoraria
            // 
            boxActHoraria.AutoSize = true;
            boxActHoraria.Location = new Point(428, 169);
            boxActHoraria.Name = "boxActHoraria";
            boxActHoraria.Size = new Size(107, 17);
            boxActHoraria.TabIndex = 33;
            boxActHoraria.Text = "Actividad Horaria";
            boxActHoraria.UseVisualStyleBackColor = true;
            // 
            // boxActDiaria
            // 
            boxActDiaria.AutoSize = true;
            boxActDiaria.Location = new Point(428, 101);
            boxActDiaria.Name = "boxActDiaria";
            boxActDiaria.Size = new Size(100, 17);
            boxActDiaria.TabIndex = 34;
            boxActDiaria.Text = "Actividad Diaria";
            boxActDiaria.UseVisualStyleBackColor = true;
            // 
            // boxActLog
            // 
            boxActLog.Anchor = AnchorStyles.None;
            boxActLog.AutoSize = true;
            boxActLog.Location = new Point(428, 122);
            boxActLog.Name = "boxActLog";
            boxActLog.Size = new Size(91, 17);
            boxActLog.TabIndex = 35;
            boxActLog.Text = "Actividad Log";
            boxActLog.UseVisualStyleBackColor = true;
            // 
            // Cups
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(731, 436);
            Controls.Add(boxActLog);
            Controls.Add(boxActDiaria);
            Controls.Add(boxActHoraria);
            Controls.Add(boxActTrama);
            Controls.Add(boxAuto);
            Controls.Add(label5);
            Controls.Add(textBoxNote);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(textBoxPrioridad);
            Controls.Add(labelNote);
            Controls.Add(labelName);
            Controls.Add(textBoxSuministro);
            Controls.Add(textBoxCup);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(dataGridView1);
            Controls.Add(buttonAdd);
            Controls.Add(Grupos);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Cups";
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
        private TextBox textBoxCup;
        private TextBox textBoxSuministro;
        private Label labelName;
        private Label labelNote;
        private Label label1;
        private TextBox textBoxPrioridad;
        private Label label4;
        private Label label5;
        private TextBox textBoxNote;
        private CheckBox boxAuto;
        private CheckBox boxActTrama;
        private CheckBox boxActHoraria;
        private CheckBox boxActDiaria;
        private CheckBox boxActLog;
    }
}