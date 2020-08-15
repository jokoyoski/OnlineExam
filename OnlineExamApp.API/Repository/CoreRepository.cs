using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Repository
{
    public class CoreRepository<T, TIdT> : ICoreRepository<T, TIdT> where T : class
    {
        private readonly DataContext _dataContext;
        private readonly Type _type;
        private readonly ILogger<CoreRepository<T, TIdT>> _logger;

        public CoreRepository(DataContext dataContext, ILogger<CoreRepository<T, TIdT>> logger)
        {
            this._dataContext = dataContext;
            this._logger = logger;
            this._type = typeof(T);
        }

        public virtual async Task<List<T>> GetAll()
        {
            _logger.LogDebug($"Get {_type.Name} from db");

            List<T> result = default(List<T>);

            try
            {
                result = _dataContext.Set<T>().AsEnumerable().ToList();

                _logger.LogDebug($"Get {_type.FullName} was successful");
            }
            catch (Exception e)
            {
                _logger.LogError($"{e.Message}");
            }

            return (List<T>)result;
        }

        public virtual async Task<List<T>> GetAll(TIdT id)
        {
            _logger.LogDebug($"Get {_type.Name} from db");

            List<T> result = default(List<T>);

            try
            {
                result = _dataContext.Set<T>().Where(p=>p.Equals(id)).AsEnumerable().ToList();

                _logger.LogDebug($"Get {_type.FullName} was successful");
            }
            catch (Exception e)
            {
                _logger.LogError($"{e.Message}");
            }

            return (List<T>)result;
        }

        public virtual async Task<List<T>> GetAll(int page, int limit)
        {
            if (page == 0)
                page = 1;

            if (limit == 0)
                limit = int.MaxValue;

            var skip = (page - 1) * limit;

            List<T> result = default(List<T>);
            
            try
            {
                result = _dataContext.Set<T>().AsEnumerable().Skip(skip).Take(limit).ToList();
                _logger.LogDebug($"Get Pageed {_type.Name} was successful");
            }
            catch(Exception e)
            {
                _logger.LogError($"{e.Message}");
            }

            return (List<T>)result;
        }

        public virtual async Task<T> Get(TIdT id)
        {
            _logger.LogDebug($"Get {_type.Name} from db with id {id}");

            T result = default(T);

            try
            {
                result = await _dataContext.FindAsync<T>(id);
                _logger.LogDebug($"Get {_type.Name} from db with id {id} was successful");

            }
            catch (Exception e)
            {
                _logger.LogError($"{e.Message}");
            }

            return (T)result;
        }

        public virtual async Task<T> Add(T t)
        {
            _logger.LogDebug($"Get {_type.Name} from db with id {t}");

            T result = default(T);

            try
            {
                var response = await _dataContext.AddAsync<T>(t);
                await _dataContext.SaveChangesAsync();
                _logger.LogDebug($"Get {t} was successful");
                result = response.Entity;

            }
            catch (Exception e)
            {
                _logger.LogError($"{e.Message}");
            }

            return (T)result;
        }

        public virtual async Task<T> Update(T t)
        {
            _logger.LogDebug($"Get {_type.Name} from db");

            T result = default(T);

            try
            {
                var response = _dataContext.Update<T>(t);
                await _dataContext.SaveChangesAsync();
                _logger.LogDebug($"Updating {t} from db was successful");
                result = response.Entity;
            }
            catch (Exception e)
            {
                _logger.LogError($"{e.Message}");
            }

            return (T)result;
        }
        
        public virtual async Task<T> Remove(T t)
        {
            _logger.LogDebug($"Get {_type.Name} from db");

            T result = default(T);

            try
            {
                result = _dataContext.Remove<T>(t).Entity;
                await _dataContext.SaveChangesAsync();
                _logger.LogDebug($"Get {t} from db was successful");
            }
            catch (Exception e)
            {
                _logger.LogError($"{e.Message}");
            }

            return (T)result;
        }


    }
}