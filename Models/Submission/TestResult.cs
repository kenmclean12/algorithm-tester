namespace AlgoLabs.Models.Submission;

public class TestResult
{
  public required string Input { get; set; }

  public required string ExpectedOutput { get; set; }

  public required string ActualOutput { get; set; }

  public bool Passed { get; set; }

  public long ExecutionTimeMs { get; set; }
}