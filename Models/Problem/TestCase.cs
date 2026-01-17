namespace AlgoLab.Models.Problem;

public class TestCase
{
  public int Id { get; set; }

  public required string Input { get; set; }

  public required string ExpectedOutput { get; set; }

  public bool Hidden { get; set; }
}