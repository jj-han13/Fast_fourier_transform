namespace Fast_fourier_transform
{
    partial class main_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        
        // 释放资源
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView_timedomain = new System.Windows.Forms.DataGridView();
            this.Column_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_amplitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_td_chart = new System.Windows.Forms.Button();
            this.button_import = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_frequencydomain = new System.Windows.Forms.DataGridView();
            this.button_fft = new System.Windows.Forms.Button();
            this.button_fd_chart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip_datagridview = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Column_freq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_magnitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_phase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_real = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_img = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_timedomain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_frequencydomain)).BeginInit();
            this.contextMenuStrip_datagridview.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Location = new System.Drawing.Point(0, 1235);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(2516, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button_fft);
            this.splitContainer1.Panel1.Controls.Add(this.button_td_chart);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView_timedomain);
            this.splitContainer1.Panel1.Controls.Add(this.button_import);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView_frequencydomain);
            this.splitContainer1.Panel2.Controls.Add(this.button_fd_chart);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(2516, 1235);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 2;
            // 
            // dataGridView_timedomain
            // 
            //this.dataGridView_timedomain.AllowUserToAddRows = false;
            //this.dataGridView_timedomain.AllowUserToOrderColumns = false;
            this.dataGridView_timedomain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView_timedomain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_timedomain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_time,
            this.Column_amplitude});
            this.dataGridView_timedomain.Location = new System.Drawing.Point(15, 162);
            this.dataGridView_timedomain.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView_timedomain.Name = "dataGridView_timedomain";
            this.dataGridView_timedomain.RowHeadersWidth = 82;
            this.dataGridView_timedomain.Size = new System.Drawing.Size(1520, 9544);
            this.dataGridView_timedomain.TabIndex = 3;
            this.dataGridView_timedomain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // Column_time
            // 
            this.Column_time.HeaderText = "Time (s)";
            this.Column_time.MinimumWidth = 10;
            this.Column_time.Name = "Column_time";
            this.Column_time.Width = 150;
            // 
            // Column_amplitude
            // 
            this.Column_amplitude.HeaderText = "Amplitude";
            this.Column_amplitude.MinimumWidth = 10;
            this.Column_amplitude.Name = "Column_amplitude";
            this.Column_amplitude.Width = 150;
            // 
            // button_td_chart
            // 
            this.button_td_chart.Location = new System.Drawing.Point(285, 82);
            this.button_td_chart.Margin = new System.Windows.Forms.Padding(6);
            this.button_td_chart.Name = "button_td_chart";
            this.button_td_chart.Size = new System.Drawing.Size(220, 65);
            this.button_td_chart.TabIndex = 2;
            this.button_td_chart.Text = "Chart";
            this.button_td_chart.UseVisualStyleBackColor = true;
            this.button_td_chart.Click += new System.EventHandler(this.button_td_chart_Click);
            // 
            // button_import
            // 
            this.button_import.Location = new System.Drawing.Point(15, 82);
            this.button_import.Margin = new System.Windows.Forms.Padding(6);
            this.button_import.Name = "button_import";
            this.button_import.Size = new System.Drawing.Size(220, 65);
            this.button_import.TabIndex = 1;
            this.button_import.Text = "Import";
            this.button_import.UseVisualStyleBackColor = true;
            this.button_import.Click += new System.EventHandler(this.button_import_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time Domain";
            // 
            // dataGridView_frequencydomain
            // 
            this.dataGridView_frequencydomain.AllowUserToAddRows = false;
            this.dataGridView_frequencydomain.AllowUserToDeleteRows = false;
            this.dataGridView_frequencydomain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView_frequencydomain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_frequencydomain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_freq,
            this.Column_magnitude,
            this.Column_phase,
            this.Column_real,
            this.Column_img});
            this.dataGridView_frequencydomain.Location = new System.Drawing.Point(18, 159);
            this.dataGridView_frequencydomain.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView_frequencydomain.Name = "dataGridView_frequencydomain";
            this.dataGridView_frequencydomain.ReadOnly = true;
            this.dataGridView_frequencydomain.RowHeadersWidth = 82;
            this.dataGridView_frequencydomain.Size = new System.Drawing.Size(1883, 2323);
            this.dataGridView_frequencydomain.TabIndex = 2;
            // 
            // button_fft
            // 
            this.button_fft.Location = new System.Drawing.Point(558, 79);
            this.button_fft.Margin = new System.Windows.Forms.Padding(6);
            this.button_fft.Name = "button_fft";
            this.button_fft.Size = new System.Drawing.Size(220, 70);
            this.button_fft.TabIndex = 4;
            this.button_fft.Text = "FFT";
            this.button_fft.UseVisualStyleBackColor = true;
            this.button_fft.Click += new System.EventHandler(this.button_fft_Click);
            // 
            // button_fd_chart
            // 
            this.button_fd_chart.Location = new System.Drawing.Point(31, 82);
            this.button_fd_chart.Margin = new System.Windows.Forms.Padding(6);
            this.button_fd_chart.Name = "button_fd_chart";
            this.button_fd_chart.Size = new System.Drawing.Size(220, 65);
            this.button_fd_chart.TabIndex = 1;
            this.button_fd_chart.Text = "Chart";
            this.button_fd_chart.UseVisualStyleBackColor = true;
            this.button_fd_chart.Click += new System.EventHandler(this.button_fd_chart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(555, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "Frequency Domain";
            // 
            // contextMenuStrip_datagridview
            // 
            this.contextMenuStrip_datagridview.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip_datagridview.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasteToolStripMenuItem,
            this.importDataToolStripMenuItem,
            this.showChartToolStripMenuItem,
            this.clearDataToolStripMenuItem});
            this.contextMenuStrip_datagridview.Name = "contextMenuStrip_datagridview";
            this.contextMenuStrip_datagridview.Size = new System.Drawing.Size(276, 156);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(275, 38);
            this.pasteToolStripMenuItem.Text = "Paste from Excel";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // importDataToolStripMenuItem
            // 
            this.importDataToolStripMenuItem.Name = "importDataToolStripMenuItem";
            this.importDataToolStripMenuItem.Size = new System.Drawing.Size(275, 38);
            this.importDataToolStripMenuItem.Text = "Import Data";
            this.importDataToolStripMenuItem.Click += new System.EventHandler(this.importDataToolStripMenuItem_Click);
            // 
            // showChartToolStripMenuItem
            // 
            this.showChartToolStripMenuItem.Name = "showChartToolStripMenuItem";
            this.showChartToolStripMenuItem.Size = new System.Drawing.Size(275, 38);
            this.showChartToolStripMenuItem.Text = "Show Chart";
            this.showChartToolStripMenuItem.Click += new System.EventHandler(this.showChartToolStripMenuItem_Click);
            // 
            // clearDataToolStripMenuItem
            // 
            this.clearDataToolStripMenuItem.Name = "clearDataToolStripMenuItem";
            this.clearDataToolStripMenuItem.Size = new System.Drawing.Size(275, 38);
            this.clearDataToolStripMenuItem.Text = "Clear Data";
            this.clearDataToolStripMenuItem.Click += new System.EventHandler(this.clearDataToolStripMenuItem_Click);
            // 
            // Column_freq
            // 
            this.Column_freq.HeaderText = "Frequency (Hz)";
            this.Column_freq.MinimumWidth = 10;
            this.Column_freq.Name = "Column_freq";
            this.Column_freq.ReadOnly = true;
            this.Column_freq.Width = 150;
            // 
            // Column_magnitude
            // 
            this.Column_magnitude.HeaderText = "Magnitude";
            this.Column_magnitude.MinimumWidth = 10;
            this.Column_magnitude.Name = "Column_magnitude";
            this.Column_magnitude.ReadOnly = true;
            this.Column_magnitude.Width = 150;
            // 
            // Column_phase
            // 
            this.Column_phase.HeaderText = "Phase";
            this.Column_phase.MinimumWidth = 10;
            this.Column_phase.Name = "Column_phase";
            this.Column_phase.ReadOnly = true;
            this.Column_phase.Width = 150;
            // 
            // Column_real
            // 
            this.Column_real.HeaderText = "Real";
            this.Column_real.MinimumWidth = 10;
            this.Column_real.Name = "Column_real";
            this.Column_real.ReadOnly = true;
            this.Column_real.Width = 150;
            // 
            // Column_img
            // 
            this.Column_img.HeaderText = "Img";
            this.Column_img.MinimumWidth = 10;
            this.Column_img.Name = "Column_img";
            this.Column_img.ReadOnly = true;
            this.Column_img.Width = 150;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2516, 1257);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(2094, 1269);
            this.Name = "main_form";
            this.Text = "Fast Fourier Transform ----- Developed by Samson Mano <https://sites.google.com/s" +
    "ite/samsoninfinite/>";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_timedomain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_frequencydomain)).EndInit();
            this.contextMenuStrip_datagridview.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_td_chart;
        private System.Windows.Forms.Button button_import;
        private System.Windows.Forms.Button button_fd_chart;
        private System.Windows.Forms.DataGridView dataGridView_timedomain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_amplitude;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_datagridview;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearDataToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView_frequencydomain;
        private System.Windows.Forms.Button button_fft;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_freq;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_magnitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_phase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_real;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_img;
    }
}