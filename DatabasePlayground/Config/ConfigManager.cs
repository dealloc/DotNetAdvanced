using System.Xml.Serialization;

namespace DatabasePlayground.Config
{
    public static class ConfigManager
    {
        private static AppConfig? _appConfig = null;

        public static AppConfig LoadConfiguration()
        {
            if (_appConfig is not null)
                return _appConfig;

            var serializer = new XmlSerializer(typeof(AppConfig));
            using var stream = new FileStream("config.xml", FileMode.Open, FileAccess.Read);

            _appConfig = (AppConfig?)serializer.Deserialize(stream);

            if (_appConfig is null)
                throw new InvalidDataException("The file config.xml contains an invalid configuration.");

            return _appConfig;
        }
    }
}
