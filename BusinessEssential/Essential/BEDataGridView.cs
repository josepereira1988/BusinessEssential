using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential
{
    public class BEDataGridView : DataGridView
    {
        public BEDataGridView()
        {
            this.BackgroundColor = Color.White;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.RowHeadersWidth = 25;
            this.ReadOnlyChanged += new System.EventHandler(this.dataGridView_ReadOnlyChanged);
        }

        //public void ConfigureGrid()
        //{
        //    foreach(DataGridViewColumn column in this.Columns)
        //    {
        //        if(column.GetType() == typeof(BEDataGridViewTextBoxColumn))
        //        {
        //            column.DefaultCellStyle.Format = "N2";
        //        }
        //    }
        //}
        private void dataGridView_ReadOnlyChanged(object sender, EventArgs e)
        {            
            if (this.ReadOnly)
            {
                this.BackgroundColor = Color.DarkGray;
            }
            else
            {
                this.BackgroundColor = Color.White;
            }
        }
        public void Numerar()
        {
            this.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_RowPostPaint);
        }
        private void dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();
            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,

                LineAlignment = StringAlignment.Center
            };
            //get the size of the string
            Size textSize = TextRenderer.MeasureText(rowIdx, this.Font);
            //if header width lower then string width then resize
            if (grid.RowHeadersWidth < textSize.Width + 15)
            {
                grid.RowHeadersWidth = textSize.Width + 15;
            }
            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
    }
}
