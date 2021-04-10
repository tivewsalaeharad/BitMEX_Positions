
namespace BitMEX_Positions
{
    partial class PositionsForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PositionsGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PositionsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PositionsGrid
            // 
            this.PositionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PositionsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PositionsGrid.Location = new System.Drawing.Point(0, 0);
            this.PositionsGrid.Name = "PositionsGrid";
            this.PositionsGrid.ReadOnly = true;
            this.PositionsGrid.RowHeadersWidth = 62;
            this.PositionsGrid.RowTemplate.Height = 28;
            this.PositionsGrid.Size = new System.Drawing.Size(800, 450);
            this.PositionsGrid.TabIndex = 0;
            // 
            // PositionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PositionsGrid);
            this.Name = "PositionsForm";
            this.Text = "Позиции";
            ((System.ComponentModel.ISupportInitialize)(this.PositionsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PositionsGrid;
    }
}

