using EPiServer.Personalization.VisitorGroups;

namespace NackademinDemo.Business.Personalization.LoggedIn
{
    public class LoggedInCriterionSettings : CriterionModelBase
    {
        public override ICriterionModel Copy()
        {
            return ShallowCopy();
        }
    }
}