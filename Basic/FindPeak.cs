namespace Algorithms
{
    public class FindPeak{
        public int[] InputArray { get; set; }
        public FindPeak(int[] inputArray)
        {
            this.InputArray = inputArray;
        }

        public int FindPeakBigO()
        {
            if(InputArray == null || InputArray.Length == 0)
                throw new System.Exception("Array cannot be empty or null");

            if(InputArray.Length == 1)
                return InputArray[0];

            for(int i=0; i <= InputArray.Length - 1; i++)
            {
                //First element
                if(i==0 && InputArray[i] > InputArray[i+1])
                    return InputArray[i];
                    
                //Inbetween elements
                if(i>0 && i < InputArray.Length-1 && InputArray[i] > InputArray[i-1] && InputArray[i] > InputArray[i+1] )
                    return InputArray[i];

                //Last element
                if(i == InputArray.Length - 1 && InputArray[i] > InputArray[i-1]) 
                    return InputArray[i];
            }
            
            return 0;
        }
    
        /*
        1: Initialize start = 0, end = array.length - 1
        2: Repeat following steps till peak element is found:
            (a) Find mid = (start+end)/2
            (b) If mid is peak element, return array[mid]
            (c) If array[mid-1] is greater than array[mid], find peak in left half of array  set end = mid - 1
            (d) Else find peak in right half of array  set start = mid + 1
        */
        public int FindPeakBinarySearch()
        {
            int start = 0;
            int end = InputArray.Length - 1;
            int mid = 0;

            while(start <= end)
            {
                mid = (start+end)/2;

                if((mid == 0 || (InputArray[mid] > InputArray[mid-1])) && (mid == InputArray.Length - 1 || (InputArray[mid] > InputArray[mid+1])))
                    return InputArray[mid];

                if(InputArray[mid-1] > InputArray[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return 0;
        }    
    }
}