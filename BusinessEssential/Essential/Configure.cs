using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential
{
    internal class Configure
    {
        public static Color CorTexBox(Statusforms btn)
        {
            if (btn == Statusforms.Atualizar)
            {
                return Color.White;
            }
            if (btn == Statusforms.Procurar)
            {
                return Color.LightGoldenrodYellow;
            }
            if (btn == Statusforms.Adicionar)
            {
                return Color.White;
            }
            if (btn == Statusforms.OK)
            {
                return Color.White;
            }
            return Color.White;
        }
        public static bool StatusID(Statusforms statusforms)
        {
            if (statusforms == Statusforms.Adicionar || statusforms == Statusforms.Atualizar)
                return true;
            return false;
        }
    }
}
