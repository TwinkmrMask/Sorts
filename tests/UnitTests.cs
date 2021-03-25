using sorts;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace UnitTest
{
    public class UnitTests : defaultList
    {
        [Fact]
        public void PanecakeSortTest()
        {
            using (PanecakeSort sort = new PanecakeSort())
            {
                List<int> listBySort = List.ToList();
                sort.Sort(listBySort);
                Assert.Equal(listBySort, List.OrderBy(x => x).ToList());
            }
        }
        [Fact]
        public void InsertionSortTest()
        {
            using (BubbleSort sort = new BubbleSort())
            {
                List<int> listBySort = List.ToList();
                sort.Sort(listBySort);
                Assert.Equal(listBySort, List.OrderBy(x => x).ToList());
            }
        }
        [Fact]
        public void BubbleSortTest()
        {
            using (InsertionSort sort = new InsertionSort())
            {
                List<int> listBySort = List.ToList();
                sort.Sort(listBySort);
                Assert.Equal(listBySort, List.OrderBy(x => x).ToList());
            }
        }

    }
}
