namespace Investment_Portfolio.Configuration
{
    public static class DateOfBirthHelper
    {
        public static bool IsDateInRightRange(this DateTime date)
        {
            if(date> DateTime.Now.AddYears(-125) && date < DateTime.Now)
            {

            }


        }
    }
}
