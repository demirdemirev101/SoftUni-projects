class Song{
    constructor(type,name,time){
        this.type=type;
        this.name=name;
        this.time=time;
    }
}
function songsPrint(arraySongs){
    let songs=[];
    const numberOfSongs=arraySongs.shift();
    const typeList=arraySongs.pop();
    for (let i = 0; i < numberOfSongs; i++) {
        const[type,name,time]=arraySongs[i].split('_');
        songs.push(new Song(type,name,time));
    }
    if (typeList==='all') {
        songs.forEach((i)=> console.log(i.name));
    } else{
        let filtered= songs.filter((i)=>i.type===typeList);
        filtered.forEach((i)=> console.log(i.name));
    }
}

songsPrint([4,
    'favourite_DownTown_3:14',
    'listenLater_Andalouse_3:24',
    'favourite_In To The Night_3:58',
    'favourite_Live It Up_3:48',
    'listenLater']
    );

console.log('\n');

    songsPrint([2,
        'like_Replay_3:15',
        'ban_Photoshop_3:48',
        'all']);