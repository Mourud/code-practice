const readline = require('readline');
const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

function main(){
    
    rl.question('Enter a number: ',(num1) =>{
        rl.question('Enter another number: ',(num2) => {
            console.log(`${num1} + ${num2} = ${parseInt(num1) + parseInt(num2)}`);
            console.log(`${num1} - ${num2} = ${parseInt(num1) - parseInt(num2)}`);
            console.log(`${num1} * ${num2} = ${parseInt(num1) * parseInt(num2)}`);
            console.log(`${num1} / ${num2} = ${parseInt(num1) / parseInt(num2)}`);
            rl.close();
        });
    });
}

main();