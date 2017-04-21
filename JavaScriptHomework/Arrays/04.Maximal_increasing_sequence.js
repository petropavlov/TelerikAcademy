/* jshint esversion: 6 */
/*jslint node: true */
'use strict';

function solve(args){
    let array = args.map(Number),
        len = array.length,
        temp = 1,
        result = 1;
console.log(array);
        for(let i = 2; i < len; i+=1){
            if(array[i] > array[i-1]){
                temp+=1;
                if(temp > result){
                    result = temp;
                }
            }else{
                temp = 1;
            }
        }

        console.log(result);
}
solve(['13', '4', '1', '1', '4', '2', '3', '4', '4', '1', '2', '4', '9', '4']);
