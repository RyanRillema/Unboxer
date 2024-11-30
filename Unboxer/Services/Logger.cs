using System;
using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using Unboxer.Interfaces;
using Unboxer.ViewModels;

namespace Unboxer.Services;

public enum LogLevel
{
    Info,
    Warn,
    Error
}

public class LogItem
{
    public LogItem(LogLevel logLevel, string logMessage, string? stackTrace = null)
    {
        LogTime = DateTime.Now;
        LogLevel = logLevel;
        LogMessage = logMessage;
        StackTrace = stackTrace;
    }
    
    public DateTime LogTime {get;set;}
    public LogLevel LogLevel {get;set;}
    public string LogMessage {get;set;}
    public string? StackTrace {get;set;}
}

public class Logger : ILogger
{
    public List<LogItem> LogItems { get; set; } = new();
    
    public event EventHandler<LogItem> OnItemLogged;
    
    public void Info(string message)
    {
        LogItems.Add(new (LogLevel.Info, message));
    }

    public void Warn(string message)
    {
        LogItems.Add(new (LogLevel.Warn, message));
    }

    public void Error(string message)
    {
        LogItems.Add(new (LogLevel.Error, message));
    }

    public void Error(Exception exception)
    {
        LogItems.Add(new (LogLevel.Error, exception.Message, exception.StackTrace));
    }
}