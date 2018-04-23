function printNumbers(args) {
    let number = Number(args[0]);
    let count = 1;

    while (count<=number){
        console.log(count);
        count++;

    }
}
printNumbers([
    '5'
]);