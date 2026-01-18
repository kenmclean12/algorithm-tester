using AlgoLab.Models.Submission;

namespace AlgoLab.ViewModels;

public class SubmissionResultViewModel
{
  public int ProblemId { get; set; }

  public JudgeResult? Result { get; set; }
}