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
    }
}