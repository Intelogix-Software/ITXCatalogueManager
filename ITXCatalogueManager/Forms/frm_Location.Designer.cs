
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Location));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery3 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery4 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.XTP1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_refresh = new DevExpress.XtraEditors.SimpleButton();
            this.MetaData = new System.Windows.Forms.GroupBox();
            this.lue_locationType = new DevExpress.XtraEditors.LookUpEdit();
            this.list_EntityTypesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SDS_Entities = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lue_City = new DevExpress.XtraEditors.LookUpEdit();
            this.list_CitiesByStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SDS_Cities = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.lue_state = new DevExpress.XtraEditors.GridLookUpEdit();
            this.list_StatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SDS_States = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.States = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.edt_address = new DevExpress.XtraEditors.TextEdit();
            this.edt_zip = new DevExpress.XtraEditors.TextEdit();
            this.edt_Description = new DevExpress.XtraEditors.TextEdit();
            this.edt_Lat = new DevExpress.XtraEditors.TextEdit();
            this.edt_Lon = new DevExpress.XtraEditors.TextEdit();
            this.edt_URL = new DevExpress.XtraEditors.TextEdit();
            this.btn_preview = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.SDS_entitiesGrid = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCoords = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colURL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEntityType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ITXCatalogueManager.Forms.WaitForm1), true, true);
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.XTP1)).BeginInit();
            this.XTP1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.MetaData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lue_locationType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_EntityTypesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_City.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_CitiesByStateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_state.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_StatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_address.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_zip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_Description.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_Lat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_Lon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_URL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainerControl1.SplitterPosition = 307;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_refresh);
            this.panelControl1.Controls.Add(this.MetaData);
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Controls.Add(this.btn_preview);
            this.panelControl1.Controls.Add(this.btn_Save);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(307, 548);
            this.panelControl1.TabIndex = 0;
            // 
            // btn_refresh
            // 
            this.btn_refresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_refresh.ImageOptions.SvgImage")));
            this.btn_refresh.Location = new System.Drawing.Point(155, 274);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(119, 85);
            this.btn_refresh.TabIndex = 15;
            this.btn_refresh.Text = "Refresh Map";
            this.btn_refresh.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // MetaData
            // 
            this.MetaData.Controls.Add(this.lue_locationType);
            this.MetaData.Controls.Add(this.labelControl1);
            this.MetaData.Controls.Add(this.labelControl2);
            this.MetaData.Controls.Add(this.lue_City);
            this.MetaData.Controls.Add(this.lue_state);
            this.MetaData.Location = new System.Drawing.Point(24, 22);
            this.MetaData.Name = "MetaData";
            this.MetaData.Size = new System.Drawing.Size(253, 114);
            this.MetaData.TabIndex = 14;
            this.MetaData.TabStop = false;
            this.MetaData.Text = "Input Data";
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
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is not valid";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxValidationProvider1.SetValidationRule(this.lue_locationType, conditionValidationRule1);
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
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(103, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Location Type";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(103, 69);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "State/City";
            // 
            // lue_City
            // 
            this.lue_City.Location = new System.Drawing.Point(131, 88);
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
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Need to select a value";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxValidationProvider1.SetValidationRule(this.lue_City, conditionValidationRule2);
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
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "This value is not valid";
            this.dxValidationProvider1.SetValidationRule(this.lue_state, conditionValidationRule3);
            this.lue_state.EditValueChanged += new System.EventHandler(this.lue_state_EditValueChanged);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edt_address);
            this.groupBox1.Controls.Add(this.edt_zip);
            this.groupBox1.Controls.Add(this.edt_Description);
            this.groupBox1.Controls.Add(this.edt_Lat);
            this.groupBox1.Controls.Add(this.edt_Lon);
            this.groupBox1.Controls.Add(this.edt_URL);
            this.groupBox1.Location = new System.Drawing.Point(24, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 126);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Look Up Data";
            // 
            // edt_address
            // 
            this.edt_address.Location = new System.Drawing.Point(6, 44);
            this.edt_address.Name = "edt_address";
            this.edt_address.Properties.NullValuePrompt = "Address";
            this.edt_address.Size = new System.Drawing.Size(244, 20);
            this.edt_address.TabIndex = 9;
            // 
            // edt_zip
            // 
            this.edt_zip.Location = new System.Drawing.Point(186, 20);
            this.edt_zip.Name = "edt_zip";
            this.edt_zip.Properties.NullValuePrompt = "ZIP Code";
            this.edt_zip.Size = new System.Drawing.Size(64, 20);
            this.edt_zip.TabIndex = 10;
            // 
            // edt_Description
            // 
            this.edt_Description.Location = new System.Drawing.Point(6, 20);
            this.edt_Description.Name = "edt_Description";
            this.edt_Description.Properties.NullValuePrompt = "Description";
            this.edt_Description.Size = new System.Drawing.Size(174, 20);
            this.edt_Description.TabIndex = 4;
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
            // edt_Lon
            // 
            this.edt_Lon.Location = new System.Drawing.Point(131, 70);
            this.edt_Lon.Name = "edt_Lon";
            this.edt_Lon.Properties.NullValuePrompt = "Longitude";
            this.edt_Lon.Size = new System.Drawing.Size(119, 20);
            this.edt_Lon.TabIndex = 7;
            this.edt_Lon.EditValueChanged += new System.EventHandler(this.edt_Log_EditValueChanged);
            // 
            // edt_URL
            // 
            this.edt_URL.Location = new System.Drawing.Point(6, 96);
            this.edt_URL.Name = "edt_URL";
            this.edt_URL.Properties.NullValuePrompt = "URL";
            this.edt_URL.Size = new System.Drawing.Size(244, 20);
            this.edt_URL.TabIndex = 8;
            // 
            // btn_preview
            // 
            this.btn_preview.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_preview.ImageOptions.Image")));
            this.btn_preview.Location = new System.Drawing.Point(33, 274);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(119, 85);
            this.btn_preview.TabIndex = 9;
            this.btn_preview.Text = "Look Up";
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.ImageOptions.Image")));
            this.btn_Save.Location = new System.Drawing.Point(33, 365);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(241, 85);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.chromiumWebBrowser1);
            this.panelControl2.Controls.Add(this.webBrowser1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(521, 548);
            this.panelControl2.TabIndex = 0;
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(2, 2);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(517, 544);
            this.chromiumWebBrowser1.TabIndex = 1;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(2, 2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(517, 544);
            this.webBrowser1.TabIndex = 0;
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
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colDescription,
            this.colCoords,
            this.colURL,
            this.colEntityType,
            this.colCity});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            // 
            // colCoords
            // 
            this.colCoords.FieldName = "Coords";
            this.colCoords.Name = "colCoords";
            this.colCoords.Visible = true;
            this.colCoords.VisibleIndex = 2;
            // 
            // colURL
            // 
            this.colURL.FieldName = "URL";
            this.colURL.Name = "colURL";
            this.colURL.Visible = true;
            this.colURL.VisibleIndex = 3;
            // 
            // colEntityType
            // 
            this.colEntityType.FieldName = "EntityType";
            this.colEntityType.Name = "colEntityType";
            this.colEntityType.Visible = true;
            this.colEntityType.VisibleIndex = 4;
            // 
            // colCity
            // 
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 5;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
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
            ((System.ComponentModel.ISupportInitialize)(this.XTP1)).EndInit();
            this.XTP1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.MetaData.ResumeLayout(false);
            this.MetaData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lue_locationType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_EntityTypesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_City.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_CitiesByStateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_state.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_StatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edt_address.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_zip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_Description.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_Lat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_Lon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_URL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl XTP1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LookUpEdit lue_locationType;
        private DevExpress.XtraEditors.SimpleButton btn_preview;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.TextEdit edt_URL;
        private DevExpress.XtraEditors.TextEdit edt_Description;
        private DevExpress.XtraEditors.TextEdit edt_Lon;
        private DevExpress.XtraEditors.TextEdit edt_Lat;
        private DevExpress.XtraEditors.LookUpEdit lue_City;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.DataAccess.Sql.SqlDataSource SDS_States;
        private DevExpress.DataAccess.Sql.SqlDataSource SDS_Cities;
        private DevExpress.DataAccess.Sql.SqlDataSource SDS_Entities;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GridLookUpEdit lue_state;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.DataAccess.Sql.SqlDataSource SDS_entitiesGrid;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colCoords;
        private DevExpress.XtraGrid.Columns.GridColumn colURL;
        private DevExpress.XtraGrid.Columns.GridColumn colEntityType;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private System.Windows.Forms.GroupBox groupBox1;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.TextEdit edt_address;
        private DevExpress.XtraEditors.TextEdit edt_zip;
        private System.Windows.Forms.BindingSource list_EntityTypesBindingSource1;
        private System.Windows.Forms.BindingSource list_CitiesByStateBindingSource;
        private System.Windows.Forms.BindingSource list_StatesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn States;
        private System.Windows.Forms.GroupBox MetaData;
        private DevExpress.XtraEditors.SimpleButton btn_refresh;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
    }
}