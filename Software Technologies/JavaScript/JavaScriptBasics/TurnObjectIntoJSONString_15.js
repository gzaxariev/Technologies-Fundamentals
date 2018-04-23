function turnObject(args) {

    let studentsinfo = {};
    for (let obj of args) {
        let input = obj.split(" -> ");
        let key = input[0];
        let value =isFinite(input[1]) ? Number(input[1]) : input[1];

        studentsinfo[key] = value;


    }
    console.log(JSON.stringify(studentsinfo));
}
turnObject([
    'name -> Angel',
    'surname -> Georgiev',
    'age -> 20',
    'grade -> 6.00',
    'date -> 23/05/1995',
    'town -> Sofia'
]);