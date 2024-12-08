public class UnitTests
{
    private readonly Solution _solution;
    
    public UnitTests()
    {
        _solution = new Solution();
    }
    
    [Fact]
    public void Test1()
    {
        int target = 9;
        int[] nums = [2, 7, 11, 15];
        int[] expected = [0, 1];
        
        int[] result = _solution.TwoSum(nums, target);
        
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test2()
    {
        int target = 6;
        int[] nums = [3,2,4];
        int[] expected = [1,2];
        
        int[] result = _solution.TwoSum(nums, target);
        
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test3()
    {
        int target = 6;
        int[] nums = [3,3];
        int[] expected = [0,1];
        
        int[] result = _solution.TwoSum(nums, target);
        
        Assert.Equal(expected, result);
    }
}