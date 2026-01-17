using AlgoLabs.Models.Submission;

namespace AlgoLab.Models.Submission;

public class JudgeResult
{
  public bool Passed { get; set; }

  public int TotalTests { get; set; }

  public int PassedTests { get; set; }

  public long ExecutionTimeMs { get; set; }

  public List<TestResult> TestResults { get; set; } = [];
}