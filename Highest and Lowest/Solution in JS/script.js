function highAndLow(numbers){
    let numbersArray = numbers.split(" ").map(function(i){
        return parseInt(i, 10);
    });
    return Math.max(...numbersArray)+" "+Math.min(...numbersArray);
  }
  console.log(highAndLow("4 4 4 6"));