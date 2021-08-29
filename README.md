# autobrawl


## Concept
* Card-based auto battler.
* WASM frontend.

## Concept headlines
* 6 players per match - PvE and PvP rounds.
* 6 board slots per player.
* Each player selects 1 of 3 `Champions`.
* Start on level 1, use mana to upgrade levels up to level 6.
* Start with 3 mana, gain 1 max mana per round up to a maximum of 10.
* 9+ `Aspects` - 6 available per match.
* 18 units per "Aspect" - 3 per level.
* Units cost 3 mana.
* Units are budgeted and weighted with stats and effects (Keywords).

## Keywords
There should probably be a distinction between primary and secondary Keywords. I.e. Curtain call, Inspire and Invoke are examples of Primary ones, while Camouflage and Fervor are examples of secondary ones. Aspects should primarily have 1-2 primary Keywords and any number of secondary Keywords. 

* `Camouflage` (cannot be directly attacked before attacking).
* `Cleave` (attack target and unit adjacent to target).
* `Curtain call` (occurs when unit dies during brawl phase).
* `Neutralize` (eliminates target's effects before attack lands).
* `Distract` (takes priority when enemy units attack).
* `Fervor` (attack twice in a row).
* `Inspire` (occurs at the start of each brawl phase).
* `Invoke` (occurs when unit enters board during draft phase).
* `Last stand` (survive with one health when unit first takes fatal damage).
* `Lethal` (ignore target's health).
* `Overkill` (occurs when damage exceeds target's health).
* `Rebuff` (ignore the first instance of damage).
* `Survivor` (occurs if unit is alive at the end of brawl phase).
* `End of  turn` (occurs at the end of each draft phase).
* `Start of turn` (occurs at the start of each draft phase).

## Aspects
Some Aspects should work primarily with intra-Aspect synergy, while others should work well in inter-Aspect lineups. Should probably not be strict counter Aspects and strict complementary Aspects, but nuanced synergies/anti synergies.
One Aspect should primarily be a support Aspect which primarily enables other Aspects and has Units that work across all Aspects.

1. {TBD} - Primary Keywords: `Inspire`, `Invoke` (`Lethal`)
2. {TBD} - Primary Keywords: `Curtain call`, `Rebuff`
3. {TBD} - Primary Keywords: `Survivor`, (`Distract`)
4. {TBD} - Primary Keywords: `Inspire` (`Distract`, `Survivor`)
5. {TBD} - Primary Keywords: `Last stand`, `Rebuff`
6. {TBD} - Primary Keywords: `Invoke`, `Survivor` (`Fervor`)
7. {TBD} - Primary Keywords: `Rebuff` (`Cleave`, `Overkill`)
8. {TBD} - Primary Keywords: `Curtain call`, `Inspire` (`Camouflage`)
9. {TBD} - Primary Keywords: `Last stand`, (`Lethal`, `Survivor`)


## Champions
Champions should have one or two signature abilities which provides a unique twist to how you want to execute your match. 
Guiding principles: 

* There should be 1 champion for each Aspect that strictly prefers that Aspect, and is only available when that Aspect is in the match. Landing a "Aspected" lineup properly with a "Aspected" champion should lead to excellent odds of winning.
* There should be 1 champion for each "Primary Keyword" that heavily favours that Keyword. Landing a "Keyworded" lineup properly with a "Keyworded" champion should lead to excellent odds of winning.
* There should be champions focused on early game dominance.
* There should be champions focused on Mana manipulation.
* There should be a few champions that fundamentally alters gameplay. (Lower Unit cost, additional Board slot?)

## Drafting
Drafts are phases between each battle, and gives players a selection of Units to draft. The draft board starts with 3 Units on level 1, and adds 1 Unit every even-numbered level (2,4,6). You can refresh the draft board for 1 Mana, or obtain a Unit for 3 mana. Obtaining a Unit adds it to the hand, and it can then be played onto the board.

