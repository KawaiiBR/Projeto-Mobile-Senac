using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    public class Usuarios
    {
        [PrimaryKey, AutoIncrement]
        public Guid ID { get; set; }

        [MaxLength(50), NotNull]
        public string Email { get; set; }

        [MaxLength(255), NotNull]
        public string Senha { get; set; }
        
        [MaxLength(5), NotNull]
        public int NumeroDaCasa { get; set; }

        [MaxLength(255), NotNull]
        public string Bairro { get; set; }

        [MaxLength(255), NotNull]
        public string Rua { get; set; }

        [MaxLength(255), NotNull]
        public string Cidade { get; set; }

        [MaxLength(255), NotNull]
        public string Estado { get; set; }

        [MaxLength(255)]
        public string CEP { get; set; }
    }
}
