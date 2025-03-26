using CommunityToolkit.Mvvm.Input;
using MauiAuth.Models;

namespace MauiAuth.PageModels;

public interface IProjectTaskPageModel
{
	IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
	bool IsBusy { get; }
}