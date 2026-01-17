namespace AlgoLab.Models.Submission;

public class Submission
{
  public int Id { get; set; }

  public int ProblemId { get; set; }

  public required string UserCode { get; set; }

  public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;

  public JudgeResult? Result { get; set; }
}