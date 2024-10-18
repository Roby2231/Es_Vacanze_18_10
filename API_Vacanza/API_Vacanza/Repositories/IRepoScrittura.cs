﻿namespace API_Vacanza.Repositories
{
    public interface IRepoScrittura<T>
    {
            bool Create(T entity);
            bool Update(T entity);
            bool Delete(int id);

        }
    }
