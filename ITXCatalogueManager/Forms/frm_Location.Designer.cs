
namespace ITXCatalogueManager.Forms
{
    partial class frm_Location
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
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Location));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery3 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery4 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule6 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule7 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule8 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule9 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule12 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule11 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule10 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.list_EntityTypesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SDS_Entities = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.list_CitiesByStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SDS_Cities = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.list_StatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SDS_States = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.SDS_entitiesGrid = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.lookUpEdit3 = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEdit4 = new DevExpress.XtraEditors.LookUpEdit();
            this.gridLookUpEdit2 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpEdit9 = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEdit10 = new DevExpress.XtraEditors.LookUpEdit();
            this.gridLookUpEdit5 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView9 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn29 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpEdit11 = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEdit12 = new DevExpress.XtraEditors.LookUpEdit();
            this.gridLookUpEdit6 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView11 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn38 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splashScreenManager2 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ITXCatalogueManager.Forms.WaitForm1), true, true);
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl7 = new DevExpress.XtraEditors.SplitContainerControl();
            this.panelControl9 = new DevExpress.XtraEditors.PanelControl();
            this.splitContainerControl8 = new DevExpress.XtraEditors.SplitContainerControl();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit8 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit9 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit10 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit11 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit12 = new DevExpress.XtraEditors.TextEdit();
            this.panelControl10 = new DevExpress.XtraEditors.PanelControl();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelControl11 = new DevExpress.XtraEditors.PanelControl();
            this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage10 = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl15 = new DevExpress.XtraEditors.SplitContainerControl();
            this.panelControl20 = new DevExpress.XtraEditors.PanelControl();
            this.splitContainerControl16 = new DevExpress.XtraEditors.SplitContainerControl();
            this.simpleButton17 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton18 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton19 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.textEdit25 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit26 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit27 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit28 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit29 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit30 = new DevExpress.XtraEditors.TextEdit();
            this.panelControl21 = new DevExpress.XtraEditors.PanelControl();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panelControl22 = new DevExpress.XtraEditors.PanelControl();
            this.chromiumWebBrowser5 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.webBrowser5 = new System.Windows.Forms.WebBrowser();
            this.xtraTabPage11 = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl17 = new DevExpress.XtraEditors.SplitContainerControl();
            this.simpleButton20 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl23 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl5 = new DevExpress.XtraGrid.GridControl();
            this.gridView10 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn30 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn31 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn32 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn33 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn34 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn35 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn36 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn37 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabControl6 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage12 = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl18 = new DevExpress.XtraEditors.SplitContainerControl();
            this.panelControl24 = new DevExpress.XtraEditors.PanelControl();
            this.splitContainerControl19 = new DevExpress.XtraEditors.SplitContainerControl();
            this.simpleButton21 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton22 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton23 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.textEdit31 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit32 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit33 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit34 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit35 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit36 = new DevExpress.XtraEditors.TextEdit();
            this.panelControl25 = new DevExpress.XtraEditors.PanelControl();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panelControl26 = new DevExpress.XtraEditors.PanelControl();
            this.xtraTabControl5 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLatitude = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLongitude = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCoords = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colURL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZIPCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.splitContainerControl3 = new DevExpress.XtraEditors.SplitContainerControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edt_URL = new DevExpress.XtraEditors.TextEdit();
            this.edt_Lon = new DevExpress.XtraEditors.TextEdit();
            this.edt_Lat = new DevExpress.XtraEditors.TextEdit();
            this.edt_Description = new DevExpress.XtraEditors.TextEdit();
            this.edt_zip = new DevExpress.XtraEditors.TextEdit();
            this.edt_address = new DevExpress.XtraEditors.TextEdit();
            this.MetaData = new System.Windows.Forms.GroupBox();
            this.lue_state = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.States = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lue_City = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lue_locationType = new DevExpress.XtraEditors.LookUpEdit();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_refresh = new DevExpress.XtraEditors.SimpleButton();
            this.btn_preview = new DevExpress.XtraEditors.SimpleButton();
            this.XTP1 = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.list_EntityTypesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_CitiesByStateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_StatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit10.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit11.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit12.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl7.Panel1)).BeginInit();
            this.splitContainerControl7.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl7.Panel2)).BeginInit();
            this.splitContainerControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl9)).BeginInit();
            this.panelControl9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl8.Panel1)).BeginInit();
            this.splitContainerControl8.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl8.Panel2)).BeginInit();
            this.splitContainerControl8.Panel2.SuspendLayout();
            this.splitContainerControl8.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit10.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit11.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit12.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl10)).BeginInit();
            this.panelControl10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
            this.xtraTabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl15.Panel1)).BeginInit();
            this.splitContainerControl15.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl15.Panel2)).BeginInit();
            this.splitContainerControl15.Panel2.SuspendLayout();
            this.splitContainerControl15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl20)).BeginInit();
            this.panelControl20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl16.Panel1)).BeginInit();
            this.splitContainerControl16.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl16.Panel2)).BeginInit();
            this.splitContainerControl16.Panel2.SuspendLayout();
            this.splitContainerControl16.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit25.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit26.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit27.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit28.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit29.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit30.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl21)).BeginInit();
            this.panelControl21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl22)).BeginInit();
            this.panelControl22.SuspendLayout();
            this.xtraTabPage11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl17.Panel1)).BeginInit();
            this.splitContainerControl17.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl17.Panel2)).BeginInit();
            this.splitContainerControl17.Panel2.SuspendLayout();
            this.splitContainerControl17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl23)).BeginInit();
            this.panelControl23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl18.Panel1)).BeginInit();
            this.splitContainerControl18.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl18.Panel2)).BeginInit();
            this.splitContainerControl18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl24)).BeginInit();
            this.panelControl24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl19.Panel1)).BeginInit();
            this.splitContainerControl19.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl19.Panel2)).BeginInit();
            this.splitContainerControl19.Panel2.SuspendLayout();
            this.splitContainerControl19.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit31.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit32.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit33.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit34.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit35.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit36.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl25)).BeginInit();
            this.panelControl25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl5)).BeginInit();
            this.xtraTabControl5.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel1)).BeginInit();
            this.splitContainerControl2.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel2)).BeginInit();
            this.splitContainerControl2.Panel2.SuspendLayout();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3.Panel1)).BeginInit();
            this.splitContainerControl3.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3.Panel2)).BeginInit();
            this.splitContainerControl3.Panel2.SuspendLayout();
            this.splitContainerControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_URL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_Lon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_Lat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_Description.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_zip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_address.Properties)).BeginInit();
            this.MetaData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lue_state.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_City.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_locationType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XTP1)).BeginInit();
            this.XTP1.SuspendLayout();
            this.SuspendLayout();
            // 
            // list_EntityTypesBindingSource1
            // 
            this.list_EntityTypesBindingSource1.DataMember = "List_EntityTypes";
            this.list_EntityTypesBindingSource1.DataSource = this.SDS_Entities;
            // 
            // SDS_Entities
            // 
            this.SDS_Entities.ConnectionName = "_Global_Connection";
            this.SDS_Entities.Name = "SDS_Entities";
            storedProcQuery1.Name = "List_EntityTypes";
            storedProcQuery1.StoredProcName = "List_LocationsTypes";
            this.SDS_Entities.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.SDS_Entities.ResultSchemaSerializable = resources.GetString("SDS_Entities.ResultSchemaSerializable");
            // 
            // list_CitiesByStateBindingSource
            // 
            this.list_CitiesByStateBindingSource.DataMember = "List_CitiesByState";
            this.list_CitiesByStateBindingSource.DataSource = this.SDS_Cities;
            // 
            // SDS_Cities
            // 
            this.SDS_Cities.ConnectionName = "_Global_Connection";
            this.SDS_Cities.Name = "SDS_Cities";
            storedProcQuery2.Name = "List_CitiesByState";
            queryParameter1.Name = "@ID_State";
            queryParameter1.Type = typeof(System.Guid);
            queryParameter1.ValueInfo = "8da2086e-0f15-424f-9f17-c9b60dbcfd7b";
            storedProcQuery2.Parameters.Add(queryParameter1);
            storedProcQuery2.StoredProcName = "List_CitiesByState";
            this.SDS_Cities.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery2});
            this.SDS_Cities.ResultSchemaSerializable = resources.GetString("SDS_Cities.ResultSchemaSerializable");
            // 
            // list_StatesBindingSource
            // 
            this.list_StatesBindingSource.DataMember = "List_States";
            this.list_StatesBindingSource.DataSource = this.SDS_States;
            // 
            // SDS_States
            // 
            this.SDS_States.ConnectionName = "_Global_Connection";
            this.SDS_States.Name = "SDS_States";
            storedProcQuery3.Name = "List_States";
            queryParameter2.Name = "@ID_Country";
            queryParameter2.Type = typeof(System.Guid);
            queryParameter2.ValueInfo = "00000000-0000-0000-0000-000000000000";
            storedProcQuery3.Parameters.Add(queryParameter2);
            storedProcQuery3.StoredProcName = "List_States";
            this.SDS_States.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery3});
            this.SDS_States.ResultSchemaSerializable = resources.GetString("SDS_States.ResultSchemaSerializable");
            // 
            // SDS_entitiesGrid
            // 
            this.SDS_entitiesGrid.ConnectionName = "_Global_Connection";
            this.SDS_entitiesGrid.Name = "SDS_entitiesGrid";
            storedProcQuery4.Name = "List_Entities";
            queryParameter3.Name = "@ID_City";
            queryParameter3.Type = typeof(System.Guid);
            queryParameter3.ValueInfo = "00000000-0000-0000-0000-000000000000";
            storedProcQuery4.Parameters.Add(queryParameter3);
            storedProcQuery4.StoredProcName = "List_LocationsBycity";
            this.SDS_entitiesGrid.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery4});
            this.SDS_entitiesGrid.ResultSchemaSerializable = resources.GetString("SDS_entitiesGrid.ResultSchemaSerializable");
            // 
            // lookUpEdit3
            // 
            this.lookUpEdit3.Location = new System.Drawing.Point(6, 40);
            this.lookUpEdit3.Name = "lookUpEdit3";
            this.lookUpEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit3.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_EntityType", "ID_Entity Type", 81, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEdit3.Properties.DataSource = this.list_EntityTypesBindingSource1;
            this.lookUpEdit3.Properties.DisplayMember = "Description";
            this.lookUpEdit3.Properties.NullText = "";
            this.lookUpEdit3.Properties.NullValuePrompt = "Entity Type";
            this.lookUpEdit3.Properties.PopupFormMinSize = new System.Drawing.Size(119, 0);
            this.lookUpEdit3.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth;
            this.lookUpEdit3.Properties.ValueMember = "ID_LocationType";
            this.lookUpEdit3.Size = new System.Drawing.Size(244, 20);
            this.lookUpEdit3.TabIndex = 1;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxValidationProvider1.SetValidationRule(this.lookUpEdit3, conditionValidationRule1);
            // 
            // lookUpEdit4
            // 
            this.lookUpEdit4.Location = new System.Drawing.Point(128, 88);
            this.lookUpEdit4.Name = "lookUpEdit4";
            this.lookUpEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit4.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_City", "ID_City", 45, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Cities", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_State", "ID_State", 52, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description_1", "Description_1", 74, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEdit4.Properties.DataSource = this.list_CitiesByStateBindingSource;
            this.lookUpEdit4.Properties.DisplayMember = "Description";
            this.lookUpEdit4.Properties.NullText = "";
            this.lookUpEdit4.Properties.NullValuePrompt = "City";
            this.lookUpEdit4.Properties.PopupFormMinSize = new System.Drawing.Size(119, 0);
            this.lookUpEdit4.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth;
            this.lookUpEdit4.Properties.ValueMember = "ID_City";
            this.lookUpEdit4.Size = new System.Drawing.Size(119, 20);
            this.lookUpEdit4.TabIndex = 3;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Need to select a value";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxValidationProvider1.SetValidationRule(this.lookUpEdit4, conditionValidationRule2);
            // 
            // gridLookUpEdit2
            // 
            this.gridLookUpEdit2.Location = new System.Drawing.Point(6, 88);
            this.gridLookUpEdit2.Name = "gridLookUpEdit2";
            this.gridLookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit2.Properties.DataSource = this.list_StatesBindingSource;
            this.gridLookUpEdit2.Properties.DisplayMember = "Description_1";
            this.gridLookUpEdit2.Properties.NullText = "";
            this.gridLookUpEdit2.Properties.NullValuePrompt = "State";
            this.gridLookUpEdit2.Properties.PopupFormSize = new System.Drawing.Size(100, 0);
            this.gridLookUpEdit2.Properties.PopupView = this.gridView4;
            this.gridLookUpEdit2.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth;
            this.gridLookUpEdit2.Properties.ValueMember = "ID_State_1";
            this.gridLookUpEdit2.Size = new System.Drawing.Size(119, 20);
            this.gridLookUpEdit2.TabIndex = 2;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.gridLookUpEdit2, conditionValidationRule3);
            this.gridLookUpEdit2.EditValueChanged += new System.EventHandler(this.lue_state_EditValueChanged);
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn10});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn10
            // 
            this.gridColumn10.FieldName = "Description_1";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 0;
            // 
            // lookUpEdit9
            // 
            this.lookUpEdit9.Location = new System.Drawing.Point(6, 40);
            this.lookUpEdit9.Name = "lookUpEdit9";
            this.lookUpEdit9.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit9.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_EntityType", "ID_Entity Type", 81, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEdit9.Properties.DataSource = this.list_EntityTypesBindingSource1;
            this.lookUpEdit9.Properties.DisplayMember = "Description";
            this.lookUpEdit9.Properties.NullText = "";
            this.lookUpEdit9.Properties.NullValuePrompt = "Entity Type";
            this.lookUpEdit9.Properties.PopupFormMinSize = new System.Drawing.Size(119, 0);
            this.lookUpEdit9.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth;
            this.lookUpEdit9.Properties.ValueMember = "ID_LocationType";
            this.lookUpEdit9.Size = new System.Drawing.Size(244, 20);
            this.lookUpEdit9.TabIndex = 1;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "This value is not valid";
            conditionValidationRule4.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxValidationProvider1.SetValidationRule(this.lookUpEdit9, conditionValidationRule4);
            // 
            // lookUpEdit10
            // 
            this.lookUpEdit10.Location = new System.Drawing.Point(128, 88);
            this.lookUpEdit10.Name = "lookUpEdit10";
            this.lookUpEdit10.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit10.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_City", "ID_City", 45, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Cities", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_State", "ID_State", 52, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description_1", "Description_1", 74, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEdit10.Properties.DataSource = this.list_CitiesByStateBindingSource;
            this.lookUpEdit10.Properties.DisplayMember = "Description";
            this.lookUpEdit10.Properties.NullText = "";
            this.lookUpEdit10.Properties.NullValuePrompt = "City";
            this.lookUpEdit10.Properties.PopupFormMinSize = new System.Drawing.Size(119, 0);
            this.lookUpEdit10.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth;
            this.lookUpEdit10.Properties.ValueMember = "ID_City";
            this.lookUpEdit10.Size = new System.Drawing.Size(119, 20);
            this.lookUpEdit10.TabIndex = 3;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "Need to select a value";
            conditionValidationRule5.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxValidationProvider1.SetValidationRule(this.lookUpEdit10, conditionValidationRule5);
            // 
            // gridLookUpEdit5
            // 
            this.gridLookUpEdit5.Location = new System.Drawing.Point(6, 88);
            this.gridLookUpEdit5.Name = "gridLookUpEdit5";
            this.gridLookUpEdit5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit5.Properties.DataSource = this.list_StatesBindingSource;
            this.gridLookUpEdit5.Properties.DisplayMember = "Description_1";
            this.gridLookUpEdit5.Properties.NullText = "";
            this.gridLookUpEdit5.Properties.NullValuePrompt = "State";
            this.gridLookUpEdit5.Properties.PopupFormSize = new System.Drawing.Size(100, 0);
            this.gridLookUpEdit5.Properties.PopupView = this.gridView9;
            this.gridLookUpEdit5.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth;
            this.gridLookUpEdit5.Properties.ValueMember = "ID_State_1";
            this.gridLookUpEdit5.Size = new System.Drawing.Size(119, 20);
            this.gridLookUpEdit5.TabIndex = 2;
            conditionValidationRule6.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule6.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.gridLookUpEdit5, conditionValidationRule6);
            // 
            // gridView9
            // 
            this.gridView9.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn29});
            this.gridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView9.Name = "gridView9";
            this.gridView9.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView9.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn29
            // 
            this.gridColumn29.FieldName = "Description_1";
            this.gridColumn29.Name = "gridColumn29";
            this.gridColumn29.Visible = true;
            this.gridColumn29.VisibleIndex = 0;
            // 
            // lookUpEdit11
            // 
            this.lookUpEdit11.Location = new System.Drawing.Point(6, 40);
            this.lookUpEdit11.Name = "lookUpEdit11";
            this.lookUpEdit11.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit11.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_EntityType", "ID_Entity Type", 81, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEdit11.Properties.DataSource = this.list_EntityTypesBindingSource1;
            this.lookUpEdit11.Properties.DisplayMember = "Description";
            this.lookUpEdit11.Properties.NullText = "";
            this.lookUpEdit11.Properties.NullValuePrompt = "Entity Type";
            this.lookUpEdit11.Properties.PopupFormMinSize = new System.Drawing.Size(119, 0);
            this.lookUpEdit11.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth;
            this.lookUpEdit11.Properties.ValueMember = "ID_LocationType";
            this.lookUpEdit11.Size = new System.Drawing.Size(244, 20);
            this.lookUpEdit11.TabIndex = 1;
            conditionValidationRule7.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule7.ErrorText = "This value is not valid";
            conditionValidationRule7.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxValidationProvider1.SetValidationRule(this.lookUpEdit11, conditionValidationRule7);
            // 
            // lookUpEdit12
            // 
            this.lookUpEdit12.Location = new System.Drawing.Point(128, 88);
            this.lookUpEdit12.Name = "lookUpEdit12";
            this.lookUpEdit12.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit12.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_City", "ID_City", 45, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Cities", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_State", "ID_State", 52, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description_1", "Description_1", 74, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEdit12.Properties.DataSource = this.list_CitiesByStateBindingSource;
            this.lookUpEdit12.Properties.DisplayMember = "Description";
            this.lookUpEdit12.Properties.NullText = "";
            this.lookUpEdit12.Properties.NullValuePrompt = "City";
            this.lookUpEdit12.Properties.PopupFormMinSize = new System.Drawing.Size(119, 0);
            this.lookUpEdit12.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth;
            this.lookUpEdit12.Properties.ValueMember = "ID_City";
            this.lookUpEdit12.Size = new System.Drawing.Size(119, 20);
            this.lookUpEdit12.TabIndex = 3;
            conditionValidationRule8.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule8.ErrorText = "Need to select a value";
            conditionValidationRule8.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxValidationProvider1.SetValidationRule(this.lookUpEdit12, conditionValidationRule8);
            // 
            // gridLookUpEdit6
            // 
            this.gridLookUpEdit6.Location = new System.Drawing.Point(6, 88);
            this.gridLookUpEdit6.Name = "gridLookUpEdit6";
            this.gridLookUpEdit6.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit6.Properties.DataSource = this.list_StatesBindingSource;
            this.gridLookUpEdit6.Properties.DisplayMember = "Description_1";
            this.gridLookUpEdit6.Properties.NullText = "";
            this.gridLookUpEdit6.Properties.NullValuePrompt = "State";
            this.gridLookUpEdit6.Properties.PopupFormSize = new System.Drawing.Size(100, 0);
            this.gridLookUpEdit6.Properties.PopupView = this.gridView11;
            this.gridLookUpEdit6.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth;
            this.gridLookUpEdit6.Properties.ValueMember = "ID_State_1";
            this.gridLookUpEdit6.Size = new System.Drawing.Size(119, 20);
            this.gridLookUpEdit6.TabIndex = 2;
            conditionValidationRule9.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule9.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.gridLookUpEdit6, conditionValidationRule9);
            // 
            // gridView11
            // 
            this.gridView11.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn38});
            this.gridView11.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView11.Name = "gridView11";
            this.gridView11.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView11.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn38
            // 
            this.gridColumn38.FieldName = "Description_1";
            this.gridColumn38.Name = "gridColumn38";
            this.gridColumn38.Visible = true;
            this.gridColumn38.VisibleIndex = 0;
            // 
            // splashScreenManager2
            // 
            this.splashScreenManager2.ClosingDelay = 500;
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "e63b884b-f54d-4ccf-b0be-6261663925fc";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("b86989fa-80cc-44d7-9e8d-f5bc56f92984", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications"))), "Pellentesque lacinia tellus eget volutpat", "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor i" +
                    "ncididunt ut labore et dolore magna aliqua.", "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor i" +
                    "ncididunt ut labore et dolore magna aliqua.", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Text04)});
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(0, 0);
            // 
            // splitContainerControl7
            // 
            this.splitContainerControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl7.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl7.Name = "splitContainerControl7";
            // 
            // splitContainerControl7.Panel1
            // 
            this.splitContainerControl7.Panel1.Controls.Add(this.panelControl9);
            this.splitContainerControl7.Panel1.Text = "Panel1";
            // 
            // splitContainerControl7.Panel2
            // 
            this.splitContainerControl7.Panel2.Text = "Panel2";
            this.splitContainerControl7.Size = new System.Drawing.Size(200, 100);
            this.splitContainerControl7.TabIndex = 0;
            // 
            // panelControl9
            // 
            this.panelControl9.Controls.Add(this.splitContainerControl8);
            this.panelControl9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl9.Location = new System.Drawing.Point(0, 0);
            this.panelControl9.Name = "panelControl9";
            this.panelControl9.Size = new System.Drawing.Size(100, 96);
            this.panelControl9.TabIndex = 0;
            // 
            // splitContainerControl8
            // 
            this.splitContainerControl8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl8.Horizontal = false;
            this.splitContainerControl8.IsSplitterFixed = true;
            this.splitContainerControl8.Location = new System.Drawing.Point(2, 2);
            this.splitContainerControl8.Name = "splitContainerControl8";
            // 
            // splitContainerControl8.Panel1
            // 
            this.splitContainerControl8.Panel1.Controls.Add(this.simpleButton6);
            this.splitContainerControl8.Panel1.Controls.Add(this.simpleButton7);
            this.splitContainerControl8.Panel1.Controls.Add(this.simpleButton8);
            this.splitContainerControl8.Panel1.Controls.Add(this.groupBox4);
            this.splitContainerControl8.Panel1.Controls.Add(this.groupBox5);
            this.splitContainerControl8.Panel1.Text = "Panel1";
            // 
            // splitContainerControl8.Panel2
            // 
            this.splitContainerControl8.Panel2.Controls.Add(this.panelControl10);
            this.splitContainerControl8.Panel2.Text = "Panel2";
            this.splitContainerControl8.Size = new System.Drawing.Size(96, 92);
            this.splitContainerControl8.SplitterPosition = 441;
            this.splitContainerControl8.TabIndex = 18;
            // 
            // simpleButton6
            // 
            this.simpleButton6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton6.ImageOptions.Image")));
            this.simpleButton6.Location = new System.Drawing.Point(61, 255);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(119, 85);
            this.simpleButton6.TabIndex = 9;
            this.simpleButton6.Text = "Look Up";
            this.simpleButton6.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // simpleButton7
            // 
            this.simpleButton7.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton7.ImageOptions.SvgImage")));
            this.simpleButton7.Location = new System.Drawing.Point(183, 255);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(119, 85);
            this.simpleButton7.TabIndex = 15;
            this.simpleButton7.Text = "Refresh Map";
            this.simpleButton7.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton8
            // 
            this.simpleButton8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton8.ImageOptions.Image")));
            this.simpleButton8.Location = new System.Drawing.Point(61, 346);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(241, 85);
            this.simpleButton8.TabIndex = 10;
            this.simpleButton8.Text = "Save";
            this.simpleButton8.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lookUpEdit3);
            this.groupBox4.Controls.Add(this.labelControl5);
            this.groupBox4.Controls.Add(this.labelControl6);
            this.groupBox4.Controls.Add(this.lookUpEdit4);
            this.groupBox4.Controls.Add(this.gridLookUpEdit2);
            this.groupBox4.Location = new System.Drawing.Point(52, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(253, 114);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Input Data";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(103, 21);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(67, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Location Type";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(103, 69);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(49, 13);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "State/City";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textEdit7);
            this.groupBox5.Controls.Add(this.textEdit8);
            this.groupBox5.Controls.Add(this.textEdit9);
            this.groupBox5.Controls.Add(this.textEdit10);
            this.groupBox5.Controls.Add(this.textEdit11);
            this.groupBox5.Controls.Add(this.textEdit12);
            this.groupBox5.Location = new System.Drawing.Point(52, 123);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(253, 126);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Look Up Data";
            // 
            // textEdit7
            // 
            this.textEdit7.Location = new System.Drawing.Point(6, 44);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Properties.NullValuePrompt = "Address";
            this.textEdit7.Size = new System.Drawing.Size(244, 20);
            this.textEdit7.TabIndex = 9;
            // 
            // textEdit8
            // 
            this.textEdit8.Location = new System.Drawing.Point(186, 20);
            this.textEdit8.Name = "textEdit8";
            this.textEdit8.Properties.NullValuePrompt = "ZIP Code";
            this.textEdit8.Size = new System.Drawing.Size(64, 20);
            this.textEdit8.TabIndex = 10;
            // 
            // textEdit9
            // 
            this.textEdit9.Location = new System.Drawing.Point(6, 20);
            this.textEdit9.Name = "textEdit9";
            this.textEdit9.Properties.NullValuePrompt = "Description";
            this.textEdit9.Size = new System.Drawing.Size(174, 20);
            this.textEdit9.TabIndex = 4;
            // 
            // textEdit10
            // 
            this.textEdit10.Location = new System.Drawing.Point(6, 70);
            this.textEdit10.Name = "textEdit10";
            this.textEdit10.Properties.NullValuePrompt = "Latitude";
            this.textEdit10.Properties.UseMaskAsDisplayFormat = true;
            this.textEdit10.Size = new System.Drawing.Size(119, 20);
            this.textEdit10.TabIndex = 6;
            // 
            // textEdit11
            // 
            this.textEdit11.Location = new System.Drawing.Point(131, 70);
            this.textEdit11.Name = "textEdit11";
            this.textEdit11.Properties.NullValuePrompt = "Longitude";
            this.textEdit11.Size = new System.Drawing.Size(119, 20);
            this.textEdit11.TabIndex = 7;
            this.textEdit11.EditValueChanged += new System.EventHandler(this.edt_Log_EditValueChanged);
            // 
            // textEdit12
            // 
            this.textEdit12.Location = new System.Drawing.Point(6, 96);
            this.textEdit12.Name = "textEdit12";
            this.textEdit12.Properties.NullValuePrompt = "URL";
            this.textEdit12.Size = new System.Drawing.Size(244, 20);
            this.textEdit12.TabIndex = 8;
            // 
            // panelControl10
            // 
            this.panelControl10.Controls.Add(this.pictureBox3);
            this.panelControl10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl10.Location = new System.Drawing.Point(0, 0);
            this.panelControl10.Name = "panelControl10";
            this.panelControl10.Size = new System.Drawing.Size(0, 0);
            this.panelControl10.TabIndex = 17;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::ITXCatalogueManager.Properties.Resources.torreEiffel;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(0, 0);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelControl11
            // 
            this.panelControl11.Location = new System.Drawing.Point(0, 0);
            this.panelControl11.Name = "panelControl11";
            this.panelControl11.Size = new System.Drawing.Size(200, 100);
            this.panelControl11.TabIndex = 0;
            // 
            // xtraTabControl2
            // 
            this.xtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl2.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl2.Name = "xtraTabControl2";
            this.xtraTabControl2.SelectedTabPage = this.xtraTabPage5;
            this.xtraTabControl2.Size = new System.Drawing.Size(841, 596);
            this.xtraTabControl2.TabIndex = 4;
            // 
            // xtraTabPage10
            // 
            this.xtraTabPage10.Controls.Add(this.splitContainerControl15);
            this.xtraTabPage10.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage10.ImageOptions.Image")));
            this.xtraTabPage10.Name = "xtraTabPage10";
            this.xtraTabPage10.Size = new System.Drawing.Size(836, 552);
            this.xtraTabPage10.Text = "New Location";
            // 
            // splitContainerControl15
            // 
            this.splitContainerControl15.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl15.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl15.Name = "splitContainerControl15";
            // 
            // splitContainerControl15.Panel1
            // 
            this.splitContainerControl15.Panel1.Controls.Add(this.panelControl20);
            this.splitContainerControl15.Panel1.Text = "Panel1";
            // 
            // splitContainerControl15.Panel2
            // 
            this.splitContainerControl15.Panel2.Controls.Add(this.panelControl22);
            this.splitContainerControl15.Panel2.Text = "Panel2";
            this.splitContainerControl15.Size = new System.Drawing.Size(836, 552);
            this.splitContainerControl15.SplitterPosition = 366;
            this.splitContainerControl15.TabIndex = 0;
            // 
            // panelControl20
            // 
            this.panelControl20.Controls.Add(this.splitContainerControl16);
            this.panelControl20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl20.Location = new System.Drawing.Point(0, 0);
            this.panelControl20.Name = "panelControl20";
            this.panelControl20.Size = new System.Drawing.Size(366, 548);
            this.panelControl20.TabIndex = 0;
            // 
            // splitContainerControl16
            // 
            this.splitContainerControl16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl16.Horizontal = false;
            this.splitContainerControl16.IsSplitterFixed = true;
            this.splitContainerControl16.Location = new System.Drawing.Point(2, 2);
            this.splitContainerControl16.Name = "splitContainerControl16";
            // 
            // splitContainerControl16.Panel1
            // 
            this.splitContainerControl16.Panel1.Controls.Add(this.simpleButton17);
            this.splitContainerControl16.Panel1.Controls.Add(this.simpleButton18);
            this.splitContainerControl16.Panel1.Controls.Add(this.simpleButton19);
            this.splitContainerControl16.Panel1.Controls.Add(this.groupBox10);
            this.splitContainerControl16.Panel1.Controls.Add(this.groupBox11);
            this.splitContainerControl16.Panel1.Text = "Panel1";
            // 
            // splitContainerControl16.Panel2
            // 
            this.splitContainerControl16.Panel2.Controls.Add(this.panelControl21);
            this.splitContainerControl16.Panel2.Text = "Panel2";
            this.splitContainerControl16.Size = new System.Drawing.Size(362, 544);
            this.splitContainerControl16.SplitterPosition = 441;
            this.splitContainerControl16.TabIndex = 18;
            // 
            // simpleButton17
            // 
            this.simpleButton17.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton17.ImageOptions.Image")));
            this.simpleButton17.Location = new System.Drawing.Point(61, 255);
            this.simpleButton17.Name = "simpleButton17";
            this.simpleButton17.Size = new System.Drawing.Size(119, 85);
            this.simpleButton17.TabIndex = 9;
            this.simpleButton17.Text = "Look Up";
            // 
            // simpleButton18
            // 
            this.simpleButton18.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton18.ImageOptions.SvgImage")));
            this.simpleButton18.Location = new System.Drawing.Point(183, 255);
            this.simpleButton18.Name = "simpleButton18";
            this.simpleButton18.Size = new System.Drawing.Size(119, 85);
            this.simpleButton18.TabIndex = 15;
            this.simpleButton18.Text = "Refresh Map";
            // 
            // simpleButton19
            // 
            this.simpleButton19.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton19.ImageOptions.Image")));
            this.simpleButton19.Location = new System.Drawing.Point(61, 346);
            this.simpleButton19.Name = "simpleButton19";
            this.simpleButton19.Size = new System.Drawing.Size(241, 85);
            this.simpleButton19.TabIndex = 10;
            this.simpleButton19.Text = "Save";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.lookUpEdit9);
            this.groupBox10.Controls.Add(this.labelControl11);
            this.groupBox10.Controls.Add(this.labelControl12);
            this.groupBox10.Controls.Add(this.lookUpEdit10);
            this.groupBox10.Controls.Add(this.gridLookUpEdit5);
            this.groupBox10.Location = new System.Drawing.Point(52, 3);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(253, 114);
            this.groupBox10.TabIndex = 14;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Input Data";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(103, 21);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(67, 13);
            this.labelControl11.TabIndex = 0;
            this.labelControl11.Text = "Location Type";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(103, 69);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(49, 13);
            this.labelControl12.TabIndex = 12;
            this.labelControl12.Text = "State/City";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.textEdit25);
            this.groupBox11.Controls.Add(this.textEdit26);
            this.groupBox11.Controls.Add(this.textEdit27);
            this.groupBox11.Controls.Add(this.textEdit28);
            this.groupBox11.Controls.Add(this.textEdit29);
            this.groupBox11.Controls.Add(this.textEdit30);
            this.groupBox11.Location = new System.Drawing.Point(52, 123);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(253, 126);
            this.groupBox11.TabIndex = 13;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Look Up Data";
            // 
            // textEdit25
            // 
            this.textEdit25.Location = new System.Drawing.Point(6, 44);
            this.textEdit25.Name = "textEdit25";
            this.textEdit25.Properties.NullValuePrompt = "Address";
            this.textEdit25.Size = new System.Drawing.Size(244, 20);
            this.textEdit25.TabIndex = 9;
            // 
            // textEdit26
            // 
            this.textEdit26.Location = new System.Drawing.Point(186, 20);
            this.textEdit26.Name = "textEdit26";
            this.textEdit26.Properties.NullValuePrompt = "ZIP Code";
            this.textEdit26.Size = new System.Drawing.Size(64, 20);
            this.textEdit26.TabIndex = 10;
            // 
            // textEdit27
            // 
            this.textEdit27.Location = new System.Drawing.Point(6, 20);
            this.textEdit27.Name = "textEdit27";
            this.textEdit27.Properties.NullValuePrompt = "Description";
            this.textEdit27.Size = new System.Drawing.Size(174, 20);
            this.textEdit27.TabIndex = 4;
            // 
            // textEdit28
            // 
            this.textEdit28.Location = new System.Drawing.Point(6, 70);
            this.textEdit28.Name = "textEdit28";
            this.textEdit28.Properties.NullValuePrompt = "Latitude";
            this.textEdit28.Properties.UseMaskAsDisplayFormat = true;
            this.textEdit28.Size = new System.Drawing.Size(119, 20);
            this.textEdit28.TabIndex = 6;
            // 
            // textEdit29
            // 
            this.textEdit29.Location = new System.Drawing.Point(131, 70);
            this.textEdit29.Name = "textEdit29";
            this.textEdit29.Properties.NullValuePrompt = "Longitude";
            this.textEdit29.Size = new System.Drawing.Size(119, 20);
            this.textEdit29.TabIndex = 7;
            // 
            // textEdit30
            // 
            this.textEdit30.Location = new System.Drawing.Point(6, 96);
            this.textEdit30.Name = "textEdit30";
            this.textEdit30.Properties.NullValuePrompt = "URL";
            this.textEdit30.Size = new System.Drawing.Size(244, 20);
            this.textEdit30.TabIndex = 8;
            // 
            // panelControl21
            // 
            this.panelControl21.Controls.Add(this.pictureBox6);
            this.panelControl21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl21.Location = new System.Drawing.Point(0, 0);
            this.panelControl21.Name = "panelControl21";
            this.panelControl21.Size = new System.Drawing.Size(362, 99);
            this.panelControl21.TabIndex = 17;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox6.Image = global::ITXCatalogueManager.Properties.Resources.torreEiffel;
            this.pictureBox6.Location = new System.Drawing.Point(2, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(358, 95);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            // 
            // panelControl22
            // 
            this.panelControl22.Controls.Add(this.chromiumWebBrowser5);
            this.panelControl22.Controls.Add(this.webBrowser5);
            this.panelControl22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl22.Location = new System.Drawing.Point(0, 0);
            this.panelControl22.Name = "panelControl22";
            this.panelControl22.Size = new System.Drawing.Size(462, 548);
            this.panelControl22.TabIndex = 0;
            // 
            // chromiumWebBrowser5
            // 
            this.chromiumWebBrowser5.ActivateBrowserOnCreation = false;
// TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
            this.chromiumWebBrowser5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromiumWebBrowser5.Location = new System.Drawing.Point(2, 2);
            this.chromiumWebBrowser5.Name = "chromiumWebBrowser5";
            this.chromiumWebBrowser5.Size = new System.Drawing.Size(458, 544);
            this.chromiumWebBrowser5.TabIndex = 1;
            // 
            // webBrowser5
            // 
            this.webBrowser5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser5.Location = new System.Drawing.Point(2, 2);
            this.webBrowser5.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser5.Name = "webBrowser5";
            this.webBrowser5.Size = new System.Drawing.Size(458, 544);
            this.webBrowser5.TabIndex = 0;
            // 
            // xtraTabPage11
            // 
            this.xtraTabPage11.Controls.Add(this.splitContainerControl17);
            this.xtraTabPage11.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage11.ImageOptions.Image")));
            this.xtraTabPage11.Name = "xtraTabPage11";
            this.xtraTabPage11.Size = new System.Drawing.Size(836, 552);
            this.xtraTabPage11.Text = "Look up";
            // 
            // splitContainerControl17
            // 
            this.splitContainerControl17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl17.Horizontal = false;
            this.splitContainerControl17.IsSplitterFixed = true;
            this.splitContainerControl17.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl17.Name = "splitContainerControl17";
            // 
            // splitContainerControl17.Panel1
            // 
            this.splitContainerControl17.Panel1.Controls.Add(this.simpleButton20);
            this.splitContainerControl17.Panel1.Text = "Panel1";
            // 
            // splitContainerControl17.Panel2
            // 
            this.splitContainerControl17.Panel2.Controls.Add(this.panelControl23);
            this.splitContainerControl17.Panel2.Text = "Panel2";
            this.splitContainerControl17.Size = new System.Drawing.Size(836, 552);
            this.splitContainerControl17.SplitterPosition = 89;
            this.splitContainerControl17.TabIndex = 0;
            // 
            // simpleButton20
            // 
            this.simpleButton20.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton20.ImageOptions.Image")));
            this.simpleButton20.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton20.Location = new System.Drawing.Point(11, 3);
            this.simpleButton20.Name = "simpleButton20";
            this.simpleButton20.Size = new System.Drawing.Size(114, 84);
            this.simpleButton20.TabIndex = 0;
            // 
            // panelControl23
            // 
            this.panelControl23.Controls.Add(this.gridControl5);
            this.panelControl23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl23.Location = new System.Drawing.Point(0, 0);
            this.panelControl23.Name = "panelControl23";
            this.panelControl23.Size = new System.Drawing.Size(836, 459);
            this.panelControl23.TabIndex = 0;
            // 
            // gridControl5
            // 
            this.gridControl5.DataMember = "List_Entities";
            this.gridControl5.DataSource = this.SDS_entitiesGrid;
            this.gridControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl5.Location = new System.Drawing.Point(2, 2);
            this.gridControl5.MainView = this.gridView10;
            this.gridControl5.Name = "gridControl5";
            this.gridControl5.Size = new System.Drawing.Size(832, 455);
            this.gridControl5.TabIndex = 0;
            this.gridControl5.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView10});
            // 
            // gridView10
            // 
            this.gridView10.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn30,
            this.gridColumn31,
            this.gridColumn32,
            this.gridColumn33,
            this.gridColumn34,
            this.gridColumn35,
            this.gridColumn36,
            this.gridColumn37});
            this.gridView10.GridControl = this.gridControl5;
            this.gridView10.Name = "gridView10";
            // 
            // gridColumn30
            // 
            this.gridColumn30.FieldName = "Description";
            this.gridColumn30.Name = "gridColumn30";
            this.gridColumn30.Visible = true;
            this.gridColumn30.VisibleIndex = 0;
            // 
            // gridColumn31
            // 
            this.gridColumn31.FieldName = "Latitude";
            this.gridColumn31.Name = "gridColumn31";
            this.gridColumn31.Visible = true;
            this.gridColumn31.VisibleIndex = 1;
            // 
            // gridColumn32
            // 
            this.gridColumn32.FieldName = "Longitude";
            this.gridColumn32.Name = "gridColumn32";
            this.gridColumn32.Visible = true;
            this.gridColumn32.VisibleIndex = 2;
            // 
            // gridColumn33
            // 
            this.gridColumn33.FieldName = "Coords";
            this.gridColumn33.Name = "gridColumn33";
            this.gridColumn33.Visible = true;
            this.gridColumn33.VisibleIndex = 3;
            // 
            // gridColumn34
            // 
            this.gridColumn34.FieldName = "URL";
            this.gridColumn34.Name = "gridColumn34";
            this.gridColumn34.Visible = true;
            this.gridColumn34.VisibleIndex = 4;
            // 
            // gridColumn35
            // 
            this.gridColumn35.FieldName = "Status";
            this.gridColumn35.Name = "gridColumn35";
            this.gridColumn35.Visible = true;
            this.gridColumn35.VisibleIndex = 5;
            // 
            // gridColumn36
            // 
            this.gridColumn36.FieldName = "Address";
            this.gridColumn36.Name = "gridColumn36";
            this.gridColumn36.Visible = true;
            this.gridColumn36.VisibleIndex = 6;
            // 
            // gridColumn37
            // 
            this.gridColumn37.FieldName = "ZIPCode";
            this.gridColumn37.Name = "gridColumn37";
            this.gridColumn37.Visible = true;
            this.gridColumn37.VisibleIndex = 7;
            // 
            // xtraTabControl6
            // 
            this.xtraTabControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl6.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl6.Name = "xtraTabControl6";
            this.xtraTabControl6.SelectedTabPage = this.xtraTabPage12;
            this.xtraTabControl6.Size = new System.Drawing.Size(841, 596);
            this.xtraTabControl6.TabIndex = 6;
            // 
            // xtraTabPage12
            // 
            this.xtraTabPage12.Name = "xtraTabPage12";
            this.xtraTabPage12.Size = new System.Drawing.Size(0, 0);
            // 
            // splitContainerControl18
            // 
            this.splitContainerControl18.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl18.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl18.Name = "splitContainerControl18";
            // 
            // splitContainerControl18.Panel1
            // 
            this.splitContainerControl18.Panel1.Controls.Add(this.panelControl24);
            this.splitContainerControl18.Panel1.Text = "Panel1";
            // 
            // splitContainerControl18.Panel2
            // 
            this.splitContainerControl18.Panel2.Text = "Panel2";
            this.splitContainerControl18.Size = new System.Drawing.Size(200, 100);
            this.splitContainerControl18.TabIndex = 0;
            // 
            // panelControl24
            // 
            this.panelControl24.Controls.Add(this.splitContainerControl19);
            this.panelControl24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl24.Location = new System.Drawing.Point(0, 0);
            this.panelControl24.Name = "panelControl24";
            this.panelControl24.Size = new System.Drawing.Size(100, 96);
            this.panelControl24.TabIndex = 0;
            // 
            // splitContainerControl19
            // 
            this.splitContainerControl19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl19.Horizontal = false;
            this.splitContainerControl19.IsSplitterFixed = true;
            this.splitContainerControl19.Location = new System.Drawing.Point(2, 2);
            this.splitContainerControl19.Name = "splitContainerControl19";
            // 
            // splitContainerControl19.Panel1
            // 
            this.splitContainerControl19.Panel1.Controls.Add(this.simpleButton21);
            this.splitContainerControl19.Panel1.Controls.Add(this.simpleButton22);
            this.splitContainerControl19.Panel1.Controls.Add(this.simpleButton23);
            this.splitContainerControl19.Panel1.Controls.Add(this.groupBox12);
            this.splitContainerControl19.Panel1.Controls.Add(this.groupBox13);
            this.splitContainerControl19.Panel1.Text = "Panel1";
            // 
            // splitContainerControl19.Panel2
            // 
            this.splitContainerControl19.Panel2.Controls.Add(this.panelControl25);
            this.splitContainerControl19.Panel2.Text = "Panel2";
            this.splitContainerControl19.Size = new System.Drawing.Size(96, 92);
            this.splitContainerControl19.SplitterPosition = 441;
            this.splitContainerControl19.TabIndex = 18;
            // 
            // simpleButton21
            // 
            this.simpleButton21.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton21.ImageOptions.Image")));
            this.simpleButton21.Location = new System.Drawing.Point(61, 255);
            this.simpleButton21.Name = "simpleButton21";
            this.simpleButton21.Size = new System.Drawing.Size(119, 85);
            this.simpleButton21.TabIndex = 9;
            this.simpleButton21.Text = "Look Up";
            // 
            // simpleButton22
            // 
            this.simpleButton22.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton22.ImageOptions.SvgImage")));
            this.simpleButton22.Location = new System.Drawing.Point(183, 255);
            this.simpleButton22.Name = "simpleButton22";
            this.simpleButton22.Size = new System.Drawing.Size(119, 85);
            this.simpleButton22.TabIndex = 15;
            this.simpleButton22.Text = "Refresh Map";
            // 
            // simpleButton23
            // 
            this.simpleButton23.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton23.ImageOptions.Image")));
            this.simpleButton23.Location = new System.Drawing.Point(61, 346);
            this.simpleButton23.Name = "simpleButton23";
            this.simpleButton23.Size = new System.Drawing.Size(241, 85);
            this.simpleButton23.TabIndex = 10;
            this.simpleButton23.Text = "Save";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.lookUpEdit11);
            this.groupBox12.Controls.Add(this.labelControl13);
            this.groupBox12.Controls.Add(this.labelControl14);
            this.groupBox12.Controls.Add(this.lookUpEdit12);
            this.groupBox12.Controls.Add(this.gridLookUpEdit6);
            this.groupBox12.Location = new System.Drawing.Point(52, 3);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(253, 114);
            this.groupBox12.TabIndex = 14;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Input Data";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(103, 21);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(67, 13);
            this.labelControl13.TabIndex = 0;
            this.labelControl13.Text = "Location Type";
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(103, 69);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(49, 13);
            this.labelControl14.TabIndex = 12;
            this.labelControl14.Text = "State/City";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.textEdit31);
            this.groupBox13.Controls.Add(this.textEdit32);
            this.groupBox13.Controls.Add(this.textEdit33);
            this.groupBox13.Controls.Add(this.textEdit34);
            this.groupBox13.Controls.Add(this.textEdit35);
            this.groupBox13.Controls.Add(this.textEdit36);
            this.groupBox13.Location = new System.Drawing.Point(52, 123);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(253, 126);
            this.groupBox13.TabIndex = 13;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Look Up Data";
            // 
            // textEdit31
            // 
            this.textEdit31.Location = new System.Drawing.Point(6, 44);
            this.textEdit31.Name = "textEdit31";
            this.textEdit31.Properties.NullValuePrompt = "Address";
            this.textEdit31.Size = new System.Drawing.Size(244, 20);
            this.textEdit31.TabIndex = 9;
            // 
            // textEdit32
            // 
            this.textEdit32.Location = new System.Drawing.Point(186, 20);
            this.textEdit32.Name = "textEdit32";
            this.textEdit32.Properties.NullValuePrompt = "ZIP Code";
            this.textEdit32.Size = new System.Drawing.Size(64, 20);
            this.textEdit32.TabIndex = 10;
            // 
            // textEdit33
            // 
            this.textEdit33.Location = new System.Drawing.Point(6, 20);
            this.textEdit33.Name = "textEdit33";
            this.textEdit33.Properties.NullValuePrompt = "Description";
            this.textEdit33.Size = new System.Drawing.Size(174, 20);
            this.textEdit33.TabIndex = 4;
            // 
            // textEdit34
            // 
            this.textEdit34.Location = new System.Drawing.Point(6, 70);
            this.textEdit34.Name = "textEdit34";
            this.textEdit34.Properties.NullValuePrompt = "Latitude";
            this.textEdit34.Properties.UseMaskAsDisplayFormat = true;
            this.textEdit34.Size = new System.Drawing.Size(119, 20);
            this.textEdit34.TabIndex = 6;
            // 
            // textEdit35
            // 
            this.textEdit35.Location = new System.Drawing.Point(131, 70);
            this.textEdit35.Name = "textEdit35";
            this.textEdit35.Properties.NullValuePrompt = "Longitude";
            this.textEdit35.Size = new System.Drawing.Size(119, 20);
            this.textEdit35.TabIndex = 7;
            // 
            // textEdit36
            // 
            this.textEdit36.Location = new System.Drawing.Point(6, 96);
            this.textEdit36.Name = "textEdit36";
            this.textEdit36.Properties.NullValuePrompt = "URL";
            this.textEdit36.Size = new System.Drawing.Size(244, 20);
            this.textEdit36.TabIndex = 8;
            // 
            // panelControl25
            // 
            this.panelControl25.Controls.Add(this.pictureBox7);
            this.panelControl25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl25.Location = new System.Drawing.Point(0, 0);
            this.panelControl25.Name = "panelControl25";
            this.panelControl25.Size = new System.Drawing.Size(0, 0);
            this.panelControl25.TabIndex = 17;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox7.Image = global::ITXCatalogueManager.Properties.Resources.torreEiffel;
            this.pictureBox7.Location = new System.Drawing.Point(0, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(0, 0);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 16;
            this.pictureBox7.TabStop = false;
            // 
            // panelControl26
            // 
            this.panelControl26.Location = new System.Drawing.Point(0, 0);
            this.panelControl26.Name = "panelControl26";
            this.panelControl26.Size = new System.Drawing.Size(200, 100);
            this.panelControl26.TabIndex = 0;
            // 
            // xtraTabControl5
            // 
            this.xtraTabControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl5.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl5.Name = "xtraTabControl5";
            this.xtraTabControl5.SelectedTabPage = this.xtraTabPage10;
            this.xtraTabControl5.Size = new System.Drawing.Size(841, 596);
            this.xtraTabControl5.TabIndex = 7;
            this.xtraTabControl5.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage10,
            this.xtraTabPage11});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.splitContainerControl2);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(836, 552);
            this.xtraTabPage2.Text = "Look up";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.IsSplitterFixed = true;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            // 
            // splitContainerControl2.Panel1
            // 
            this.splitContainerControl2.Panel1.Controls.Add(this.simpleButton1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            // 
            // splitContainerControl2.Panel2
            // 
            this.splitContainerControl2.Panel2.Controls.Add(this.panelControl3);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(836, 552);
            this.splitContainerControl2.SplitterPosition = 89;
            this.splitContainerControl2.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gridControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(836, 459);
            this.panelControl3.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "List_Entities";
            this.gridControl1.DataSource = this.SDS_entitiesGrid;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(832, 455);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescription,
            this.colLatitude,
            this.colLongitude,
            this.colCoords,
            this.colURL,
            this.colStatus,
            this.colAddress,
            this.colZIPCode});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 0;
            // 
            // colLatitude
            // 
            this.colLatitude.FieldName = "Latitude";
            this.colLatitude.Name = "colLatitude";
            this.colLatitude.Visible = true;
            this.colLatitude.VisibleIndex = 1;
            // 
            // colLongitude
            // 
            this.colLongitude.FieldName = "Longitude";
            this.colLongitude.Name = "colLongitude";
            this.colLongitude.Visible = true;
            this.colLongitude.VisibleIndex = 2;
            // 
            // colCoords
            // 
            this.colCoords.FieldName = "Coords";
            this.colCoords.Name = "colCoords";
            this.colCoords.Visible = true;
            this.colCoords.VisibleIndex = 3;
            // 
            // colURL
            // 
            this.colURL.FieldName = "URL";
            this.colURL.Name = "colURL";
            this.colURL.Visible = true;
            this.colURL.VisibleIndex = 4;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 5;
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 6;
            // 
            // colZIPCode
            // 
            this.colZIPCode.FieldName = "ZIPCode";
            this.colZIPCode.Name = "colZIPCode";
            this.colZIPCode.Visible = true;
            this.colZIPCode.VisibleIndex = 7;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton1.Location = new System.Drawing.Point(11, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(114, 84);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.splitContainerControl1);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(836, 552);
            this.xtraTabPage1.Text = "New Location";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(836, 552);
            this.splitContainerControl1.SplitterPosition = 366;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.chromiumWebBrowser1);
            this.panelControl2.Controls.Add(this.webBrowser1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(462, 548);
            this.panelControl2.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(2, 2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(458, 544);
            this.webBrowser1.TabIndex = 0;
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
// TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
            this.chromiumWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(2, 2);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(458, 544);
            this.chromiumWebBrowser1.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.splitContainerControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(366, 548);
            this.panelControl1.TabIndex = 0;
            // 
            // splitContainerControl3
            // 
            this.splitContainerControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl3.Horizontal = false;
            this.splitContainerControl3.IsSplitterFixed = true;
            this.splitContainerControl3.Location = new System.Drawing.Point(2, 2);
            this.splitContainerControl3.Name = "splitContainerControl3";
            // 
            // splitContainerControl3.Panel1
            // 
            this.splitContainerControl3.Panel1.Controls.Add(this.btn_preview);
            this.splitContainerControl3.Panel1.Controls.Add(this.btn_refresh);
            this.splitContainerControl3.Panel1.Controls.Add(this.btn_Save);
            this.splitContainerControl3.Panel1.Controls.Add(this.MetaData);
            this.splitContainerControl3.Panel1.Controls.Add(this.groupBox1);
            this.splitContainerControl3.Panel1.Text = "Panel1";
            // 
            // splitContainerControl3.Panel2
            // 
            this.splitContainerControl3.Panel2.Controls.Add(this.panelControl4);
            this.splitContainerControl3.Panel2.Text = "Panel2";
            this.splitContainerControl3.Size = new System.Drawing.Size(362, 544);
            this.splitContainerControl3.SplitterPosition = 441;
            this.splitContainerControl3.TabIndex = 18;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.pictureBox1);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(0, 0);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(362, 99);
            this.panelControl4.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ITXCatalogueManager.Properties.Resources.torreEiffel;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edt_address);
            this.groupBox1.Controls.Add(this.edt_zip);
            this.groupBox1.Controls.Add(this.edt_Description);
            this.groupBox1.Controls.Add(this.edt_Lat);
            this.groupBox1.Controls.Add(this.edt_Lon);
            this.groupBox1.Controls.Add(this.edt_URL);
            this.groupBox1.Location = new System.Drawing.Point(52, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 126);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Look Up Data";
            // 
            // edt_URL
            // 
            this.edt_URL.Location = new System.Drawing.Point(6, 96);
            this.edt_URL.Name = "edt_URL";
            this.edt_URL.Properties.NullValuePrompt = "URL";
            this.edt_URL.Size = new System.Drawing.Size(244, 20);
            this.edt_URL.TabIndex = 8;
            // 
            // edt_Lon
            // 
            this.edt_Lon.Location = new System.Drawing.Point(131, 70);
            this.edt_Lon.Name = "edt_Lon";
            this.edt_Lon.Properties.NullValuePrompt = "Longitude";
            this.edt_Lon.Size = new System.Drawing.Size(119, 20);
            this.edt_Lon.TabIndex = 7;
            this.edt_Lon.EditValueChanged += new System.EventHandler(this.edt_Log_EditValueChanged);
            // 
            // edt_Lat
            // 
            this.edt_Lat.Location = new System.Drawing.Point(6, 70);
            this.edt_Lat.Name = "edt_Lat";
            this.edt_Lat.Properties.NullValuePrompt = "Latitude";
            this.edt_Lat.Properties.UseMaskAsDisplayFormat = true;
            this.edt_Lat.Size = new System.Drawing.Size(119, 20);
            this.edt_Lat.TabIndex = 6;
            // 
            // edt_Description
            // 
            this.edt_Description.Location = new System.Drawing.Point(6, 20);
            this.edt_Description.Name = "edt_Description";
            this.edt_Description.Properties.NullValuePrompt = "Description";
            this.edt_Description.Size = new System.Drawing.Size(174, 20);
            this.edt_Description.TabIndex = 4;
            // 
            // edt_zip
            // 
            this.edt_zip.Location = new System.Drawing.Point(186, 20);
            this.edt_zip.Name = "edt_zip";
            this.edt_zip.Properties.NullValuePrompt = "ZIP Code";
            this.edt_zip.Size = new System.Drawing.Size(64, 20);
            this.edt_zip.TabIndex = 10;
            // 
            // edt_address
            // 
            this.edt_address.Location = new System.Drawing.Point(6, 44);
            this.edt_address.Name = "edt_address";
            this.edt_address.Properties.NullValuePrompt = "Address";
            this.edt_address.Size = new System.Drawing.Size(244, 20);
            this.edt_address.TabIndex = 9;
            // 
            // MetaData
            // 
            this.MetaData.Controls.Add(this.lue_locationType);
            this.MetaData.Controls.Add(this.labelControl1);
            this.MetaData.Controls.Add(this.labelControl2);
            this.MetaData.Controls.Add(this.lue_City);
            this.MetaData.Controls.Add(this.lue_state);
            this.MetaData.Location = new System.Drawing.Point(52, 3);
            this.MetaData.Name = "MetaData";
            this.MetaData.Size = new System.Drawing.Size(253, 114);
            this.MetaData.TabIndex = 14;
            this.MetaData.TabStop = false;
            this.MetaData.Text = "Input Data";
            // 
            // lue_state
            // 
            this.lue_state.Location = new System.Drawing.Point(6, 88);
            this.lue_state.Name = "lue_state";
            this.lue_state.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_state.Properties.DataSource = this.list_StatesBindingSource;
            this.lue_state.Properties.DisplayMember = "Description_1";
            this.lue_state.Properties.NullText = "";
            this.lue_state.Properties.NullValuePrompt = "State";
            this.lue_state.Properties.PopupFormSize = new System.Drawing.Size(100, 0);
            this.lue_state.Properties.PopupView = this.gridLookUpEdit1View;
            this.lue_state.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth;
            this.lue_state.Properties.ValueMember = "ID_State_1";
            this.lue_state.Size = new System.Drawing.Size(119, 20);
            this.lue_state.TabIndex = 2;
            conditionValidationRule12.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule12.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.lue_state, conditionValidationRule12);
            this.lue_state.EditValueChanged += new System.EventHandler(this.lue_state_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.States});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // States
            // 
            this.States.FieldName = "Description_1";
            this.States.Name = "States";
            this.States.Visible = true;
            this.States.VisibleIndex = 0;
            // 
            // lue_City
            // 
            this.lue_City.Location = new System.Drawing.Point(128, 88);
            this.lue_City.Name = "lue_City";
            this.lue_City.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_City.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_City", "ID_City", 45, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Cities", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_State", "ID_State", 52, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description_1", "Description_1", 74, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lue_City.Properties.DataSource = this.list_CitiesByStateBindingSource;
            this.lue_City.Properties.DisplayMember = "Description";
            this.lue_City.Properties.NullText = "";
            this.lue_City.Properties.NullValuePrompt = "City";
            this.lue_City.Properties.PopupFormMinSize = new System.Drawing.Size(119, 0);
            this.lue_City.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth;
            this.lue_City.Properties.ValueMember = "ID_City";
            this.lue_City.Size = new System.Drawing.Size(119, 20);
            this.lue_City.TabIndex = 3;
            conditionValidationRule11.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule11.ErrorText = "Need to select a value";
            conditionValidationRule11.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxValidationProvider1.SetValidationRule(this.lue_City, conditionValidationRule11);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(103, 69);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "State/City";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(103, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Location Type";
            // 
            // lue_locationType
            // 
            this.lue_locationType.Location = new System.Drawing.Point(6, 40);
            this.lue_locationType.Name = "lue_locationType";
            this.lue_locationType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_locationType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_EntityType", "ID_Entity Type", 81, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lue_locationType.Properties.DataSource = this.list_EntityTypesBindingSource1;
            this.lue_locationType.Properties.DisplayMember = "Description";
            this.lue_locationType.Properties.NullText = "";
            this.lue_locationType.Properties.NullValuePrompt = "Entity Type";
            this.lue_locationType.Properties.PopupFormMinSize = new System.Drawing.Size(119, 0);
            this.lue_locationType.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth;
            this.lue_locationType.Properties.ValueMember = "ID_LocationType";
            this.lue_locationType.Size = new System.Drawing.Size(244, 20);
            this.lue_locationType.TabIndex = 1;
            conditionValidationRule10.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule10.ErrorText = "This value is not valid";
            conditionValidationRule10.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxValidationProvider1.SetValidationRule(this.lue_locationType, conditionValidationRule10);
            // 
            // btn_Save
            // 
            this.btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.ImageOptions.Image")));
            this.btn_Save.Location = new System.Drawing.Point(61, 346);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(241, 85);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_refresh.ImageOptions.SvgImage")));
            this.btn_refresh.Location = new System.Drawing.Point(183, 255);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(119, 85);
            this.btn_refresh.TabIndex = 15;
            this.btn_refresh.Text = "Refresh Map";
            this.btn_refresh.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btn_preview
            // 
            this.btn_preview.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_preview.ImageOptions.Image")));
            this.btn_preview.Location = new System.Drawing.Point(61, 255);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(119, 85);
            this.btn_preview.TabIndex = 9;
            this.btn_preview.Text = "Look Up";
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // XTP1
            // 
            this.XTP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XTP1.Location = new System.Drawing.Point(0, 0);
            this.XTP1.Name = "XTP1";
            this.XTP1.SelectedTabPage = this.xtraTabPage1;
            this.XTP1.Size = new System.Drawing.Size(841, 596);
            this.XTP1.TabIndex = 4;
            this.XTP1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // frm_Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 596);
            this.Controls.Add(this.XTP1);
            this.Name = "frm_Location";
            this.Text = "frm_Entity";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Entity_FormClosing);
            this.Load += new System.EventHandler(this.frm_Location_Load);
            ((System.ComponentModel.ISupportInitialize)(this.list_EntityTypesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_CitiesByStateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_StatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit10.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit11.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit12.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl7.Panel1)).EndInit();
            this.splitContainerControl7.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl7.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl7)).EndInit();
            this.splitContainerControl7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl9)).EndInit();
            this.panelControl9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl8.Panel1)).EndInit();
            this.splitContainerControl8.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl8.Panel2)).EndInit();
            this.splitContainerControl8.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl8)).EndInit();
            this.splitContainerControl8.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit10.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit11.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit12.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl10)).EndInit();
            this.panelControl10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
            this.xtraTabPage10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl15.Panel1)).EndInit();
            this.splitContainerControl15.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl15.Panel2)).EndInit();
            this.splitContainerControl15.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl15)).EndInit();
            this.splitContainerControl15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl20)).EndInit();
            this.panelControl20.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl16.Panel1)).EndInit();
            this.splitContainerControl16.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl16.Panel2)).EndInit();
            this.splitContainerControl16.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl16)).EndInit();
            this.splitContainerControl16.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit25.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit26.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit27.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit28.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit29.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit30.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl21)).EndInit();
            this.panelControl21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl22)).EndInit();
            this.panelControl22.ResumeLayout(false);
            this.xtraTabPage11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl17.Panel1)).EndInit();
            this.splitContainerControl17.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl17.Panel2)).EndInit();
            this.splitContainerControl17.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl17)).EndInit();
            this.splitContainerControl17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl23)).EndInit();
            this.panelControl23.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl18.Panel1)).EndInit();
            this.splitContainerControl18.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl18.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl18)).EndInit();
            this.splitContainerControl18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl24)).EndInit();
            this.panelControl24.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl19.Panel1)).EndInit();
            this.splitContainerControl19.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl19.Panel2)).EndInit();
            this.splitContainerControl19.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl19)).EndInit();
            this.splitContainerControl19.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit31.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit32.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit33.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit34.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit35.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit36.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl25)).EndInit();
            this.panelControl25.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl5)).EndInit();
            this.xtraTabControl5.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel1)).EndInit();
            this.splitContainerControl2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2.Panel2)).EndInit();
            this.splitContainerControl2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3.Panel1)).EndInit();
            this.splitContainerControl3.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3.Panel2)).EndInit();
            this.splitContainerControl3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).EndInit();
            this.splitContainerControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edt_URL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_Lon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_Lat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_Description.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_zip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_address.Properties)).EndInit();
            this.MetaData.ResumeLayout(false);
            this.MetaData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lue_state.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_City.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_locationType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XTP1)).EndInit();
            this.XTP1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.DataAccess.Sql.SqlDataSource SDS_States;
        private DevExpress.DataAccess.Sql.SqlDataSource SDS_Cities;
        private DevExpress.DataAccess.Sql.SqlDataSource SDS_Entities;
        private DevExpress.DataAccess.Sql.SqlDataSource SDS_entitiesGrid;
        private System.Windows.Forms.BindingSource list_EntityTypesBindingSource1;
        private System.Windows.Forms.BindingSource list_CitiesByStateBindingSource;
        private System.Windows.Forms.BindingSource list_StatesBindingSource;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager2;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl7;
        private DevExpress.XtraEditors.PanelControl panelControl9;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl8;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.SimpleButton simpleButton8;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit4;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private System.Windows.Forms.GroupBox groupBox5;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private DevExpress.XtraEditors.TextEdit textEdit8;
        private DevExpress.XtraEditors.TextEdit textEdit9;
        private DevExpress.XtraEditors.TextEdit textEdit10;
        private DevExpress.XtraEditors.TextEdit textEdit11;
        private DevExpress.XtraEditors.TextEdit textEdit12;
        private DevExpress.XtraEditors.PanelControl panelControl10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private DevExpress.XtraEditors.PanelControl panelControl11;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage10;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl15;
        private DevExpress.XtraEditors.PanelControl panelControl20;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl16;
        private DevExpress.XtraEditors.SimpleButton simpleButton17;
        private DevExpress.XtraEditors.SimpleButton simpleButton18;
        private DevExpress.XtraEditors.SimpleButton simpleButton19;
        private System.Windows.Forms.GroupBox groupBox10;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit9;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit10;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit5;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn29;
        private System.Windows.Forms.GroupBox groupBox11;
        private DevExpress.XtraEditors.TextEdit textEdit25;
        private DevExpress.XtraEditors.TextEdit textEdit26;
        private DevExpress.XtraEditors.TextEdit textEdit27;
        private DevExpress.XtraEditors.TextEdit textEdit28;
        private DevExpress.XtraEditors.TextEdit textEdit29;
        private DevExpress.XtraEditors.TextEdit textEdit30;
        private DevExpress.XtraEditors.PanelControl panelControl21;
        private System.Windows.Forms.PictureBox pictureBox6;
        private DevExpress.XtraEditors.PanelControl panelControl22;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser5;
        private System.Windows.Forms.WebBrowser webBrowser5;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage11;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl17;
        private DevExpress.XtraEditors.SimpleButton simpleButton20;
        private DevExpress.XtraEditors.PanelControl panelControl23;
        private DevExpress.XtraGrid.GridControl gridControl5;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn30;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn31;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn32;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn33;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn34;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn35;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn36;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn37;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl6;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage12;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl18;
        private DevExpress.XtraEditors.PanelControl panelControl24;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl19;
        private DevExpress.XtraEditors.SimpleButton simpleButton21;
        private DevExpress.XtraEditors.SimpleButton simpleButton22;
        private DevExpress.XtraEditors.SimpleButton simpleButton23;
        private System.Windows.Forms.GroupBox groupBox12;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit11;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit12;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit6;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn38;
        private System.Windows.Forms.GroupBox groupBox13;
        private DevExpress.XtraEditors.TextEdit textEdit31;
        private DevExpress.XtraEditors.TextEdit textEdit32;
        private DevExpress.XtraEditors.TextEdit textEdit33;
        private DevExpress.XtraEditors.TextEdit textEdit34;
        private DevExpress.XtraEditors.TextEdit textEdit35;
        private DevExpress.XtraEditors.TextEdit textEdit36;
        private DevExpress.XtraEditors.PanelControl panelControl25;
        private System.Windows.Forms.PictureBox pictureBox7;
        private DevExpress.XtraEditors.PanelControl panelControl26;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl5;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colLatitude;
        private DevExpress.XtraGrid.Columns.GridColumn colLongitude;
        private DevExpress.XtraGrid.Columns.GridColumn colCoords;
        private DevExpress.XtraGrid.Columns.GridColumn colURL;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colZIPCode;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl3;
        private DevExpress.XtraEditors.SimpleButton btn_preview;
        private DevExpress.XtraEditors.SimpleButton btn_refresh;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private System.Windows.Forms.GroupBox MetaData;
        private DevExpress.XtraEditors.LookUpEdit lue_locationType;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit lue_City;
        private DevExpress.XtraEditors.GridLookUpEdit lue_state;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn States;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit edt_address;
        private DevExpress.XtraEditors.TextEdit edt_zip;
        private DevExpress.XtraEditors.TextEdit edt_Description;
        private DevExpress.XtraEditors.TextEdit edt_Lat;
        private DevExpress.XtraEditors.TextEdit edt_Lon;
        private DevExpress.XtraEditors.TextEdit edt_URL;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private DevExpress.XtraTab.XtraTabControl XTP1;
    }
}