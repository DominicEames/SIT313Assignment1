using System;
using Foundation;
using UIKit;

namespace Assignment1
{
    public class TableSource : UITableViewSource
    {
        string[] tableItems;
        string cellIdentifier = "TableCell";

        public TableSource(string[] items)
        {
            tableItems = items;

        }
        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return tableItems.Length;
        }
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);
            if (cell == null)
                cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);
            cell.TextLabel.Text = tableItems[indexPath.Row];
            return cell;
        }
    }
}
