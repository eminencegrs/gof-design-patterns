namespace DesignPatterns.Strategy;

public class MergeSortingStrategy : ISortingStrategy
{
    public void Sort<T>(List<T> list) where T : IComparable<T>
    {
        var sortedList = this.MergeSort(list);
        list.Clear();
        list.AddRange(sortedList);
    }

    private List<T> MergeSort<T>(List<T> list) where T : IComparable<T>
    {
        if (list.Count <= 1)
        {
            return list;
        }

        var middle = list.Count / 2;
        var left = this.MergeSort(list.GetRange(0, middle));
        var right = this.MergeSort(list.GetRange(middle, list.Count - middle));

        return this.Merge(left, right);
    }

    private List<T> Merge<T>(List<T> left, List<T> right) where T : IComparable<T>
    {
        var result = new List<T>();
        var i = 0;
        var j = 0;

        while (i < left.Count && j < right.Count)
        {
            if (left[i].CompareTo(right[j]) < 0)
            {
                result.Add(left[i]);
                i++;
            }
            else
            {
                result.Add(right[j]);
                j++;
            }
        }

        result.AddRange(left.GetRange(i, left.Count - i));
        result.AddRange(right.GetRange(j, right.Count - j));

        return result;
    }
}
