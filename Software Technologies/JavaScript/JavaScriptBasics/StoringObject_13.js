function storingObject(args) {
    let result = [];

    for (let obj of args) {
        let input = obj.split(" -> ");

        let name = input[0];
        let age = input[1];
        let grade = input[2];

        let usernameinfo = {};

        usernameinfo['name'] = name;
        usernameinfo['age'] = age;
        usernameinfo['grade'] = grade;

        result.push(usernameinfo);

    }
    for (let obj of result) {
        console.log(`Name: ${obj.name}`);
        console.log(`Age: ${obj.age}`);
        console.log(`Grade: ${obj.grade}`);
    }
}
storingObject([
    'Pesho -> 13 -> 6.00',
    'Ivan -> 12 -> 5.57',
    'Toni -> 13 -> 4.90'

]);