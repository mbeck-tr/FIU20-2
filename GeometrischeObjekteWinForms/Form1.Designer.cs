
namespace LutzundGrub.GeoObjekte.GeometrischeObjekteWinForms
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox_GeoObjekte = new System.Windows.Forms.ListBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_GeoObjectList = new System.Windows.Forms.Label();
            this.cb_ObjektArt = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(183, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 426);
            this.panel1.TabIndex = 0;
            // 
            // listBox_GeoObjekte
            // 
            this.listBox_GeoObjekte.FormattingEnabled = true;
            this.listBox_GeoObjekte.Location = new System.Drawing.Point(12, 28);
            this.listBox_GeoObjekte.Name = "listBox_GeoObjekte";
            this.listBox_GeoObjekte.Size = new System.Drawing.Size(165, 147);
            this.listBox_GeoObjekte.TabIndex = 1;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(12, 212);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(165, 23);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Hinzufügen ...";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_GeoObjectList
            // 
            this.lbl_GeoObjectList.AutoSize = true;
            this.lbl_GeoObjectList.Location = new System.Drawing.Point(13, 12);
            this.lbl_GeoObjectList.Name = "lbl_GeoObjectList";
            this.lbl_GeoObjectList.Size = new System.Drawing.Size(115, 13);
            this.lbl_GeoObjectList.TabIndex = 3;
            this.lbl_GeoObjectList.Text = "Geometrische Objekte:";
            // 
            // cb_ObjektArt
            // 
            this.cb_ObjektArt.FormattingEnabled = true;
            this.cb_ObjektArt.Location = new System.Drawing.Point(12, 185);
            this.cb_ObjektArt.Name = "cb_ObjektArt";
            this.cb_ObjektArt.Size = new System.Drawing.Size(165, 21);
            this.cb_ObjektArt.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.cb_ObjektArt);
            this.Controls.Add(this.lbl_GeoObjectList);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.listBox_GeoObjekte);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Lutz und Grub Graphics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox_GeoObjekte;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_GeoObjectList;
        private System.Windows.Forms.ComboBox cb_ObjektArt;
    }
}

