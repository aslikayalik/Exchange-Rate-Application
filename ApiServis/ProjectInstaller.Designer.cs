﻿
namespace ApiServis
{
    partial class ProjectInstaller
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DovizKurServisi = new System.ServiceProcess.ServiceProcessInstaller();
            this.DovizServis = new System.ServiceProcess.ServiceInstaller();
            // 
            // DovizKurServisi
            // 
            this.DovizKurServisi.Account = System.ServiceProcess.ServiceAccount.NetworkService;
            this.DovizKurServisi.Password = null;
            this.DovizKurServisi.Username = null;
            this.DovizKurServisi.AfterInstall += new System.Configuration.Install.InstallEventHandler(this.serviceProcessInstaller1_AfterInstall);
            // 
            // DovizServis
            // 
            this.DovizServis.Description = "Doviz kur uygulaması için hazırlandı.";
            this.DovizServis.ServiceName = "Doviz Uygulaması Servisi";
            this.DovizServis.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.DovizKurServisi,
            this.DovizServis});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller DovizKurServisi;
        private System.ServiceProcess.ServiceInstaller DovizServis;
    }
}