using System;
using System.Collections.Generic;

namespace Exercise
{
    public interface IWorkFlow
    {
        void AddActivity(IActivity activity);
        void RemoveActivity(IActivity activity);

        IList<IActivity> GetActivities();
    }

    public class WorkFlow : IWorkFlow
    {
        private readonly IList<IActivity> _activities;

        public WorkFlow()
        {
            _activities = new List<IActivity>();
        }
        public void AddActivity(IActivity activity)
        {
            _activities.Add(activity);
        }
        public void RemoveActivity(IActivity activity)
        {
            _activities.Remove(activity);
        }

        public IList<IActivity> GetActivities()
        {
            return _activities;
        }
    }

    public class WorkflowEngine
    {

        public void Run(IWorkFlow workFlow)
        {
            foreach (var activity in workFlow.GetActivities())
            {
                activity.Execute();
            }
        }


    }

    public interface IActivity
    {
        void Execute();
    }

    public class Activity1 : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Executing activity 1");
        }
    }

    public class Activity2 : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Executing activity 2");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var workflow = new WorkFlow();
            workflow.AddActivity(new Activity1());
            workflow.AddActivity(new Activity2());

            var workflowEngine = new WorkflowEngine();
            workflowEngine.Run(workflow);
        }
    }
}
