# TestAssignment2

## Reflections

### Computer Mouse
First the basics needs to be tested:
- Left/right Mouse Click
- Mouse Wheel up/down
- Mouse Wheel click
- (if any) Side Buttons click
- Sensor under mouse

And after more advanced:
- Latency between click to registered
- Only one click per click, no doubles

### Catastrophic Failure
In 1999, The Mars Climate Orbiter made by Nasa crashed due to a unit measuring conflict. Another story by Nasa where this accured aswell, was when a ballistic anti nuclear defence system was developed. They had to have a mirror at sea level reflect a laserbeam from the top of a mountain in a very specific direction. The problem was, that the mirror read the distance from the mountain as nautical miles, instead of feet. This resulted in the project's failure.

A very easy and simple way to make sure that units aren't confused for different ones, is to make a DTO when sending the data. This way, instead of sending a single data variable of 'integer' or 'long', we can send a DTO object that also stores the type of unit it is. This makes sure that we aren't in doubt of what unit the value is.

## Two Katas

### String Utility
