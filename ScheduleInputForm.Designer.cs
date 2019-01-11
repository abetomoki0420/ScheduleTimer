namespace ScheduleStopWatch
{
    partial class ScheduleInputForm
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
            this.ScheduleName = new System.Windows.Forms.TextBox();
            this.ScheduleLimitYear = new System.Windows.Forms.TextBox();
            this.plusButton = new System.Windows.Forms.Button();
            this.ScheduleLimitMonth = new System.Windows.Forms.TextBox();
            this.ScheduleLimitDay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ScheduleName
            // 
            this.ScheduleName.Location = new System.Drawing.Point(3, 12);
            this.ScheduleName.Name = "ScheduleName";
            this.ScheduleName.Size = new System.Drawing.Size(144, 19);
            this.ScheduleName.TabIndex = 0;
            // 
            // ScheduleLimitYear
            // 
            this.ScheduleLimitYear.Location = new System.Drawing.Point(153, 12);
            this.ScheduleLimitYear.Name = "ScheduleLimitYear";
            this.ScheduleLimitYear.Size = new System.Drawing.Size(50, 19);
            this.ScheduleLimitYear.TabIndex = 1;
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(321, 12);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(30, 19);
            this.plusButton.TabIndex = 2;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            // 
            // ScheduleLimitMonth
            // 
            this.ScheduleLimitMonth.Location = new System.Drawing.Point(209, 12);
            this.ScheduleLimitMonth.Name = "ScheduleLimitMonth";
            this.ScheduleLimitMonth.Size = new System.Drawing.Size(50, 19);
            this.ScheduleLimitMonth.TabIndex = 4;
            // 
            // ScheduleLimitDay
            // 
            this.ScheduleLimitDay.Location = new System.Drawing.Point(265, 12);
            this.ScheduleLimitDay.Name = "ScheduleLimitDay";
            this.ScheduleLimitDay.Size = new System.Drawing.Size(50, 19);
            this.ScheduleLimitDay.TabIndex = 5;
            // 
            // ScheduleInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ScheduleLimitDay);
            this.Controls.Add(this.ScheduleLimitMonth);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.ScheduleLimitYear);
            this.Controls.Add(this.ScheduleName);
            this.Name = "ScheduleInputForm";
            this.Size = new System.Drawing.Size(366, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button plusButton;
        public System.Windows.Forms.TextBox ScheduleName;
        public System.Windows.Forms.TextBox ScheduleLimitYear;
        public System.Windows.Forms.TextBox ScheduleLimitMonth;
        public System.Windows.Forms.TextBox ScheduleLimitDay;
    }
}
