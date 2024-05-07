
/*
Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.

Rules:
Only add onpen paranthesis if open_count < n
only add a closing paranthesis if closed_count < open_count
only a vailid answer if open_count == closed_count == n
*/

public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        List<string> ans = new List<string>();
        string testAnser = string.Empty;
         
        void BackTrack(int openCount,int closedCount,string path)
        {
            if (openCount == closedCount && openCount == n && closedCount == n) 
            {
                ans.Add(path);
                return;
            }
            if (openCount < n)
            {
                BackTrack(openCount + 1, closedCount, path + "(");
            }
            if (closedCount < openCount)
            {
                BackTrack(openCount, closedCount + 1, path + ")");
            }

        }

        BackTrack(0,0,"");

        return ans;
    }


    static void Main()
    {
        Solution mySolution = new Solution();

        mySolution.GenerateParenthesis(3);
    }
}