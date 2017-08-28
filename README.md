# NewWorld description
The Game will be made with Unity.
This Game will be set in a Steampunk-fantasy world. You control a group of settlers that have made their way to an unexplored continent. They will  have to fight the native land every step of the way in order to survive and thrive in this *new world*.
You control your civilisation through simple orders, you do not have direct control over your units.
Challenges to overcome include: Disease, Wild natives (e.g. Orks, goblins and the like), more civilised Natives (Technologically on a comparable level), Ancient magical things (e.g. a dragon, a living mountain, ancient ruins that hold a devastating power)…

It will have simple 2d graphics. Consisting mostly of the World map. important locations such as settlements, ruins, valuable resources or outposts will be represented by Icons.

# MVP (minimal viable product)
You spawn on a fixed map and expand your civilisation over all of it. You need ressources (Food and Materials) to expand your civilisation.
# Similar Games + Differences
- Settlers of catan
	- Not a multi player game
	- You do not rely on luck to gain ressources
	- Not a board game
	- Unevenly matched opponents
- Civilization + civ clones
	- “Zooming out”, as your empire grows your ability to micromanage everything is limited. 
	- Harsher surroundings, Each Hex is a challenge to overcome
	- Unevenly matched opponents
- Crusader kings 2/stellaris/Europa universalis4
	- Turn based.
	- Hex based.
	- A World that is not already inhabited by big factions but lots of little ones and maybe one or two big ones. 
	- Not a character simulator. you the player are in charge of your actions
- Dwarf Fortress
	- Turn based.
	- Further zoomed out gameplay
	- Does not require a PHD in the game to play it
- Rim World
	- Turn Based.
	- Further zoomed out
	- You expand continously
	- Single characters are not of your concern
- Anno
	- Not island based
	- Not on a small map
	- hex based
	- Turn based
	- not based on production chains

## The Differences
- Focus on single player gameplay = no balanced Factions that grow together. The player shares the world with lots of factions that act in their own interests and do not have the same win conditions as the players.
- Not much micro management/Very top-down perspective. Usually your empire grows too big to control everything in a short time. But you still have the option to do so and it is the most effective way to play, so turns get drawn out and can take upwards of an hour. Being able to control only a small-ish number of characters (a character is anything that let’s you interact with the worlds) limits the time one turn can take and gives a much clearer decision what you want to focus on.
- Harsh world. Except the occasional outlaws 4x games tend to have a vast unexplored world for your taking. Here we will have a world that fights you every step of the way. Acquiring a hex takes work and should feel rewarding on its own. 
- Zooming out. The more your Empire grows the more zoomed out your control over it becomes. At the beginning you might manage single people living in your colony. Later you might only manage Lords in your empire.

# To-do
## Name the Game:
Name idea tank, just write it down if you have an idea:
- March West
- The Forth world
## Design the Game:
- How long should a single play through be?
- What are the loss conditions?
- What are the win conditions?
- How does our tech tree look?
- How does the moment-to-moment gameplay look and feel like?
- Do we have Lore? If so how do we implement it?
	  

## Figure out Unity.
- Do the roll-a-ball and space-shooter Tutorials for Unity.
- Decide wether to use JS or C# (I have some experience with JS but don’t care much either way.)
- Make a basic interactive Hex map.

## Divide Responsibilities

## Make the game:

### MVP
- Art
	- A few Green and blue Tiles
	- A marker for the Village
- Coding
	- Game startup
	- Spawning of the player 
	- Player order to take over a new Tile
### Actual Game
- Coding
	- AI
	- Map interaction
	- Civilisation Management
- Art
	- Tiles
	- Accents
		- Rivers
		- Roads
		- coasts
	- Markers
		- Village
		- Town
		- City
		- Ruin
		- 
- Menu
	- Main
		- New game
		- Load saved Game
		- Options
		- Quit
	- Options
		- Graphics
		- Audio
		- Keybindings
- Lore

## Add your ideas for the game here
The longer you play the more time is consumed by your turns. E.G. you might start off with one turn = 1 day. Once you get your village set up one turn is 1 week worth of time, that means suddenly things happen 7 times faster. When before it took you 2 turns to move a hex, you can now move three in one turn.

You, the player have a limited number of *things* you can control directly. one thing might be a character, an other a village, again an other might be an entire region. Things you do not control directly are controlled by the AI. The things you are able to do depend on what you control. e.g. A single person can scout a location. But you will need the entire village to survey it. These Objects are structured hierarchically. So lower tiered objects will help their direct superior to achieve their orders.

Example:
Villager\<Village\<region\<state\<empire

Every hex should be a challenge to overcome. First you need to *scout* it, then *conquer* it finally you can *claim* it. Once it is claimed you gain access to it’s properties.
- Scouting a hex reveals what is in it. It triggers a scout event where you have to decide how to interact with what you’ve discovered. eg. you can choose to *trade* with a tribe of natives. This determines what you need to do in order to *conquer* the hex.
	- Conquering a hex is driving out what occupied it before and replacing it with your own. e.g. if you chose to *attack* a tribe of natives while *scouting* you need to kill them, if you instead chose to *trade* with the natives you might be able to *integrate* them into your civilisation.
	- Claiming a hex is available when you are the only force in it. A hex remains claimed until somebody *conquers*it.
Each settlement is a “unit” somewhat like a dwarf in dwarf fortress or a person in RimWorld. With their own needs and abilities. As their population grows they can do more tasks. They fulfil their needs with nearby hexes if they can, if not they may trade with other settlements. If they cannot do that either they will suffer penalties such as a shrinking population. There is a hapiness rate at each village that will influence production and loyalty. Further, each village will on a more or less regular basis (maybe dependent on the villages gross production and freedom?) create “Initiatives” that uses a lot of the villages resources, e.g. build an alchemist academy, rise up in rebellion etc.  

Heroes: Heroes are specific modifiers for a settlement that can be assigned to one. They confer special effects to it for a limited time.

