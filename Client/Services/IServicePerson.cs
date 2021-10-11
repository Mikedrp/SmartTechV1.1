using System.Collections.Generic;
using PracticaSemanaIV.Shared.Entity;

namespace PracticaSemanaIV.Client.Services
{
    public interface IServicePerson
    {
         List<Actor> GetActor();
    }
}