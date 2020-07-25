using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Repository
{
    public class CoreRepository<T, TIdT>: ICoreRepository<T, TIdT> where T : class
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

        public List<T> Get() 
        {
            _logger.LogDebug($"Get {_type.FullName} from db");

            List<T> result = default(List<T>); 

            try
            {
                //result = (List<T>) _dataContext.<T>();   
                
            }
            catch(Exception e)
            {
                _logger.LogError($"{e.Message}");
            }

            return result;
        }


        public T Get(TIdT id) 
        {
            _logger.LogDebug($"Get {_type.FullName} from db with id {id}");

            T result = default(T); 

            try
            {
                result = (T) _dataContext.Find(_type, id);   
                
            }
            catch(Exception e)
            {
                _logger.LogError($"{e.Message}");
            }

            return result;
        }

        public T Update(T t) 
        {
            _logger.LogDebug($"Get {_type.FullName} from db");

            T result = default(T); 

            try
            {
                result =  (T)_dataContext.Update<T>(t).Entity;  
                
            }
            catch(Exception e)
            {
                _logger.LogError($"{e.Message}");
            }

            return result;
        }


    }
}