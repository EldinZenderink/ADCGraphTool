//global pin trigger values used to determin if a pin should trigger. (16bit: since values can be between 0-1023)
uint16_t pin0trigger0 = 0;
uint16_t pin1trigger0 = 0;
uint16_t pin2trigger0 = 0;
uint16_t pin3trigger0 = 0;
uint16_t pin4trigger0 = 0;
uint16_t pin5trigger0 = 0;

//global pin trigger values for telling the software if a trigger should be inverted (8bit int used since these can represent booleans easily)
uint8_t pin0trigger0inv = 0;
uint8_t pin1trigger0inv = 0;
uint8_t pin2trigger0inv = 0;
uint8_t pin3trigger0inv = 0;
uint8_t pin4trigger0inv = 0;
uint8_t pin5trigger0inv = 0;

//char array for parsing received data from serial
char received[100] = {'\0'};

//char array for setting the output string to be send over serial
char outputBuffer[34];

//prev string, used within setupTriggers method
String prevString = "";

//method for converting a char string to an integer (max 9999).
uint16_t convertStringToInt(char* inStr){
   uint16_t thousand = inStr[0] - 48;
   uint16_t hundred = inStr[1] - 48;
   uint16_t tenth = inStr[2] - 48;
   uint16_t decimal = inStr[3] - 48;
   return (thousand * 1000) + (hundred * 100) + (tenth * 10) + decimal; 
}

//method for converting an 16bit integer to a character array
void convertIntToCharArray(uint16_t inInt, char* outStr){
  
  uint8_t tenththousanddec = inInt / 10000;
  uint8_t thousanddec = (inInt - (tenththousanddec * 10000)) / 1000;
  uint8_t hundreddec = (inInt - (tenththousanddec * 10000) - (thousanddec * 1000)) / 100;
  uint8_t tenthdec = (inInt - (tenththousanddec * 10000) - (thousanddec * 1000)- (hundreddec * 100)) / 10;
  uint8_t dec = (inInt - (tenththousanddec * 10000) - (thousanddec * 1000)- (hundreddec * 100) - (tenthdec * 10));

  outStr[0] = tenththousanddec + '0';
  outStr[1] = thousanddec + '0';
  outStr[2] = hundreddec + '0';
  outStr[3] = tenthdec + '0';
  outStr[4] = dec + '0';
}

//method for setting up the triggers if incomming data tells it so.
void setupTriggers(){
  char val[4]; 

  if(Serial.available() > 0){
      String readFromSerial = Serial.readString();
      if(readFromSerial != prevString){    
        
        Serial.println(readFromSerial);
        strcpy(received, readFromSerial.c_str());

  
        memcpy(val, received, 4);
        pin0trigger0 = convertStringToInt(val);
        pin0trigger0inv = received[4] - '0';
        Serial.println(pin0trigger0);
        Serial.println(pin0trigger0inv);    
        memcpy(val, received + 5, 4);
        pin1trigger0 = convertStringToInt(val);
        pin1trigger0inv = received[9] - '0';
        
        Serial.println(pin1trigger0);
        Serial.println(pin1trigger0inv);
        memcpy(val, received + 10, 4);
        pin2trigger0 = convertStringToInt(val);
        pin2trigger0inv = received[14] - '0';
        
        Serial.println(pin2trigger0);
        Serial.println(pin2trigger0inv);    
        memcpy(val, received + 15, 4);
        pin3trigger0 = convertStringToInt(val);
        pin3trigger0inv = received[19] - '0';
        
        Serial.println(pin3trigger0);
        Serial.println(pin3trigger0inv);     
        memcpy(val, received + 20, 4);
        pin4trigger0 = convertStringToInt(val);
        pin4trigger0inv = received[24] - '0';
        
        Serial.println(pin4trigger0);
        Serial.println(pin4trigger0inv);
        memcpy(val, received + 25, 4);
        pin5trigger0 = convertStringToInt(val);
        pin5trigger0inv = received[29] - '0';
        
        Serial.println(pin5trigger0);
        Serial.println(pin5trigger0inv);
        digitalWrite(13, HIGH);
        delay(250);
        digitalWrite(13, LOW);
        delay(250);
        digitalWrite(13, HIGH);
        delay(250);
        digitalWrite(13, LOW);          
        delay(250);
        digitalWrite(13, HIGH);
        prevString = readFromSerial;
      }
  }
}

//triggers a pin if a analog value corresponding that pin is going above(or below if inverted) its triggervalue.
void triggerTriggers(uint16_t a0, uint16_t a1, uint16_t a2,uint16_t a3,uint16_t a4,uint16_t a5){
  if(pin0trigger0inv >= 1){
    if(a0 < pin0trigger0){
      digitalWrite(3, HIGH);
      
    } else if(a0 > pin0trigger0)  {      
      digitalWrite(3, LOW);
    }
  } else {
    if(a0 > pin0trigger0){
      digitalWrite(3, HIGH);
    } else if(a0 < pin0trigger0) {
      digitalWrite(3, LOW);
    }
  }

  if(pin1trigger0inv >= 1){
    if(a1< pin1trigger0){
      digitalWrite(4, HIGH);
    } else if(a1 > pin1trigger0){
      digitalWrite(4, LOW);
    }
  } else {
    if(a1 > pin1trigger0){
      digitalWrite(4, HIGH);
    } else if(a1 < pin1trigger0) {
      digitalWrite(4, LOW);
    }
  }

  if(pin2trigger0inv >= 1){
    if(a2 < pin2trigger0){
      digitalWrite(5, HIGH);
    } else if(a2 > pin2trigger0){
      digitalWrite(5, LOW);
    }
  } else if(a2 < pin2trigger0) {
    if(a2 > pin2trigger0){
      digitalWrite(5, HIGH);
    } else {
      digitalWrite(5, LOW);
    }
  }
  
  if(pin3trigger0inv >= 1){
    if(a3 < pin3trigger0){
      digitalWrite(6, HIGH);
    } else if (a3 > pin3trigger0) {
      digitalWrite(6, LOW);
    }
  } else {
    if(a3 > pin3trigger0){
      digitalWrite(6, HIGH);
    } else if (a3 < pin3trigger0) {
      digitalWrite(6, LOW);
    }
  }

  if(pin4trigger0inv >= 1){
    if(a4 < pin4trigger0){
      digitalWrite(7, HIGH);
    } else if (a4 > pin4trigger0){
      digitalWrite(7, LOW);
    }
  } else {
    if(a4 > pin4trigger0){
      digitalWrite(7, HIGH);
    } else if (a4 < pin4trigger0){
      digitalWrite(7, LOW);
    }
  }
  

  if(pin5trigger0inv >= 1){
    if(a5 < pin5trigger0){
      digitalWrite(8, HIGH);
    } else if(a5 > pin5trigger0){
      digitalWrite(8, LOW);
    }
  } else {
    if(a5 > pin5trigger0){
      digitalWrite(8, HIGH);
    } else if(a5 < pin5trigger0){
      digitalWrite(8, LOW);
    }
  }
}

//arduino specific code, setup is actually what comes before the main loop. Settin gup all the digital pins for output mode.
void setup() {
  uint8_t pin = 0;
  for(pin = 0; pin < 8; pin++){    
    pinMode(pin, OUTPUT);
  }  
  pinMode(13, OUTPUT);
  Serial.begin(115200);
}

//this is what you would call the main loop, in here, it reads the analog pins, and activate the triggerTriggers method when all pins are read.
void loop() {
  // put your main code here, to run repeatedly:

    char strWithA0Val[5];
    char strWithA1Val[5];
    char strWithA2Val[5];
    char strWithA3Val[5];
    char strWithA4Val[5];
    char strWithA5Val[5];

    uint16_t a0 = analogRead(0);
    uint16_t a1 = analogRead(1);
    uint16_t a2 = analogRead(2);
    uint16_t a3 = analogRead(3);
    uint16_t a4 = analogRead(4);
    uint16_t a5 = analogRead(5);
    
    convertIntToCharArray(a0, strWithA0Val);
    convertIntToCharArray(a1, strWithA1Val);
    convertIntToCharArray(a2, strWithA2Val);
    convertIntToCharArray(a3, strWithA3Val);
    convertIntToCharArray(a4, strWithA4Val);
    convertIntToCharArray(a5, strWithA5Val);
    
    memcpy(outputBuffer + 2, strWithA0Val, 5);
    memcpy(outputBuffer + 7, strWithA1Val, 5);
    memcpy(outputBuffer + 12, strWithA2Val, 5);
    memcpy(outputBuffer + 17, strWithA3Val, 5);
    memcpy(outputBuffer + 22, strWithA4Val, 5);
    memcpy(outputBuffer + 27, strWithA5Val, 5); 
    outputBuffer[0] = '\n';
    outputBuffer[1] = 'D';
    outputBuffer[33] = '\0'; 
    Serial.print(outputBuffer); 
        
    setupTriggers();
    triggerTriggers(a0,a1,a2,a3,a4,a5); 
    
}


