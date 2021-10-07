using System.Configuration;

namespace NackademinDemo
{
    public static class Constants
    {
        public static string OmdbApiKey { 
            get { 
                return ConfigurationManager.AppSettings["omdbApiKey"]; 
            }
        }
    }
}