using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CalculatorBackend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CalculatorController : ControllerBase
{
    [HttpPost("calculate")]
    public IActionResult Calculate([FromBody] CalculationRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Expression))
        {
            return BadRequest("Expression cannot be empty.");
        }

        try
        {
            // Use DataTable to compute the expression safely
            // Note: This is a simple way to evaluate math expressions in C# without external libraries.
            // For production, a more robust parser would be better, but this fits the "simple project" requirement.
            var dataTable = new DataTable();
            var result = dataTable.Compute(request.Expression, null);
            
            // Handle potential infinity or NaN
            if (result is double d && (double.IsInfinity(d) || double.IsNaN(d)))
             {
                 return BadRequest("Invalid calculation result.");
             }

            return Ok(new { result = result });
        }
        catch (Exception ex)
        {
            return BadRequest($"Error calculating expression: {ex.Message}");
        }
    }
}

public class CalculationRequest
{
    public string Expression { get; set; }
}
