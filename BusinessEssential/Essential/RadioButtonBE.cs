using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential
{
    public class RadioButtonBE : RadioButton
    {
        public RadioButtonBE()
        {
            this.Font = new System.Drawing.Font(new FontFamily("Calibri"), 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        }
        public string Tabela { get; set; }
        public string Campo { get; set; }
    }
}
