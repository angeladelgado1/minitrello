using MiTrello.Domain.Entities;

namespace MiTrello.Domain.Services
{
    public interface IWriteOnlyRepository
    {
        T Create<T>(T itemToCreate) where T : class, IEntity;
        T Update<T>(T itemToUpdate) where T : class, IEntity;
        T Archive<T>(T itemToArchive) where T : class, IEntity;
    }
}