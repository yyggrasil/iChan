using ichan.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ichan.Domain.Entities
{
    public class Participa : BaseEntity<int>
    {
        public Participa() { }
        public Participa(int id, DateTime dataSeguida)
        {
            Id = id;
            DataSeguida = dataSeguida;
        }

        public DateTime DataSeguida { get; set; }
    }
}
