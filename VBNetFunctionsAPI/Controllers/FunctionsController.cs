
using System;
using Microsoft.AspNetCore.Mvc;
using VBNetFunctions;
using VBNetFunctions.CalculaDesconto;

namespace VBNetFunctionsAPI.Controllers
   {
       [ApiController]
       [Route("api/functions")]
       public class FunctionsController : ControllerBase
       {
           [HttpPost("sum-even")]
           public IActionResult SumEven([FromBody] int[] numbers)
           {
               try
               {
                   var result = SomaPares.SomarNumerosPares(numbers);
                   return Ok(new { Result = result });
               }
               catch (Exception ex)
               {
                   return BadRequest(new { Error = ex.Message });
               }
           }

           [HttpPost("max-number")]
           public IActionResult MaxNumber([FromBody] int[] numbers)
           {
               try
               {
                   var result = MaiorNumero.EncontrarMaiorNumero(numbers);
                   return Ok(new { Result = result });
               }
               catch (Exception ex)
               {
                   return BadRequest(new { Error = ex.Message });
               }
           }

           [HttpPost("count-vowels")]
           public IActionResult CountVowels([FromBody] string input)
           {
               try
               {
                   var result = ContadorVogais.ContarVogais(input);
                   return Ok(new { Result = result });
               }
               catch (Exception ex)
               {
                   return BadRequest(new { Error = ex.Message });
               }
           }

           [HttpPost("calculate-discount")]
           public IActionResult CalculateDiscount([FromBody] decimal price)
           {
               try
               {
                   var result = CalculaDesconto.CalcularDesconto(price);
                   return Ok(new { Result = result });
               }
               catch (Exception ex)
               {
                   return BadRequest(new { Error = ex.Message });
               }
           }

           [HttpPost("reverse-array")]
           public IActionResult ReverseArray([FromBody] int[] array)
           {
               try
               {
                   var result = ReverteArray.ReverterArray(array);
                   return Ok(new { Result = result });
               }
               catch (Exception ex)
               {
                   return BadRequest(new { Error = ex.Message });
               }
           }

           [HttpPost("weighted-average")]
           public IActionResult WeightedAverage([FromBody] WeightedAverageInput input)
           {
               try
               {
                   var result = MediaPonderada.CalcularMediaPonderada(input.Notas, input.Pesos);
                   return Ok(new { Result = result });
               }
               catch (Exception ex)
               {
                   return BadRequest(new { Error = ex.Message });
               }
           }

           [HttpPost("has-three-consecutive")]
           public IActionResult HasThreeConsecutive([FromBody] int[] numbers)
           {
               try
               {
                   var result = NumerosConsecutivos.TemTresConsecutivosCrescentes(numbers);
                   return Ok(new { Result = result });
               }
               catch (Exception ex)
               {
                   return BadRequest(new { Error = ex.Message });
               }
           }

           [HttpPost("first-repeated")]
           public IActionResult FirstRepeated([FromBody] int[] numbers)
           {
               try
               {
                   var result = NumeroRepetido.EncontrarPrimeiroRepetido(numbers);
                   return Ok(new { Result = result });
               }
               catch (Exception ex)
               {
                   return BadRequest(new { Error = ex.Message });
               }
           }

           [HttpPost("unique-numbers")]
           public IActionResult UniqueNumbers([FromBody] int[] numbers)
           {
               try
               {
                   var result = NumerosNaoRepetidos.ObterNumerosUnicos(numbers);
                   return Ok(new { Result = result });
               }
               catch (Exception ex)
               {
                   return BadRequest(new { Error = ex.Message });
               }
           }
       }

       public class WeightedAverageInput
       {
           public decimal[] Notas { get; set; }
           public int[] Pesos { get; set; }
       }
   }