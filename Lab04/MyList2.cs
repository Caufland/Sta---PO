using System.Collections;

namespace Lab04
{
    public partial class MyList<T> : IEnumerable<T>
    {

        class MyEnumerator : IEnumerator<T>
        {

            Node fisrst, current;

            public MyEnumerator(Node first)
            {
                this.fisrst = first = this.current = new Node
                {
                    Next = first
                };
            }

            public T Current => this.current.Value;

            object IEnumerator.Current => this.Current;

            public void Dispose()
            {
                //destruktor
            }

            public bool MoveNext()
            {
                if (this.current != null)
                    this.current = this.current.Next;
                return this.current != null;
            }

            public void Reset()
            {
                this.current = this.fisrst;
            }
        }


        public IEnumerator<T> GetEnumerator()
        {
            return new MyEnumerator(this.first);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new MyEnumerator(this.first);
        }
    }
}
