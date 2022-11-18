using System.Resources;
using Hashing;

public class HashSetLinearProbing : HashSet {
    private Object[] buckets;
    private int currentSize;
    private enum State { DELETED }

    public HashSetLinearProbing(int bucketsLength) {
        buckets = new Object[bucketsLength];
        currentSize = 0;
    }

    public bool Contains(Object x) {
        int h = HashValue(x);
        int startIndex = HashValue(x);
        bool found = false;

        while (!found && buckets[h] != null)
        {
            if (buckets[h].Equals(x))
            {
                found = true;
            }
            else 
            {
                h = (h + 1) % buckets.Length;

                if (h == startIndex)
                {
                    return found;
                }
            }
        }
        return found;
    }

    public bool Add(Object x) {      
        int h = HashValue(x);
        int startIndex = HashValue(x);
        bool found = false;

        while (!found)
        {
            if (buckets[h] == null)
            {
                buckets[h] = x;
                found = true;
                currentSize++;
            }
            else
            {
                h = (h + 1) % buckets.Length;

                if (h == startIndex)
                {
                    return found;
                }
            }
        }
        
        return found;
    }

    public bool Remove(Object x) {
        
        int h = HashValue(x);
        bool found = false;

        if (buckets.Contains(x))
        {
            while (!found)
            {
                if (buckets[h].Equals(x))
                {
                    buckets[h] = State.DELETED;
                    found = true;
                    currentSize--;
                }
                else
                {
                    h = (h + 1) % buckets.Length;
                }
            }
        }

        return found;
    }

    public int Size() {
        return currentSize;
    }

    private int HashValue(Object x) {
        int h = x.GetHashCode();
        if (h < 0) {
            h = -h;
        }
        h = h % buckets.Length;
        return h;
    }

    public override String ToString() {
        String result = "";
        for (int i = 0; i < buckets.Length; i++) {
            int value = buckets[i] != null && !buckets[i].Equals(State.DELETED) ? 
                    HashValue(buckets[i]) : -1;
            result += i + "\t" + buckets[i] + "(h:" + value + ")\n";
        }
        return result;
    }

}
