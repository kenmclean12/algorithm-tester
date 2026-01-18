namespace AlgoLab.ViewModels;

public class SolveProblemViewModel
{
  public int ProblemId { get; set; }

  public required string Title { get; set; }

  public required string Description { get; set; }

  public required string FunctionSignature { get; set; }

  public required string StarterCode { get; set; }

  public string UserCode { get; set; } = "";
}