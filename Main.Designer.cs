namespace ElGamal_Signature
{
    partial class Main
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
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.textBoxSignature = new System.Windows.Forms.TextBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonSign = new System.Windows.Forms.Button();
            this.labelSignature = new System.Windows.Forms.Label();
            this.labelDigest = new System.Windows.Forms.Label();
            this.textBoxDigest = new System.Windows.Forms.TextBox();
            this.labelY = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.buttonPrivateKey = new System.Windows.Forms.Button();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSignatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSignatureToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSignatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importPublicKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importPrivateKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportPublicKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportPrivateKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.buttonVerify = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxMessage.Location = new System.Drawing.Point(11, 58);
            this.textBoxMessage.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(523, 99);
            this.textBoxMessage.TabIndex = 0;
            // 
            // textBoxSignature
            // 
            this.textBoxSignature.BackColor = System.Drawing.Color.LightGray;
            this.textBoxSignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxSignature.Location = new System.Drawing.Point(11, 239);
            this.textBoxSignature.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSignature.Multiline = true;
            this.textBoxSignature.Name = "textBoxSignature";
            this.textBoxSignature.ReadOnly = true;
            this.textBoxSignature.Size = new System.Drawing.Size(523, 86);
            this.textBoxSignature.TabIndex = 0;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMessage.Location = new System.Drawing.Point(11, 32);
            this.labelMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(94, 24);
            this.labelMessage.TabIndex = 1;
            this.labelMessage.Text = "Message";
            // 
            // buttonSign
            // 
            this.buttonSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSign.Location = new System.Drawing.Point(538, 58);
            this.buttonSign.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(140, 45);
            this.buttonSign.TabIndex = 2;
            this.buttonSign.Text = "Sign";
            this.buttonSign.UseVisualStyleBackColor = true;
            this.buttonSign.Click += new System.EventHandler(this.signMessage);
            // 
            // labelSignature
            // 
            this.labelSignature.AutoSize = true;
            this.labelSignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSignature.Location = new System.Drawing.Point(11, 213);
            this.labelSignature.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSignature.Name = "labelSignature";
            this.labelSignature.Size = new System.Drawing.Size(99, 24);
            this.labelSignature.TabIndex = 1;
            this.labelSignature.Text = "Signature";
            // 
            // labelDigest
            // 
            this.labelDigest.AutoSize = true;
            this.labelDigest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDigest.Location = new System.Drawing.Point(11, 159);
            this.labelDigest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDigest.Name = "labelDigest";
            this.labelDigest.Size = new System.Drawing.Size(158, 24);
            this.labelDigest.TabIndex = 4;
            this.labelDigest.Text = "Message Digest";
            // 
            // textBoxDigest
            // 
            this.textBoxDigest.BackColor = System.Drawing.Color.LightGray;
            this.textBoxDigest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxDigest.Location = new System.Drawing.Point(11, 185);
            this.textBoxDigest.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDigest.Name = "textBoxDigest";
            this.textBoxDigest.ReadOnly = true;
            this.textBoxDigest.Size = new System.Drawing.Size(523, 26);
            this.textBoxDigest.TabIndex = 3;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelY.Location = new System.Drawing.Point(11, 453);
            this.labelY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(128, 24);
            this.labelY.TabIndex = 7;
            this.labelY.Text = "Public Key Y";
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelG.Location = new System.Drawing.Point(11, 392);
            this.labelG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(159, 24);
            this.labelG.TabIndex = 7;
            this.labelG.Text = "Primitive Root G";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelX.Location = new System.Drawing.Point(11, 509);
            this.labelX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(149, 24);
            this.labelX.TabIndex = 7;
            this.labelX.Text = "Private Key (X)";
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelP.Location = new System.Drawing.Point(11, 333);
            this.labelP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(161, 24);
            this.labelP.TabIndex = 7;
            this.labelP.Text = "Prime number P";
            // 
            // textBoxY
            // 
            this.textBoxY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxY.Location = new System.Drawing.Point(11, 479);
            this.textBoxY.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.ReadOnly = true;
            this.textBoxY.Size = new System.Drawing.Size(523, 26);
            this.textBoxY.TabIndex = 6;
            // 
            // textBoxG
            // 
            this.textBoxG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxG.Location = new System.Drawing.Point(11, 418);
            this.textBoxG.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.ReadOnly = true;
            this.textBoxG.Size = new System.Drawing.Size(523, 26);
            this.textBoxG.TabIndex = 6;
            // 
            // textBoxX
            // 
            this.textBoxX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxX.Location = new System.Drawing.Point(11, 535);
            this.textBoxX.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.ReadOnly = true;
            this.textBoxX.Size = new System.Drawing.Size(450, 26);
            this.textBoxX.TabIndex = 6;
            this.textBoxX.UseSystemPasswordChar = true;
            // 
            // buttonPrivateKey
            // 
            this.buttonPrivateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPrivateKey.Location = new System.Drawing.Point(465, 535);
            this.buttonPrivateKey.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrivateKey.Name = "buttonPrivateKey";
            this.buttonPrivateKey.Size = new System.Drawing.Size(69, 26);
            this.buttonPrivateKey.TabIndex = 5;
            this.buttonPrivateKey.Text = "Show";
            this.buttonPrivateKey.UseVisualStyleBackColor = true;
            this.buttonPrivateKey.Click += new System.EventHandler(this.btnPrivateKey_Click);
            // 
            // textBoxP
            // 
            this.textBoxP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxP.Location = new System.Drawing.Point(11, 359);
            this.textBoxP.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.ReadOnly = true;
            this.textBoxP.Size = new System.Drawing.Size(523, 26);
            this.textBoxP.TabIndex = 6;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(690, 32);
            this.menu.TabIndex = 8;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.openSignatureToolStripMenuItem,
            this.generateKeyToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 28);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(192, 28);
            this.openFileToolStripMenuItem.Text = "Open file";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFile);
            // 
            // openSignatureToolStripMenuItem
            // 
            this.openSignatureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSignatureToolStripMenuItem1,
            this.saveSignatureToolStripMenuItem});
            this.openSignatureToolStripMenuItem.Name = "openSignatureToolStripMenuItem";
            this.openSignatureToolStripMenuItem.Size = new System.Drawing.Size(192, 28);
            this.openSignatureToolStripMenuItem.Text = "Signature";
            // 
            // openSignatureToolStripMenuItem1
            // 
            this.openSignatureToolStripMenuItem1.Name = "openSignatureToolStripMenuItem1";
            this.openSignatureToolStripMenuItem1.Size = new System.Drawing.Size(210, 28);
            this.openSignatureToolStripMenuItem1.Text = "Open signature";
            this.openSignatureToolStripMenuItem1.Click += new System.EventHandler(this.openSignature);
            // 
            // saveSignatureToolStripMenuItem
            // 
            this.saveSignatureToolStripMenuItem.Name = "saveSignatureToolStripMenuItem";
            this.saveSignatureToolStripMenuItem.Size = new System.Drawing.Size(210, 28);
            this.saveSignatureToolStripMenuItem.Text = "Save signature";
            this.saveSignatureToolStripMenuItem.Click += new System.EventHandler(this.saveSignature);
            // 
            // generateKeyToolStripMenuItem
            // 
            this.generateKeyToolStripMenuItem.Name = "generateKeyToolStripMenuItem";
            this.generateKeyToolStripMenuItem.Size = new System.Drawing.Size(192, 28);
            this.generateKeyToolStripMenuItem.Text = "Generate key";
            this.generateKeyToolStripMenuItem.Click += new System.EventHandler(this.GenerateKey);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importPublicKeyToolStripMenuItem,
            this.importPrivateKeyToolStripMenuItem});
            this.importToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(74, 28);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // importPublicKeyToolStripMenuItem
            // 
            this.importPublicKeyToolStripMenuItem.Name = "importPublicKeyToolStripMenuItem";
            this.importPublicKeyToolStripMenuItem.Size = new System.Drawing.Size(226, 28);
            this.importPublicKeyToolStripMenuItem.Text = "Import public key";
            this.importPublicKeyToolStripMenuItem.Click += new System.EventHandler(this.importPublicKey);
            // 
            // importPrivateKeyToolStripMenuItem
            // 
            this.importPrivateKeyToolStripMenuItem.Name = "importPrivateKeyToolStripMenuItem";
            this.importPrivateKeyToolStripMenuItem.Size = new System.Drawing.Size(226, 28);
            this.importPrivateKeyToolStripMenuItem.Text = "Import private key";
            this.importPrivateKeyToolStripMenuItem.Click += new System.EventHandler(this.importPrivateKey);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportPublicKeyToolStripMenuItem,
            this.exportPrivateKeyToolStripMenuItem});
            this.exportToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(77, 28);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // exportPublicKeyToolStripMenuItem
            // 
            this.exportPublicKeyToolStripMenuItem.Name = "exportPublicKeyToolStripMenuItem";
            this.exportPublicKeyToolStripMenuItem.Size = new System.Drawing.Size(229, 28);
            this.exportPublicKeyToolStripMenuItem.Text = "Export public key";
            this.exportPublicKeyToolStripMenuItem.Click += new System.EventHandler(this.exportPublicKey);
            // 
            // exportPrivateKeyToolStripMenuItem
            // 
            this.exportPrivateKeyToolStripMenuItem.Name = "exportPrivateKeyToolStripMenuItem";
            this.exportPrivateKeyToolStripMenuItem.Size = new System.Drawing.Size(229, 28);
            this.exportPrivateKeyToolStripMenuItem.Text = "Export private key";
            this.exportPrivateKeyToolStripMenuItem.Click += new System.EventHandler(this.exportPrivateKey);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // buttonVerify
            // 
            this.buttonVerify.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonVerify.Location = new System.Drawing.Point(538, 112);
            this.buttonVerify.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(140, 45);
            this.buttonVerify.TabIndex = 9;
            this.buttonVerify.Text = "Verify";
            this.buttonVerify.UseVisualStyleBackColor = true;
            this.buttonVerify.Click += new System.EventHandler(this.verifyMessage);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(690, 572);
            this.Controls.Add(this.buttonVerify);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelG);
            this.Controls.Add(this.buttonSign);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.labelP);
            this.Controls.Add(this.textBoxG);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.buttonPrivateKey);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.labelDigest);
            this.Controls.Add(this.textBoxDigest);
            this.Controls.Add(this.textBoxSignature);
            this.Controls.Add(this.labelSignature);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(706, 611);
            this.Name = "Main";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Elgamal Signature";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.TextBox textBoxSignature;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button buttonSign;
        private System.Windows.Forms.Label labelSignature;
        private System.Windows.Forms.Label labelDigest;
        private System.Windows.Forms.TextBox textBoxDigest;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Button buttonPrivateKey;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.TextBox textBoxG;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.TextBox textBoxY;
        private MenuStrip menu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private SaveFileDialog sfd;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private OpenFileDialog ofd;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripMenuItem importPublicKeyToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem importPrivateKeyToolStripMenuItem;
        private ToolStripMenuItem exportPublicKeyToolStripMenuItem;
        private ToolStripMenuItem exportPrivateKeyToolStripMenuItem;
        private ToolStripMenuItem openSignatureToolStripMenuItem;
        private ToolStripMenuItem openSignatureToolStripMenuItem1;
        private ToolStripMenuItem saveSignatureToolStripMenuItem;
        private ToolStripMenuItem generateKeyToolStripMenuItem;
        private Button buttonVerify;
    }
}