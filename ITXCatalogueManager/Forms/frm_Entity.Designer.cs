
namespace ITXCatalogueManager.Forms
{
    partial class frm_Entity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Entity));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery5 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery6 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery7 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery8 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            this.XTP1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.edt_code = new DevExpress.XtraEditors.TextEdit();
            this.lue_state = new DevExpress.XtraEditors.GridLookUpEdit();
            this.list_StatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SDS_States = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescription1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lue_entityType = new DevExpress.XtraEditors.LookUpEdit();
            this.list_EntityTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SDS_Entities = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.btn_preview = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.edt_URL = new DevExpress.XtraEditors.TextEdit();
            this.edt_Description = new DevExpress.XtraEditors.TextEdit();
            this.edt_Lon = new DevExpress.XtraEditors.TextEdit();
            this.edt_Lat = new DevExpress.XtraEditors.TextEdit();
            this.lue_City = new DevExpress.XtraEditors.LookUpEdit();
            this.list_CitiesByStateBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SDS_Cities = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
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
            this.list_StatesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.edt_code.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_state.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_StatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_entityType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_EntityTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_URL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_Description.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_Lon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_Lat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_City.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_CitiesByStateBindingSource1)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.list_StatesBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.xtraTabPage1.Text = "New Entity";
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
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.lue_state);
            this.panelControl1.Controls.Add(this.lue_entityType);
            this.panelControl1.Controls.Add(this.btn_preview);
            this.panelControl1.Controls.Add(this.btn_Save);
            this.panelControl1.Controls.Add(this.lue_City);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(307, 548);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(158, 61);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(23, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "City:";
            // 
            // edt_code
            // 
            this.edt_code.Location = new System.Drawing.Point(131, 20);
            this.edt_code.Name = "edt_code";
            this.edt_code.Properties.NullValuePrompt = "Code";
            this.edt_code.Size = new System.Drawing.Size(119, 20);
            this.edt_code.TabIndex = 5;
            // 
            // lue_state
            // 
            this.lue_state.Location = new System.Drawing.Point(33, 80);
            this.lue_state.Name = "lue_state";
            this.lue_state.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_state.Properties.DataSource = this.list_StatesBindingSource;
            this.lue_state.Properties.DisplayMember = "Description";
            this.lue_state.Properties.NullText = "";
            this.lue_state.Properties.NullValuePrompt = "State";
            this.lue_state.Properties.PopupFormSize = new System.Drawing.Size(100, 0);
            this.lue_state.Properties.PopupView = this.gridLookUpEdit1View;
            this.lue_state.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth;
            this.lue_state.Properties.ValueMember = "ID_State";
            this.lue_state.Size = new System.Drawing.Size(119, 20);
            this.lue_state.TabIndex = 2;
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
            storedProcQuery5.Name = "List_States";
            storedProcQuery5.StoredProcName = "List_States";
            this.SDS_States.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery5});
            this.SDS_States.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0iU0RTX1N0YXRlcyI+PFZpZXcgTmFtZT0iTGlzdF9TdGF0ZXMiPjxGaWVsZCBOY" +
    "W1lPSJEZXNjcmlwdGlvbiIgVHlwZT0iU3RyaW5nIiAvPjxGaWVsZCBOYW1lPSJJRF9TdGF0ZSIgVHlwZ" +
    "T0iR3VpZCIgLz48L1ZpZXc+PC9EYXRhU2V0Pg==";
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescription1});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colDescription1
            // 
            this.colDescription1.FieldName = "Description";
            this.colDescription1.Name = "colDescription1";
            this.colDescription1.Visible = true;
            this.colDescription1.VisibleIndex = 0;
            // 
            // lue_entityType
            // 
            this.lue_entityType.Location = new System.Drawing.Point(33, 54);
            this.lue_entityType.Name = "lue_entityType";
            this.lue_entityType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_entityType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_EntityType", "ID_Entity Type", 81, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lue_entityType.Properties.DataSource = this.list_EntityTypesBindingSource;
            this.lue_entityType.Properties.DisplayMember = "Description";
            this.lue_entityType.Properties.NullText = "";
            this.lue_entityType.Properties.NullValuePrompt = "Entity Type";
            this.lue_entityType.Properties.PopupFormMinSize = new System.Drawing.Size(119, 0);
            this.lue_entityType.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth;
            this.lue_entityType.Properties.ValueMember = "ID_EntityType";
            this.lue_entityType.Size = new System.Drawing.Size(119, 20);
            this.lue_entityType.TabIndex = 1;
            // 
            // list_EntityTypesBindingSource
            // 
            this.list_EntityTypesBindingSource.DataMember = "List_EntityTypes";
            this.list_EntityTypesBindingSource.DataSource = this.SDS_Entities;
            // 
            // SDS_Entities
            // 
            this.SDS_Entities.ConnectionName = "_Global_Connection";
            this.SDS_Entities.Name = "SDS_Entities";
            storedProcQuery6.Name = "List_EntityTypes";
            storedProcQuery6.StoredProcName = "List_EntityTypes";
            this.SDS_Entities.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery6});
            this.SDS_Entities.ResultSchemaSerializable = resources.GetString("SDS_Entities.ResultSchemaSerializable");
            // 
            // btn_preview
            // 
            this.btn_preview.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_preview.ImageOptions.Image")));
            this.btn_preview.Location = new System.Drawing.Point(33, 274);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(119, 85);
            this.btn_preview.TabIndex = 9;
            this.btn_preview.Text = "Preview";
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.ImageOptions.Image")));
            this.btn_Save.Location = new System.Drawing.Point(158, 274);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(119, 85);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // edt_URL
            // 
            this.edt_URL.Location = new System.Drawing.Point(6, 72);
            this.edt_URL.Name = "edt_URL";
            this.edt_URL.Properties.NullValuePrompt = "URL";
            this.edt_URL.Size = new System.Drawing.Size(244, 20);
            this.edt_URL.TabIndex = 8;
            // 
            // edt_Description
            // 
            this.edt_Description.Location = new System.Drawing.Point(6, 20);
            this.edt_Description.Name = "edt_Description";
            this.edt_Description.Properties.NullValuePrompt = "Description";
            this.edt_Description.Size = new System.Drawing.Size(119, 20);
            this.edt_Description.TabIndex = 4;
            this.edt_Description.EditValueChanged += new System.EventHandler(this.edt_Description_EditValueChanged);
            // 
            // edt_Lon
            // 
            this.edt_Lon.Location = new System.Drawing.Point(131, 46);
            this.edt_Lon.Name = "edt_Lon";
            this.edt_Lon.Properties.NullValuePrompt = "Longitude";
            this.edt_Lon.Size = new System.Drawing.Size(119, 20);
            this.edt_Lon.TabIndex = 7;
            this.edt_Lon.EditValueChanged += new System.EventHandler(this.edt_Log_EditValueChanged);
            // 
            // edt_Lat
            // 
            this.edt_Lat.Location = new System.Drawing.Point(6, 46);
            this.edt_Lat.Name = "edt_Lat";
            this.edt_Lat.Properties.NullValuePrompt = "Latitude";
            this.edt_Lat.Size = new System.Drawing.Size(119, 20);
            this.edt_Lat.TabIndex = 6;
            // 
            // lue_City
            // 
            this.lue_City.Location = new System.Drawing.Point(158, 80);
            this.lue_City.Name = "lue_City";
            this.lue_City.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_City.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 62, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_State", "ID_State", 52, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description_1", "Description_1", 74, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_City", "ID_City", 45, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lue_City.Properties.DataSource = this.list_CitiesByStateBindingSource1;
            this.lue_City.Properties.DisplayMember = "Description_1";
            this.lue_City.Properties.NullText = "";
            this.lue_City.Properties.NullValuePrompt = "City";
            this.lue_City.Properties.PopupFormMinSize = new System.Drawing.Size(119, 0);
            this.lue_City.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth;
            this.lue_City.Properties.ValueMember = "ID_City";
            this.lue_City.Size = new System.Drawing.Size(119, 20);
            this.lue_City.TabIndex = 3;
            // 
            // list_CitiesByStateBindingSource1
            // 
            this.list_CitiesByStateBindingSource1.DataMember = "List_CitiesByState";
            this.list_CitiesByStateBindingSource1.DataSource = this.SDS_Cities;
            // 
            // SDS_Cities
            // 
            this.SDS_Cities.ConnectionName = "_Global_Connection";
            this.SDS_Cities.Name = "SDS_Cities";
            storedProcQuery7.Name = "List_CitiesByState";
            queryParameter2.Name = "@ID_state";
            queryParameter2.Type = typeof(System.Guid);
            queryParameter2.ValueInfo = "8da2086e-0f15-424f-9f17-c9b60dbcfd7b";
            storedProcQuery7.Parameters.Add(queryParameter2);
            storedProcQuery7.StoredProcName = "List_CitiesByState";
            this.SDS_Cities.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery7});
            this.SDS_Cities.ResultSchemaSerializable = resources.GetString("SDS_Cities.ResultSchemaSerializable");
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(33, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "New Entity/Location";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.webBrowser1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(521, 548);
            this.panelControl2.TabIndex = 0;
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
            storedProcQuery8.Name = "List_Entities";
            storedProcQuery8.StoredProcName = "List_Entities";
            this.SDS_entitiesGrid.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery8});
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
            // list_StatesBindingSource1
            // 
            this.list_StatesBindingSource1.DataMember = "List_States";
            this.list_StatesBindingSource1.DataSource = this.SDS_States;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edt_Description);
            this.groupBox1.Controls.Add(this.edt_code);
            this.groupBox1.Controls.Add(this.edt_Lat);
            this.groupBox1.Controls.Add(this.edt_Lon);
            this.groupBox1.Controls.Add(this.edt_URL);
            this.groupBox1.Location = new System.Drawing.Point(24, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 105);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Data";
            // 
            // frm_Entity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 596);
            this.Controls.Add(this.XTP1);
            this.Name = "frm_Entity";
            this.Text = "frm_Entity";
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
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_code.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_state.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_StatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_entityType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_EntityTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_URL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_Description.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_Lon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_Lat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_City.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_CitiesByStateBindingSource1)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.list_StatesBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl XTP1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LookUpEdit lue_entityType;
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
        private System.Windows.Forms.BindingSource list_EntityTypesBindingSource;
        private System.Windows.Forms.BindingSource list_StatesBindingSource1;
        private System.Windows.Forms.BindingSource list_CitiesByStateBindingSource1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GridLookUpEdit lue_state;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.DataAccess.Sql.SqlDataSource SDS_entitiesGrid;
        private DevExpress.XtraEditors.TextEdit edt_code;
        private System.Windows.Forms.BindingSource list_StatesBindingSource;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colCoords;
        private DevExpress.XtraGrid.Columns.GridColumn colURL;
        private DevExpress.XtraGrid.Columns.GridColumn colEntityType;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}