using System;

namespace ArrayList
{
    // Array List using generic type
    public class ArrayListTest
    {
       public class ArrayList<T>
       {

            //Initialize an arraylist of generic type
            private T[] arr;
            private int count;
            public int Count {  get { return this.count; } }

            // initialize the size of the array list
            private const int INITIAL_SIZE = 3;

            //Create a constructor and pass the initial size as the argument
            public ArrayList(int size = INITIAL_SIZE)
            {
                this.arr = new T[size]; // pass the size to the already defined array
                this.count = 0;
            }
            //  This method add an item to the array
            public void AddItem(T item)
            {
                DoubleArraySize(); // call this method if the array is full
                this.arr[this.count] = item; //That is first element in the array takes the count of 0
                this.count++;
            }
            //Insert an item at a particular position
            public void InsertItem(int index, T item)
            {
                if (index > this.count || index < 0)
                {
                    throw new IndexOutOfRangeException(
                    "Invalid index: " + index);
                }
                DoubleArraySize();
                Array.Copy(this.arr, index, this.arr , index + 1, this.count - index);
                this.arr[index] = item;
                this.count++;  // Increases the  count after inert

            }
            //double the size of the array if it is full
            public void DoubleArraySize()
            {
                if (this.count + 1 > this.arr.Length)
                {
                    // create a new array of double the size of the first array
                    T[] newArr = new T[this.arr.Length * 2];
                    // copy the old array into the new array
                    Array.Copy(this.arr, newArr, this.count);
                    this.arr = newArr;
                }
            }
            // Clear the array
            public void Clear()
            {
                this.arr = new T[INITIAL_SIZE];
                this.count = 0;
            }
            // Find the index of a given item
            public int IndexOfItem(T item)
            {
                for (int i = 0; i < this.arr.Length; i++)
                {
                    if (object.Equals(item, this.arr[i]))
                    {
                        return i;
                    }
                }
                return -1;
            }
            //Check if an item exist
            public bool Contains(T item)
            {
                int index = IndexOfItem(item);
                bool found = (index != -1);
                return found;
            }
            // Remove item at a specific index
            public T RemoveAt(int index)
            {
                if (index >= this.count || index < 0)
                {
                    throw new ArgumentOutOfRangeException(
                    "Invalid index: " + index);
                }
                T item = this.arr[index];
                Array.Copy(this.arr, index + 1,
                this.arr, index, this.count - index - 1);
                this.arr[this.count - 1] = default(T);
                this.count--;
                return item;
            }
            // Remove an item
            public int Remove(T item)
            {
                int index = IndexOfItem(item);
                if (index != -1)

                {
                    this.RemoveAt(index);
                }
                return index;
            }
            // Create Indexer
            public T this[int index]
            {
                get
                {
                    if (index >= this.count || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(
                        "Invalid index: " + index);
                    }
                    return this.arr[index];

                }
                set
                {
                    if (index >= this.count || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(
                        "Invalid index: " + index);
                    }
                    this.arr[index] = value;
                }
            }

       }
        static void Main(string[] args)
        {
            ArrayList<string> myDevStackList = new ArrayList<string>();
            myDevStackList.AddItem("Git");
            myDevStackList.AddItem("C#");
            myDevStackList.AddItem("Docker");
            myDevStackList.AddItem("SQL");
            myDevStackList.AddItem("Kubernetes");
            myDevStackList.AddItem(".Net Core");
            myDevStackList.Remove("Kubernetes");
            myDevStackList.InsertItem(1, "Git");
            myDevStackList.RemoveAt(3);

            Console.WriteLine("I need to learn:");
            for (int i = 0; i < myDevStackList.Count; i++)
            {
                Console.WriteLine(" - " + myDevStackList[i]);
            }
            Console.WriteLine("Position of 'SQL' = {0}",
            myDevStackList.IndexOfItem("SQL"));
            Console.WriteLine("Position of 'Kubernetes' = {0}",
            myDevStackList.IndexOfItem("Kubernetes"));
            Console.WriteLine("Do we have to learn Docker? " +

            myDevStackList.Contains("Docker"));

            
           
            Console.WriteLine("Enter key to close");
            Console.ReadKey();
        }
        

    }
}
