namespace DesignPatterns.Strategy;

public class QuickSortingStrategy : ISortingStrategy
{
    public void Sort<T>(List<T> list) where T : IComparable<T>
    {
        this.QuickSort(list, 0, list.Count - 1);
    }

    private void QuickSort<T>(List<T> list, int low, int high) where T : IComparable<T>
    {
        if (low >= high)
        {
            return;
        }

        var pivotIndex = this.Partition(list, low, high);
        this.QuickSort(list, low, pivotIndex - 1);
        this.QuickSort(list, pivotIndex + 1, high);
    }

    private int Partition<T>(List<T> list, int low, int high) where T : IComparable<T>
    {
        T pivot = list[high];
        var i = low - 1;

        for (var j = low; j < high; j++)
        {
            if (list[j].CompareTo(pivot) < 0)
            {
                i++;
                (list[i], list[j]) = (list[j], list[i]);
            }
        }

        (list[i + 1], list[high]) = (list[high], list[i + 1]);
        return i + 1;
    }
}
