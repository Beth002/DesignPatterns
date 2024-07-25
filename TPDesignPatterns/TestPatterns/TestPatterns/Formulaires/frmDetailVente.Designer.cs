namespace TestPatterns.Formulaires
{
    partial class frmDetailVente
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
            this.label4 = new System.Windows.Forms.Label();
            this.cbProduit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listeProduit = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPu = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pu_vente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listeProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(626, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 29);
            this.label4.TabIndex = 55;
            this.label4.Text = "Produit";
            // 
            // cbProduit
            // 
            this.cbProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProduit.FormattingEnabled = true;
            this.cbProduit.Location = new System.Drawing.Point(631, 117);
            this.cbProduit.Name = "cbProduit";
            this.cbProduit.Size = new System.Drawing.Size(335, 33);
            this.cbProduit.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 29);
            this.label3.TabIndex = 53;
            this.label3.Text = "QTE";
            // 
            // txtQte
            // 
            this.txtQte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQte.Location = new System.Drawing.Point(186, 207);
            this.txtQte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(391, 35);
            this.txtQte.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 51;
            this.label1.Text = "DETAIL VENTE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(190, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 29);
            this.label5.TabIndex = 50;
            this.label5.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(186, 117);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(391, 35);
            this.txtId.TabIndex = 49;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(758, 349);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(208, 41);
            this.button4.TabIndex = 48;
            this.button4.Text = "Supprimer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(527, 349);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 41);
            this.button3.TabIndex = 47;
            this.button3.Text = "Modifier";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(297, 349);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 41);
            this.button2.TabIndex = 46;
            this.button2.Text = "Enregistrer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(62, 349);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 41);
            this.button1.TabIndex = 45;
            this.button1.Text = "Actualiser";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listeProduit
            // 
            this.listeProduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listeProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.refProduit,
            this.qte,
            this.pu_vente,
            this.pt});
            this.listeProduit.Location = new System.Drawing.Point(30, 414);
            this.listeProduit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listeProduit.Name = "listeProduit";
            this.listeProduit.RowTemplate.Height = 24;
            this.listeProduit.Size = new System.Drawing.Size(979, 220);
            this.listeProduit.TabIndex = 44;
            this.listeProduit.DoubleClick += new System.EventHandler(this.listeProduit_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 29);
            this.label2.TabIndex = 57;
            this.label2.Text = "P.U";
            // 
            // txtPu
            // 
            this.txtPu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPu.Location = new System.Drawing.Point(186, 296);
            this.txtPu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPu.Name = "txtPu";
            this.txtPu.Size = new System.Drawing.Size(391, 35);
            this.txtPu.TabIndex = 56;
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Identifiant";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // refProduit
            // 
            this.refProduit.DataPropertyName = "produit";
            this.refProduit.HeaderText = "PRODUIT";
            this.refProduit.Name = "refProduit";
            // 
            // qte
            // 
            this.qte.DataPropertyName = "qte";
            this.qte.HeaderText = "QUANTITE";
            this.qte.Name = "qte";
            // 
            // pu_vente
            // 
            this.pu_vente.DataPropertyName = "pu_vente";
            this.pu_vente.HeaderText = "P.U";
            this.pu_vente.Name = "pu_vente";
            // 
            // pt
            // 
            this.pt.DataPropertyName = "total";
            this.pt.HeaderText = "PRIX TOTAL";
            this.pt.Name = "pt";
            // 
            // frmDetailVente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1041, 651);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbProduit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listeProduit);
            this.Name = "frmDetailVente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetailVente";
            this.Load += new System.EventHandler(this.frmDetailVente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listeProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbProduit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView listeProduit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPu;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn refProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn qte;
        private System.Windows.Forms.DataGridViewTextBoxColumn pu_vente;
        private System.Windows.Forms.DataGridViewTextBoxColumn pt;
    }
}