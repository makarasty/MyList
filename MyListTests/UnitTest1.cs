namespace MyListTests;

using Xunit;

public class MyListTests
{
	[Fact]
	public void Add_AddsItemToList()
	{
		// Базові налаштування 
		MyList myList = new MyList();

		// Робимо щось
		myList.Add(42);

		// Перевіряємо
		Assert.Equal(1, myList.Count);
		Assert.Equal(42, myList[0]);
	}

	[Fact]
	public void InsertAt_InsertsItemAtIndex()
	{
		MyList myList = new MyList();
		myList.Add(1);
		myList.Add(3);

		myList.InsertAt(1, 2);

		Assert.Equal(3, myList.Count);
		Assert.Equal(1, myList[0]);
		Assert.Equal(2, myList[1]);
		Assert.Equal(3, myList[2]);
	}

	[Fact]
	public void RemoveAt_RemovesItemAtIndex()
	{
		MyList myList = new MyList();
		myList.Add(1);
		myList.Add(2);
		myList.Add(3);

		myList.RemoveAt(1);

		Assert.Equal(2, myList.Count);
		Assert.Equal(1, myList[0]);
		Assert.Equal(3, myList[1]);
	}

	[Fact]
	public void Remove_RemovesItem()
	{
		MyList myList = new MyList();
		myList.Add(1);
		myList.Add(2);
		myList.Add(3);

		myList.Remove(2);

		Assert.Equal(2, myList.Count);
		Assert.Equal(1, myList[0]);
		Assert.Equal(3, myList[1]);
	}

	[Fact]
	public void IndexOf_ReturnsIndexOfItem()
	{
		MyList myList = new MyList();
		myList.Add(10);
		myList.Add(20);
		myList.Add(30);

		int index = myList.IndexOf(20);

		Assert.Equal(1, index);
	}
}
