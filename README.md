# JeffTheDiscordBot
This is old project of mine that I have resurrected.
At it is core it is meant to be a discord bot that will flag any rasist messages that get sent on server.

## Project Template
For now the project is a NodeJs "Frontend" and .Net Backend API.

### NodeJs Frontend 
The NodeJs Frontend will be reading messages and doning operations on the discord server.

### .Net Backend API
The .Net Backend API, as Mvp will just have one end point which checks if a given string is classified as rasist or not. It will be using .Net ML sentiment analysys which is traind from a dataset I got from a StandFord study identifying rasist tweets. In future I want the API to do a bit more like users can create there own sentiment analysys cases and train models with their own messages.
