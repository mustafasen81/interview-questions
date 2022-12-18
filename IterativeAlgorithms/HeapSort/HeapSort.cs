namespace IterativeAlgorithms.HeapSort;

public class Solution
{

    private static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    private static void Sink(int[] arr, int start, int end)
    {
        while (start < end)
        {
            int leftChild = LeftChild(start);
            int rightChild = RightChild(start);
            int childToSwap = -1;
            if (leftChild < end)
            {
                int maxChild = leftChild;
                if (rightChild < end && arr[rightChild] > arr[leftChild])
                {
                    maxChild = rightChild;
                }
                if (arr[maxChild] > arr[start])
                {
                    childToSwap = maxChild;
                }
            }
            if (childToSwap < 0)
            {
                break;
            }
            else
            {
                Swap(arr, start, childToSwap);
                start = childToSwap;
            }
        }
    }

    private static int LeftChild(int i)
    {
        return 2 * i;
    }

    private static int RightChild(int i)
    {
        return 2 * i + 1;
    }

    private static void Heapify(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Sink(arr, i, arr.Length);
        }
    }

    private static void PopAll(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Swap(arr, 0, i);
            Sink(arr, 0, i);
        }
    }

    public static void Run(int[] arr)
    {
        Heapify(arr);
        PopAll(arr);
    }
}