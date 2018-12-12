using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModisAPI.Models
{
    public class Studente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        //[StringLength(40, ErrorMessage = "Name cannot be longer than 40 characters.")]
        public string Cognome { get; set; }

        //private string _soprannome;
        //public string GetSoprannome()
        //{
        //    return _soprannome;
        //}

        //public void SetSoprannome(string value)
        //{
        //    _soprannome = value;
        //}

    }
}
