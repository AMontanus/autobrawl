# autobrawl


## Concept
* Card-based auto battler.
* Build with WASM?

## Concept headlines
* 6 players per match - PvE and PvP rounds.
* 6 board slots per player.
* Each player selects 1 of 3 champions.
* Start on level 1, use mana to upgrade levels up to level 6.
* Start with 3 mana, gain 1 max mana per round up to a maximum of 10.
* 9+ "themes" - 6 available per match.
* 18 units per "theme" - 3 per level.
* Units cost 3 mana.
* Units are budgeted and weighted with stats and effects (Keywords).

## Keywords
There should probably be a distinction between Primary and Secondary Keywords. I.e. Curtain call, Inspire and Invoke are examples of Primary ones, while Camouflage and Fervor are examples of secondary ones.

* Camouflage (cannot be directly attacked before attacking).
* Cleave (attack target and unit adjacent to target).
* Curtain call (occurs when unit dies during brawl phase).
* Neutralize (eliminates target's effects before attack lands).
* Distract (takes priority when enemy units attack).
* Fervor (attack twice in a row).
* Inspire (occurs at the start of each brawl phase).
* Invoke (occurs when unit enters board during draft phase).
* Last stand (survive with one health when unit first takes fatal damage).
* Lethal (ignore target's health).
* Overkill (occurs when damage exceeds target's health).
* Rebuff (ignore the first instance of damage).
* Survivor (occurs if unit is alive at the end of brawl phase).
* End of  turn (occurs at the end of each draft phase).
* Start of turn (occurs at the start of each draft phase).

## Themes
Some themes should work primarily with intra-theme synergy, while others should work well in inter-theme lineups. Should probably not be strict counter themes are strict complementary themes, but nuanced synergies/anti synergies.

1. {TBD} - Priority keywords: Inspire, Invoke, Lethal
2. {TBD} - Priority keywords: Curtain call, Distract, Last stand
3. {TBD} - Priority keywords: Distract, Overkill, Rebuff
4. {TBD} - Priority keywords: Inspire, Distract, Survivor
5. {TBD} - Priority keywords: Distract, Last stand, Rebuff
6. {TBD} - Priority keywords: Fervor, Invoke, Survivor
7. {TBD} - Priority keywords: Cleave, Overkill, Rebuff
8. {TBD} - Priority keywords: Camouflage, Curtain call, Inspire
9. {TBD} - Priority keywords: Last stand, Lethal, Survivor


## Champions
Champions should have one or two signature abilities which provides a unique twist to how you want to execute your match. 
Guiding principles: 

* There should be 1 champion for each Theme that strictly prefers that Theme, and is only available when that Theme is in the match. Landing a "Themed" lineup properly with a "Themed" champion should lead to excellent odds of winning.
* There should be 1 champion for each "Primary Keyword" that heavily favours that Keyword. Landing a "Keyworded" lineup properly with a "Keyworded" champion should lead to excellent odds of winning.
* There should be champions focused on early game dominance.
* There should be champions focused on Mana manipulation.
* There should be a few champions that fundamentally alters gameplay. (Lower Unit cost, additional Board slot?)
