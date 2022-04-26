using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class TaskList
    {

        /// <summary>
        /// name - имя списка с задачами.
        ///tasks - список задач, относящихся к списку
        /// </summary>
        private string Name;
        private List<Task> tasks;

        /// <summary>
        /// Конструктор инициализирует список задач с указанным именем
        /// </summary>
        /// <param name="name"></param>
        public TaskList(string name)
        {
            Name = name;
            tasks = new List<Task>();
        }

        /// <summary>
        /// GetName - возвращает имя списка задач
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return Name;
        }

        /// <summary>
        /// AddTask - добавляет задачу в список задач
        /// </summary>
        /// <param name="task"></param>
        public void AddTask(Task task)
        {
            tasks.Add(task);
        }


        /// <summary>
        /// GetTasks - возвращает список всех задач
        /// </summary>
        /// <returns></returns>

        public List<Task> GetTasks()
        {
            return tasks;
        }

        /// <summary>
        /// Remove - удаляет задачу из списка задач
        /// </summary>
        /// <param name="task"></param>

        public void Remove (Task task)
        {
            tasks.Remove(task);
        }

        /// <summary>
        /// GetTasksByToday - возвращает задачи запланированные на сегодня в хронологическом порядке.
        /// </summary>
        /// <returns></returns>

        public List<Task> GetTasksByToday()
        {
            return tasks.Where(x => x.Due == DateTime.Now).ToList();
        }

        /// <summary>
        /// GetTasksByFuture - возвращает задачи на завтра и позже в хронологическом порядке.
        /// </summary>
        /// <returns></returns>


        public List<Task> GetTasksByFuture()
        {
            return tasks.Where(x => x.Due > DateTime.Now).ToList();
        }

    }
}
