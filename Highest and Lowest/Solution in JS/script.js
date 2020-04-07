function highAndLow(numbers){
	//declare array where we split the given input by space and each element is being parsed into an integer
    let numbersArray = numbers.split(" ").map(function(i){
        return parseInt(i, 10);
    });
	// Use Math.max and Math.min function to find the max and min value of element in the numbersArray
    return Math.max(...numbersArray)+" "+Math.min(...numbersArray);
  }
//Print the output
  console.log(highAndLow("4 4 4 6"));