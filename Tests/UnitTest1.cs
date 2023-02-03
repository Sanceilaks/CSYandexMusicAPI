using System.Diagnostics;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        public Yandex GetYandexApi()
        {
            var token = Environment.GetEnvironmentVariable("YANDEX_MUSIC_TOKEN", EnvironmentVariableTarget.User);
            return new Yandex(token!);
        }

        [TestMethod]
        public async Task AuthorizationTest()
        {
            await GetYandexApi().AuthorizeAsync();
        }
    }
}