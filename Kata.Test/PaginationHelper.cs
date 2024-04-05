using Kata.PaginationHelper;

namespace Kata.Test
{
    // TODO: Replace examples and use TDD development by writing your own tests

    [TestFixture, Order(1)]
    public class SampleTestsFromDescription
    {
        [TestCase(6, 4, 2)]
        [TestCase(6, 2, 3)]
        [TestCase(6, 7, 1)]
        [TestCase(0, 4, 0)]
        [TestCase(1, 4, 1)]
        [TestCase(2, 4, 1)]
        [TestCase(3, 4, 1)]
        [TestCase(4, 4, 1)]
        public void PageCountTest(int numberOfItem, int itemsPerPage, int expected)
        {
            var helper = new PaginationHelper<char>(new List<char>(new string('a', numberOfItem)), itemsPerPage);
            Assert.That(helper.PageCount, Is.EqualTo(expected));
        }

        [TestCase(6, 4, 6)]
        public void ItemCountTest(int numberOfItem, int itemsPerPage, int expected)
        {
            var helper = new PaginationHelper<char>(new List<char>(new string('a', numberOfItem)), itemsPerPage);
            Assert.That(helper.ItemCount, Is.EqualTo(expected));
        }


        [TestCase(6, 0, 4)]
        [TestCase(6, 1, 2)]
        [TestCase(6, 2, -1)]
        [TestCase(6, 3, -1)]
        [TestCase(6, 4, -1)]
        [TestCase(6, 5, -1)]
        [TestCase(6, 7, -1)]
        public void PageItemCountTest(int numberOfItem, int pageIndex, int expected)
        {
            var helper = new PaginationHelper<char>(new List<char>(new string('a', numberOfItem)), 4);
            Assert.That(helper.PageItemCount(pageIndex), Is.EqualTo(expected));
        }

        [Test]
        [TestCase(6, 5, ExpectedResult = 1)]
        [TestCase(6, 2, ExpectedResult = 0)]
        [TestCase(6, 20, ExpectedResult = -1)]
        [TestCase(6, -10, ExpectedResult = -1)]
        [TestCase(50, 20, ExpectedResult = 4)]
        [TestCase(50, 0, ExpectedResult = 0)]
        [TestCase(50, 49, ExpectedResult = 12)]
        [TestCase(50, 50, ExpectedResult = -1)]
        
        
        public int PageIndexTest(int itemCount, int itemIndex)
        {
            var helper = new PaginationHelper<char>(new List<char>(new string('a', itemCount)), 4);
            return helper.PageIndex(itemIndex);
        }
    }

    [TestFixture, Order(2)]
    public class EmptyCollection
    {
        private readonly IList<string> _collection = Array.Empty<string>();
        private PaginationHelper<string> _helper;

        public EmptyCollection(PaginationHelper<string> helper)
        {
            this._helper = helper;
        }

        [SetUp]
        public void SetUp()
        {
            _helper = new PaginationHelper<string>(_collection, 4);
        }

        [Test]
        public void PageCountTest()
        {
            Assert.That(_helper.PageCount, Is.EqualTo(0));
        }

        [Test]
        public void ItemCountTest()
        {
            Assert.That(_helper.ItemCount, Is.EqualTo(0));
        }


        [Test]
        [TestCase(0, ExpectedResult = -1)]
        [TestCase(1, ExpectedResult = -1)]
        [TestCase(-1, ExpectedResult = -1)]
        public int PageItemCountTest(int pageIndex)
        {
            return _helper.PageItemCount(pageIndex);
        }

        [Test]
        [TestCase(0, ExpectedResult = -1)]
        [TestCase(1, ExpectedResult = -1)]
        [TestCase(-1, ExpectedResult = -1)]
        public int PageIndexTest(int itemIndex)
        {
            return _helper.PageIndex(itemIndex);
        }
    }
}