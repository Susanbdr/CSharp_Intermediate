using System.Collections.Generic;

namespace CSharp_Intermediate
{
    public class WorkFlow : IWorkFlow
    {
        private readonly List<IActivity> _tasks;

        public WorkFlow()
        {
            _tasks = new List<IActivity>();
        }
        public void Add(IActivity task)
        {
            _tasks.Add(task);
        }

        public void Remove(IActivity task)
        {
            _tasks.Remove(task);
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return _tasks;
        }
    }
}