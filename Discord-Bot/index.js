'use strict';

const  { getResponses }  = require("./message-response");

const Discord = require('discord.js');
const {prefix, token} = require('./config.json');
const client = new Discord.Client();

var line = 0;

client.once('ready',() => {
    console.log('Ready!')
})



client.on('message',message =>{
    console.log(message.content);
    if(message.content === 'jeff what do you think Gabzilla and Tristan')
    {
        
        message.channel.send(`<@!294520778203070464> is still a furry and <@!297358479105064981> is gay`);
        console.log("yes");
    }
})

client.login(token);
