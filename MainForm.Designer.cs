namespace USB_Camera
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pbLiveFeed;
        private System.Windows.Forms.PictureBox pbDetectedFace;
        private System.Windows.Forms.Label lblCameraStatus;
        private System.Windows.Forms.Label lblRecordingStatus;
        private System.Windows.Forms.Button btnSnapshot;
        private System.Windows.Forms.Button btnStopSnapshot;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Label lblSavePath;
        private System.Windows.Forms.NumericUpDown numericSnapshotInterval;
        private System.Windows.Forms.Label lblSnapshotInterval;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Button btnTrain;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pbLiveFeed = new System.Windows.Forms.PictureBox();
            this.pbDetectedFace = new System.Windows.Forms.PictureBox();
            this.lblCameraStatus = new System.Windows.Forms.Label();
            this.lblRecordingStatus = new System.Windows.Forms.Label();
            this.btnSnapshot = new System.Windows.Forms.Button();
            this.btnStopSnapshot = new System.Windows.Forms.Button();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.lblSavePath = new System.Windows.Forms.Label();
            this.numericSnapshotInterval = new System.Windows.Forms.NumericUpDown();
            this.lblSnapshotInterval = new System.Windows.Forms.Label();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.btnTrain = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.pbLiveFeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetectedFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSnapshotInterval)).BeginInit();
            this.SuspendLayout();

            // 
            // pbLiveFeed
            // 
            this.pbLiveFeed.Location = new System.Drawing.Point(12, 12);
            this.pbLiveFeed.Name = "pbLiveFeed";
            this.pbLiveFeed.Size = new System.Drawing.Size(640, 480);
            this.pbLiveFeed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLiveFeed.TabIndex = 0;
            this.pbLiveFeed.TabStop = false;

            // 
            // pbDetectedFace
            // 
            this.pbDetectedFace.Location = new System.Drawing.Point(660, 12);
            this.pbDetectedFace.Name = "pbDetectedFace";
            this.pbDetectedFace.Size = new System.Drawing.Size(160, 160);
            this.pbDetectedFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDetectedFace.TabIndex = 1;
            this.pbDetectedFace.TabStop = false;

            // 
            // lblCameraStatus
            // 
            this.lblCameraStatus.Location = new System.Drawing.Point(12, 500);
            this.lblCameraStatus.Name = "lblCameraStatus";
            this.lblCameraStatus.Size = new System.Drawing.Size(200, 23);
            this.lblCameraStatus.TabIndex = 2;
            this.lblCameraStatus.Text = "Camera: Disconnected";

            // 
            // lblRecordingStatus
            // 
            this.lblRecordingStatus.Location = new System.Drawing.Point(12, 530);
            this.lblRecordingStatus.Name = "lblRecordingStatus";
            this.lblRecordingStatus.Size = new System.Drawing.Size(200, 23);
            this.lblRecordingStatus.TabIndex = 3;

            // 
            // btnSnapshot
            // 
            this.btnSnapshot.Location = new System.Drawing.Point(12, 560);
            this.btnSnapshot.Name = "btnSnapshot";
            this.btnSnapshot.Size = new System.Drawing.Size(100, 30);
            this.btnSnapshot.TabIndex = 4;
            this.btnSnapshot.Text = "Start Snapshot";
            this.btnSnapshot.UseVisualStyleBackColor = true;

            // 
            // btnStopSnapshot
            // 
            this.btnStopSnapshot.Location = new System.Drawing.Point(120, 560);
            this.btnStopSnapshot.Name = "btnStopSnapshot";
            this.btnStopSnapshot.Size = new System.Drawing.Size(100, 30);
            this.btnStopSnapshot.TabIndex = 5;
            this.btnStopSnapshot.Text = "Stop Snapshot";
            this.btnStopSnapshot.UseVisualStyleBackColor = true;

            // 
            // txtSavePath
            // 
            this.txtSavePath.Location = new System.Drawing.Point(300, 560);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(300, 23);
            this.txtSavePath.TabIndex = 6;

            // 
            // lblSavePath
            // 
            this.lblSavePath.Location = new System.Drawing.Point(300, 530);
            this.lblSavePath.Name = "lblSavePath";
            this.lblSavePath.Size = new System.Drawing.Size(100, 23);
            this.lblSavePath.TabIndex = 7;
            this.lblSavePath.Text = "Save Path:";

            // 
            // numericSnapshotInterval
            // 
            this.numericSnapshotInterval.Location = new System.Drawing.Point(660, 560);
            this.numericSnapshotInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericSnapshotInterval.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericSnapshotInterval.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericSnapshotInterval.TabIndex = 8;

            // 
            // lblSnapshotInterval
            // 
            this.lblSnapshotInterval.Location = new System.Drawing.Point(660, 530);
            this.lblSnapshotInterval.Name = "lblSnapshotInterval";
            this.lblSnapshotInterval.Size = new System.Drawing.Size(120, 23);
            this.lblSnapshotInterval.TabIndex = 9;
            this.lblSnapshotInterval.Text = "Interval (sec):";

            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.ItemHeight = 15;
            this.lstLog.Location = new System.Drawing.Point(12, 600);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(808, 184);
            this.lstLog.TabIndex = 10;

            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(230, 560);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(100, 30);
            this.btnTrain.TabIndex = 11;
            this.btnTrain.Text = "Train Face";
            this.btnTrain.UseVisualStyleBackColor = true;

            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(832, 800);
            this.Controls.Add(this.pbLiveFeed);
            this.Controls.Add(this.pbDetectedFace);
            this.Controls.Add(this.lblCameraStatus);
            this.Controls.Add(this.lblRecordingStatus);
            this.Controls.Add(this.btnSnapshot);
            this.Controls.Add(this.btnStopSnapshot);
            this.Controls.Add(this.txtSavePath);
            this.Controls.Add(this.lblSavePath);
            this.Controls.Add(this.numericSnapshotInterval);
            this.Controls.Add(this.lblSnapshotInterval);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.btnTrain);
            this.Name = "MainForm";
            this.Text = "USB Camera with Face Detection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);

            ((System.ComponentModel.ISupportInitialize)(this.pbLiveFeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetectedFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSnapshotInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
