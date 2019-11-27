class Heap<T> where T : IComparable
{
    public HeapNode<T> top;

    public void push(T val)
    {
        top = HeapNode<T>.meld(top, new HeapNode<T>(val));
    }

    public T pop()
    {
        T ret = top.val;
        top = HeapNode<T>.meld(top.r, top.l);
        return ret;
    }

    public void merge(Heap<T> h2)
    {
        top = HeapNode<T>.meld(top, h2.top);
    }

    public class HeapNode<NT> where NT : IComparable
    {
        public HeapNode<NT> l, r;
        public NT val;

        public HeapNode(NT _val)
        {
            val = _val;
        }

        public static HeapNode<NT> meld(HeapNode<NT> a, HeapNode<NT> b)
        {
            if (a == null) return b;
            if (b == null) return a;
            if (a.val.CompareTo(b.val) > 0)
            {
                HeapNode<NT> temp = a;
                a = b;
                b = temp;
            }
            a.r = meld(a.r, b);
            HeapNode<NT> temph = a.l;
            a.l = a.r;
            a.r = temph;
            return a;
        }
    }
}