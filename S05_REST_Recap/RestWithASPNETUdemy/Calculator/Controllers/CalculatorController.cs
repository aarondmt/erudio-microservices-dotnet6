using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Calculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            if (decimal.TryParse(firstNumber, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out decimal firstNum) 
                && decimal.TryParse(secondNumber, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out decimal secondNum))
                return Ok((firstNum + secondNum).ToString());

            return BadRequest("Invalid Input");
        }

        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public IActionResult Subtraction(string firstNumber, string secondNumber)
        {
            if (decimal.TryParse(firstNumber, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out decimal firstNum)
                && decimal.TryParse(secondNumber, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out decimal secondNum))
                return Ok((firstNum - secondNum).ToString());

            return BadRequest("Invalid Input");
        }

        [HttpGet("multiplication/{firstNumber}/{secondNumber}")]
        public IActionResult Multiplication(string firstNumber, string secondNumber)
        {
            if (decimal.TryParse(firstNumber, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out decimal firstNum)
                && decimal.TryParse(secondNumber, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out decimal secondNum))
                return Ok((firstNum * secondNum).ToString());

            return BadRequest("Invalid Input");
        }

        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public IActionResult Division(string firstNumber, string secondNumber)
        {
            if (decimal.TryParse(firstNumber, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out decimal firstNum)
                && decimal.TryParse(secondNumber, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out decimal secondNum))
                return Ok((firstNum / secondNum).ToString());

            return BadRequest("Invalid Input");
        }

        [HttpGet("average/{firstNumber}/{secondNumber}")]
        public IActionResult Average(string firstNumber, string secondNumber)
        {
            if (decimal.TryParse(firstNumber, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out decimal firstNum)
                && decimal.TryParse(secondNumber, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out decimal secondNum))
            {
                var arr = new decimal[]
                {
                    firstNum,
                    secondNum
                };
                return Ok(arr.Average().ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("squareroot/{number}")]
        public IActionResult SquareRoot(string number)
        {
            if (double.TryParse(number, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out double num))
                return Ok(Math.Sqrt(num).ToString());

            return BadRequest("Invalid Input");
        }
    }
}