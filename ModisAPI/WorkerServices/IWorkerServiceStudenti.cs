using System.Collections.Generic;
using ModisAPI.Models;

namespace ModisAPI.WorkerServices
{
    public interface IWorkerServiceStudenti
    {
        List<ViewModelStudente> RestituisciListaStudenti();
        Studente RestituisciStudente(int id);

        //issue23 inserire un nuovo studente//
        void CreaStudente(Studente studente);

        //inserire i nuovi valori nel db
        void ModificaStudente(Studente studenteModificato);

        void CancellaStudente(int id);

    }
}