using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculadoraServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculadoraController : ControllerBase
    {
        //API está aberta escutando em uma porta 5000
        [HttpGet("calcular")]
        public IActionResult Calcular(string operador, double num1, double num2)
        {
            double result = 0;

            switch (operador)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "/":
                    if (num2 == 0)
                        return Ok("NAO EXISTE!");
                    else
                        result = num1 / num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                default:
                    return NotFound("Operador Não encontrado");
            }

            return Ok(result);
        }
    }
 }

