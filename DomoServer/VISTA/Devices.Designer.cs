namespace DomoServer.VISTA
{
	partial class Devices
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
			this.dataDevices = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataDevices)).BeginInit();
			this.SuspendLayout();
			// 
			// dataDevices
			// 
			this.dataDevices.AllowUserToAddRows = false;
			this.dataDevices.AllowUserToDeleteRows = false;
			this.dataDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataDevices.Location = new System.Drawing.Point(12, 12);
			this.dataDevices.Name = "dataDevices";
			this.dataDevices.ReadOnly = true;
			this.dataDevices.Size = new System.Drawing.Size(776, 426);
			this.dataDevices.TabIndex = 0;
			// 
			// Devices
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataDevices);
			this.Name = "Devices";
			this.Text = "Devices";
			((System.ComponentModel.ISupportInitialize)(this.dataDevices)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataDevices;
	}
}