using Xdgk.Communi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Xdgk.Communi.Test
{
    
    
    /// <summary>
    ///这是 CommuniDetailQueueTest 的测试类，旨在
    ///包含所有 CommuniDetailQueueTest 单元测试
    ///</summary>
    [TestClass()]
    public class CommuniDetailQueueTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试属性
        // 
        //编写测试时，还可使用以下属性:
        //
        //使用 ClassInitialize 在运行类中的第一个测试前先运行代码
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //使用 ClassCleanup 在运行完类中的所有测试后再运行代码
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //使用 TestInitialize 在运行每个测试前先运行代码
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //使用 TestCleanup 在运行完每个测试后运行代码
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Enqueue 的测试
        ///</summary>
        [TestMethod()]
        public void EnqueueTest()
        {
            //CommuniDetailQueue target = new CommuniDetailQueue(); // TODO: 初始化为适当的值
            //CommuniDetail item = null; // TODO: 初始化为适当的值
            //target.Enqueue(item);
            //Assert.Inconclusive("无法验证不返回值的方法。");

            CommuniDetailQueue target = new CommuniDetailQueue();

            for (int i = 0; i < 1200; i++)
            {
                CommuniDetail item = new CommuniDetail(
                    "operaText",
                    "result",
                    null,
                    null,
                    ParseResultEnum.Fail );
                target.Enqueue(item);
                System.Console.WriteLine(target.Count);
                Assert.IsTrue(target.Count <= 1000);

            }
        }

        /// <summary>
        ///Add 的测试
        ///</summary>
        [TestMethod()]
        public void AddTest()
        {
            CommuniDetailQueue target = new CommuniDetailQueue();

            for (int i = 0; i < 1200; i++)
            {
                CommuniDetail item = new CommuniDetail(
                    "operaText",
                    "result",
                    null,
                    null,
                    ParseResultEnum.Success);
                target.Add(item);
                System.Console.WriteLine(target.Count);
                Assert.IsTrue(target.Count <= 1000);

            }
        }

        /// <summary>
        ///CommuniDetailQueue 构造函数 的测试
        ///</summary>
        [TestMethod()]
        public void CommuniDetailQueueConstructorTest()
        {
        }
    }
}
