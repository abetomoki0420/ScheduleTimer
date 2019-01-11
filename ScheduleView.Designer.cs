namespace ScheduleStopWatch
{
    partial class ScheduleView
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.timeUpLimitBox = new System.Windows.Forms.TextBox();
            this.TimerLimitLabel = new System.Windows.Forms.Label();
            this.TimerNameLabel = new System.Windows.Forms.Label();
            this.minusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timeUpLimitBox
            // 
            this.timeUpLimitBox.BackColor = System.Drawing.Color.White;
            this.timeUpLimitBox.Font = new System.Drawing.Font("メイリオ", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.timeUpLimitBox.Location = new System.Drawing.Point(13, 29);
            this.timeUpLimitBox.Name = "timeUpLimitBox";
            this.timeUpLimitBox.ReadOnly = true;
            this.timeUpLimitBox.Size = new System.Drawing.Size(360, 51);
            this.timeUpLimitBox.TabIndex = 2;
            this.timeUpLimitBox.Text = "0";
            this.timeUpLimitBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TimerLimitLabel
            // 
            this.TimerLimitLabel.AutoSize = true;
            this.TimerLimitLabel.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TimerLimitLabel.Location = new System.Drawing.Point(136, 10);
            this.TimerLimitLabel.Name = "TimerLimitLabel";
            this.TimerLimitLabel.Size = new System.Drawing.Size(81, 15);
            this.TimerLimitLabel.TabIndex = 5;
            this.TimerLimitLabel.Text = "9999 99 99";
            // 
            // TimerNameLabel
            // 
            this.TimerNameLabel.AutoSize = true;
            this.TimerNameLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TimerNameLabel.Location = new System.Drawing.Point(10, 10);
            this.TimerNameLabel.Name = "TimerNameLabel";
            this.TimerNameLabel.Size = new System.Drawing.Size(69, 16);
            this.TimerNameLabel.TabIndex = 4;
            this.TimerNameLabel.Text = "Schedule";
            // 
            // minusButton
            // 
            this.minusButton.Location = new System.Drawing.Point(379, 41);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(30, 19);
            this.minusButton.TabIndex = 6;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            // 
            // ScheduleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.TimerLimitLabel);
            this.Controls.Add(this.TimerNameLabel);
            this.Controls.Add(this.timeUpLimitBox);
            this.Name = "ScheduleView";
            this.Size = new System.Drawing.Size(415, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox timeUpLimitBox;
        private System.Windows.Forms.Label TimerLimitLabel;
        private System.Windows.Forms.Label TimerNameLabel;
        public System.Windows.Forms.Button minusButton;
    }
}
