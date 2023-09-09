    using Newtonsoft.Json;

    public static class HistoricalEventSearch
    {
        public static List<HistoricalEvent> ReadEvents(string dataset)
        {
            StreamReader reader = new StreamReader(dataset);
            string jsonString = reader.ReadToEnd();
            reader.Close();
            return JsonConvert.DeserializeObject<List<HistoricalEvent>>(jsonString)!;
        }

        public static List<HistoricalEvent> SearchInDescription(List<HistoricalEvent> events, string query) =>
            events.Where(e => 
                    e.Description.ToLower().Contains(query.ToLower()))
                .ToList();

        public static List<HistoricalEvent> SearchBetweenYears(List<HistoricalEvent> events, int fromYear, int toYear) =>
            events
                .Where(e => e.Year >= fromYear && e.Year <= toYear)
                .ToList();

        public static int AverageEventYear(List<HistoricalEvent> events) =>
            events.Select(e => e.Year).Sum() / events.Count;
    }