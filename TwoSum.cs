public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> index = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            // x + y = target
            // => y = target - x 
            int x = nums[i];
            int y = target - x;
            if (index.ContainsKey(y)) {
                return new int[] { index[y], i };
            } 
            if (!index.ContainsKey(x)) index.Add(x, i);
        }
        return new int[] {0, 0};
    }
}