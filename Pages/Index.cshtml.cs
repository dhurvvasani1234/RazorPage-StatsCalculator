using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public double? Total { get; set; }
        public double? Maximum { get; set; }
        public double? Minimum { get; set; }
        public double? Average { get; set; }
        public double? Counter { get; set; }
        public string? Success { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            List<double?> NumbersList = new List<double?>();

            // check first number
            double firstNumber= 0.0;
            bool isempty1 = false;
            bool isempty2 = false;
            bool isempty3 = false;
            bool isFirstNumberValid= false;
            bool isSecondNumberValid= false;
            bool isThirdNumberValid= false;
            string first = Request.Form["inputFirstNumber"];
            if (first != "")
            {
               isFirstNumberValid = Double.TryParse(first, out firstNumber);
                if (isFirstNumberValid == true)
                {
                    NumbersList.Add(firstNumber);
                }
            }
            else {
                isempty1 = true;
            }
            

            // check second number
            double secondNumber= 0.0;
            string second = Request.Form["inputSecondNumber"];
            if (second != "")
            {
                isSecondNumberValid = Double.TryParse(second, out secondNumber);
                if (isSecondNumberValid == true)
                {
                    NumbersList.Add(secondNumber);
                }
            }
            else
            {
                isempty2 = true;
            }

            // check third number
            double thirdNumber = 0.0;
            string third = Request.Form["inputThirdNumber"];
            if (third!= "")
            {
                isThirdNumberValid = Double.TryParse(third, out thirdNumber);
                if (isThirdNumberValid == true)
                {
                    NumbersList.Add(thirdNumber);
                }
            }
            else
            {
                isempty3 = true;
            }

            
            if (isFirstNumberValid == true || isSecondNumberValid == true || isThirdNumberValid == true)
            {
                Counter = NumbersList.Count;

                Total = firstNumber + secondNumber + thirdNumber;
                Minimum = NumbersList.Min();
                Maximum = NumbersList.Max();
                Average = NumbersList.Average();

            }

            if (isempty1 == true && isempty2 == true && isempty3 == true)
            {

                ViewData["Success"] = "noValues";
            }
            if (isFirstNumberValid == true || isSecondNumberValid == true || isThirdNumberValid == true)
            {
               
                ViewData["Success"] = "Values";
            }
        }
    }
}