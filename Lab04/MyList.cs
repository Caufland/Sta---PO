namespace Lab04
{
    public partial class MyList<T>
    {
        private class Node
        {
            public T Value { get; set; }
            public Node Next;
        }

        private Node first = null;
        private Node last = null;

        public void Add(T element)
        {
            if (first == null)
                this.first = this.last = new Node() { Value = element };
            else
                this.last = last.Next = new Node() { Value = element };
        }

        public int Count
        {
            get 
            {
                int count = 0;
                var current = this.first;
                while (current != null) 
                {
                    current = current.Next;
                    count++;
                }

                return count;
            }
        }

        public void Insert(int index, T element)
        {
            this.Get(index).Value = element;
        }

        public bool Remove(T element)
        {

            Node aktualny = this.first;
            Node poprzedni = null;

            while (aktualny != null)
            {
                if (element.Equals(aktualny.Value)) // wiemy ze nasz aktualny to jest ten co szukamy i jeśli poprzeni jest nullem to podmieni go na nexta a jeśli nie jest nullem to podmieni go na następny 
                {
                    if (poprzedni == null) //Pierwszy wyraz bo nie ma poprzedniego
                    { 
                        this.first = aktualny.Next; //Poprzez pominięcie pierwszego elementu usuwamy wszystkie połaczenia z tym obiektem co sprawia ze GC (Garbage Collector) go usuwa i tym samym zapobiega powstawaniu memory leak (posiadania tych samych dwóch obiektów w czasie
                        return true;
                    }
                    else //Środkowe elelemnty i ostatni
                    {
                        //Usuwanie środkowego wyrazu
                        poprzedni.Next = aktualny.Next; //poprzeni nie jest nullem podmieniamy poprzeni na aktlany next czyli jak mamy liste 1 2 3 i mamy do usunięcia 2 to poprzenim.next jest nasza 2 a aktalny net to jest nasza 3 więc podnieniamy je i aktumatyhcznie GC usuwa nam 2 
                        
                        //Usuwanie ostatniego wyrazu
                        if (aktualny.Next == null) //jeśli element aktualny jest nullem to wtedy oznacza ze wyszlismy poza noda co oznacza ze poprzedni element był ostatnim (last)
                        {
                            this.last = poprzedni;
                            return true;
                        }
                    }
                }
                poprzedni = aktualny;
                aktualny = aktualny.Next;
            }

            return false;
        }
        public bool RemoveAt(int index)
        {
            Node aktualny = this.first;
            Node poprzedni = null;
            int count = 0;

            if (index == 1)
            {
                this.first = aktualny.Next;
                return true;
            }
            while (aktualny != null)
            {
                count++;
                if (count == index)
                {
                    poprzedni.Next = aktualny.Next;

                    if (aktualny.Next == null)
                    {
                        this.last = poprzedni;
                        return true;
                    }

                }

                poprzedni = aktualny;
                aktualny = aktualny.Next;
            }

            return false;
        }

        private Node Get(int index)
        {
            var e = this.first;
            while (index-- > 0 && e != null)
                e = e.Next;
            if (e == null)
                throw new IndexOutOfRangeException();
            return e;
        }

        public T this[int i] 
        {
            get => Get(i).Value; 
            set => Get(i).Value = value; 
        }
    }
}
