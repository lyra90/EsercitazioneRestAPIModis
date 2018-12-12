using ModisAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModisAPI.WorkerServices
{
    public class WorkerServiceOracleDb : IWorkerServiceStudenti
    {
        public List<Studente> RestituisciListaStudenti()
        {
            throw new NotImplementedException();
        }

        public Studente RestituisciStudente(int id)
        {
            throw new NotImplementedException();
        }
    }

    public class WorkerServiceStudenti : IWorkerServiceStudenti
    {
        public List<Studente> RestituisciListaStudenti()
        {
            var studente1 = new Studente { Id = 1, Cognome = "Mario", Nome = "Rossi" };
            var studente2 = new Studente { Id = 2, Cognome = "MastroCesare", Nome = "Francesco" };
            return new List<Studente> { studente1, studente2 };
        }

        public Studente RestituisciStudente(int id)
        {
            return RestituisciListaStudenti().Where(x => x.Id == id).FirstOrDefault();
        }

    }
}
