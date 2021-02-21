
const getResponses = (msgContent) => {    
    let msgResponses = [];
    if (msgContent.includes("hey jeff"))
    {
        msgResponses.push("wud up");
    }

    if(msgContent.includes("ziegay"))
    {
        msgResponses.push("No u");
    }

    if(msgContent.includes("epic games"))
    {
        msgResponses.push("E-pig games is gay");
    }

    return msgResponses;
}

exports.getResponses = getResponses;