﻿namespace Kata.PaginationHelper;

public class PaginationHelper<T>
{
    // TODO: Complete this class
  
    /// <summary>
    /// Constructor, takes in a list of items and the number of items that fit within a single page
    /// </summary>
    /// <param name="collection">A list of items</param>
    /// <param name="itemsPerPage">The number of items that fit within a single page</param>
    public PaginationHelper(IList<T> collection, int itemsPerPage)
    {

    }

    /// <summary>
    /// The number of items within the collection
    /// </summary>
    public int ItemCount
    {
        get
        {
            return 0;
        }
    }

    /// <summary>
    /// The number of pages
    /// </summary>
    public int PageCount
    {
        get
        {
            return 0;
        }
    }

    /// <summary>
    /// Returns the number of items in the page at the given page index 
    /// </summary>
    /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
    /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
    public int PageItemCount(int pageIndex)
    {
        return 0;
    }

    /// <summary>
    /// Returns the page index of the page containing the item at the given item index.
    /// </summary>
    /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
    /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
    public int PageIndex(int itemIndex)
    {
        return 0;
    }
}