namespace Service2.Data
{
    public class SportStatisticService
    {
        private static readonly string[] Names = new[]
        {
            "Развлекательное шоу", "Спортивная площадка", "Головоломки", "Ролевые игры"
        };

        public Task<SportStatistic[]> GetForecastAsync(DateOnly startDate)
        {
            Random rnd = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new SportStatistic
            {
                Date = startDate.AddDays(index),
                TimeSpending = DateTime.UtcNow.AddHours(rnd.Next(24)),
                Summary = Names[Random.Shared.Next(Names.Length)]
            }).ToArray());
        }
    }
}
