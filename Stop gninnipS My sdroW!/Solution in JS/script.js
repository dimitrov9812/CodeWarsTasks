function spinWords(a){
    // split the sentence by a space to a desired amount of words
    let splittedString = a.split(' ');
    console.log(splittedString);
    // assign a variable for the return of the new string in the end
    var newString = [];
    // start a for loop to go through each word and check for a condition
    for (let i = 0; i < splittedString.length; i++) {
        // get the currentword by index
        const currentWord = splittedString[i];
        // check if the lenght of the word is equal or bigger to five
        if(currentWord.length >= 5){
            // split the word in an array of characters
            let currentWordSplitted = currentWord.split("");
            console.log("currentwordSPlitted" + currentWordSplitted);
            // reverse the array
            let reversedWord = currentWordSplitted.reverse();
            console.log("reversed word" +reversedWord);
            // join the reversed array in a result of a new string
            let newWord = reversedWord.join('');
            // check if the index of the word is the last index  and if yes
            // do not put a white space after joining it to the return array
            newString.push(newWord);
         } 
         // append the word without reversing it
         else{
            newString.push(currentWord);
         }
    }
    return newString.join(" ");
}
    
// print the output
   console.log(spinWords("Hey fellow warriors"));
