/// разработчик: Самаев Антон ИВТ-21

using Chat;

namespace TestChat
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_set_get()
        {
            ChatBotCS f = new ChatBotCS();

            f.username_set("rew");
            Assert.AreEqual("rew", f.username_get());

            f.username_set("pol");
            Assert.AreEqual("pol", f.username_get());

            f.username_set("gty");
            Assert.AreEqual("gty", f.username_get());
        }

        [TestMethod]
        public void TestMethod_answer()
        {
            ChatBotCS f = new ChatBotCS();

            Assert.AreEqual("Привет", f.answer("Привет"));
            Assert.AreEqual("Привет", f.answer("пРив"));
            Assert.AreEqual("Привет", f.answer("приветик"));

            Assert.AreEqual(DateTime.Now.ToString("T"), f.answer("время"));
            Assert.AreEqual(DateTime.Now.ToString("T"), f.answer("врем"));
            Assert.AreEqual(DateTime.Now.ToString("T"), f.answer("вреМеЧко"));

            Assert.AreEqual(DateTime.Now.ToString("D"), f.answer("дата"));
            Assert.AreEqual(DateTime.Now.ToString("D"), f.answer("дат"));
            Assert.AreEqual(DateTime.Now.ToString("D"), f.answer("ДаТу"));

            // третий параметр это погрешность в сравнении
            Assert.AreEqual(21.0, float.Parse(f.answer("прибавь 12 и 9")), 0.0001);
            Assert.AreEqual(72.0, float.Parse(f.answer("прибавь 0 и 72")), 0.0001);

            Assert.AreEqual(108, float.Parse(f.answer("умножь 12 и 9")), 0.0001);
            Assert.AreEqual(-18, float.Parse(f.answer("умножь 6 и -3")), 0.0001);

            Assert.AreEqual(3.0, float.Parse(f.answer("разность 12 и 9")), 0.0001);
            Assert.AreEqual(-8, float.Parse(f.answer("разность 0 и 8")), 0.0001);

            Assert.AreEqual(1.3333, float.Parse(f.answer("раздели 12 и 9")), 0.0001);
            Assert.AreEqual(4, float.Parse(f.answer("раздели 100 и 25")), 0.0001);

            Assert.AreEqual("Не знаю, что ответить", f.answer("zdgfsdg"));

        }
    }
}