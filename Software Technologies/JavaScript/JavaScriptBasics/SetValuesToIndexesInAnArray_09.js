function setVelues(args) {
    let arrSize = Number(args.shift());

    let arr = new Array(arrSize).fill(0);

    for (let obj of args) {
        let input = obj.split(" - ");

        let index = input[0];
        let value = input[1];

        arr[index] = value;
    }
    console.log(arr.join('\n'))
        
    
}
setVelues([
    '3',
    '0 - 5',
    '1 - 6',
    '2 - 7'
]);