using Serilog;
using System;
namespace GraphQLCore.Helper
{
    public static class Logger
    {
        public static void InformationLog(string InfoMessage)
        {
            try
            {
                Log.Information(InfoMessage);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ErrorLog(string ErrorMessage)
        {
            try
            {
                Log.Error(ErrorMessage);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Close()
        {
            try
            {
                Log.CloseAndFlush();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ErrorLog(Exception ex, string v)
        {
            throw new NotImplementedException();
        }
    }
}
