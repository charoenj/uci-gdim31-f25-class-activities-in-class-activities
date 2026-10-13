# in-class-activities
## Devlogs
### W1
1. When I moved Camera off of the Cat GameObject, it took away the first-person perspective and instead set it into a fixed camera position. This happens because the camera is not a child of the Cat GameObject and therefore does not share the same properties, in this case its movement.
2. https://charoenj.itch.io/wk1-class-activity

### W2
1. The r, g, and b are all floats because they contain numbers that are decimals. Ints only refer to numbers that are whole, bool only has true or false values, and strings are made up of words and not numbers.
2. The _bounce variable is an int because the number of bounces can only be a whole number, not a decimal of a bounce nor is it a true/false value nor a word.
3. There was a semi-colon missing at the end of the statement. 

### W3
## Activity 1 - Table #18
1. You’re building a visual novel, and you’re writing a method named GetResponse that gives you a character’s text response to a player’s dialogue choice. The relevant data for the dialogue choice are the player’s current friendship level with the character and a flag that tells you whether or not the player knows the character’s secret.
   public string GetResponse (int friendshipLevel, bool knowSecret) {}
   - input: int/float (friendship level), bool (knows secret? yes or no?) 
   - output: string (text response)
2. You’re building a horror game, and you’re writing a method named SetLightDimness that makes the room’s lights brighter or darker based on the player’s current sanity level. The player’s sanity level is a number that goes from 0% - 100%. The method changes the light itself, so it doesn’t need any output.
   public void SetLightDimness (float sanityLevel) {}
   - input: float (sanity level) 
   - output: no output (void method) 
3. You’re building a rhythm game, and you’re writing a method named DidPlayerHitBeat that tells you whether or not the player accurately hit a beat based on the time that they pressed a key.
   public bool DidPlayerHitBeat (float timeHit) {}
   - input: float (when did they hit)
   - output: bool (hit beat or no?)
   - 
## Activity 2 - Table #18
   - Class - blueprint of the board
   - Component - actual surfboard
   - Variable - color, size, shape
   - Method - does the surfboard work?? lol

### W4

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
