using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1.Models
{
    public class DataGridViewProgressBarCell : DataGridViewCell
    {
        public DataGridViewProgressBarCell()
        {
            this.ValueType = typeof(int); // Progress değeri int olarak olacak
        }

        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex,
            DataGridViewElementStates elementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle,
            DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);

            if (value == null) return;

            // ProgressBar'ı çizelim
            int progress = (int)value;
            if (progress < 0) progress = 0;
            if (progress > 100) progress = 100;

            using (var progressBrush = new SolidBrush(Color.Green))
            {
                var progressRect = new Rectangle(cellBounds.X + 2, cellBounds.Y + 2, (int)((cellBounds.Width - 4) * (progress / 100.0)), cellBounds.Height - 4);
                graphics.FillRectangle(progressBrush, progressRect);
            }
        }

        // Progress değerini sıfırlamak için
        public void ResetProgress()
        {
            this.Value = 0; // Progress'i sıfırlıyoruz
        }
    }
}