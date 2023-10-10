namespace MyListTests
{
	public interface IMyList
	{
		void Add(int item);

		void InsertAt(int index, int item);

		int this[int index] { get; set; }

		void RemoveAt(int index);

		void Remove(int item);

		int IndexOf(int item);

		int Count { get; }
	}
	public class MyList : IMyList
	{
		private int[] items;

		private int count;

		public MyList()
		{
			items = new int[10];
			count = 0;
		}

		public void Add(int item)
		{
			EnsureCapacity(count + 1);
			items[count++] = item;
		}

		public void InsertAt(int index, int item)
		{
			if (index < 0 || index > count)
				throw new ArgumentOutOfRangeException("index");

			EnsureCapacity(count + 1);

			for (int i = count; i > index; i--)
			{
				items[i] = items[i - 1];
			}

			items[index] = item;
			count++;
		}

		public int this[int index]
		{
			get
			{
				if (index < 0 || index >= count)
					throw new ArgumentOutOfRangeException("index");

				return items[index];
			}
			set
			{
				if (index < 0 || index >= count)
					throw new ArgumentOutOfRangeException("index");

				items[index] = value;
			}
		}

		public void RemoveAt(int index)
		{
			if (index < 0 || index >= count)
				throw new ArgumentOutOfRangeException("index");

			for (int i = index; i < count - 1; i++)
			{
				items[i] = items[i + 1];
			}

			count--;
		}

		public void Remove(int item)
		{
			int index = IndexOf(item);

			if (index != -1)
			{
				RemoveAt(index);
			}
		}

		public int IndexOf(int item)
		{
			for (int i = 0; i < count; i++)
			{
				if (items[i] == item)
				{
					return i;
				}
			}

			return -1;
		}
		public int Count
		{
			get
			{
				return count;
			}
		}

		private void EnsureCapacity(int requiredCapacity)
		{
			if (requiredCapacity > items.Length)
			{
				int newCapacity = Math.Max(items.Length * 2, requiredCapacity);
				int[] newArray = new int[newCapacity];
				Array.Copy(items, newArray, count); // lifehack
				items = newArray;
			}
		}
	}
}