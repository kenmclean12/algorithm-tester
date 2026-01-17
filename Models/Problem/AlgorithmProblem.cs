namespace AlgoLab.Models.Problem;

public class AlgorithmProblem
{
  public int Id { get; set; }

  public required string Name { get; set; }

  public required string Description { get; set; }

  public required string FunctionSignature { get; set; }

  public required string Difficulty { get; set; }

  public required string Category { get; set; }

  public List<TestCase> TestCases { get; set; } = [];
}