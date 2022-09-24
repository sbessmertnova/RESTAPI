namespace WeatherForecastService.Controllers.Models
{
    /// <summary>
    /// Объект на базе класса WeatherForecastHolder, будет хранить список показателей
    /// </summary>
    public class WeatherForecastHolder
    {
        //Коллекция для хранения показателей температуры
        private List<WeatherForecast> _values;

        public WeatherForecastHolder()
        {
            //инициализирую коллекцию для хранения показателей температуры
            _values = new List<WeatherForecast>();
        }

        /// <summary>
        /// Добавить новый показатель температуры
        /// </summary>
        /// <param name="date">дата фиксации показателя температуры</param>
        /// <param name="temperatureC">показатель температуры</param>
        public void Add(DateTime date, int temperatureC)
        {
            _values.Add(new WeatherForecast() { Date = date, TemperatureC = temperatureC });
        }

        /// <summary>
        /// Обновить показатель даты
        /// </summary>
        /// <param name="date">Дата фиксации показания температуры</param>
        /// <param name="temperatureC">Новый показатель температуры</param>
        /// <returns></returns>
        public bool Update(DateTime date, int temperatureC)
        {
            foreach (var item in _values)
            {
                if (item.Date == date)
                {
                    item.TemperatureC = temperatureC;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Получить показатели температуры за временной период
        /// </summary>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <returns></returns>
        public List<WeatherForecast> Get (DateTime dateFrom, DateTime dateTo)
        {
            return _values.FindAll(item=> item.Date >= dateFrom && item.Date <= dateTo);
        }

        /// <summary>
        /// Удалить показатель температуры на дату
        /// </summary>
        /// <param name="date">дата фиксации показания температры</param>
        /// <returns></returns>
        public bool Delete (DateTime date)
        {
            foreach(var item in _values)
            {
                if (item.Date == date)
                {
                    _values.Remove(item);
                    return true;
                }
            }
            return false;
        }
    }
}
