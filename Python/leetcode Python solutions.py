# Completed

# https://leetcode.com/problems/find-the-duplicate-number

# Given an array nums containing n + 1 integers where each integer is between 1 and n (inclusive), 
# prove that at least one duplicate number must exist. Assume that there is only one duplicate number, find the duplicate one.
# Example 1:
# Input: [1,3,4,2,2]
# Output: 2
# Example 2:
# Input: [3,1,3,4,2]
# Output: 3
# Note:
# You must not modify the array (assume the array is read only).
# You must use only constant, O(1) extra space.
# Your runtime complexity should be less than O(n2).
# There is only one duplicate number in the array, but it could be repeated more than once.

class Solution:
    def findDuplicate(self, nums: List[int]) -> int:
        new_list = []
        
        
        for num in nums:
            if num not in new_list:
                new_list.append(num)
            else:
                return num

# https://leetcode.com/problems/longest-substring-without-repeating-characters/

# Given a string s, find the length of the longest substring without repeating characters.

 

# Example 1:

# Input: s = "abcabcbb"
# Output: 3
# Explanation: The answer is "abc", with the length of 3.
# Example 2:

# Input: s = "bbbbb"
# Output: 1
# Explanation: The answer is "b", with the length of 1.
# Example 3:

# Input: s = "pwwkew"
# Output: 3
# Explanation: The answer is "wke", with the length of 3.
# Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
# Example 4:

# Input: s = ""
# Output: 0

class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        new_arr = []
        
        for letter in s:
            if letter not in new_arr:
                new_arr.append(letter)
                
        return len(new_arr)

# Planned 
# https://leetcode.com/problems/search-in-rotated-sorted-array/


# Started

