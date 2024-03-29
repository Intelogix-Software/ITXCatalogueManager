﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CefSharp;
using ITXCatalogueManager.Forms;

namespace ITXCatalogueManager
{
    public partial class frm_main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static ITXFramework.ITXFramework ITX = new ITXFramework.ITXFramework();
        public frm_Location it = new frm_Location();
        public frm_main()
        {
            InitializeComponent();
        // This line of code is generated by Data Source Configuration Wizard
        // Fill the SqlDataSource asynchronously
            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            
            pnl_control.Controls.Remove(it);
            pnl_control.Refresh();

            //it.Show();

            ITX.cfrm_InsertForm(it, this.pnl_control);
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            bool a = true;
            if (a )
            {
                BeginInvoke(new Action(() =>
                {
                    Show();
                    //splashScreenManager1.ShowWaitForm();
                    SecureInstaller.SecureUpdate sec = new SecureInstaller.SecureUpdate(@"\\35.223.136.179\01 IT-Apps\ITXCatalogueManager");
                    sec.InstallUpdateSyncWithInfo();

                    if (ApplicationDeployment.IsNetworkDeployed)
                    {
                        Text = $"ITXCatalogueManager v{ApplicationDeployment.CurrentDeployment.CurrentVersion}!";
                        Update();
                    }

                    //splashScreenManager1.CloseWaitForm();
                }));



            }
            else
            {
                //splashScreenManager1.CloseWaitForm();
                this.Close();
            }
        }

        private void pnl_control_Resize(object sender, EventArgs e)
        {
            ITX.RefreshForms(this.pnl_control);
        }

        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
//https://www.google.com/maps/search/+36.026453%C2%B0+-102.08660%C2%B0/