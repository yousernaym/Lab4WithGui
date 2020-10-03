//Har man flera ino-filer slås allt ihop till en enda fil vilket orsakade en del problem
//så jag gjorde ett zip library med cpp/h-filer.
//Känns knasigt att behöva göra ett lib för att få struktur på koden, men men...

#include "deviceStates.h"
#include "uart.h"

void setup()
{
  initDeviceStates();
  Serial.begin(9600);
}

void loop() 
{
  readUartCommand();
  processCurrentState();  
}
