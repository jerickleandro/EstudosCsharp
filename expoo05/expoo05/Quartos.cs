using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expoo05
{
    class Quartos
    {
        public string hospede;
        public string email;
        

        public Quartos (string hospede, string email)
        {
            this.hospede = hospede;
            this.email = email;
            
        }

        public override string ToString()
        {
            return hospede + ", "+ email;
        }

    }
}
