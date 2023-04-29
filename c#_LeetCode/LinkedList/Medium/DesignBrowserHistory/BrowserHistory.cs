namespace LeetCode.LinkedList.Medium.DesignBrowserHistory;

public class HistoryNode
{
    public string Page { get; set; }
    public HistoryNode Next { get; set; }
    public HistoryNode Previous { get; set;}
}

//https://leetcode.com/problems/design-browser-history/description/
public class BrowserHistory
{
    private readonly HistoryNode head;
    private HistoryNode current;

    public BrowserHistory(string homepage)
    {
        var historyNode = new HistoryNode { Page = homepage };
        head = historyNode;
        current = historyNode;
    }

    public void Visit(string url)
    {
        var newNode = new HistoryNode { Page = url };

        current.Next = newNode;
        newNode.Previous = current;
        current = newNode;
    }

    public string Back(int steps)
    {
        while(current.Previous != null && steps > 0)
        {
            current = current.Previous;
            steps--;
        }

        return current.Page;
    }

    public string Forward(int steps)
    {
        while (current.Next != null && steps > 0)
        {
            current = current.Next;
            steps--;
        }

        return current.Page;
    }
}