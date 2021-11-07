using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppName.Services
{
    public interface IJbeServiceGenerique<T>
    {
        Task<T> PostSharp(object param, string url); 
    }
}
