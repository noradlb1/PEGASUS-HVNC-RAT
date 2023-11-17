using System.Collections;
using System.Windows.Forms;

public class ListViewColumnSorter : IComparer
{
    private readonly CaseInsensitiveComparer _objectCompare;

    public ListViewColumnSorter()
    {
        SortColumn = 0;
        Order = SortOrder.None;
        _objectCompare = new CaseInsensitiveComparer();
    }

    public int SortColumn { set; get; }

    public SortOrder Order { set; get; }

    public int Compare(object x, object y)
    {
        var listViewItem1 = (ListViewItem) x;
        var listViewItem2 = (ListViewItem) y;
        if (listViewItem1.SubItems[0].Text == ".." || listViewItem2.SubItems[0].Text == "..")
            return 0;
        var num = _objectCompare.Compare(listViewItem1.SubItems[SortColumn].Text,
            listViewItem2.SubItems[SortColumn].Text);
        if (Order == SortOrder.Ascending)
            return num;
        return Order == SortOrder.Descending ? -num : 0;
    }
}