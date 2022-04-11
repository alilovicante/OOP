using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskie
{
    public class ToDoTask
    {
        protected string title;
        protected int importance;

        public ToDoTask()
        {
            title = "Task";
            importance = 1;
        }
        public ToDoTask(string title, int importance)
        {
            this.title = title;
            this.importance = importance;
        }
        public string Title { get { return title; } private set { this.title = value; } }
        public int Importance { get { return importance; } private set { this.importance = value; } }
        public override string ToString()
        {
            return $"Name: {title}\nImportance level: {importance}";
        }
    }
    public class TimedTask : ToDoTask
    {
        private DateTime deadline;
        public TimedTask()
        {
            title = "Task";
            importance = 1;
            deadline = DateTime.Now;
        }
        public TimedTask(string title,int importance,DateTime deadline) : base(title,importance)
        {
            this.deadline = deadline;
        }
        public TimeSpan timeRemaining(TimedTask a)
        {
            if (a.deadline < DateTime.Now)
            {
                return TimeSpan.Zero;
            }
            else
            {
                return a.deadline - DateTime.Now;
            }
        }
        public override string ToString()
        {
            return base.ToString()+$"\nDeadline: {deadline}";
        }
    }
}
namespace Taskie.Data
{
    public interface ITaskDao
    {
        void SaveTask(ToDoTask task);
        IEnumerable<ToDoTask> GetTasks();
        void Delete(ToDoTask task);
        void CompleteTask(string title);

    }
    public class TaskRepository : ITaskDao
    {
        List<ToDoTask> list = new List<ToDoTask>();
        public void SaveTask(ToDoTask task)
        {
            list.Add(task);
        }
        public IEnumerable<ToDoTask> GetTasks()
        {
            return list;
        }
        public void Delete(ToDoTask task)
        {
            list.Remove(task);
        }
        public void CompleteTask(string title)
        {
            foreach(var a in list.ToList())
            {
                if (title == a.Title) { list.Remove(a); }
            }
        }
    }
}

