function printNumbersFromNto1(args) {
    let numbers = Number(args[0]);
    while (numbers > 0){
        console.log(numbers);
       numbers--;
    }

}
printNumbersFromNto1([
    '5'
]);