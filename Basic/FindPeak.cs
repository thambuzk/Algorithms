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

                
        }
    }
}