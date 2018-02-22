int[] bubble(int[] input_array) {
  bool swap_occurred;
  for(int i = 0; i < input_array.Length-1; i++) {
    swap_occurred = false;
    for(int j = 0; j < input_array.Length-i-1; j++) {
      /**If the current element is greater than the next element,
      create a temporary variable to hold the current element's value
      and swap the current value with the next element
      and the next element with the temp variable with the old current element.**/
      if(input_array[j] > input_array[j+1]) {
        int temp = input_array[j];
	input_array[j] = input_array[j+1];
	input_array[j+1] = temp;
	swap_occurred = true;
      }
    }
    //Condition to terminate loop.
    //If no swapping occurred after iterating through whole list, it is sorted.
    if(swap_occurred == false) {
      break;
    }
  }
  return input_array;  
}
