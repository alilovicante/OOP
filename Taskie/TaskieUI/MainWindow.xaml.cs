using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Taskie;
using Taskie.Data;
using System.IO;

namespace TaskieUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ITaskDao taskDao = new TaskRepository();
        public MainWindow()
        {
            InitializeComponent();
            TasksList.ItemsSource = taskDao.GetTasks();
        }
        private void SaveTask_Click(object sender, RoutedEventArgs e)
        {
            string title = TitleInput.Text;
            int importance = (int)ImportanceInput.Value;
            DateTime time = DateInput.SelectedDate ?? DateTime.Now;

            ToDoTask t = new TimedTask(title, importance, time);

            taskDao.SaveTask(t);
            TasksList.Items.Refresh();
        }
        private void TasksList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var taskToRemove = TasksList.SelectedItem as ToDoTask;
            taskDao.Delete(taskToRemove);
            TasksList.Items.Refresh();
        }
        private void CompleteTask_Click(object sender, RoutedEventArgs e)
        {
            string title = TaskToCompleteInput.Text;
            taskDao.CompleteTask(title);
            TasksList.Items.Refresh();
        }
    }
}
