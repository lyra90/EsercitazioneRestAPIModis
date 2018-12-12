using System.Collections.Generic;
using ModisAPI.Models;

namespace ModisAPI.WorkerServices
{
    public interface IWorkerServiceStudenti
    {
        List<Studente> RestituisciListaStudenti();
        Studente RestituisciStudente(int id);
    }
}