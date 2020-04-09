// [1,2,3] 6
// [1,2,3,6,11,20] - 6 items

function tribonacci(signature,n){
  let tribonacciArray = [];
  if(n === 0){
    return tribonacciArray;
  }else if(n === 1){
    tribonacciArray.push(signature[0])
    return tribonacciArray;
  }
  else{
      for (let i = 0; i < signature.length; i++) {
        const element = signature[i];
        tribonacciArray.push(element);
      }
    }
  while (tribonacciArray.length < n) {
    var numberToAdd = parseFloat(tribonacciArray[tribonacciArray.length-1]) + parseFloat(tribonacciArray[tribonacciArray.length-2]) +  parseFloat(tribonacciArray[tribonacciArray.length-3]);
    console.log('number to add ' + numberToAdd);
    tribonacciArray.push(numberToAdd);
  }
  return tribonacciArray;
}

//console.log(tribonacci([1,2,3], 6));