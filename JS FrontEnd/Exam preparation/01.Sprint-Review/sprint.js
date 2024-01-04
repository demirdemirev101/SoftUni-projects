function solve(input){
    const ticketLines= Number(input.shift());
    const tickets=input.slice(0,ticketLines);
    const commands=input.slice(ticketLines, input.length);
    
    const board=tickets.reduce((acc, curr)=>{
        const [assignee, taskId,title, status, points]=curr.split(':');

        if(!acc.hasOwnProperty(assignee)){
            acc[assignee]=[];
        }

        acc[assignee].push({taskId,title,status,points: Number(points)});
        return acc;
    },{});
   //console.log(JSON.stringify(board, null, 2));

    const options={
        'Add New': addTaskToGivenAssignee,
        'Change Status':changeStatusOfGivenTask,
        'Remove Task':removeTaskByGivenIndex,
    };
   
    commands.forEach(command => {
        const [commandName, ...rest]=command.split(':');
        options[commandName](...rest);
    });

        const todoPints=points('ToDo');
        const inProgressPoints=points('In Progress');
        const codeReviewPoints=points('Code Review');
        const donePoints=points('Done');

        console.log('ToDo: '+todoPints+'pts');
        console.log('In Progress: '+inProgressPoints+'pts');
        console.log('Code Review: '+codeReviewPoints+'pts');
        console.log('Done Points: '+donePoints+'pts');

        if(donePoints>=todoPints+inProgressPoints+codeReviewPoints){
            console.log('Sprint was successful!');
        } else{
            console.log('Sprint was unsuccessful...');
        }

    function addTaskToGivenAssignee(assignee, taskId,title, status, points){
        if(!board.hasOwnProperty(assignee)){
            console.log(`Assignee ${assignee} does not exist on the board!`);
            return;
        }
        board[assignee].push({taskId,title,status,points: Number(points)});

    }
    function changeStatusOfGivenTask(assignee, taskId, newStatus){
        if(!board.hasOwnProperty(assignee)){
            console.log(`Assignee ${assignee} does not exist on the board!`);
            return;
        }
        
        const finded=board[assignee].find((b)=>b.taskId===taskId);
        if(!finded){
            console.log(`Task with ID ${taskId} does not exist for ${assignee}!`);
            return;
        }
        finded.status=newStatus;
    }
    function removeTaskByGivenIndex(assignee, index){
        if(!board.hasOwnProperty(assignee)){
            console.log(`Assignee ${assignee} does not exist on the board!`);
            return;
        }
        if(index<0 || index>=board[assignee].length){
            console.log(`Index is out of range!`)
        }

        board[assignee].splice(index,1);
    }

    function points(status){
        return Object.values(board).reduce((acc, curr)=> {
            const totalTaskPoints=curr
            .filter((c)=>c.status===status)
            .reduce((taskTotal, task)=>{
                return taskTotal+task.points;
            },0)
            
            return acc+totalTaskPoints;
        },0)
    }
}


solve(
    [
    '5',
    'Kiril:BOP-1209:Fix Minor Bug:ToDo:3',
    'Mariya:BOP-1210:Fix Major Bug:In Progress:3',
    'Peter:BOP-1211:POC:Code Review:5',
    'Georgi:BOP-1212:Investigation Task:Done:2',
    'Mariya:BOP-1213:New Account Page:In Progress:13',
    'Add New:Kiril:BOP-1217:Add Info Page:In Progress:5',
    'Change Status:Peter:BOP-1290:ToDo',
    'Remove Task:Mariya:1',
    'Remove Task:Joro:1',
    ]
)