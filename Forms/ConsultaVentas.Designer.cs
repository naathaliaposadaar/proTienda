namespace proTienda
{
    partial class ConsultaVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaVentas));
            this.lvListaVentas = new System.Windows.Forms.ListView();
            this.FechaVenta = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.FechaFin = new System.Windows.Forms.DateTimePicker();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.vVENTASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbTiendaDataSet = new proTienda.dbTiendaDataSet();
            this.vENTASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENTASTableAdapter = new proTienda.dbTiendaDataSetTableAdapters.VENTASTableAdapter();
            this.vVENTASTableAdapter = new proTienda.dbTiendaDataSetTableAdapters.vVENTASTableAdapter();
            this.fOLIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPRODUCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cANTIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUNITARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCPRODUCTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vVENTASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTiendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lvListaVentas
            // 
            this.lvListaVentas.GridLines = true;
            this.lvListaVentas.Location = new System.Drawing.Point(651, 60);
            this.lvListaVentas.Name = "lvListaVentas";
            this.lvListaVentas.Size = new System.Drawing.Size(184, 359);
            this.lvListaVentas.TabIndex = 0;
            this.lvListaVentas.UseCompatibleStateImageBehavior = false;
            this.lvListaVentas.SelectedIndexChanged += new System.EventHandler(this.lvListaVentas_SelectedIndexChanged);
            // 
            // FechaVenta
            // 
            this.FechaVenta.CustomFormat = "yyyy/MM/dd";
            this.FechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaVenta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FechaVenta.Location = new System.Drawing.Point(12, 34);
            this.FechaVenta.Name = "FechaVenta";
            this.FechaVenta.Size = new System.Drawing.Size(200, 20);
            this.FechaVenta.TabIndex = 1;
            this.FechaVenta.ValueChanged += new System.EventHandler(this.FechaVenta_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(651, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Todos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FechaFin
            // 
            this.FechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaFin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FechaFin.Location = new System.Drawing.Point(261, 34);
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.Size = new System.Drawing.Size(200, 20);
            this.FechaFin.TabIndex = 1;
            this.FechaFin.ValueChanged += new System.EventHandler(this.FechaFin_ValueChanged);
            // 
            // dgvVentas
            // 
            this.dgvVentas.AutoGenerateColumns = false;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fOLIODataGridViewTextBoxColumn,
            this.iDPRODUCTODataGridViewTextBoxColumn,
            this.cANTIDADDataGridViewTextBoxColumn,
            this.pUNITARIODataGridViewTextBoxColumn,
            this.iVADataGridViewTextBoxColumn,
            this.tOTALDataGridViewTextBoxColumn,
            this.dESCPRODUCTODataGridViewTextBoxColumn,
            this.uSERNAMEDataGridViewTextBoxColumn,
            this.fECHADataGridViewTextBoxColumn});
            this.dgvVentas.DataSource = this.vVENTASBindingSource;
            this.dgvVentas.Location = new System.Drawing.Point(12, 60);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(551, 359);
            this.dgvVentas.TabIndex = 3;
            this.dgvVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // vVENTASBindingSource
            // 
            this.vVENTASBindingSource.DataMember = "vVENTAS";
            this.vVENTASBindingSource.DataSource = this.dbTiendaDataSet;
            // 
            // dbTiendaDataSet
            // 
            this.dbTiendaDataSet.DataSetName = "dbTiendaDataSet";
            this.dbTiendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vENTASBindingSource
            // 
            this.vENTASBindingSource.DataMember = "VENTAS";
            this.vENTASBindingSource.DataSource = this.dbTiendaDataSet;
            // 
            // vENTASTableAdapter
            // 
            this.vENTASTableAdapter.ClearBeforeFill = true;
            // 
            // vVENTASTableAdapter
            // 
            this.vVENTASTableAdapter.ClearBeforeFill = true;
            // 
            // fOLIODataGridViewTextBoxColumn
            // 
            this.fOLIODataGridViewTextBoxColumn.DataPropertyName = "FOLIO";
            this.fOLIODataGridViewTextBoxColumn.HeaderText = "FOLIO";
            this.fOLIODataGridViewTextBoxColumn.Name = "fOLIODataGridViewTextBoxColumn";
            // 
            // iDPRODUCTODataGridViewTextBoxColumn
            // 
            this.iDPRODUCTODataGridViewTextBoxColumn.DataPropertyName = "ID_PRODUCTO";
            this.iDPRODUCTODataGridViewTextBoxColumn.HeaderText = "ID_PRODUCTO";
            this.iDPRODUCTODataGridViewTextBoxColumn.Name = "iDPRODUCTODataGridViewTextBoxColumn";
            // 
            // cANTIDADDataGridViewTextBoxColumn
            // 
            this.cANTIDADDataGridViewTextBoxColumn.DataPropertyName = "CANTIDAD";
            this.cANTIDADDataGridViewTextBoxColumn.HeaderText = "CANTIDAD";
            this.cANTIDADDataGridViewTextBoxColumn.Name = "cANTIDADDataGridViewTextBoxColumn";
            // 
            // pUNITARIODataGridViewTextBoxColumn
            // 
            this.pUNITARIODataGridViewTextBoxColumn.DataPropertyName = "P_UNITARIO";
            this.pUNITARIODataGridViewTextBoxColumn.HeaderText = "P_UNITARIO";
            this.pUNITARIODataGridViewTextBoxColumn.Name = "pUNITARIODataGridViewTextBoxColumn";
            // 
            // iVADataGridViewTextBoxColumn
            // 
            this.iVADataGridViewTextBoxColumn.DataPropertyName = "IVA";
            this.iVADataGridViewTextBoxColumn.HeaderText = "IVA";
            this.iVADataGridViewTextBoxColumn.Name = "iVADataGridViewTextBoxColumn";
            this.iVADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tOTALDataGridViewTextBoxColumn
            // 
            this.tOTALDataGridViewTextBoxColumn.DataPropertyName = "TOTAL";
            this.tOTALDataGridViewTextBoxColumn.HeaderText = "TOTAL";
            this.tOTALDataGridViewTextBoxColumn.Name = "tOTALDataGridViewTextBoxColumn";
            this.tOTALDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESCPRODUCTODataGridViewTextBoxColumn
            // 
            this.dESCPRODUCTODataGridViewTextBoxColumn.DataPropertyName = "DESC_PRODUCTO";
            this.dESCPRODUCTODataGridViewTextBoxColumn.HeaderText = "DESC_PRODUCTO";
            this.dESCPRODUCTODataGridViewTextBoxColumn.Name = "dESCPRODUCTODataGridViewTextBoxColumn";
            // 
            // uSERNAMEDataGridViewTextBoxColumn
            // 
            this.uSERNAMEDataGridViewTextBoxColumn.DataPropertyName = "USER_NAME";
            this.uSERNAMEDataGridViewTextBoxColumn.HeaderText = "USER_NAME";
            this.uSERNAMEDataGridViewTextBoxColumn.Name = "uSERNAMEDataGridViewTextBoxColumn";
            // 
            // fECHADataGridViewTextBoxColumn
            // 
            this.fECHADataGridViewTextBoxColumn.DataPropertyName = "FECHA";
            this.fECHADataGridViewTextBoxColumn.HeaderText = "FECHA";
            this.fECHADataGridViewTextBoxColumn.Name = "fECHADataGridViewTextBoxColumn";
            this.fECHADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ConsultaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 431);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FechaFin);
            this.Controls.Add(this.FechaVenta);
            this.Controls.Add(this.lvListaVentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 500);
            this.MinimumSize = new System.Drawing.Size(767, 381);
            this.Name = "ConsultaVentas";
            this.Text = "frmConsultaVentas";
            this.Load += new System.EventHandler(this.frmConsultaVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vVENTASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTiendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvListaVentas;
        private System.Windows.Forms.DateTimePicker FechaVenta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker FechaFin;
        private System.Windows.Forms.DataGridView dgvVentas;
        private dbTiendaDataSet dbTiendaDataSet;
        private System.Windows.Forms.BindingSource vENTASBindingSource;
        private dbTiendaDataSetTableAdapters.VENTASTableAdapter vENTASTableAdapter;
        private System.Windows.Forms.BindingSource vVENTASBindingSource;
        private dbTiendaDataSetTableAdapters.vVENTASTableAdapter vVENTASTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fOLIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPRODUCTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cANTIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUNITARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iVADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCPRODUCTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHADataGridViewTextBoxColumn;
    }
}