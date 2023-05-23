using System.ComponentModel;

public class Quiz : INotifyPropertyChanged
{
    private string _quizTitle;

    public string QuizTitle
    {
        get { return _quizTitle; }
        set
        {
            _quizTitle = value;
            OnPropertyChanged(nameof(QuizTitle));
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
