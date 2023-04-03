using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airports.Application.Result
{
    public class Result<T>
    {
        public Result(T entity)
        {
            Success = true;
            Entity = entity;
        }

        public Result(string error)
        {
            Success = false;
            Error = error;
        }

        public bool Success { get; set;}
        public T Entity { get; set;}
        public string? Error { get; set;}
    }
}
