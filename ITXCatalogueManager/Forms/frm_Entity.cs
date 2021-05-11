﻿using DevExpress.XtraEditors;
using ITXCatalogueManager.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITXCatalogueManager.Forms
{
    public partial class frm_Entity : DevExpress.XtraEditors.XtraForm
    {


        public string lat;
        public string lon;
        public string urlb;
        public frm_Entity()
        {
            InitializeComponent();
            //lat = "+36.026453";
            //lon = "-102.08660";
            //urlb = "https://www.google.com/maps/@" + lat + "," + lon + ",17.75z";
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously

            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            SDS_Entities.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
      
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            SDS_Cities.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            SDS_entitiesGrid.FillAsync();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            SDS_States.FillAsync();
        }

        public string dourl(string lat, string lon)
        {
            return "https://www.google.com/maps/@" + lat + "," + lon + ",17.75z/data=!3m1!1e3";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            NewEntity ne = new NewEntity();
            ne.Id_Entity = Guid.Empty;
            ne.Id_City = (Guid)lue_City.EditValue;
            ne.Id_EntityType = (Guid)lue_entityType.EditValue;
            ne.Latitude = (float)Convert.ToDecimal( edt_Lat.Text.ToString().Trim());
            ne.Longitude = (float)Convert.ToDecimal(edt_Lon.Text.ToString().Trim());
            ne.description = edt_Description.Text;
            ne.URL = edt_URL.Text;
            ne.code = edt_code.Text;
            ne.Status = true;
            SQLCon.SQLCon con = new SQLCon.SQLCon();
            con.sendNewEntity(ne);

        }

        private void lue_state_EditValueChanged(object sender, EventArgs e)
        {
            SDS_Cities.ClearRows();
            DevExpress.DataAccess.Sql.QueryParameter qp = new DevExpress.DataAccess.Sql.QueryParameter();
            qp.Name = "@ID_state";
            qp.Type = typeof(Guid);
            qp.Value = lue_state.EditValue;
            SDS_Cities.Queries[0].Parameters.Clear();
            SDS_Cities.Queries[0].Parameters.Add(qp);
            SDS_Cities.Fill();
            lue_City.Text = null;
        }

        private void edt_Log_EditValueChanged(object sender, EventArgs e)
        {
            edt_URL.Text = dourl(edt_Lat.Text,edt_Lon.Text);
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(edt_URL.Text);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SDS_entitiesGrid.Fill();
        }

        private void edt_Description_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}