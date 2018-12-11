using System.Collections.Generic;
using ModisAPI.Models;

namespace ModisAPI.WorkerServices
{
    public interface IWorkerServiceStudenti
    {
        List<Studente> RestituisciListaStudenti();
        Studente RestituisciStudente(int id);

        //issue23 inserire un nuovo studente//
        void CreaStudente(Studente studente);

    }
}