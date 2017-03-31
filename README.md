# ADCGraphTool

ADCGraphTool is a tool to visualize the analog values of the analog pins on the Arduino Uno. You can save the graph as an Image, or save the data recorded as a CSV file for later use in Excel for example.

You can also set trigger values per analog pin. The code for the arduino has by default digital pin 3 to 8 mapped to analog pin 0 to 5. So if the trigger is set right, if analog pin 0 reaches value x, digital pin 3 turns on, if not, digital pin stays off. These Triggers can be inverted as well.

  - Show a visual graph (with options for amount of data points on the x-axis, speed of recording etc.)
  - Save the data recorded since launch as a Graph Image or as a CSV.
  - Setup triggers for each pin independendt.

### Installation and Usage

1. Download the release zip [here](http://tocome.com).
2. Open the INO file located in the zip with your Arduino IDE.
3. Compile and Upload to the Arduino.
4. Run the ADCGraphTool.exe 
5. If Arduino is the only com port device, it should be automatically detected, otherwise, select the right Com Port.
6. Default baudrate set in the INO file is 115200. Change this if you changed it within the INO file.
7. Click connect.
8. Have fun.

**Done.**

### Development

This application is made for a college project, where we made a tool for a ABB robot arm which can detect an object using light sensors and a very narrow bright LED's. We used an arduino to interface with the ABB robot through optocouplers. To make sure detection is perfect, we needed a calibration tool for each Analog pin. It would be even better if we could set the trigger values on the fly. Hence ADCGraphTool was born. 

As the project was kinda in a hurry, the code for this application is a bit of a mess. I might fix that in the future, but the main goal for this thing is just to work.

### Known issues.
- Fixed screen size. 
- Crash when saving data as image when recording to long.
- Not much else yet.

### Todos

 - Make code more readable.

License
----

MIT


**Free Software, Hell Yeah!**
