using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unboxer.Services;

namespace Unboxer.Interfaces
{
    public interface ILogger
    {
        event EventHandler<LogItem> OnItemLogged;
        void Info(string message);
        void Warn(string message);
        void Error(string message);
        void Error(Exception exception);

    }
}
