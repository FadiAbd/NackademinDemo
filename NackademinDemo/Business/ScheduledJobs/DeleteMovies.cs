using EPiServer.PlugIn;
using EPiServer.Scheduler;
using EPiServer.ServiceLocation;
using NackademinDemo.Abstractions;

namespace NackademinDemo.Business.ScheduledJobs
{
    [ScheduledPlugIn(
        DisplayName = "Ett testjobb",
        Description = "Ett jobb som tar bort filmer",
        GUID = "9A95AECA-A547-4E84-86C2-74F350EE78A2"
    )]
    public class DeleteMovies : ScheduledJobBase
    {
        private IDdsService _ddsService = ServiceLocator.Current.GetInstance<IDdsService>();
        private bool stopSignal;

        public DeleteMovies()
        {
            IsStoppable = true;
        }

        public override string Execute()
        {
            if (stopSignal)
            {
                return "jobbet har stoppats";
            }
            else
            {               
                var numberOfMovies = _ddsService.DeleteMovies();

                return $"{numberOfMovies} film/er blev raderade";
            }
        }

        public override void Stop()
        {
            stopSignal = true;

            base.Stop();
        }
    }
}