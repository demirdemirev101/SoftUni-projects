function OperationByCommand(stringNum, command1, command2, command3, command4, command5){
    let num=Number(stringNum);
    let listCommands=command1+' '+command2+' '+command3+' '+command4+' '+command5;
    listCommands=listCommands.split(' ');
    for (let i = 0; i <= listCommands.length-1; i++) {
        if(listCommands[i]==='chop'){
            num/=2;
        } 
        else if(listCommands[i]==='dice'){
            num=Math.sqrt(num);
        }
        else if(listCommands[i]==='spice'){
            num+=1;
        }
        else if(listCommands[i]==='bake'){
            num*=3;
        }
        else if(listCommands[i]==='fillet'){
            num-=num*20/100.0;
        }
        console.log(num);     
    }
}
OperationByCommand('9', 'dice', 'spice', 'chop', 'bake','fillet');