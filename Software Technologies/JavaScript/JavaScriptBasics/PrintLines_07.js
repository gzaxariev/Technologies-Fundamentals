function printLines(args) {
    for (let obj of args) {
        if(obj === "Stop"){
            break;
        }
        console.log(obj)
    }

}
printLines([
    'Line 1',
    'Line 2',
    'Line 3',
    'Stop'

]);