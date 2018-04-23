function multipleValuesForAKey(args) {
    let key = args.pop();

    let map = new Map();

    for (let obj of args) {
        let input = obj.split(" ");

        let key = input [0];
        let value = input [1];

        if(!map.has(key)){
            map.set(key, [])
        }
        map.get(key).push(value);
    }
    if(map.has(key)){
        console.log(map.get(key).join('\n'))
    }
    else{
        console.log("None")
    }

}
multipleValuesForAKey([
    'key value',
    'key eulav',
    'test tset',
    'key'
]);