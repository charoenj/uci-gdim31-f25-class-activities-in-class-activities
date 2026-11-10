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
Activity 1 - Table #18
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
     
Activity 2 - Table #18
   - Class - blueprint of the board
   - Component - actual surfboard
   - Variable - color, size, shape
   - Method - does the surfboard work?? lol

Activity 3   
   - I think the ball gets extremely bright when they bounce too many times because step 9 changes the ball color based on its velocity, so I guess the faster the ball goes, the ball increases in brightness. 

### W4
Collision Setup Activity - Table #18
1. We added rigid bodies to the Cat and the Soccer ball. The cat needs one so that it can move and kick the ball and then the soccer ball needs one so it can be kicked and so it can bounce off of the wall. We added the IsTrigger to the goal because it allows the game to detect when the ball enters the goal without blocking it. 
2. Our code worked fine!

### W6 
1. What member variable(s) does this class need?
   - We need a Transform variable to store the gameobject that the Deer will walk to.
   - We need a NavMeshAgent variable to store the component attached to the deer. 
2. What method(s) does this class need? Should it be something that Unity provides (like Start(), Update(), or a collision method), or one you write?
   - It needs the Start() method most likely, it probably won't need an Update() method since the NavMeshAgent does it. 
3. What should the method(s) do?
   - The Start() method should use GetComponent<NavMeshAgent>() to get the NavMeshAgent component from the deer. Then, it should use SetDestination()      to tell the deer to walk toward the target's position.
  
### W7
1. We need a speed variable (most likely a float), a cat variable, and a boolean value to see if the bat is chasing the player.
2. It needs the Start() method for testing ("just for the sake of testing"), Update() so it makes the bat move towards the cat to chase, startChasing(), and stopChasing().
3. The Start() will find the cat object in the scene and calls the startChasing(). The Update() will move the bat towards the cat using the speed value. startChasing() will set isChasing value to true and stopChasing() will do the opposite.

Link to class resource guide thing: https://docs.google.com/document/d/1L_iLX4u2GuvH3esfO7PilPQzlPAVBcT6UHJst6lTWh0/edit?tab=t.0
General C# coding


## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
