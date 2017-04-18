namespace Cajero
{
    partial class Depositar
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
            this.txtMmonto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnDepositar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // txtMmonto
            // 
            this.txtMmonto.Depth = 0;
            this.txtMmonto.Hint = "Cantidad";
            this.txtMmonto.Location = new System.Drawing.Point(5, 74);
            this.txtMmonto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMmonto.Name = "txtMmonto";
            this.txtMmonto.PasswordChar = '\0';
            this.txtMmonto.SelectedText = "";
            this.txtMmonto.SelectionLength = 0;
            this.txtMmonto.SelectionStart = 0;
            this.txtMmonto.Size = new System.Drawing.Size(280, 23);
            this.txtMmonto.TabIndex = 1;
            this.txtMmonto.UseSystemPasswordChar = false;
            // 
            // btnDepositar
            // 
            this.btnDepositar.Depth = 0;
            this.btnDepositar.Location = new System.Drawing.Point(5, 120);
            this.btnDepositar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Primary = true;
            this.btnDepositar.Size = new System.Drawing.Size(280, 30);
            this.btnDepositar.TabIndex = 2;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(79, 9);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(136, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Deposito de dinero";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(5, 165);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(280, 30);
            this.materialRaisedButton1.TabIndex = 4;
            this.materialRaisedButton1.Text = "Cancelar";
            this.materialRaisedButton1.UseVisualStyleBackColor = false;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // Depositar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(291, 215);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.txtMmonto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Depositar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depositar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMmonto;
        private MaterialSkin.Controls.MaterialRaisedButton btnDepositar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}