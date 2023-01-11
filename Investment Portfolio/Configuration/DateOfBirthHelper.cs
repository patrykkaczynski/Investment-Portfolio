namespace Investment_Portfolio.Configuration
{
    public static class DateOfBirthHelper
    {
        public static bool IsDateInRightRange(DateTime date) => date > DateTime.Now.AddYears(-125) && date < DateTime.Now;
   
    }
}
