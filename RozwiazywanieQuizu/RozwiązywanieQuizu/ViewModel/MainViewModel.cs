using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace RozwiazywanieQuizu
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Quiz> _quizzes;
        public ObservableCollection<Quiz> Quizzes
        {
            get { return _quizzes; }
            set
            {
                _quizzes = value;
                OnPropertyChanged(nameof(Quizzes));
            }
        }

        public MainViewModel()
        {
            LoadQuizzes();
        }

        private void LoadQuizzes()
        {
            QuizDataAccess dataAccess = new QuizDataAccess();
            Quizzes = new ObservableCollection<Quiz>(dataAccess.GetQuizzes());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
