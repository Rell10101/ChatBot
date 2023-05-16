/// �����������: ������ ����� ���-21

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

            Assert.AreEqual("������", f.answer("������"));
            Assert.AreEqual("������", f.answer("����"));
            Assert.AreEqual("������", f.answer("��������"));

            Assert.AreEqual(DateTime.Now.ToString("T"), f.answer("�����"));
            Assert.AreEqual(DateTime.Now.ToString("T"), f.answer("����"));
            Assert.AreEqual(DateTime.Now.ToString("T"), f.answer("��������"));

            Assert.AreEqual(DateTime.Now.ToString("D"), f.answer("����"));
            Assert.AreEqual(DateTime.Now.ToString("D"), f.answer("���"));
            Assert.AreEqual(DateTime.Now.ToString("D"), f.answer("����"));

            // ������ �������� ��� ����������� � ���������
            Assert.AreEqual(21.0, float.Parse(f.answer("������� 12 � 9")), 0.0001);
            Assert.AreEqual(72.0, float.Parse(f.answer("������� 0 � 72")), 0.0001);

            Assert.AreEqual(108, float.Parse(f.answer("������ 12 � 9")), 0.0001);
            Assert.AreEqual(-18, float.Parse(f.answer("������ 6 � -3")), 0.0001);

            Assert.AreEqual(3.0, float.Parse(f.answer("�������� 12 � 9")), 0.0001);
            Assert.AreEqual(-8, float.Parse(f.answer("�������� 0 � 8")), 0.0001);

            Assert.AreEqual(1.3333, float.Parse(f.answer("������� 12 � 9")), 0.0001);
            Assert.AreEqual(4, float.Parse(f.answer("������� 100 � 25")), 0.0001);

            Assert.AreEqual("�� ����, ��� ��������", f.answer("zdgfsdg"));

        }
    }
}