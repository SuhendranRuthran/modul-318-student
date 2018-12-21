namespace FAHRPLAN_APPLIKATION
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LBX_station = new System.Windows.Forms.ListBox();
            this.BTN_suche_3 = new System.Windows.Forms.Button();
            this.TXT_station = new System.Windows.Forms.TextBox();
            this.WEB_google_maps = new System.Windows.Forms.WebBrowser();
            this.GRP_suche_3 = new System.Windows.Forms.GroupBox();
            this.LBL_station = new System.Windows.Forms.Label();
            this.BTN_nav3 = new System.Windows.Forms.Button();
            this.LBX_von_2 = new System.Windows.Forms.ListBox();
            this.BTN_suche_2 = new System.Windows.Forms.Button();
            this.BTN_von_2 = new System.Windows.Forms.TextBox();
            this.LBL_von_2 = new System.Windows.Forms.Label();
            this.GRP_suche_2 = new System.Windows.Forms.GroupBox();
            this.DTG_Verbindungen_2 = new System.Windows.Forms.DataGridView();
            this.GRP_result_2 = new System.Windows.Forms.GroupBox();
            this.DTG_verbindungen = new System.Windows.Forms.DataGridView();
            this.BTN_nav2 = new System.Windows.Forms.Button();
            this.GRP_suche = new System.Windows.Forms.GroupBox();
            this.TXT_email = new System.Windows.Forms.TextBox();
            this.BTN_email = new System.Windows.Forms.Button();
            this.PB_switch = new System.Windows.Forms.PictureBox();
            this.TXT_nach = new System.Windows.Forms.TextBox();
            this.TXT_von = new System.Windows.Forms.TextBox();
            this.DTP_zeit = new System.Windows.Forms.DateTimePicker();
            this.DTP_datum = new System.Windows.Forms.DateTimePicker();
            this.BTN_suche = new System.Windows.Forms.Button();
            this.BTN_google_maps = new System.Windows.Forms.Button();
            this.LBL_von = new System.Windows.Forms.Label();
            this.LBL_nach = new System.Windows.Forms.Label();
            this.LBL_datum = new System.Windows.Forms.Label();
            this.LBL_zeit = new System.Windows.Forms.Label();
            this.LBX_von = new System.Windows.Forms.ListBox();
            this.LBX_nach = new System.Windows.Forms.ListBox();
            this.PNL_3 = new System.Windows.Forms.Panel();
            this.PNL_1 = new System.Windows.Forms.Panel();
            this.GRP_result = new System.Windows.Forms.GroupBox();
            this.PNL_2 = new System.Windows.Forms.Panel();
            this.PB_zug = new System.Windows.Forms.PictureBox();
            this.LBL_titel_abfahrtstafel = new System.Windows.Forms.Label();
            this.BTN_nav1 = new System.Windows.Forms.Button();
            this.BTN_close = new System.Windows.Forms.Button();
            this.LBL_laden = new System.Windows.Forms.PictureBox();
            this.GRP_suche_3.SuspendLayout();
            this.GRP_suche_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_Verbindungen_2)).BeginInit();
            this.GRP_result_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_verbindungen)).BeginInit();
            this.GRP_suche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_switch)).BeginInit();
            this.PNL_3.SuspendLayout();
            this.PNL_1.SuspendLayout();
            this.GRP_result.SuspendLayout();
            this.PNL_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_zug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LBL_laden)).BeginInit();
            this.SuspendLayout();
            // 
            // LBX_station
            // 
            this.LBX_station.FormattingEnabled = true;
            this.LBX_station.Location = new System.Drawing.Point(6, 59);
            this.LBX_station.Name = "LBX_station";
            this.LBX_station.Size = new System.Drawing.Size(200, 95);
            this.LBX_station.TabIndex = 9;
            this.LBX_station.Visible = false;
            this.LBX_station.DoubleClick += new System.EventHandler(this.lbx_3_start_DoubleClick);
            // 
            // BTN_suche_3
            // 
            this.BTN_suche_3.BackColor = System.Drawing.Color.Firebrick;
            this.BTN_suche_3.ForeColor = System.Drawing.Color.White;
            this.BTN_suche_3.Location = new System.Drawing.Point(225, 37);
            this.BTN_suche_3.Name = "BTN_suche_3";
            this.BTN_suche_3.Size = new System.Drawing.Size(134, 23);
            this.BTN_suche_3.TabIndex = 14;
            this.BTN_suche_3.Text = "Station anzeigen";
            this.BTN_suche_3.UseVisualStyleBackColor = false;
            this.BTN_suche_3.Click += new System.EventHandler(this.BTN_suche_3_Click);
            // 
            // TXT_station
            // 
            this.TXT_station.Location = new System.Drawing.Point(6, 40);
            this.TXT_station.Name = "TXT_station";
            this.TXT_station.Size = new System.Drawing.Size(200, 20);
            this.TXT_station.TabIndex = 13;
            this.TXT_station.TextChanged += new System.EventHandler(this.TXT_station_TextChanged);
            // 
            // WEB_google_maps
            // 
            this.WEB_google_maps.Location = new System.Drawing.Point(14, 181);
            this.WEB_google_maps.MinimumSize = new System.Drawing.Size(20, 20);
            this.WEB_google_maps.Name = "WEB_google_maps";
            this.WEB_google_maps.ScriptErrorsSuppressed = true;
            this.WEB_google_maps.Size = new System.Drawing.Size(661, 341);
            this.WEB_google_maps.TabIndex = 5;
            // 
            // GRP_suche_3
            // 
            this.GRP_suche_3.Controls.Add(this.LBX_station);
            this.GRP_suche_3.Controls.Add(this.BTN_suche_3);
            this.GRP_suche_3.Controls.Add(this.TXT_station);
            this.GRP_suche_3.Controls.Add(this.LBL_station);
            this.GRP_suche_3.Location = new System.Drawing.Point(8, 10);
            this.GRP_suche_3.Name = "GRP_suche_3";
            this.GRP_suche_3.Size = new System.Drawing.Size(887, 164);
            this.GRP_suche_3.TabIndex = 4;
            this.GRP_suche_3.TabStop = false;
            this.GRP_suche_3.Text = "Suche";
            // 
            // LBL_station
            // 
            this.LBL_station.AutoSize = true;
            this.LBL_station.Location = new System.Drawing.Point(6, 24);
            this.LBL_station.Name = "LBL_station";
            this.LBL_station.Size = new System.Drawing.Size(40, 13);
            this.LBL_station.TabIndex = 2;
            this.LBL_station.Text = "Station";
            // 
            // BTN_nav3
            // 
            this.BTN_nav3.BackColor = System.Drawing.Color.Firebrick;
            this.BTN_nav3.ForeColor = System.Drawing.Color.White;
            this.BTN_nav3.Location = new System.Drawing.Point(394, 20);
            this.BTN_nav3.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.BTN_nav3.Name = "BTN_nav3";
            this.BTN_nav3.Size = new System.Drawing.Size(150, 58);
            this.BTN_nav3.TabIndex = 9;
            this.BTN_nav3.Text = "Google Maps";
            this.BTN_nav3.UseVisualStyleBackColor = false;
            this.BTN_nav3.Click += new System.EventHandler(this.BTN_nav3_Click);
            // 
            // LBX_von_2
            // 
            this.LBX_von_2.FormattingEnabled = true;
            this.LBX_von_2.Location = new System.Drawing.Point(9, 59);
            this.LBX_von_2.Name = "LBX_von_2";
            this.LBX_von_2.Size = new System.Drawing.Size(200, 95);
            this.LBX_von_2.TabIndex = 0;
            this.LBX_von_2.Visible = false;
            this.LBX_von_2.DoubleClick += new System.EventHandler(this.LBX_von_2_DoubleClick);
            // 
            // BTN_suche_2
            // 
            this.BTN_suche_2.BackColor = System.Drawing.Color.Firebrick;
            this.BTN_suche_2.ForeColor = System.Drawing.Color.White;
            this.BTN_suche_2.Location = new System.Drawing.Point(226, 37);
            this.BTN_suche_2.Name = "BTN_suche_2";
            this.BTN_suche_2.Size = new System.Drawing.Size(134, 23);
            this.BTN_suche_2.TabIndex = 12;
            this.BTN_suche_2.Text = "Abfahrtstafel anzeigen";
            this.BTN_suche_2.UseVisualStyleBackColor = false;
            this.BTN_suche_2.Click += new System.EventHandler(this.BTN_suche_2_Click);
            // 
            // BTN_von_2
            // 
            this.BTN_von_2.Location = new System.Drawing.Point(9, 40);
            this.BTN_von_2.Name = "BTN_von_2";
            this.BTN_von_2.Size = new System.Drawing.Size(200, 20);
            this.BTN_von_2.TabIndex = 11;
            this.BTN_von_2.TextChanged += new System.EventHandler(this.BTN_von_2_TextChanged);
            // 
            // LBL_von_2
            // 
            this.LBL_von_2.AutoSize = true;
            this.LBL_von_2.Location = new System.Drawing.Point(9, 24);
            this.LBL_von_2.Name = "LBL_von_2";
            this.LBL_von_2.Size = new System.Drawing.Size(26, 13);
            this.LBL_von_2.TabIndex = 2;
            this.LBL_von_2.Text = "Von";
            // 
            // GRP_suche_2
            // 
            this.GRP_suche_2.Controls.Add(this.LBX_von_2);
            this.GRP_suche_2.Controls.Add(this.BTN_suche_2);
            this.GRP_suche_2.Controls.Add(this.BTN_von_2);
            this.GRP_suche_2.Controls.Add(this.LBL_von_2);
            this.GRP_suche_2.Location = new System.Drawing.Point(12, 102);
            this.GRP_suche_2.Name = "GRP_suche_2";
            this.GRP_suche_2.Size = new System.Drawing.Size(502, 164);
            this.GRP_suche_2.TabIndex = 3;
            this.GRP_suche_2.TabStop = false;
            this.GRP_suche_2.Text = "Suche";
            // 
            // DTG_Verbindungen_2
            // 
            this.DTG_Verbindungen_2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DTG_Verbindungen_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_Verbindungen_2.Cursor = System.Windows.Forms.Cursors.No;
            this.DTG_Verbindungen_2.Location = new System.Drawing.Point(9, 24);
            this.DTG_Verbindungen_2.Name = "DTG_Verbindungen_2";
            this.DTG_Verbindungen_2.RowHeadersVisible = false;
            this.DTG_Verbindungen_2.Size = new System.Drawing.Size(481, 204);
            this.DTG_Verbindungen_2.TabIndex = 0;
            // 
            // GRP_result_2
            // 
            this.GRP_result_2.Controls.Add(this.DTG_Verbindungen_2);
            this.GRP_result_2.Location = new System.Drawing.Point(12, 273);
            this.GRP_result_2.Name = "GRP_result_2";
            this.GRP_result_2.Size = new System.Drawing.Size(502, 242);
            this.GRP_result_2.TabIndex = 4;
            this.GRP_result_2.TabStop = false;
            this.GRP_result_2.Text = "Suchergebniss";
            // 
            // DTG_verbindungen
            // 
            this.DTG_verbindungen.AllowUserToAddRows = false;
            this.DTG_verbindungen.AllowUserToDeleteRows = false;
            this.DTG_verbindungen.AllowUserToResizeRows = false;
            this.DTG_verbindungen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTG_verbindungen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTG_verbindungen.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DTG_verbindungen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DTG_verbindungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_verbindungen.Cursor = System.Windows.Forms.Cursors.No;
            this.DTG_verbindungen.Location = new System.Drawing.Point(9, 159);
            this.DTG_verbindungen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DTG_verbindungen.Name = "DTG_verbindungen";
            this.DTG_verbindungen.ReadOnly = true;
            this.DTG_verbindungen.RowHeadersVisible = false;
            this.DTG_verbindungen.Size = new System.Drawing.Size(954, 294);
            this.DTG_verbindungen.TabIndex = 0;
            this.DTG_verbindungen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTG_verbindungen_CellContentClick);
            // 
            // BTN_nav2
            // 
            this.BTN_nav2.BackColor = System.Drawing.Color.Firebrick;
            this.BTN_nav2.ForeColor = System.Drawing.Color.White;
            this.BTN_nav2.Location = new System.Drawing.Point(202, 20);
            this.BTN_nav2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.BTN_nav2.Name = "BTN_nav2";
            this.BTN_nav2.Size = new System.Drawing.Size(150, 58);
            this.BTN_nav2.TabIndex = 6;
            this.BTN_nav2.Text = "Abfahrtstafel";
            this.BTN_nav2.UseVisualStyleBackColor = false;
            this.BTN_nav2.Click += new System.EventHandler(this.BTN_nav2_Click);
            // 
            // GRP_suche
            // 
            this.GRP_suche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GRP_suche.Controls.Add(this.TXT_email);
            this.GRP_suche.Controls.Add(this.BTN_email);
            this.GRP_suche.Controls.Add(this.PB_switch);
            this.GRP_suche.Controls.Add(this.TXT_nach);
            this.GRP_suche.Controls.Add(this.TXT_von);
            this.GRP_suche.Controls.Add(this.DTP_zeit);
            this.GRP_suche.Controls.Add(this.DTP_datum);
            this.GRP_suche.Controls.Add(this.BTN_suche);
            this.GRP_suche.Controls.Add(this.BTN_google_maps);
            this.GRP_suche.Controls.Add(this.LBL_von);
            this.GRP_suche.Controls.Add(this.LBL_nach);
            this.GRP_suche.Controls.Add(this.LBL_datum);
            this.GRP_suche.Controls.Add(this.LBL_zeit);
            this.GRP_suche.Controls.Add(this.LBX_von);
            this.GRP_suche.Controls.Add(this.LBX_nach);
            this.GRP_suche.Location = new System.Drawing.Point(4, 8);
            this.GRP_suche.Name = "GRP_suche";
            this.GRP_suche.Size = new System.Drawing.Size(963, 164);
            this.GRP_suche.TabIndex = 0;
            this.GRP_suche.TabStop = false;
            this.GRP_suche.Text = "Suche";
            // 
            // TXT_email
            // 
            this.TXT_email.Location = new System.Drawing.Point(637, 109);
            this.TXT_email.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TXT_email.Name = "TXT_email";
            this.TXT_email.Size = new System.Drawing.Size(152, 20);
            this.TXT_email.TabIndex = 13;
            // 
            // BTN_email
            // 
            this.BTN_email.BackColor = System.Drawing.Color.Firebrick;
            this.BTN_email.ForeColor = System.Drawing.Color.White;
            this.BTN_email.Location = new System.Drawing.Point(637, 135);
            this.BTN_email.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BTN_email.Name = "BTN_email";
            this.BTN_email.Size = new System.Drawing.Size(152, 23);
            this.BTN_email.TabIndex = 12;
            this.BTN_email.Text = "Per Email versenden";
            this.BTN_email.UseVisualStyleBackColor = false;
            this.BTN_email.Click += new System.EventHandler(this.BTN_email_Click);
            // 
            // PB_switch
            // 
            this.PB_switch.Image = ((System.Drawing.Image)(resources.GetObject("PB_switch.Image")));
            this.PB_switch.Location = new System.Drawing.Point(210, 47);
            this.PB_switch.Name = "PB_switch";
            this.PB_switch.Size = new System.Drawing.Size(28, 31);
            this.PB_switch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_switch.TabIndex = 11;
            this.PB_switch.TabStop = false;
            this.PB_switch.Click += new System.EventHandler(this.PB_switch_Click);
            // 
            // TXT_nach
            // 
            this.TXT_nach.Location = new System.Drawing.Point(250, 40);
            this.TXT_nach.Name = "TXT_nach";
            this.TXT_nach.Size = new System.Drawing.Size(200, 20);
            this.TXT_nach.TabIndex = 5;
            this.TXT_nach.TextChanged += new System.EventHandler(this.TXT_nach_TextChanged);
            // 
            // TXT_von
            // 
            this.TXT_von.Location = new System.Drawing.Point(6, 40);
            this.TXT_von.Name = "TXT_von";
            this.TXT_von.Size = new System.Drawing.Size(200, 20);
            this.TXT_von.TabIndex = 4;
            this.TXT_von.TextChanged += new System.EventHandler(this.TXT_von_TextChanged);
            // 
            // DTP_zeit
            // 
            this.DTP_zeit.CustomFormat = "HH:mm";
            this.DTP_zeit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_zeit.Location = new System.Drawing.Point(131, 92);
            this.DTP_zeit.Name = "DTP_zeit";
            this.DTP_zeit.ShowUpDown = true;
            this.DTP_zeit.Size = new System.Drawing.Size(75, 20);
            this.DTP_zeit.TabIndex = 8;
            // 
            // DTP_datum
            // 
            this.DTP_datum.CustomFormat = "dd.MM.yyyy";
            this.DTP_datum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_datum.Location = new System.Drawing.Point(6, 92);
            this.DTP_datum.Name = "DTP_datum";
            this.DTP_datum.Size = new System.Drawing.Size(119, 20);
            this.DTP_datum.TabIndex = 7;
            // 
            // BTN_suche
            // 
            this.BTN_suche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_suche.BackColor = System.Drawing.Color.Firebrick;
            this.BTN_suche.ForeColor = System.Drawing.Color.White;
            this.BTN_suche.Location = new System.Drawing.Point(637, 40);
            this.BTN_suche.Name = "BTN_suche";
            this.BTN_suche.Size = new System.Drawing.Size(152, 23);
            this.BTN_suche.TabIndex = 9;
            this.BTN_suche.Text = "Verbindung suchen";
            this.BTN_suche.UseVisualStyleBackColor = false;
            this.BTN_suche.Click += new System.EventHandler(this.BTN_suche_Click_1);
            // 
            // BTN_google_maps
            // 
            this.BTN_google_maps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_google_maps.BackColor = System.Drawing.Color.Firebrick;
            this.BTN_google_maps.ForeColor = System.Drawing.Color.White;
            this.BTN_google_maps.Location = new System.Drawing.Point(637, 72);
            this.BTN_google_maps.Name = "BTN_google_maps";
            this.BTN_google_maps.Size = new System.Drawing.Size(152, 23);
            this.BTN_google_maps.TabIndex = 10;
            this.BTN_google_maps.Text = "Auf Google Maps ansehen";
            this.BTN_google_maps.UseVisualStyleBackColor = false;
            this.BTN_google_maps.Click += new System.EventHandler(this.BTN_google_maps_Click);
            // 
            // LBL_von
            // 
            this.LBL_von.AutoSize = true;
            this.LBL_von.Location = new System.Drawing.Point(6, 24);
            this.LBL_von.Name = "LBL_von";
            this.LBL_von.Size = new System.Drawing.Size(26, 13);
            this.LBL_von.TabIndex = 0;
            this.LBL_von.Text = "Von";
            // 
            // LBL_nach
            // 
            this.LBL_nach.AutoSize = true;
            this.LBL_nach.Location = new System.Drawing.Point(250, 24);
            this.LBL_nach.Name = "LBL_nach";
            this.LBL_nach.Size = new System.Drawing.Size(33, 13);
            this.LBL_nach.TabIndex = 0;
            this.LBL_nach.Text = "Nach";
            // 
            // LBL_datum
            // 
            this.LBL_datum.AutoSize = true;
            this.LBL_datum.BackColor = System.Drawing.Color.Firebrick;
            this.LBL_datum.ForeColor = System.Drawing.Color.White;
            this.LBL_datum.Location = new System.Drawing.Point(6, 76);
            this.LBL_datum.Name = "LBL_datum";
            this.LBL_datum.Size = new System.Drawing.Size(38, 13);
            this.LBL_datum.TabIndex = 0;
            this.LBL_datum.Text = "Datum";
            this.LBL_datum.Click += new System.EventHandler(this.LBL_datum_Click);
            // 
            // LBL_zeit
            // 
            this.LBL_zeit.AutoSize = true;
            this.LBL_zeit.BackColor = System.Drawing.Color.Firebrick;
            this.LBL_zeit.ForeColor = System.Drawing.Color.White;
            this.LBL_zeit.Location = new System.Drawing.Point(131, 76);
            this.LBL_zeit.Name = "LBL_zeit";
            this.LBL_zeit.Size = new System.Drawing.Size(25, 13);
            this.LBL_zeit.TabIndex = 0;
            this.LBL_zeit.Text = "Zeit";
            // 
            // LBX_von
            // 
            this.LBX_von.FormattingEnabled = true;
            this.LBX_von.Location = new System.Drawing.Point(6, 59);
            this.LBX_von.Name = "LBX_von";
            this.LBX_von.Size = new System.Drawing.Size(200, 95);
            this.LBX_von.TabIndex = 0;
            this.LBX_von.Visible = false;
            this.LBX_von.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LBX_von_MouseDoubleClick);
            // 
            // LBX_nach
            // 
            this.LBX_nach.FormattingEnabled = true;
            this.LBX_nach.Location = new System.Drawing.Point(250, 59);
            this.LBX_nach.Name = "LBX_nach";
            this.LBX_nach.Size = new System.Drawing.Size(200, 95);
            this.LBX_nach.TabIndex = 0;
            this.LBX_nach.Visible = false;
            this.LBX_nach.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LBX_nach_MouseDoubleClick);
            // 
            // PNL_3
            // 
            this.PNL_3.Controls.Add(this.WEB_google_maps);
            this.PNL_3.Controls.Add(this.GRP_suche_3);
            this.PNL_3.Location = new System.Drawing.Point(58, 104);
            this.PNL_3.Name = "PNL_3";
            this.PNL_3.Size = new System.Drawing.Size(721, 537);
            this.PNL_3.TabIndex = 11;
            this.PNL_3.Paint += new System.Windows.Forms.PaintEventHandler(this.PNL_3_Paint);
            // 
            // PNL_1
            // 
            this.PNL_1.Controls.Add(this.GRP_suche);
            this.PNL_1.Controls.Add(this.GRP_result);
            this.PNL_1.Location = new System.Drawing.Point(12, 101);
            this.PNL_1.Name = "PNL_1";
            this.PNL_1.Size = new System.Drawing.Size(979, 540);
            this.PNL_1.TabIndex = 7;
            this.PNL_1.Paint += new System.Windows.Forms.PaintEventHandler(this.PNL_1_Paint);
            // 
            // GRP_result
            // 
            this.GRP_result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GRP_result.Controls.Add(this.LBL_laden);
            this.GRP_result.Controls.Add(this.DTG_verbindungen);
            this.GRP_result.Location = new System.Drawing.Point(4, 67);
            this.GRP_result.Name = "GRP_result";
            this.GRP_result.Size = new System.Drawing.Size(963, 453);
            this.GRP_result.TabIndex = 0;
            this.GRP_result.TabStop = false;
            this.GRP_result.Text = "Resultat";
            // 
            // PNL_2
            // 
            this.PNL_2.Controls.Add(this.PB_zug);
            this.PNL_2.Controls.Add(this.LBL_titel_abfahrtstafel);
            this.PNL_2.Controls.Add(this.GRP_result_2);
            this.PNL_2.Controls.Add(this.GRP_suche_2);
            this.PNL_2.Location = new System.Drawing.Point(58, 101);
            this.PNL_2.Name = "PNL_2";
            this.PNL_2.Size = new System.Drawing.Size(519, 527);
            this.PNL_2.TabIndex = 10;
            this.PNL_2.Paint += new System.Windows.Forms.PaintEventHandler(this.PNL_2_Paint);
            // 
            // PB_zug
            // 
            this.PB_zug.Image = ((System.Drawing.Image)(resources.GetObject("PB_zug.Image")));
            this.PB_zug.Location = new System.Drawing.Point(21, 11);
            this.PB_zug.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PB_zug.Name = "PB_zug";
            this.PB_zug.Size = new System.Drawing.Size(75, 81);
            this.PB_zug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_zug.TabIndex = 6;
            this.PB_zug.TabStop = false;
            // 
            // LBL_titel_abfahrtstafel
            // 
            this.LBL_titel_abfahrtstafel.AutoSize = true;
            this.LBL_titel_abfahrtstafel.BackColor = System.Drawing.Color.Firebrick;
            this.LBL_titel_abfahrtstafel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_titel_abfahrtstafel.ForeColor = System.Drawing.Color.White;
            this.LBL_titel_abfahrtstafel.Location = new System.Drawing.Point(100, 29);
            this.LBL_titel_abfahrtstafel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_titel_abfahrtstafel.Name = "LBL_titel_abfahrtstafel";
            this.LBL_titel_abfahrtstafel.Size = new System.Drawing.Size(235, 44);
            this.LBL_titel_abfahrtstafel.TabIndex = 5;
            this.LBL_titel_abfahrtstafel.Text = "Abfahrtstafel";
            // 
            // BTN_nav1
            // 
            this.BTN_nav1.BackColor = System.Drawing.Color.Firebrick;
            this.BTN_nav1.ForeColor = System.Drawing.Color.White;
            this.BTN_nav1.Location = new System.Drawing.Point(12, 20);
            this.BTN_nav1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.BTN_nav1.Name = "BTN_nav1";
            this.BTN_nav1.Size = new System.Drawing.Size(150, 58);
            this.BTN_nav1.TabIndex = 5;
            this.BTN_nav1.Text = "Verbindung suchen";
            this.BTN_nav1.UseVisualStyleBackColor = false;
            this.BTN_nav1.Click += new System.EventHandler(this.BTN_nav1_Click);
            // 
            // BTN_close
            // 
            this.BTN_close.BackColor = System.Drawing.Color.Firebrick;
            this.BTN_close.ForeColor = System.Drawing.Color.White;
            this.BTN_close.Location = new System.Drawing.Point(829, 647);
            this.BTN_close.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.BTN_close.Name = "BTN_close";
            this.BTN_close.Size = new System.Drawing.Size(150, 58);
            this.BTN_close.TabIndex = 12;
            this.BTN_close.Text = "Anwendung Schliessen";
            this.BTN_close.UseVisualStyleBackColor = false;
            this.BTN_close.Click += new System.EventHandler(this.btn_exit_Click_1);
            // 
            // LBL_laden
            // 
            this.LBL_laden.Image = ((System.Drawing.Image)(resources.GetObject("LBL_laden.Image")));
            this.LBL_laden.Location = new System.Drawing.Point(-550, -330);
            this.LBL_laden.Name = "LBL_laden";
            this.LBL_laden.Size = new System.Drawing.Size(1525, 800);
            this.LBL_laden.TabIndex = 2;
            this.LBL_laden.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1015, 717);
            this.Controls.Add(this.PNL_1);
            this.Controls.Add(this.BTN_close);
            this.Controls.Add(this.BTN_nav3);
            this.Controls.Add(this.BTN_nav2);
            this.Controls.Add(this.PNL_3);
            this.Controls.Add(this.PNL_2);
            this.Controls.Add(this.BTN_nav1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1082, 802);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(967, 579);
            this.Name = "Form1";
            this.Text = "Schweizer Fahrplan (Eine Desktop-Applikation von Ruthran Suhendran)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GRP_suche_3.ResumeLayout(false);
            this.GRP_suche_3.PerformLayout();
            this.GRP_suche_2.ResumeLayout(false);
            this.GRP_suche_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_Verbindungen_2)).EndInit();
            this.GRP_result_2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTG_verbindungen)).EndInit();
            this.GRP_suche.ResumeLayout(false);
            this.GRP_suche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_switch)).EndInit();
            this.PNL_3.ResumeLayout(false);
            this.PNL_1.ResumeLayout(false);
            this.GRP_result.ResumeLayout(false);
            this.PNL_2.ResumeLayout(false);
            this.PNL_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_zug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LBL_laden)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox LBX_station;
        private System.Windows.Forms.Button BTN_suche_3;
        private System.Windows.Forms.TextBox TXT_station;
        private System.Windows.Forms.WebBrowser WEB_google_maps;
        private System.Windows.Forms.GroupBox GRP_suche_3;
        private System.Windows.Forms.Label LBL_station;
        private System.Windows.Forms.Button BTN_nav3;
        private System.Windows.Forms.ListBox LBX_von_2;
        private System.Windows.Forms.Button BTN_suche_2;
        private System.Windows.Forms.TextBox BTN_von_2;
        private System.Windows.Forms.Label LBL_von_2;
        private System.Windows.Forms.GroupBox GRP_suche_2;
        private System.Windows.Forms.DataGridView DTG_Verbindungen_2;
        private System.Windows.Forms.GroupBox GRP_result_2;
        private System.Windows.Forms.DataGridView DTG_verbindungen;
        private System.Windows.Forms.Button BTN_nav2;
        private System.Windows.Forms.GroupBox GRP_suche;
        private System.Windows.Forms.TextBox TXT_nach;
        private System.Windows.Forms.TextBox TXT_von;
        private System.Windows.Forms.DateTimePicker DTP_zeit;
        private System.Windows.Forms.DateTimePicker DTP_datum;
        private System.Windows.Forms.Button BTN_suche;
        private System.Windows.Forms.Button BTN_google_maps;
        private System.Windows.Forms.Label LBL_von;
        private System.Windows.Forms.Label LBL_nach;
        private System.Windows.Forms.Label LBL_datum;
        private System.Windows.Forms.Label LBL_zeit;
        private System.Windows.Forms.ListBox LBX_von;
        private System.Windows.Forms.ListBox LBX_nach;
        private System.Windows.Forms.Panel PNL_3;
        private System.Windows.Forms.Panel PNL_1;
        private System.Windows.Forms.GroupBox GRP_result;
        private System.Windows.Forms.Panel PNL_2;
        private System.Windows.Forms.Button BTN_nav1;
        private System.Windows.Forms.Label LBL_titel_abfahrtstafel;
        private System.Windows.Forms.PictureBox PB_zug;
        private System.Windows.Forms.PictureBox PB_switch;
        private System.Windows.Forms.Button BTN_close;
        private System.Windows.Forms.Button BTN_email;
        private System.Windows.Forms.TextBox TXT_email;
        private System.Windows.Forms.PictureBox LBL_laden;
    }
}