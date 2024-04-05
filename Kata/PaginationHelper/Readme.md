For this exercise you will be strengthening your page-fu mastery. You will complete the PaginationHelper class, which is a utility class helpful for querying paging information related to an array.

The class is designed to take in an array of values and an integer indicating how many items will be allowed per each page. The types of values contained within the collection/array are not relevant.

The following are some examples of how this class is used:

    var helper = new PaginationHelper(['a','b','c','d','e','f'], 4);
    helper.pageCount(); // should == 2
    helper.itemCount(); // should == 6
    helper.pageItemCount(0); // should == 4
    helper.pageItemCount(1); // last page - should == 2
    helper.pageItemCount(2); // should == -1 since the page is invalid
    
    // pageIndex takes an item index and returns the page that it belongs on
    helper.pageIndex(5); // should == 1 (zero based index)
    helper.pageIndex(2); // should == 0
    helper.pageIndex(20); // should == -1
    helper.pageIndex(-10); // should == -1
    

    helper = PaginationHelper(Char).new(['a','b','c','d','e','f'], 4);
    helper.page_count() # should == 2
    helper.item_count() # should == 6
    helper.page_item_count(0) # should == 4
    helper.page_item_count(1) # last page - should == 2
    helper.page_item_count(2) # should == -1 since the page is invalid
    
    # pageIndex takes an item index and returns the page that it belongs on
    helper.page_index(5) # should == 1 (zero based index)
    helper.page_index(2) # should == 0
    helper.page_index(20) # should == -1
    helper.page_index(-10) # should == -1
    

    PaginationHelper<Character> helper = new PaginationHelper(Arrays.asList('a', 'b', 'c', 'd', 'e', 'f'), 4);
    helper.pageCount(); // should == 2
    helper.itemCount(); // should == 6
    helper.pageItemCount(0); // should == 4
    helper.pageItemCount(1); // last page - should == 2
    helper.pageItemCount(2); // should == -1 since the page is invalid
    
    // pageIndex takes an item index and returns the page that it belongs on
    helper.pageIndex(5); // should == 1 (zero based index)
    helper.pageIndex(2); // should == 0
    helper.pageIndex(20); // should == -1
    helper.pageIndex(-10); // should == -1
    

    helper = new PaginationHelper(['a','b','c','d','e','f'], 4)
    helper.pageCount() # should == 2
    helper.itemCount() # should == 6
    helper.pageItemCount(0) # should == 4
    helper.pageItemCount(1) # last page - should == 2
    helper.pageItemCount(2) # should == -1 since the page is invalid
    
    # pageIndex takes an item index and returns the page that it belongs on
    helper.pageIndex(5) # should == 1 (zero based index)
    helper.pageIndex(2) # should == 0
    helper.pageIndex(20) # should == -1
    helper.pageIndex(-10) # should == -1
    

    helper = PaginationHelper.new(['a','b','c','d','e','f'], 4)
    helper.page_count() # should == 2
    helper.item_count() # should == 6
    helper.page_item_count(0) # should == 4
    helper.page_item_count(1) # last page - should == 2
    helper.page_item_count(2) # should == -1 since the page is invalid
    
    # page_index takes an item index and returns the page that it belongs on
    helper.page_index(5) # should == 1 (zero based index)
    helper.page_index(2) # should == 0
    helper.page_index(20) # should == -1
    helper.page_index(-10) # should == -1 because negative indexes are invalid
    

    collection   = ['a','b','c','d','e','f']
    itemsPerPage = 4
    
    pageCount collection itemsPerPage       `shouldBe` 2
    itemCount collection itemsPerPage       `shouldBe` 6
    
    pageItemCount collection itemsPerPage 0 `shouldBe` Just 4 -- four of six items
    pageItemCount collection itemsPerPage 1 `shouldBe` Just 2 -- the last two items
    pageItemCount collection itemsPerPage 3 `shouldBe` Nothing -- page doesn't exist
    
    pageIndex collection itemsPerPage  0    `shouldBe` Just 0 -- zero based index
    pageIndex collection itemsPerPage  5    `shouldBe` Just 1 
    pageIndex collection itemsPerPage 20    `shouldBe` Nothing
    pageIndex collection itemsPerPage (-20) `shouldBe` Nothing
    

    helper = PaginationHelper(['a','b','c','d','e','f'], 4)
    helper.page_count() # should == 2
    helper.item_count() # should == 6
    helper.page_item_count(0) # should == 4
    helper.page_item_count(1) # last page - should == 2
    helper.page_item_count(2) # should == -1 since the page is invalid
    
    # page_index takes an item index and returns the page that it belongs on
    helper.page_index(5) # should == 1 (zero based index)
    helper.page_index(2) # should == 0
    helper.page_index(20) # should == -1
    helper.page_index(-10) # should == -1 because negative indexes are invalid
    

    var helper = new PaginationHelper<char>(new List<char>{'a', 'b', 'c', 'd', 'e', 'f'}, 4);
    helper.PageCount; // should == 2
    helper.ItemCount; // should == 6
    helper.PageItemCount(0); // should == 4
    helper.PageItemCount(1); // last page - should == 2
    helper.PageItemCount(2); // should == -1 since the page is invalid
    
    // pageIndex takes an item index and returns the page that it belongs on
    helper.PageIndex(5); // should == 1 (zero based index)
    helper.PageIndex(2); // should == 0
    helper.PageIndex(20); // should == -1
    helper.PageIndex(-10); // should == -1
    

    val helper = PaginationHelper<Char>(listOf('a', 'b', 'c', 'd', 'e', 'f'), 4)
    helper.pageCount // should == 2
    helper.itemCount // should == 6
    helper.pageItemCount(0) // should == 4
    helper.pageItemCount(1) // last page - should == 2
    helper.pageItemCount(2) // should == -1 since the page is invalid
    
    // pageIndex takes an item index and returns the page that it belongs on
    helper.pageIndex(5) // should == 1 (zero based index)
    helper.pageIndex(2) // should == 0
    helper.pageIndex(20) // should == -1
    helper.pageIndex(-10) // should == -1
    

    let helper = new PaginationHelper(["a", "b", "c", "d", "e", "f"], 4)
    helper.pageCount() // should == 2
    helper.itemCount() // should == 6
    helper.pageItemCount(0) // should == 4
    helper.pageItemCount(1) // last page - should == 2
    helper.pageItemCount(2) // should == -1 since the page is invalid
    
    // pageIndex takes an item index and returns the page that it belongs on
    helper.pageIndex(5) // should == 1 (zero based index)
    helper.pageIndex(2) // should == 0
    helper.pageIndex(20) // should == -1
    helper.pageIndex(-10) // should == -1
    

    let helper = PaginationHelper::new(vec!['a', 'b', 'c', 'd', 'e', 'f'], 4);
    helper.page_count() // should be 2
    helper.item_count() // should be 6
    helper.page_item_count(0) // should be Some(4)
    helper.page_item_count(1) // should be Some(2) (last page)
    helper.page_item_count(2) // should be None (since the page is invalid)
    
    // page_index takes an item index and returns the page that it belongs on
    helper.page_index(5) // should be Some(1) (zero based index)
    helper.page_index(2) // should be Some(0)
    helper.page_index(20) // should be None (since the item is invalid)