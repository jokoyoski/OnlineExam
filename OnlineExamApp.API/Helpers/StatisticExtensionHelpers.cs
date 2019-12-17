namespace OnlineExamApp.API.Helpers
{
    public static class StatisticExtensionHelpers
    {
        public static decimal Average(this decimal[] arr)
        {
            decimal sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum/arr.Length;
        }
    }
}