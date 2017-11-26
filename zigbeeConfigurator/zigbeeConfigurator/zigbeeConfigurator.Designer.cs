namespace zigbeeConfigurator
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbPorts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.grbConfigurer = new System.Windows.Forms.GroupBox();
            this.btnLireConfig = new System.Windows.Forms.Button();
            this.btnConfigurer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbDeviceName = new System.Windows.Forms.TextBox();
            this.rdbRouter = new System.Windows.Forms.RadioButton();
            this.rdbCoordinator = new System.Windows.Forms.RadioButton();
            this.txtPANID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grbTerminal = new System.Windows.Forms.GroupBox();
            this.txbTerm = new System.Windows.Forms.TextBox();
            this.grbTransmettre = new System.Windows.Forms.GroupBox();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnEnvoyer = new System.Windows.Forms.Button();
            this.txbToSend = new System.Windows.Forms.TextBox();
            this.grbConfigurer.SuspendLayout();
            this.grbTerminal.SuspendLayout();
            this.grbTransmettre.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbPorts
            // 
            this.cmbPorts.FormattingEnabled = true;
            this.cmbPorts.Location = new System.Drawing.Point(123, 12);
            this.cmbPorts.Name = "cmbPorts";
            this.cmbPorts.Size = new System.Drawing.Size(140, 24);
            this.cmbPorts.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choisir un port";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(283, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(120, 30);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Tag = "0";
            this.btnConnect.Text = "Connexion";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.ReadTimeout = 5000;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // grbConfigurer
            // 
            this.grbConfigurer.Controls.Add(this.btnLireConfig);
            this.grbConfigurer.Controls.Add(this.btnConfigurer);
            this.grbConfigurer.Controls.Add(this.label3);
            this.grbConfigurer.Controls.Add(this.txbDeviceName);
            this.grbConfigurer.Controls.Add(this.rdbRouter);
            this.grbConfigurer.Controls.Add(this.rdbCoordinator);
            this.grbConfigurer.Controls.Add(this.txtPANID);
            this.grbConfigurer.Controls.Add(this.label2);
            this.grbConfigurer.Enabled = false;
            this.grbConfigurer.Location = new System.Drawing.Point(12, 57);
            this.grbConfigurer.Name = "grbConfigurer";
            this.grbConfigurer.Size = new System.Drawing.Size(391, 249);
            this.grbConfigurer.TabIndex = 3;
            this.grbConfigurer.TabStop = false;
            this.grbConfigurer.Text = "configuration du module Zigbee";
            // 
            // btnLireConfig
            // 
            this.btnLireConfig.Location = new System.Drawing.Point(6, 197);
            this.btnLireConfig.Name = "btnLireConfig";
            this.btnLireConfig.Size = new System.Drawing.Size(160, 33);
            this.btnLireConfig.TabIndex = 7;
            this.btnLireConfig.Text = "Lire la config";
            this.btnLireConfig.UseVisualStyleBackColor = true;
            this.btnLireConfig.Click += new System.EventHandler(this.btnLireConfig_Click);
            // 
            // btnConfigurer
            // 
            this.btnConfigurer.Location = new System.Drawing.Point(226, 197);
            this.btnConfigurer.Name = "btnConfigurer";
            this.btnConfigurer.Size = new System.Drawing.Size(160, 33);
            this.btnConfigurer.TabIndex = 6;
            this.btnConfigurer.Text = "Configurer";
            this.btnConfigurer.UseVisualStyleBackColor = true;
            this.btnConfigurer.Click += new System.EventHandler(this.btnConfigurer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nom du module";
            // 
            // txbDeviceName
            // 
            this.txbDeviceName.Location = new System.Drawing.Point(42, 158);
            this.txbDeviceName.Name = "txbDeviceName";
            this.txbDeviceName.Size = new System.Drawing.Size(100, 22);
            this.txbDeviceName.TabIndex = 4;
            // 
            // rdbRouter
            // 
            this.rdbRouter.AutoSize = true;
            this.rdbRouter.Checked = true;
            this.rdbRouter.Location = new System.Drawing.Point(42, 116);
            this.rdbRouter.Name = "rdbRouter";
            this.rdbRouter.Size = new System.Drawing.Size(80, 21);
            this.rdbRouter.TabIndex = 3;
            this.rdbRouter.TabStop = true;
            this.rdbRouter.Text = "Routeur";
            this.rdbRouter.UseVisualStyleBackColor = true;
            // 
            // rdbCoordinator
            // 
            this.rdbCoordinator.AutoSize = true;
            this.rdbCoordinator.Location = new System.Drawing.Point(42, 79);
            this.rdbCoordinator.Name = "rdbCoordinator";
            this.rdbCoordinator.Size = new System.Drawing.Size(111, 21);
            this.rdbCoordinator.TabIndex = 2;
            this.rdbCoordinator.Text = "Coordinateur";
            this.rdbCoordinator.UseVisualStyleBackColor = true;
            // 
            // txtPANID
            // 
            this.txtPANID.Location = new System.Drawing.Point(42, 38);
            this.txtPANID.Name = "txtPANID";
            this.txtPANID.Size = new System.Drawing.Size(100, 22);
            this.txtPANID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "PAN ID";
            // 
            // grbTerminal
            // 
            this.grbTerminal.Controls.Add(this.txbTerm);
            this.grbTerminal.Location = new System.Drawing.Point(12, 410);
            this.grbTerminal.Name = "grbTerminal";
            this.grbTerminal.Size = new System.Drawing.Size(388, 175);
            this.grbTerminal.TabIndex = 4;
            this.grbTerminal.TabStop = false;
            this.grbTerminal.Text = "Terminal";
            // 
            // txbTerm
            // 
            this.txbTerm.BackColor = System.Drawing.SystemColors.InfoText;
            this.txbTerm.Font = new System.Drawing.Font("Courier", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTerm.ForeColor = System.Drawing.SystemColors.Info;
            this.txbTerm.Location = new System.Drawing.Point(6, 24);
            this.txbTerm.Multiline = true;
            this.txbTerm.Name = "txbTerm";
            this.txbTerm.Size = new System.Drawing.Size(376, 145);
            this.txbTerm.TabIndex = 0;
            // 
            // grbTransmettre
            // 
            this.grbTransmettre.Controls.Add(this.btnLine);
            this.grbTransmettre.Controls.Add(this.btnEnvoyer);
            this.grbTransmettre.Controls.Add(this.txbToSend);
            this.grbTransmettre.Enabled = false;
            this.grbTransmettre.Location = new System.Drawing.Point(12, 312);
            this.grbTransmettre.Name = "grbTransmettre";
            this.grbTransmettre.Size = new System.Drawing.Size(391, 92);
            this.grbTransmettre.TabIndex = 5;
            this.grbTransmettre.TabStop = false;
            this.grbTransmettre.Text = "Transmettre";
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(226, 44);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(160, 33);
            this.btnLine.TabIndex = 5;
            this.btnLine.Text = "Nouvelle Ligne";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.Location = new System.Drawing.Point(4, 44);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(159, 33);
            this.btnEnvoyer.TabIndex = 4;
            this.btnEnvoyer.Text = "Envoyer";
            this.btnEnvoyer.UseVisualStyleBackColor = true;
            this.btnEnvoyer.Click += new System.EventHandler(this.btnEnvoyer_Click);
            // 
            // txbToSend
            // 
            this.txbToSend.Location = new System.Drawing.Point(4, 16);
            this.txbToSend.Name = "txbToSend";
            this.txbToSend.Size = new System.Drawing.Size(376, 22);
            this.txbToSend.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 597);
            this.Controls.Add(this.grbTransmettre);
            this.Controls.Add(this.grbTerminal);
            this.Controls.Add(this.grbConfigurer);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPorts);
            this.Name = "Form1";
            this.Text = "zigbeeConfigurator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbConfigurer.ResumeLayout(false);
            this.grbConfigurer.PerformLayout();
            this.grbTerminal.ResumeLayout(false);
            this.grbTerminal.PerformLayout();
            this.grbTransmettre.ResumeLayout(false);
            this.grbTransmettre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPorts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox grbConfigurer;
        private System.Windows.Forms.Button btnConfigurer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbDeviceName;
        private System.Windows.Forms.RadioButton rdbRouter;
        private System.Windows.Forms.RadioButton rdbCoordinator;
        private System.Windows.Forms.TextBox txtPANID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbTerminal;
        private System.Windows.Forms.TextBox txbTerm;
        private System.Windows.Forms.GroupBox grbTransmettre;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnEnvoyer;
        private System.Windows.Forms.TextBox txbToSend;
        private System.Windows.Forms.Button btnLireConfig;
    }
}

