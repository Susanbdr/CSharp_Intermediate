using System.Collections.Generic;

namespace CSharp_Intermediate
{
    public interface IWorkFlow
    {
        void Add(IActivity task);

        void Remove(IActivity task);

        IEnumerable<IActivity> GetActivities();

    }
}