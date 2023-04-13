using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class RetornoObj
    {
        public static int obj(string entity)
        {
            var resultado = Objtype.Users;
            if (entity.ToUpper() == "PaymentEntity".ToUpper())
                resultado = Objtype.Pagamento;
            return Convert.ToInt32(resultado);
        }
    }
}
