Reader for the `game_data` folder of a Manual Archipelago's patch file.

# What is this?
In my [Manual AP for Euro Truck Simulator 2](https://github.com/Nixill/APManual-ETS2), I made it so that some secret extra instructions are packaged with a file that Manual itself already creates and sends to the archipelago host. This is a small application that can display those instructions to the player. However, it's made slightly more generic because I want the functionality I added to ETS2 to be adopted into the core Manual template.

If you're playing in an Archipelago, you don't need to use this unless you're playing on a Manual apworld that has told you to use it.

# How do I use this as a player?
You will need to:
1. Download and unzip this program's folder somewhere you can easily find it.
2. If you are playing a game hosted on archipelago.gg, go to the room's webpage, find your player slot name, and select "Download patch file...".
3. If you are playing a game not hosted on archipelago.gg, ask the room's host for your patch file or the generated room file. You may use either with this application.

## On Windows:
1. Find the program, and open its `launch` batch file.
2. On the webpage that appears, drag the file you got in step 2 or 3 above onto the page.
3. If the file you selected is generated room data, rather than a patch file, you will also need to select your player slot.
4. You will be presented with a list of files in the game data. **DO NOT open any of those** until your game tells you to!

## On Mac or Linux:
At this time, you will need to build (or just debug) from source with .NET 10. Then follow steps 2-4 above.

# How do I use this as an APWorld developer?
For files to be read by this application, they must be part of the container's contents in a `game_data` directory. For now, you will need to make a modification to the core Manual code to do this. A template (or pull request) with the required changes is coming soon. You can take a look at [ETS2's container.py](https://github.com/Nixill/APManual-ETS2/blob/main/src/container.py) to see how I did it.

# Would it be nice if this were part of Manual itself?
Yes, it would! I'm probably going to pull-request my changes to the apworld in the coming days, but I would need someone else to make the actual file viewer in the Manual Client since UI like that is not my specialty.