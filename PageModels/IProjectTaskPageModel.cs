using _2051Assignment.Models;
using CommunityToolkit.Mvvm.Input;

namespace _2051Assignment.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}