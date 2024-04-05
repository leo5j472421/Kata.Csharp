namespace Kata.Test {
    [TestFixture]
    public class UserTest
    {  
  
        // Assert correct rank progression
        public void assertRankProgression(int rank, User user, int expRank, int expProgress) {
            Assert.True(user.rank == expRank,
                "Applied Rank: " + rank + 
                "; Expected rank: " + expRank + 
                "; Actual: " + user.rank);
        
            Assert.True(user.progress == expProgress,
                "Applied Rank; " + rank + 
                "; Expected progress: " + expProgress + 
                ", Actual: " + user.progress);
        }
    
        [TestCase(-7, -8, 10)]
        [TestCase(-6, -8, 40)]
        [TestCase(-5, -8, 90)]
        [TestCase(-4, -7, 60)]
        [TestCase(-8, -8, 3)]
        // Check single increments
        public void testValidSingleRankProgression(int rank, int expectedRank, int expectedProgress)
        {
            User user = new User();
      
            user.incProgress(rank);
      
            assertRankProgression(rank, user, expectedRank, expectedProgress);
        }
    
        [TestCase(9)]
        [TestCase(-9)]
        [TestCase(0)]
        // Check invalid rank progressions
        public void testInvalidRange(int rank) 
        {
            User user = new User();
            Assert.Throws<ArgumentException>(() => user.incProgress(rank));
        }
    }
}